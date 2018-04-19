namespace MscrmTools.CrmTraceReader.Forms
{
    partial class FilterForm
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbClearFilters = new System.Windows.Forms.ToolStripButton();
            this.lblOperation = new System.Windows.Forms.Label();
            this.pnlReqId = new System.Windows.Forms.Panel();
            this.cbbRequId = new System.Windows.Forms.ComboBox();
            this.btnClearReqId = new System.Windows.Forms.Button();
            this.pnlProcess = new System.Windows.Forms.Panel();
            this.cbbProcess = new System.Windows.Forms.ComboBox();
            this.btnClearProcess = new System.Windows.Forms.Button();
            this.pnlOrganization = new System.Windows.Forms.Panel();
            this.cbbOrganization = new System.Windows.Forms.ComboBox();
            this.btnClearOrganization = new System.Windows.Forms.Button();
            this.pnlThread = new System.Windows.Forms.Panel();
            this.cbbThread = new System.Windows.Forms.ComboBox();
            this.btnClearThread = new System.Windows.Forms.Button();
            this.pnlCategory = new System.Windows.Forms.Panel();
            this.cbbCategory = new System.Windows.Forms.ComboBox();
            this.btnClearCategory = new System.Windows.Forms.Button();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.cbbUser = new System.Windows.Forms.ComboBox();
            this.btnClearUser = new System.Windows.Forms.Button();
            this.pnlLevel = new System.Windows.Forms.Panel();
            this.cbbLevel = new System.Windows.Forms.ComboBox();
            this.btnClearLevel = new System.Windows.Forms.Button();
            this.lblProcess = new System.Windows.Forms.Label();
            this.lblOrganization = new System.Windows.Forms.Label();
            this.lblThread = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblReqId = new System.Windows.Forms.Label();
            this.pnlOperation = new System.Windows.Forms.Panel();
            this.cbbOperation = new System.Windows.Forms.ComboBox();
            this.btnClearOperation = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.pnlReqId.SuspendLayout();
            this.pnlProcess.SuspendLayout();
            this.pnlOrganization.SuspendLayout();
            this.pnlThread.SuspendLayout();
            this.pnlCategory.SuspendLayout();
            this.pnlUser.SuspendLayout();
            this.pnlLevel.SuspendLayout();
            this.pnlOperation.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbClearFilters});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(441, 25);
            this.toolStrip1.TabIndex = 42;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbClearFilters
            // 
            this.tsbClearFilters.Image = global::MscrmTools.CrmTraceReader.Properties.Resources.Clear_16;
            this.tsbClearFilters.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClearFilters.Name = "tsbClearFilters";
            this.tsbClearFilters.Size = new System.Drawing.Size(101, 22);
            this.tsbClearFilters.Text = "Clear all filters";
            this.tsbClearFilters.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblOperation
            // 
            this.lblOperation.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOperation.Location = new System.Drawing.Point(0, 25);
            this.lblOperation.Name = "lblOperation";
            this.lblOperation.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.lblOperation.Size = new System.Drawing.Size(441, 20);
            this.lblOperation.TabIndex = 43;
            this.lblOperation.Text = "Operation";
            // 
            // pnlReqId
            // 
            this.pnlReqId.Controls.Add(this.cbbRequId);
            this.pnlReqId.Controls.Add(this.btnClearReqId);
            this.pnlReqId.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlReqId.Location = new System.Drawing.Point(0, 332);
            this.pnlReqId.Name = "pnlReqId";
            this.pnlReqId.Size = new System.Drawing.Size(441, 21);
            this.pnlReqId.TabIndex = 59;
            // 
            // cbbRequId
            // 
            this.cbbRequId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbRequId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRequId.FormattingEnabled = true;
            this.cbbRequId.Location = new System.Drawing.Point(0, 0);
            this.cbbRequId.Name = "cbbRequId";
            this.cbbRequId.Size = new System.Drawing.Size(420, 21);
            this.cbbRequId.TabIndex = 59;
            this.cbbRequId.SelectedIndexChanged += new System.EventHandler(this.CbbFilterChanged);
            // 
            // btnClearReqId
            // 
            this.btnClearReqId.BackgroundImage = global::MscrmTools.CrmTraceReader.Properties.Resources.Clear_16;
            this.btnClearReqId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClearReqId.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClearReqId.Location = new System.Drawing.Point(420, 0);
            this.btnClearReqId.Name = "btnClearReqId";
            this.btnClearReqId.Size = new System.Drawing.Size(21, 21);
            this.btnClearReqId.TabIndex = 0;
            this.btnClearReqId.UseVisualStyleBackColor = true;
            this.btnClearReqId.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pnlProcess
            // 
            this.pnlProcess.Controls.Add(this.cbbProcess);
            this.pnlProcess.Controls.Add(this.btnClearProcess);
            this.pnlProcess.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProcess.Location = new System.Drawing.Point(0, 86);
            this.pnlProcess.Name = "pnlProcess";
            this.pnlProcess.Size = new System.Drawing.Size(441, 21);
            this.pnlProcess.TabIndex = 61;
            // 
            // cbbProcess
            // 
            this.cbbProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbProcess.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbProcess.FormattingEnabled = true;
            this.cbbProcess.Location = new System.Drawing.Point(0, 0);
            this.cbbProcess.Name = "cbbProcess";
            this.cbbProcess.Size = new System.Drawing.Size(420, 21);
            this.cbbProcess.TabIndex = 47;
            this.cbbProcess.SelectedIndexChanged += new System.EventHandler(this.CbbFilterChanged);
            // 
            // btnClearProcess
            // 
            this.btnClearProcess.BackgroundImage = global::MscrmTools.CrmTraceReader.Properties.Resources.Clear_16;
            this.btnClearProcess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClearProcess.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClearProcess.Location = new System.Drawing.Point(420, 0);
            this.btnClearProcess.Name = "btnClearProcess";
            this.btnClearProcess.Size = new System.Drawing.Size(21, 21);
            this.btnClearProcess.TabIndex = 0;
            this.btnClearProcess.UseVisualStyleBackColor = true;
            this.btnClearProcess.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pnlOrganization
            // 
            this.pnlOrganization.Controls.Add(this.cbbOrganization);
            this.pnlOrganization.Controls.Add(this.btnClearOrganization);
            this.pnlOrganization.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOrganization.Location = new System.Drawing.Point(0, 127);
            this.pnlOrganization.Name = "pnlOrganization";
            this.pnlOrganization.Size = new System.Drawing.Size(441, 21);
            this.pnlOrganization.TabIndex = 62;
            // 
            // cbbOrganization
            // 
            this.cbbOrganization.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbOrganization.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbOrganization.FormattingEnabled = true;
            this.cbbOrganization.Location = new System.Drawing.Point(0, 0);
            this.cbbOrganization.Name = "cbbOrganization";
            this.cbbOrganization.Size = new System.Drawing.Size(420, 21);
            this.cbbOrganization.TabIndex = 49;
            this.cbbOrganization.SelectedIndexChanged += new System.EventHandler(this.CbbFilterChanged);
            // 
            // btnClearOrganization
            // 
            this.btnClearOrganization.BackgroundImage = global::MscrmTools.CrmTraceReader.Properties.Resources.Clear_16;
            this.btnClearOrganization.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClearOrganization.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClearOrganization.Location = new System.Drawing.Point(420, 0);
            this.btnClearOrganization.Name = "btnClearOrganization";
            this.btnClearOrganization.Size = new System.Drawing.Size(21, 21);
            this.btnClearOrganization.TabIndex = 0;
            this.btnClearOrganization.UseVisualStyleBackColor = true;
            this.btnClearOrganization.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pnlThread
            // 
            this.pnlThread.Controls.Add(this.cbbThread);
            this.pnlThread.Controls.Add(this.btnClearThread);
            this.pnlThread.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlThread.Location = new System.Drawing.Point(0, 168);
            this.pnlThread.Name = "pnlThread";
            this.pnlThread.Size = new System.Drawing.Size(441, 21);
            this.pnlThread.TabIndex = 63;
            // 
            // cbbThread
            // 
            this.cbbThread.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbThread.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbThread.FormattingEnabled = true;
            this.cbbThread.Location = new System.Drawing.Point(0, 0);
            this.cbbThread.Name = "cbbThread";
            this.cbbThread.Size = new System.Drawing.Size(420, 21);
            this.cbbThread.TabIndex = 51;
            this.cbbThread.SelectedIndexChanged += new System.EventHandler(this.CbbFilterChanged);
            // 
            // btnClearThread
            // 
            this.btnClearThread.BackgroundImage = global::MscrmTools.CrmTraceReader.Properties.Resources.Clear_16;
            this.btnClearThread.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClearThread.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClearThread.Location = new System.Drawing.Point(420, 0);
            this.btnClearThread.Name = "btnClearThread";
            this.btnClearThread.Size = new System.Drawing.Size(21, 21);
            this.btnClearThread.TabIndex = 0;
            this.btnClearThread.UseVisualStyleBackColor = true;
            this.btnClearThread.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pnlCategory
            // 
            this.pnlCategory.Controls.Add(this.cbbCategory);
            this.pnlCategory.Controls.Add(this.btnClearCategory);
            this.pnlCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCategory.Location = new System.Drawing.Point(0, 209);
            this.pnlCategory.Name = "pnlCategory";
            this.pnlCategory.Size = new System.Drawing.Size(441, 21);
            this.pnlCategory.TabIndex = 64;
            // 
            // cbbCategory
            // 
            this.cbbCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCategory.FormattingEnabled = true;
            this.cbbCategory.Location = new System.Drawing.Point(0, 0);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Size = new System.Drawing.Size(420, 21);
            this.cbbCategory.TabIndex = 53;
            this.cbbCategory.SelectedIndexChanged += new System.EventHandler(this.CbbFilterChanged);
            // 
            // btnClearCategory
            // 
            this.btnClearCategory.BackgroundImage = global::MscrmTools.CrmTraceReader.Properties.Resources.Clear_16;
            this.btnClearCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClearCategory.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClearCategory.Location = new System.Drawing.Point(420, 0);
            this.btnClearCategory.Name = "btnClearCategory";
            this.btnClearCategory.Size = new System.Drawing.Size(21, 21);
            this.btnClearCategory.TabIndex = 0;
            this.btnClearCategory.UseVisualStyleBackColor = true;
            this.btnClearCategory.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pnlUser
            // 
            this.pnlUser.Controls.Add(this.cbbUser);
            this.pnlUser.Controls.Add(this.btnClearUser);
            this.pnlUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUser.Location = new System.Drawing.Point(0, 250);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(441, 21);
            this.pnlUser.TabIndex = 65;
            // 
            // cbbUser
            // 
            this.cbbUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbUser.FormattingEnabled = true;
            this.cbbUser.Location = new System.Drawing.Point(0, 0);
            this.cbbUser.Name = "cbbUser";
            this.cbbUser.Size = new System.Drawing.Size(420, 21);
            this.cbbUser.TabIndex = 55;
            this.cbbUser.SelectedIndexChanged += new System.EventHandler(this.CbbFilterChanged);
            // 
            // btnClearUser
            // 
            this.btnClearUser.BackgroundImage = global::MscrmTools.CrmTraceReader.Properties.Resources.Clear_16;
            this.btnClearUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClearUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClearUser.Location = new System.Drawing.Point(420, 0);
            this.btnClearUser.Name = "btnClearUser";
            this.btnClearUser.Size = new System.Drawing.Size(21, 21);
            this.btnClearUser.TabIndex = 0;
            this.btnClearUser.UseVisualStyleBackColor = true;
            this.btnClearUser.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pnlLevel
            // 
            this.pnlLevel.Controls.Add(this.cbbLevel);
            this.pnlLevel.Controls.Add(this.btnClearLevel);
            this.pnlLevel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLevel.Location = new System.Drawing.Point(0, 291);
            this.pnlLevel.Name = "pnlLevel";
            this.pnlLevel.Size = new System.Drawing.Size(441, 21);
            this.pnlLevel.TabIndex = 66;
            // 
            // cbbLevel
            // 
            this.cbbLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLevel.FormattingEnabled = true;
            this.cbbLevel.Location = new System.Drawing.Point(0, 0);
            this.cbbLevel.Name = "cbbLevel";
            this.cbbLevel.Size = new System.Drawing.Size(420, 21);
            this.cbbLevel.TabIndex = 57;
            this.cbbLevel.SelectedIndexChanged += new System.EventHandler(this.CbbFilterChanged);
            // 
            // btnClearLevel
            // 
            this.btnClearLevel.BackgroundImage = global::MscrmTools.CrmTraceReader.Properties.Resources.Clear_16;
            this.btnClearLevel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClearLevel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClearLevel.Location = new System.Drawing.Point(420, 0);
            this.btnClearLevel.Name = "btnClearLevel";
            this.btnClearLevel.Size = new System.Drawing.Size(21, 21);
            this.btnClearLevel.TabIndex = 0;
            this.btnClearLevel.UseVisualStyleBackColor = true;
            this.btnClearLevel.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblProcess
            // 
            this.lblProcess.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProcess.Location = new System.Drawing.Point(0, 66);
            this.lblProcess.Name = "lblProcess";
            this.lblProcess.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.lblProcess.Size = new System.Drawing.Size(441, 20);
            this.lblProcess.TabIndex = 67;
            this.lblProcess.Text = "Process";
            // 
            // lblOrganization
            // 
            this.lblOrganization.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOrganization.Location = new System.Drawing.Point(0, 107);
            this.lblOrganization.Name = "lblOrganization";
            this.lblOrganization.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.lblOrganization.Size = new System.Drawing.Size(441, 20);
            this.lblOrganization.TabIndex = 68;
            this.lblOrganization.Text = "Organization";
            // 
            // lblThread
            // 
            this.lblThread.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblThread.Location = new System.Drawing.Point(0, 148);
            this.lblThread.Name = "lblThread";
            this.lblThread.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.lblThread.Size = new System.Drawing.Size(441, 20);
            this.lblThread.TabIndex = 69;
            this.lblThread.Text = "Thread";
            // 
            // lblCategory
            // 
            this.lblCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCategory.Location = new System.Drawing.Point(0, 189);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.lblCategory.Size = new System.Drawing.Size(441, 20);
            this.lblCategory.TabIndex = 70;
            this.lblCategory.Text = "Category";
            // 
            // lblUser
            // 
            this.lblUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUser.Location = new System.Drawing.Point(0, 230);
            this.lblUser.Name = "lblUser";
            this.lblUser.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.lblUser.Size = new System.Drawing.Size(441, 20);
            this.lblUser.TabIndex = 71;
            this.lblUser.Text = "User";
            // 
            // lblLevel
            // 
            this.lblLevel.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLevel.Location = new System.Drawing.Point(0, 271);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.lblLevel.Size = new System.Drawing.Size(441, 20);
            this.lblLevel.TabIndex = 72;
            this.lblLevel.Text = "Level";
            // 
            // lblReqId
            // 
            this.lblReqId.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblReqId.Location = new System.Drawing.Point(0, 312);
            this.lblReqId.Name = "lblReqId";
            this.lblReqId.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.lblReqId.Size = new System.Drawing.Size(441, 20);
            this.lblReqId.TabIndex = 73;
            this.lblReqId.Text = "ReqId";
            // 
            // pnlOperation
            // 
            this.pnlOperation.Controls.Add(this.cbbOperation);
            this.pnlOperation.Controls.Add(this.btnClearOperation);
            this.pnlOperation.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOperation.Location = new System.Drawing.Point(0, 45);
            this.pnlOperation.Name = "pnlOperation";
            this.pnlOperation.Size = new System.Drawing.Size(441, 21);
            this.pnlOperation.TabIndex = 74;
            // 
            // cbbOperation
            // 
            this.cbbOperation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbOperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbOperation.FormattingEnabled = true;
            this.cbbOperation.Location = new System.Drawing.Point(0, 0);
            this.cbbOperation.Name = "cbbOperation";
            this.cbbOperation.Size = new System.Drawing.Size(420, 21);
            this.cbbOperation.TabIndex = 45;
            this.cbbOperation.SelectedIndexChanged += new System.EventHandler(this.CbbFilterChanged);
            // 
            // btnClearOperation
            // 
            this.btnClearOperation.BackgroundImage = global::MscrmTools.CrmTraceReader.Properties.Resources.Clear_16;
            this.btnClearOperation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClearOperation.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClearOperation.Location = new System.Drawing.Point(420, 0);
            this.btnClearOperation.Name = "btnClearOperation";
            this.btnClearOperation.Size = new System.Drawing.Size(21, 21);
            this.btnClearOperation.TabIndex = 0;
            this.btnClearOperation.UseVisualStyleBackColor = true;
            this.btnClearOperation.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 512);
            this.CloseButton = false;
            this.CloseButtonVisible = false;
            this.Controls.Add(this.pnlReqId);
            this.Controls.Add(this.lblReqId);
            this.Controls.Add(this.pnlLevel);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.pnlUser);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.pnlCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.pnlThread);
            this.Controls.Add(this.lblThread);
            this.Controls.Add(this.pnlOrganization);
            this.Controls.Add(this.lblOrganization);
            this.Controls.Add(this.pnlProcess);
            this.Controls.Add(this.lblProcess);
            this.Controls.Add(this.pnlOperation);
            this.Controls.Add(this.lblOperation);
            this.Controls.Add(this.toolStrip1);
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)((WeifenLuo.WinFormsUI.Docking.DockAreas.DockLeft | WeifenLuo.WinFormsUI.Docking.DockAreas.DockRight)));
            this.Name = "FilterForm";
            this.Text = "Filters";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnlReqId.ResumeLayout(false);
            this.pnlProcess.ResumeLayout(false);
            this.pnlOrganization.ResumeLayout(false);
            this.pnlThread.ResumeLayout(false);
            this.pnlCategory.ResumeLayout(false);
            this.pnlUser.ResumeLayout(false);
            this.pnlLevel.ResumeLayout(false);
            this.pnlOperation.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbClearFilters;
        private System.Windows.Forms.Label lblOperation;
        private System.Windows.Forms.Panel pnlReqId;
        private System.Windows.Forms.Button btnClearReqId;
        private System.Windows.Forms.ComboBox cbbRequId;
        private System.Windows.Forms.Panel pnlProcess;
        private System.Windows.Forms.ComboBox cbbProcess;
        private System.Windows.Forms.Button btnClearProcess;
        private System.Windows.Forms.Panel pnlOrganization;
        private System.Windows.Forms.ComboBox cbbOrganization;
        private System.Windows.Forms.Button btnClearOrganization;
        private System.Windows.Forms.Panel pnlThread;
        private System.Windows.Forms.ComboBox cbbThread;
        private System.Windows.Forms.Button btnClearThread;
        private System.Windows.Forms.Panel pnlCategory;
        private System.Windows.Forms.ComboBox cbbCategory;
        private System.Windows.Forms.Button btnClearCategory;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.ComboBox cbbUser;
        private System.Windows.Forms.Button btnClearUser;
        private System.Windows.Forms.Panel pnlLevel;
        private System.Windows.Forms.ComboBox cbbLevel;
        private System.Windows.Forms.Button btnClearLevel;
        private System.Windows.Forms.Label lblProcess;
        private System.Windows.Forms.Label lblOrganization;
        private System.Windows.Forms.Label lblThread;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblReqId;
        private System.Windows.Forms.Panel pnlOperation;
        private System.Windows.Forms.ComboBox cbbOperation;
        private System.Windows.Forms.Button btnClearOperation;
    }
}