using System;
using MscrmTools.CrmTraceReader.AppCode;

namespace MscrmTools.CrmTraceReader.CustomEventArgs
{
    public class TraceSelectedEventArgs : EventArgs
    {
        public TraceSelectedEventArgs(TraceInfo info)
        {
            Info = info;
        }

        public TraceInfo Info { get; set; }
    }
}