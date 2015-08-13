using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Web.Http;
using System.Xml.Serialization;
using ErrorLogViewer.Models;
using ServiceStack.Redis;

namespace ErrorLogViewer.Controllers
{
    public class LogController : ApiController
    {
        public List<GroupedError> Get()
        {
            var client = new RedisClient();
            client.ChangeDb(2);
            const string keyPattern = "elmah-error:*";
            var errorLogKeys = client.SearchKeys(keyPattern);
            IEnumerable<ErrorModel> allError = client.GetAll<ErrorModel>(errorLogKeys).Values;
            return ErrorLogAnalyzer(allError);
        }

        private List<GroupedError> ErrorLogAnalyzer(IEnumerable<ErrorModel> errors)
        {
            var client = new RedisClient();
            foreach (ErrorModel errorModel in errors)
            {
                var deserializer = new XmlSerializer(typeof(error));
                var reader = new StringReader(errorModel.ErrorXml);
                errorModel.DetailErrorXml = (error)deserializer.Deserialize(reader);

            }

            List<GroupedError> errorObjectList = (from grp in errors.GroupBy(e => e.DetailErrorXml.detail)
                    let grpErrors = grp.Select(g => new ErrorModel()
                                                        {
                                                            ErrorTime = g.ErrorTime,
                                                            ErrorXml = g.ErrorXml,
                                                            DetailErrorXml = g.DetailErrorXml,
                                                            Id = g.Id
                                                        })
                    let effectedUser = grp.Select(p => p.DetailErrorXml.user).Distinct()
                    let occured = grp.Select(p => p.DetailErrorXml.time.ToString("g",
                  CultureInfo.CreateSpecificCulture("en-ES"))).Distinct()
                    select new GroupedError()
                               {
                                   EffectedUserCount = effectedUser.Distinct().Count(),
                                   Errorcount = grpErrors.Count(),
                                   ElmahErrors = grpErrors,
                                   Occuredtime = occured,
                                   EfectedUsers = effectedUser
                               }).OrderByDescending(x => x.Errorcount).ToList();
            foreach (GroupedError groupedError in errorObjectList)
            {
                groupedError.ErrorStatus = new ErrorStatus();
                var errorStatus = client.Get<ErrorStatus>(groupedError.ElmahErrors.FirstOrDefault().DetailErrorXml.detail);
                if (errorStatus != null)
                {
                    groupedError.ErrorStatus = errorStatus;
                }
            }

            return errorObjectList;
        }

        public void Post(GroupedError errorWithStatus)
        {
            var client = new RedisClient();
            if (client.Get(errorWithStatus.ElmahErrors.FirstOrDefault().DetailErrorXml.detail)==null)
            {
                client.Add(errorWithStatus.ElmahErrors.FirstOrDefault().DetailErrorXml.detail,
                                         errorWithStatus.ErrorStatus);
            }
            else
            {
                client.Replace(errorWithStatus.ElmahErrors.FirstOrDefault().DetailErrorXml.detail,
                                         errorWithStatus.ErrorStatus);
            }
        }
    }
}
