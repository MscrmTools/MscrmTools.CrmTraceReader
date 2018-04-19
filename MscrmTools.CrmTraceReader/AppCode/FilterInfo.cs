namespace MscrmTools.CrmTraceReader.AppCode
{
    public class FilterInfo
    {
        public string Category { get; set; }
        public string Level { get; set; }
        public string Operation { get; set; }
        public string Organization { get; set; }
        public string Process { get; set; }
        public string ReqId { get; set; }
        public string Thread { get; set; }
        public UserInfo User { get; set; }
    }
}