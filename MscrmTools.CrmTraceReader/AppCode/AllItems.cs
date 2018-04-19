using System;
using System.Collections.ObjectModel;
using System.Linq;
using MscrmTools.CrmTraceReader.CustomEventArgs;

namespace MscrmTools.CrmTraceReader.AppCode
{
    public class AllItems
    {
        public AllItems()
        {
            Operations.CollectionChanged += CollectionChanged;
            Processes.CollectionChanged += CollectionChanged;
            Organizations.CollectionChanged += CollectionChanged;
            Threads.CollectionChanged += CollectionChanged;
            Categories.CollectionChanged += CollectionChanged;
            Users.CollectionChanged += CollectionChanged;
            Levels.CollectionChanged += CollectionChanged;
            RequestIds.CollectionChanged += CollectionChanged;
        }

        public event EventHandler<FilterItemChangedEventArgs> ItemChanged;

        public ObservableCollection<string> Operations { get; set; } = new ObservableCollection<string>();
        public ObservableCollection<string> Processes { get; set; } = new ObservableCollection<string>();
        public ObservableCollection<string> Organizations { get; set; } = new ObservableCollection<string>();
        public ObservableCollection<string> Threads { get; set; } = new ObservableCollection<string>();
        public ObservableCollection<string> Categories { get; set; } = new ObservableCollection<string>();
        public ObservableCollection<UserInfo> Users { get; set; } = new ObservableCollection<UserInfo>();
        public ObservableCollection<string> Levels { get; set; } = new ObservableCollection<string>();
        public ObservableCollection<string> RequestIds { get; set; } = new ObservableCollection<string>();

        public void ClearAll()
        {
            Operations.Clear();
            Processes.Clear();
            Organizations.Clear();
            Threads.Clear();
            Categories.Clear();
            Users.Clear();
            Levels.Clear();
            RequestIds.Clear();
        }

        public void TryAdd(FilterItemType type, object value)
        {
            if (value == null)
            {
                return;
            }

            switch (type)
            {
                case FilterItemType.Category:
                    if (!Categories.Contains(value.ToString()))
                    {
                        Categories.Add(value.ToString());
                    }
                    break;

                case FilterItemType.Level:
                    if (!Levels.Contains(value.ToString()))
                    {
                        Levels.Add(value.ToString());
                    }
                    break;

                case FilterItemType.Operation:
                    if (!Operations.Contains(value.ToString()))
                    {
                        Operations.Add(value.ToString());
                    }
                    break;

                case FilterItemType.Organization:
                    if (!Organizations.Contains(value.ToString()))
                    {
                        Organizations.Add(value.ToString());
                    }
                    break;

                case FilterItemType.Process:
                    if (!Processes.Contains(value.ToString()))
                    {
                        Processes.Add(value.ToString());
                    }
                    break;

                case FilterItemType.ReqId:
                    if (!RequestIds.Contains(value.ToString()))
                    {
                        RequestIds.Add(value.ToString());
                    }
                    break;

                case FilterItemType.Thread:
                    if (!Threads.Contains(value.ToString()))
                    {
                        Threads.Add(value.ToString());
                    }
                    break;

                default:
                    if (Users.All(u => u.Id != ((UserInfo)value).Id))
                    {
                        Users.Add((UserInfo)value);
                    }
                    break;
            }
        }

        private void CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            var args = new FilterItemChangedEventArgs
            {
                Changes = e
            };

            if (sender == Operations)
            {
                args.Type = FilterItemType.Operation;
            }
            else if (sender == Processes)
            {
                args.Type = FilterItemType.Process;
            }
            else if (sender == Organizations)
            {
                args.Type = FilterItemType.Organization;
            }
            else if (sender == Threads)
            {
                args.Type = FilterItemType.Thread;
            }
            else if (sender == Categories)
            {
                args.Type = FilterItemType.Category;
            }
            else if (sender == Users)
            {
                args.Type = FilterItemType.User;
            }
            else if (sender == Levels)
            {
                args.Type = FilterItemType.Level;
            }
            else if (sender == RequestIds)
            {
                args.Type = FilterItemType.ReqId;
            }

            ItemChanged?.Invoke(this, args);
        }
    }
}