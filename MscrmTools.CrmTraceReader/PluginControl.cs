using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using MscrmTools.CrmTraceReader.AppCode;
using MscrmTools.CrmTraceReader.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Interfaces;

namespace MscrmTools.CrmTraceReader
{
    public partial class PluginControl : PluginControlBase, IGitHubPlugin
    {
        private readonly FilterForm filterForm;
        private readonly TraceForm traceForm;
        private readonly DetailsForm detailsForm;

        public PluginControl()
        {
            InitializeComponent();

            var allItems = new AllItems();

            dockPanel1.Theme = new VS2015LightTheme();

            filterForm = new FilterForm(allItems);
            filterForm.Show(dockPanel1, DockState.DockLeft);
            filterForm.FilterChanged += FilterForm_FilterChanged;

            detailsForm = new DetailsForm();
            detailsForm.Show(dockPanel1, DockState.DockBottom);

            traceForm = new TraceForm(allItems);
            traceForm.Show(dockPanel1, DockState.Document);
            traceForm.TraceSelected += TraceForm_TraceSelected;
        }

        private void MyPluginControl_Load(object sender, EventArgs e)
        {
        }

        #region Filter form events

        private void FilterForm_FilterChanged(object sender, CustomEventArgs.FilterChangedEventArgs e)
        {
            traceForm.DisplayTraces(e.Info);
        }

        private void TraceForm_TraceSelected(object sender, CustomEventArgs.TraceSelectedEventArgs e)
        {
            detailsForm.SetText(e.Info.Description);
        }

        #endregion Filter form events

        #region Files loading

        private void tsbOpenFile_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog
            {
                Filter = @"Log files (*.log)|*.log"
            };

            if (ofd.ShowDialog(this) == DialogResult.OK)
            {
                traceForm.Files.Clear();
                traceForm.Files.Add(new FileInfo(ofd.FileName));
                traceForm.LoadFiles();
            }
        }

        private void tsbOpenFolder_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog(this) == DialogResult.OK)
            {
                var di = new DirectoryInfo(fbd.SelectedPath);
                var files = di.GetFiles("*.log");

                traceForm.Files.Clear();
                traceForm.Files.AddRange(files);
                traceForm.LoadFiles();
            }
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            traceForm.LoadFiles();
        }

        #endregion Files loading

        #region Name resolution

        private void tsbResolveNames_Click(object sender, EventArgs e)
        {
            ExecuteMethod(ResolveNames);
        }

        private void ResolveNames()
        {
            traceForm.ShowLoadingPanel(true);
            WorkAsync(new WorkAsyncInfo
            {
                Message = @"Retrieving users...",
                Work = (bw, e) =>
                {
                    var users = GetUsers();
                    traceForm.ApplyUsers(users);
                    filterForm.ApplyUsers(users);
                },
                PostWorkCallBack = e =>
                {
                    traceForm.ShowLoadingPanel(false);
                }
            });
        }

        private Dictionary<Guid, string> GetUsers()
        {
            Dictionary<Guid, string> users = new Dictionary<Guid, string>();

            var query = new QueryExpression("systemuser")
            {
                NoLock = true,
                ColumnSet = new ColumnSet("fullname"),
                Criteria = new FilterExpression
                {
                    Conditions =
                    {
                        new ConditionExpression("isdisabled", ConditionOperator.Equal, false)
                    }
                },
                PageInfo = new PagingInfo
                {
                    Count = 500,
                    PageNumber = 1
                }
            };

            EntityCollection ec;
            do
            {
                ec = Service.RetrieveMultiple(query);

                foreach (var result in ec.Entities)
                {
                    users.Add(result.Id, result.GetAttributeValue<string>("fullname"));
                }

                query.PageInfo.PageNumber++;
            } while (ec.MoreRecords);

            return users;
        }

        private void tsbClearNameCache_Click(object sender, EventArgs e)
        {
            traceForm.ClearUsers();
            filterForm.ClearUsers();
            traceForm.ShowLoadingPanel(false);
        }

        #endregion Name resolution

        #region IGithubPlugin

        public string RepositoryName => "MscrmTools.CrmTraceReader";
        public string UserName => "MscrmTools";

        #endregion IGithubPlugin
    }
}