using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ErrorLogViewer.Models
{
    public class GroupedError
    {
        public int Errorcount { set; get; }
        public IEnumerable<ErrorModel> ElmahErrors { set; get; }
        public int EffectedUserCount { set; get; }
        public IEnumerable<string> Occuredtime { set; get; }
        public IEnumerable<string> EfectedUsers { set; get; }
        public ErrorStatus ErrorStatus { set; get; }
    }
}