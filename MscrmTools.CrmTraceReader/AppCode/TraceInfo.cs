using System;

namespace MscrmTools.CrmTraceReader.AppCode
{
    public class TraceInfo
    {
        public DateTime Date { get; set; }

        public string Process { get; set; }

        public string Organization { get; set; }

        public string Thread { get; set; }

        public string Category { get; set; }

        public UserInfo User { get; set; }

        public string Level { get; set; }

        public string Context { get; set; }

        public string Description { get; set; }

        public string ReqId { get; set; }
    }
}