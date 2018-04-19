using System;
using System.Collections.Specialized;
using MscrmTools.CrmTraceReader.AppCode;

namespace MscrmTools.CrmTraceReader.CustomEventArgs
{
    public class FilterItemChangedEventArgs : EventArgs
    {
        public FilterItemType Type { get; set; }

        public NotifyCollectionChangedEventArgs Changes { get; set; }
    }
}