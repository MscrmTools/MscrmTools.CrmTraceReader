using System;
using MscrmTools.CrmTraceReader.AppCode;

namespace MscrmTools.CrmTraceReader.CustomEventArgs
{
    public class FilterChangedEventArgs : EventArgs
    {
        public FilterChangedEventArgs(FilterInfo info)
        {
            Info = info;
        }

        public FilterInfo Info { get; set; }
    }
}