using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace ErrorLogViewer.Models
{
    [XmlRoot("error")]
    public sealed class error
    {
         [XmlAttribute]
        public string host { set; get; }
        [XmlAttribute]
        public string type { set; get; }
        [XmlAttribute]
        public string message { set; get; }
        [XmlAttribute]
        public string source { set; get; }
        [XmlAttribute]
        public string detail { set; get; }
        [XmlAttribute]
        public string user { set; get; }
        [XmlAttribute]
        public DateTime time { set; get; }
    }
}