
using System.Web.Http;
using ServiceStack.Redis;

namespace ErrorLogViewer.Controllers
{
    public class RediesClearController : ApiController
    {
        public void Post()
        {
            var client = new RedisClient();
            client.FlushAll();
        }
    }
}