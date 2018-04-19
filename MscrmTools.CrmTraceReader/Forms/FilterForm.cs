using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Windows.Forms;
using MscrmTools.CrmTraceReader.AppCode;
using MscrmTools.CrmTraceReader.CustomEventArgs;
using WeifenLuo.WinFormsUI.Docking;

namespace MscrmTools.CrmTraceReader.Forms
{
    public partial class FilterForm : DockContent
    {
        public FilterForm(AllItems allItems)
        {
            InitializeComponent();

            allItems.ItemChanged += AllItems_ItemChanged;
        }

        public event EventHandler<FilterChangedEventArgs> FilterChanged;

        private void AllItems_ItemChanged(object sender, FilterItemChangedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                ComboBox cbb;
                switch (e.Type)
                {
                    case FilterItemType.Category:
                        cbb = cbbCategory;
                        break;

                    case FilterItemType.Level:
                        cbb = cbbLevel;
                        break;

                    case FilterItemType.Operation:
                        cbb = cbbOperation;
                        break;

                    case FilterItemType.Organization:
                        cbb = cbbOrganization;
                        break;

                    case FilterItemType.Process:
                        cbb = cbbProcess;
                        break;

                    case FilterItemType.ReqId:
                        cbb = cbbRequId;
                        break;

                    case FilterItemType.Thread:
                        cbb = cbbThread;
                        break;

                    default:
                        cbb = cbbUser;
                        break;
                }

                if (e.Changes.Action == NotifyCollectionChangedAction.Add)
                {
                    foreach (var item in e.Changes.NewItems)
                    {
                        cbb.Items.Add(item);
                    }
                }
                else if (e.Changes.Action == NotifyCollectionChangedAction.Remove)
                {
                    foreach (var item in e.Changes.OldItems)
                    {
                        cbb.Items.Remove(item);
                    }
                }
            }));
        }

        private void CbbFilterChanged(object sender, EventArgs e)
        {
            var fi = new FilterInfo
            {
                Category = cbbCategory.SelectedItem?.ToString(),
                Level = cbbLevel.SelectedItem?.ToString(),
                Operation = cbbOperation.SelectedItem?.ToString(),
                Organization = cbbOrganization.SelectedItem?.ToString(),
                Process = cbbProcess.SelectedItem?.ToString(),
                ReqId = cbbRequId.SelectedItem?.ToString(),
                Thread = cbbThread.SelectedItem?.ToString(),
                User = (UserInfo)cbbUser.SelectedItem
            };

            FilterChanged?.Invoke(this, new FilterChangedEventArgs(fi));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (sender == btnClearReqId)
            {
                cbbRequId.SelectedItem = null;
            }
            else if (sender == btnClearCategory)
            {
                cbbCategory.SelectedItem = null;
            }
            else if (sender == btnClearLevel)
            {
                cbbLevel.SelectedItem = null;
            }
            else if (sender == btnClearOperation)
            {
                cbbOperation.SelectedItem = null;
            }
            else if (sender == btnClearOrganization)
            {
                cbbOrganization.SelectedItem = null;
            }
            else if (sender == btnClearProcess)
            {
                cbbProcess.SelectedItem = null;
            }
            else if (sender == btnClearThread)
            {
                cbbThread.SelectedItem = null;
            }
            else if (sender == btnClearUser)
            {
                cbbUser.SelectedItem = null;
            }
            else
            {
                foreach (var cbb in Controls.OfType<ComboBox>())
                {
                    cbb.SelectedIndexChanged -= CbbFilterChanged;
                }

                cbbRequId.SelectedItem = null;
                cbbCategory.SelectedItem = null;
                cbbLevel.SelectedItem = null;
                cbbOperation.SelectedItem = null;
                cbbOrganization.SelectedItem = null;
                cbbProcess.SelectedItem = null;
                cbbThread.SelectedItem = null;
                cbbUser.SelectedItem = null;

                foreach (var cbb in Controls.OfType<ComboBox>())
                {
                    cbb.SelectedIndexChanged += CbbFilterChanged;
                }

                CbbFilterChanged(null, null);
            }
        }

        public void ApplyUsers(Dictionary<Guid, string> users)
        {
            Invoke(new Action(() =>
            {
                var selectedId = ((UserInfo)cbbUser.SelectedItem)?.Id ?? Guid.Empty;
                var items = cbbUser.Items.Cast<UserInfo>().ToList();
                cbbUser.Items.Clear();
                cbbUser.Items.AddRange(items.ToArray());

                if (selectedId != Guid.Empty)
                {
                    cbbUser.SelectedItem = items.First(i => i.Id == selectedId);
                }
            }));
        }

        public void ClearUsers()
        {
            Invoke(new Action(() =>
            {
                var selectedId = ((UserInfo)cbbUser.SelectedItem)?.Id ?? Guid.Empty;
                var items = cbbUser.Items.Cast<UserInfo>().ToList();
                cbbUser.Items.Clear();
                cbbUser.Items.AddRange(items.ToArray());

                if (selectedId != Guid.Empty)
                {
                    cbbUser.SelectedItem = items.First(i => i.Id == selectedId);
                }
            }));
        }
    }
}