namespace MscrmTools.CrmTraceReader
{
    partial class PluginControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PluginControl));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.tsbOpenFolder = new System.Windows.Forms.ToolStripButton();
            this.tsbOpenFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbResolveNames = new System.Windows.Forms.ToolStripButton();
            this.tsbClearNameCache = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbViewXml = new System.Windows.Forms.ToolStripButton();
            this.dockPanel1 = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.toolStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOpenFolder,
            this.tsbOpenFile,
            this.toolStripSeparator1,
            this.tsbRefresh,
            this.toolStripSeparator2,
            this.tsbResolveNames,
            this.tsbClearNameCache,
            this.toolStripSeparator4,
            this.tsbViewXml});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(888, 25);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // tsbOpenFolder
            // 
            this.tsbOpenFolder.Image = ((System.Drawing.Image)(resources.GetObject("tsbOpenFolder.Image")));
            this.tsbOpenFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpenFolder.Name = "tsbOpenFolder";
            this.tsbOpenFolder.Size = new System.Drawing.Size(90, 22);
            this.tsbOpenFolder.Text = "Open folder";
            this.tsbOpenFolder.ToolTipText = "Reads all log files in the specified folder\r\n\r\nIt can take some time to load file" +
    "s depending on their sizes";
            this.tsbOpenFolder.Click += new System.EventHandler(this.tsbOpenFolder_Click);
            // 
            // tsbOpenFile
            // 
            this.tsbOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("tsbOpenFile.Image")));
            this.tsbOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpenFile.Name = "tsbOpenFile";
            this.tsbOpenFile.Size = new System.Drawing.Size(75, 22);
            this.tsbOpenFile.Text = "Open file";
            this.tsbOpenFile.ToolTipText = "This can take some time depending on the file size";
            this.tsbOpenFile.Click += new System.EventHandler(this.tsbOpenFile_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsbRefresh.Image")));
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(95, 22);
            this.tsbRefresh.Text = "Reload file(s)";
            this.tsbRefresh.Click += new System.EventHandler(this.tsbRefresh_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbResolveNames
            // 
            this.tsbResolveNames.Image = ((System.Drawing.Image)(resources.GetObject("tsbResolveNames.Image")));
            this.tsbResolveNames.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbResolveNames.Name = "tsbResolveNames";
            this.tsbResolveNames.Size = new System.Drawing.Size(105, 22);
            this.tsbResolveNames.Text = "Resolve names";
            this.tsbResolveNames.ToolTipText = "This action allows to replace unique identifiers (GUID) by names. \r\n\r\nIt only wor" +
    "ks for one Dynamics CRM deployment.";
            this.tsbResolveNames.Click += new System.EventHandler(this.tsbResolveNames_Click);
            // 
            // tsbClearNameCache
            // 
            this.tsbClearNameCache.Image = ((System.Drawing.Image)(resources.GetObject("tsbClearNameCache.Image")));
            this.tsbClearNameCache.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClearNameCache.Name = "tsbClearNameCache";
            this.tsbClearNameCache.Size = new System.Drawing.Size(126, 22);
            this.tsbClearNameCache.Text = "Clear names cache";
            this.tsbClearNameCache.ToolTipText = "This also reloads traces";
            this.tsbClearNameCache.Click += new System.EventHandler(this.tsbClearNameCache_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator4.Visible = false;
            // 
            // tsbViewXml
            // 
            this.tsbViewXml.Enabled = false;
            this.tsbViewXml.Image = ((System.Drawing.Image)(resources.GetObject("tsbViewXml.Image")));
            this.tsbViewXml.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbViewXml.Name = "tsbViewXml";
            this.tsbViewXml.Size = new System.Drawing.Size(153, 22);
            this.tsbViewXml.Text = "Improve Xml readability";
            this.tsbViewXml.Visible = false;
            // 
            // dockPanel1
            // 
            this.dockPanel1.AllowDrop = true;
            this.dockPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanel1.DocumentStyle = WeifenLuo.WinFormsUI.Docking.DocumentStyle.DockingWindow;
            this.dockPanel1.Location = new System.Drawing.Point(0, 25);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.Size = new System.Drawing.Size(888, 489);
            this.dockPanel1.TabIndex = 5;
            // 
            // PluginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dockPanel1);
            this.Controls.Add(this.toolStripMenu);
            this.Name = "PluginControl";
            this.Size = new System.Drawing.Size(888, 514);
            this.Load += new System.EventHandler(this.MyPluginControl_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton tsbOpenFolder;
        private System.Windows.Forms.ToolStripButton tsbOpenFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbResolveNames;
        private System.Windows.Forms.ToolStripButton tsbClearNameCache;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbViewXml;
        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel1;
    }
}
