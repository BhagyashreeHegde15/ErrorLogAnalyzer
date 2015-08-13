using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ErrorLogViewer.Models
{
    public class ErrorModel
    {
        public DateTime? ErrorTime { set; get; }
        public string ErrorXml { set; get; }
        public string Id { set; get; }
        public error DetailErrorXml { set; get; }
    }
}