using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace ErrorLogViewer.Controllers
{
    public class IisResetController : ApiController
    {
        public void Get()
        {
            var processInfo = new ProcessStartInfo
            {
                Arguments = "/stop",
                WindowStyle = ProcessWindowStyle.Hidden,
                FileName = "iisreset"
            };
            using (var process = new Process())
            {
                process.StartInfo = processInfo;
                process.Start();
                process.WaitForExit();
            }
        }
    }
}