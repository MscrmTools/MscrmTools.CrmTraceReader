using System;

namespace MscrmTools.CrmTraceReader.AppCode
{
    public class UserInfo
    {
        public Guid Id { get; set; }

        public string Fullname { get; set; }

        public override string ToString()
        {
            return Fullname ?? Id.ToString("B");
        }
    }
}