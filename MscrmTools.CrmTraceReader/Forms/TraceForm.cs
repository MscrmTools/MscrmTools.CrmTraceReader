using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using MscrmTools.CrmTraceReader.AppCode;
using MscrmTools.CrmTraceReader.CustomEventArgs;
using WeifenLuo.WinFormsUI.Docking;

namespace MscrmTools.CrmTraceReader.Forms
{
    public partial class TraceForm : DockContent
    {
        private List<FileInfo> files;
        private List<TraceInfo> traces;
        private FilterInfo currentFilterInfo;
        private readonly AllItems allItems;
        private TraceInfo lastSelectedTraceInfo;

        public TraceForm(AllItems allItems)
        {
            InitializeComponent();
            this.allItems = allItems;
            files = new List<FileInfo>();
        }

        public List<FileInfo> Files => files;

        public event EventHandler<TraceSelectedEventArgs> TraceSelected;

        #region Drag & Drop

        private void LvDragDrop(object sender, DragEventArgs e)
        {
            files = new List<FileInfo>();

            FileAttributes attr = File.GetAttributes(((string[])e.Data.GetData(DataFormats.FileDrop))[0]);
            if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
            {
                foreach (var file in new DirectoryInfo(((string[])e.Data.GetData(DataFormats.FileDrop))[0]).GetFiles("*.log"))
                {
                    files.Add(file);
                }
            }
            else
            {
                foreach (var filename in (string[])e.Data.GetData(DataFormats.FileDrop))
                {
                    files.Add(new FileInfo(filename));
                }
            }

            LoadFiles();
        }

        private void LvDragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                var droppedFiles = (string[])e.Data.GetData(DataFormats.FileDrop);

                FileAttributes attr = File.GetAttributes(droppedFiles[0]);
                if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    e.Effect = new DirectoryInfo(droppedFiles[0]).GetFiles("*.log").Length > 0
                        ? DragDropEffects.All
                        : DragDropEffects.None;
                }
                else
                {
                    e.Effect = droppedFiles.ToList().Any(f => !f.EndsWith(".log"))
                        ? DragDropEffects.None
                        : DragDropEffects.All;
                }
            }
            else
                e.Effect = DragDropEffects.None;
        }

        #endregion Drag & Drop

        #region Methods

        public void ShowLoadingPanel(bool display)
        {
            lvTraces.Visible = !display;
            loadingPanel.Visible = display;
        }

        public void LoadFiles()
        {
            traces = new List<TraceInfo>();
            lvTraces.Items.Clear();
            ShowLoadingPanel(true);
            loadingLabel.Text = @"Loading files...";

            var bw = new BackgroundWorker { WorkerReportsProgress = true };
            bw.DoWork += (sender, e) => { ParseFiles(); };
            bw.ProgressChanged += (sender, e) => { loadingLabel.Text = e.UserState.ToString(); };
            bw.RunWorkerCompleted += (sender, e) =>
            {
                ShowLoadingPanel(false);

                if (e.Error != null)
                {
                    MessageBox.Show(this, e.Error.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                DisplayTraces();
            };
            bw.RunWorkerAsync();
        }

        private void ParseFiles()
        {
            foreach (var file in files)
            {
                using (var fileStream = new FileStream(file.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                using (var reader = new StreamReader(fileStream))
                {
                    TraceInfo ti = null;
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.Trim().StartsWith("#") || string.IsNullOrEmpty(line))
                            continue;

                        if (line.StartsWith("["))
                        {
                            var lineParts = line.Split('|');

                            if (lineParts.Length == 1)
                            {
                                ti.Description += lineParts[0];
                                continue;
                            }

                            if (ti != null)
                            {
                                traces.Add(ti);
                            }

                            var threadParts = lineParts[2].Split(':');
                            var list = threadParts.ToList();
                            list.RemoveAt(0);

                            ti = new TraceInfo();

                            for (int i = 0; i < lineParts.Length; i++)
                            {
                                if (i == 0)
                                {
                                    var parts = lineParts[i].Split(']');
                                    ti.Date = DateTime.Parse(parts[0].Remove(0, 1));
                                    ti.Process = parts[1].Trim().Split(':')[1].Trim();
                                    allItems.TryAdd(FilterItemType.Process, ti.Process);
                                }
                                else
                                {
                                    if (ti.Process == "OUTLOOK")
                                    {
                                        var parts = lineParts[i].Split(':');
                                        switch (parts[0].Trim())
                                        {
                                            case "Thread":
                                                ti.Thread = parts[1].Trim();
                                                allItems.TryAdd(FilterItemType.Thread, ti.Thread);
                                                break;

                                            case "Category":
                                                ti.Category = parts[1].Trim();
                                                allItems.TryAdd(FilterItemType.Category, ti.Category);
                                                break;

                                            case "User":
                                                ti.User = new UserInfo { Id = new Guid(parts[1].Trim()) };
                                                allItems.TryAdd(FilterItemType.User, ti.User);
                                                break;

                                            case "Level":
                                                ti.Level = parts[1].Trim();
                                                allItems.TryAdd(FilterItemType.Level, ti.Level);
                                                break;

                                            default:
                                                ti.Description = lineParts[i].Trim() + "\r\n";
                                                break;
                                        }

                                        ti.Organization = string.Empty;
                                        ti.ReqId = string.Empty;
                                        ti.Context = string.Empty;
                                    }
                                    else
                                    {
                                        var parts = lineParts[i].Split(':');
                                        switch (parts[0].Trim())
                                        {
                                            case "Organization":
                                                ti.Organization = parts[1].Trim();
                                                allItems.TryAdd(FilterItemType.Organization, ti.Organization);
                                                break;

                                            case "Thread":
                                                ti.Thread = parts[1].Trim();
                                                allItems.TryAdd(FilterItemType.Thread, ti.Thread);
                                                break;

                                            case "Category":
                                                ti.Category = parts[1].Trim();
                                                allItems.TryAdd(FilterItemType.Category, ti.Category);
                                                break;

                                            case "User":
                                                ti.User = new UserInfo { Id = new Guid(parts[1].Trim()) };
                                                allItems.TryAdd(FilterItemType.User, ti.User);
                                                break;

                                            case "Level":
                                                ti.Level = parts[1].Trim();
                                                allItems.TryAdd(FilterItemType.Level, ti.Level);
                                                break;

                                            case "ReqId":
                                                ti.ReqId = parts[1].Trim();
                                                allItems.TryAdd(FilterItemType.ReqId, ti.ReqId);
                                                break;

                                            default:
                                                ti.Context = lineParts[i].Trim().Split(' ')[0];
                                                allItems.TryAdd(FilterItemType.Operation, ti.Context);
                                                break;
                                        }
                                    }
                                }
                            }
                        }
                        else if (line.StartsWith(">"))
                        {
                            ti.Description += line.Remove(0, 1) + "\r\n";
                        }
                        else
                        {
                            ti.Description += line + "\r\n";
                        }
                    }
                }
            }
        }

        public void DisplayTraces(FilterInfo eInfo = null)
        {
            currentFilterInfo = eInfo;

            if (traces == null || traces.Count == 0)
            {
                return;
            }

            int i = 0;
            var lvis = new List<ListViewItem>();

            var filteredTraces = traces;

            if (eInfo != null)
            {
                filteredTraces = filteredTraces.Where(t =>
                    (eInfo.Category == null || eInfo.Category != null && t.Category == eInfo.Category)
                    && (eInfo.Level == null || eInfo.Level != null && t.Level == eInfo.Level)
                    && (eInfo.Operation == null || eInfo.Operation != null && t.Context == eInfo.Operation)
                    && (eInfo.Organization == null || eInfo.Organization != null && t.Organization == eInfo.Organization)
                    && (eInfo.Process == null || eInfo.Process != null && t.Process == eInfo.Process)
                    && (eInfo.ReqId == null || eInfo.ReqId != null && t.ReqId == eInfo.ReqId)
                    && (eInfo.Thread == null || eInfo.Thread != null && t.Thread == eInfo.Thread)
                    && (eInfo.User == null || eInfo.User != null && t.User.Id == eInfo.User.Id)
                ).ToList();
            }

            if (txtFilter.Text.Length > 3)
            {
                filteredTraces =
                    filteredTraces.Where(t => t.Description.ToLower().IndexOf(txtFilter.Text.ToLower()) >= 0).ToList();
            }

            if (filteredTraces.Count == 0)
            {
                Invoke(new Action(() =>
                {
                    lvTraces.Items.Clear();
                    txtFilter.BackColor = lvis.Count == 0 ? Color.Salmon : SystemColors.Window;
                }));
                return;
            }

            int toDisplay = -1;

            foreach (var ti in filteredTraces)
            {
                var item = new ListViewItem(ti.Date.ToString("yyyy/MM/dd HH:mm:ss.FFF"));
                item.SubItems.Add(ti.Context);
                item.SubItems.Add(ti.Process);
                item.SubItems.Add(ti.Organization);
                item.SubItems.Add(ti.Thread);
                item.SubItems.Add(ti.Category);
                item.SubItems.Add(ti.User.ToString());
                item.SubItems.Add(ti.Level);
                item.SubItems.Add(ti.ReqId);
                item.Tag = ti;

                item.ImageIndex = (ti.Level == "Info"
                    ? 0
                    : ti.Level == "Warning" ? 1 : ti.Level == "Verbose" ? 3 : 2);

                item.ForeColor = (ti.Level == "Info"
                    ? Color.FromArgb(74, 125, 177)
                    : ti.Level == "Warning"
                        ? Color.FromArgb(240, 155, 33)
                        : ti.Level == "Verbose" ? Color.Black : Color.FromArgb(216, 3, 3));

                lvis.Add(item);

                if (lastSelectedTraceInfo != null && lastSelectedTraceInfo == ti)
                {
                    item.Selected = true;
                    toDisplay = i;
                }

                i++;
            }

            Invoke(new Action(() =>
            {
                lvTraces.Items.Clear();
                lvTraces.Items.AddRange(lvis.ToArray());

                if (toDisplay != -1)
                {
                    lvTraces.EnsureVisible(toDisplay);
                }
            }));
        }

        public void Reload()
        {
            DisplayTraces(currentFilterInfo);
        }

        #endregion Methods

        private void lvTraces_ColumnClick(object sender, ColumnClickEventArgs e)
        {
        }

        private void lvTraces_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvTraces.SelectedItems.Count == 0)
            {
                return;
            }

            lastSelectedTraceInfo = (TraceInfo)lvTraces.SelectedItems[0].Tag;

            TraceSelected?.Invoke(this, new TraceSelectedEventArgs(lastSelectedTraceInfo));
        }

        public void ApplyUsers(Dictionary<Guid, string> users)
        {
            foreach (var trace in traces)
            {
                if (users.ContainsKey(trace.User.Id))
                {
                    trace.User.Fullname = users[trace.User.Id];
                }
            }
        }

        public void ClearUsers()
        {
            foreach (var trace in traces)
            {
                trace.User.Fullname = null;
            }
        }

        private Thread searchThread;

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (txtFilter.Text.Length > 3)
            {
                txtFilter.BackColor = SystemColors.Window;
                searchThread?.Abort();
                searchThread = new Thread(() => DisplayTraces(currentFilterInfo));
                searchThread.Start();
            }
        }
    }
}