namespace MscrmTools.CrmTraceReader.Forms
{
    partial class TraceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TraceForm));
            this.lvTraces = new System.Windows.Forms.ListView();
            this.chDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chOperation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chProcess = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chOrganization = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chThread = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chReqId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.loadingPanel = new System.Windows.Forms.Panel();
            this.pbLoading = new System.Windows.Forms.PictureBox();
            this.loadingLabel = new System.Windows.Forms.Label();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loadingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).BeginInit();
            this.pnlFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvTraces
            // 
            this.lvTraces.AllowDrop = true;
            this.lvTraces.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chDate,
            this.chOperation,
            this.chProcess,
            this.chOrganization,
            this.chThread,
            this.chCategory,
            this.chUser,
            this.chLevel,
            this.chReqId});
            this.lvTraces.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvTraces.FullRowSelect = true;
            this.lvTraces.HideSelection = false;
            this.lvTraces.Location = new System.Drawing.Point(0, 21);
            this.lvTraces.MultiSelect = false;
            this.lvTraces.Name = "lvTraces";
            this.lvTraces.Size = new System.Drawing.Size(800, 429);
            this.lvTraces.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvTraces.TabIndex = 2;
            this.lvTraces.UseCompatibleStateImageBehavior = false;
            this.lvTraces.View = System.Windows.Forms.View.Details;
            this.lvTraces.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvTraces_ColumnClick);
            this.lvTraces.SelectedIndexChanged += new System.EventHandler(this.lvTraces_SelectedIndexChanged);
            this.lvTraces.DragDrop += new System.Windows.Forms.DragEventHandler(this.LvDragDrop);
            this.lvTraces.DragEnter += new System.Windows.Forms.DragEventHandler(this.LvDragEnter);
            // 
            // chDate
            // 
            this.chDate.Text = "Date";
            this.chDate.Width = 150;
            // 
            // chOperation
            // 
            this.chOperation.Text = "Operation";
            this.chOperation.Width = 300;
            // 
            // chProcess
            // 
            this.chProcess.Text = "Process";
            // 
            // chOrganization
            // 
            this.chOrganization.Text = "Organization";
            this.chOrganization.Width = 250;
            // 
            // chThread
            // 
            this.chThread.Text = "Thread";
            this.chThread.Width = 250;
            // 
            // chCategory
            // 
            this.chCategory.Text = "Category";
            this.chCategory.Width = 120;
            // 
            // chUser
            // 
            this.chUser.Text = "User";
            this.chUser.Width = 250;
            // 
            // chLevel
            // 
            this.chLevel.Text = "Level";
            // 
            // chReqId
            // 
            this.chReqId.Text = "ReqId";
            this.chReqId.Width = 250;
            // 
            // loadingPanel
            // 
            this.loadingPanel.BackColor = System.Drawing.Color.White;
            this.loadingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loadingPanel.Controls.Add(this.pbLoading);
            this.loadingPanel.Controls.Add(this.loadingLabel);
            this.loadingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadingPanel.Location = new System.Drawing.Point(0, 21);
            this.loadingPanel.Name = "loadingPanel";
            this.loadingPanel.Size = new System.Drawing.Size(800, 429);
            this.loadingPanel.TabIndex = 3;
            this.loadingPanel.Visible = false;
            // 
            // pbLoading
            // 
            this.pbLoading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbLoading.Image = ((System.Drawing.Image)(resources.GetObject("pbLoading.Image")));
            this.pbLoading.Location = new System.Drawing.Point(381, 210);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(36, 36);
            this.pbLoading.TabIndex = 1;
            this.pbLoading.TabStop = false;
            // 
            // loadingLabel
            // 
            this.loadingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.loadingLabel.Location = new System.Drawing.Point(0, 169);
            this.loadingLabel.Name = "loadingLabel";
            this.loadingLabel.Size = new System.Drawing.Size(798, 38);
            this.loadingLabel.TabIndex = 0;
            this.loadingLabel.Text = "[TEXT]";
            this.loadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlFilter
            // 
            this.pnlFilter.BackColor = System.Drawing.Color.White;
            this.pnlFilter.Controls.Add(this.txtFilter);
            this.pnlFilter.Controls.Add(this.label1);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilter.Location = new System.Drawing.Point(0, 0);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(800, 21);
            this.pnlFilter.TabIndex = 2;
            // 
            // txtFilter
            // 
            this.txtFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFilter.Location = new System.Drawing.Point(88, 0);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(712, 20);
            this.txtFilter.TabIndex = 1;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filter by details :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TraceForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvTraces);
            this.Controls.Add(this.loadingPanel);
            this.Controls.Add(this.pnlFilter);
            this.DockAreas = WeifenLuo.WinFormsUI.Docking.DockAreas.Document;
            this.Name = "TraceForm";
            this.TabText = "Traces";
            this.Text = "TraceForm";
            this.loadingPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvTraces;
        private System.Windows.Forms.ColumnHeader chDate;
        private System.Windows.Forms.ColumnHeader chOperation;
        private System.Windows.Forms.ColumnHeader chProcess;
        private System.Windows.Forms.ColumnHeader chOrganization;
        private System.Windows.Forms.ColumnHeader chThread;
        private System.Windows.Forms.ColumnHeader chCategory;
        private System.Windows.Forms.ColumnHeader chUser;
        private System.Windows.Forms.ColumnHeader chLevel;
        private System.Windows.Forms.ColumnHeader chReqId;
        private System.Windows.Forms.Panel loadingPanel;
        private System.Windows.Forms.PictureBox pbLoading;
        private System.Windows.Forms.Label loadingLabel;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label1;
    }
}