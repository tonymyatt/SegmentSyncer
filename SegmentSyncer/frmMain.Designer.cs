using SegmentSyncer.Properties;
using System;

namespace SegmentSyncer
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.dataStravaSegments = new System.Windows.Forms.DataGridView();
            this.UserIcon = new System.Windows.Forms.DataGridViewImageColumn();
            this.UserPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KomDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pTop = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSetUser = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tboxSegment = new System.Windows.Forms.TextBox();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.layoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.picMap = new System.Windows.Forms.PictureBox();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.pBottom = new System.Windows.Forms.Panel();
            this.txtStravaUser = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lblUserId = new System.Windows.Forms.Label();
            this.txtStravaId = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.pageSetupDialog2 = new System.Windows.Forms.PageSetupDialog();
            this.webWorker = new System.ComponentModel.BackgroundWorker();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.komTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stravaSegmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataStravaSegments)).BeginInit();
            this.pTop.SuspendLayout();
            this.menuMain.SuspendLayout();
            this.layoutPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMap)).BeginInit();
            this.tab2.SuspendLayout();
            this.pBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stravaSegmentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataStravaSegments
            // 
            this.dataStravaSegments.AllowUserToAddRows = false;
            this.dataStravaSegments.AllowUserToDeleteRows = false;
            this.dataStravaSegments.AutoGenerateColumns = false;
            this.dataStravaSegments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataStravaSegments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserIcon,
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.UserPosition,
            this.UserTime,
            this.UserDate,
            this.KomName,
            this.komTimeDataGridViewTextBoxColumn,
            this.KomDate});
            this.dataStravaSegments.DataMember = "Segments";
            this.dataStravaSegments.DataSource = this.stravaSegmentsBindingSource;
            this.dataStravaSegments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataStravaSegments.Location = new System.Drawing.Point(0, 0);
            this.dataStravaSegments.MultiSelect = false;
            this.dataStravaSegments.Name = "dataStravaSegments";
            this.dataStravaSegments.ReadOnly = true;
            this.dataStravaSegments.Size = new System.Drawing.Size(1138, 318);
            this.dataStravaSegments.TabIndex = 1;
            this.dataStravaSegments.Tag = "";
            this.dataStravaSegments.SelectionChanged += new System.EventHandler(this.dataStravaSegments_SelectionChanged);
            this.dataStravaSegments.BindingContextChanged += new System.EventHandler(this.dataStravaSegments_SelectionChanged);
            // 
            // UserIcon
            // 
            this.UserIcon.DataPropertyName = "UserIcon";
            this.UserIcon.HeaderText = "";
            this.UserIcon.MinimumWidth = 32;
            this.UserIcon.Name = "UserIcon";
            this.UserIcon.ReadOnly = true;
            this.UserIcon.Width = 32;
            // 
            // UserPosition
            // 
            this.UserPosition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.UserPosition.DataPropertyName = "UserPosition";
            this.UserPosition.HeaderText = "Position";
            this.UserPosition.Name = "UserPosition";
            this.UserPosition.ReadOnly = true;
            this.UserPosition.Width = 70;
            // 
            // UserTime
            // 
            this.UserTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.UserTime.DataPropertyName = "UserTime";
            this.UserTime.HeaderText = "Time";
            this.UserTime.Name = "UserTime";
            this.UserTime.ReadOnly = true;
            this.UserTime.Width = 80;
            // 
            // UserDate
            // 
            this.UserDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.UserDate.DataPropertyName = "UserDate";
            this.UserDate.HeaderText = "Date";
            this.UserDate.Name = "UserDate";
            this.UserDate.ReadOnly = true;
            this.UserDate.Width = 150;
            // 
            // KomName
            // 
            this.KomName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.KomName.DataPropertyName = "KomName";
            this.KomName.HeaderText = "KOM Name";
            this.KomName.Name = "KomName";
            this.KomName.ReadOnly = true;
            this.KomName.Width = 130;
            // 
            // KomDate
            // 
            this.KomDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.KomDate.DataPropertyName = "KomDate";
            this.KomDate.HeaderText = "KOM Date";
            this.KomDate.Name = "KomDate";
            this.KomDate.ReadOnly = true;
            this.KomDate.Width = 150;
            // 
            // pTop
            // 
            this.pTop.Controls.Add(this.btnCancel);
            this.pTop.Controls.Add(this.btnSetUser);
            this.pTop.Controls.Add(this.btnRemove);
            this.pTop.Controls.Add(this.btnSave);
            this.pTop.Controls.Add(this.btnUpdate);
            this.pTop.Controls.Add(this.btnAdd);
            this.pTop.Controls.Add(this.tboxSegment);
            this.pTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTop.Location = new System.Drawing.Point(3, 3);
            this.pTop.Name = "pTop";
            this.pTop.Size = new System.Drawing.Size(1558, 34);
            this.pTop.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(767, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 24);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel Update";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSetUser
            // 
            this.btnSetUser.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetUser.Location = new System.Drawing.Point(640, 5);
            this.btnSetUser.Name = "btnSetUser";
            this.btnSetUser.Size = new System.Drawing.Size(120, 24);
            this.btnSetUser.TabIndex = 5;
            this.btnSetUser.Text = "Set Strava User";
            this.btnSetUser.UseVisualStyleBackColor = true;
            this.btnSetUser.Click += new System.EventHandler(this.btnSetUser_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(265, 5);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(120, 24);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove Segment";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(515, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 24);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Generate FIT Files";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(390, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 24);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(160, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 24);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add Segment";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tboxSegment
            // 
            this.tboxSegment.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxSegment.Location = new System.Drawing.Point(5, 5);
            this.tboxSegment.Name = "tboxSegment";
            this.tboxSegment.Size = new System.Drawing.Size(150, 22);
            this.tboxSegment.TabIndex = 0;
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(1584, 24);
            this.menuMain.TabIndex = 6;
            this.menuMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // layoutPanel
            // 
            this.layoutPanel.ColumnCount = 1;
            this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutPanel.Controls.Add(this.tabControl1, 0, 0);
            this.layoutPanel.Controls.Add(this.pBottom, 0, 1);
            this.layoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPanel.Location = new System.Drawing.Point(0, 0);
            this.layoutPanel.Name = "layoutPanel";
            this.layoutPanel.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.layoutPanel.RowCount = 2;
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.layoutPanel.Size = new System.Drawing.Size(1584, 462);
            this.layoutPanel.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab1);
            this.tabControl1.Controls.Add(this.tab2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1578, 396);
            this.tabControl1.TabIndex = 7;
            // 
            // tab1
            // 
            this.tab1.BackColor = System.Drawing.Color.Transparent;
            this.tab1.Controls.Add(this.tableLayoutPanel1);
            this.tab1.Location = new System.Drawing.Point(4, 22);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(1570, 370);
            this.tab1.TabIndex = 1;
            this.tab1.Text = "Browser";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pTop, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1564, 364);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 43);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataStravaSegments);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.picMap);
            this.splitContainer1.Size = new System.Drawing.Size(1558, 318);
            this.splitContainer1.SplitterDistance = 1138;
            this.splitContainer1.TabIndex = 3;
            // 
            // picMap
            // 
            this.picMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picMap.Location = new System.Drawing.Point(0, 0);
            this.picMap.Name = "picMap";
            this.picMap.Size = new System.Drawing.Size(416, 318);
            this.picMap.TabIndex = 0;
            this.picMap.TabStop = false;
            // 
            // tab2
            // 
            this.tab2.BackColor = System.Drawing.Color.Transparent;
            this.tab2.Controls.Add(this.webBrowser);
            this.tab2.Location = new System.Drawing.Point(4, 22);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(3);
            this.tab2.Size = new System.Drawing.Size(1570, 370);
            this.tab2.TabIndex = 2;
            this.tab2.Text = "Map";
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(3, 3);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(1564, 364);
            this.webBrowser.TabIndex = 0;
            this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_DocumentCompleted);
            // 
            // pBottom
            // 
            this.pBottom.Controls.Add(this.txtStravaUser);
            this.pBottom.Controls.Add(this.lblUserName);
            this.pBottom.Controls.Add(this.lbStatus);
            this.pBottom.Controls.Add(this.lblUserId);
            this.pBottom.Controls.Add(this.txtStravaId);
            this.pBottom.Controls.Add(this.txtStatus);
            this.pBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pBottom.Location = new System.Drawing.Point(3, 430);
            this.pBottom.Name = "pBottom";
            this.pBottom.Size = new System.Drawing.Size(1578, 29);
            this.pBottom.TabIndex = 4;
            // 
            // txtStravaUser
            // 
            this.txtStravaUser.BackColor = System.Drawing.SystemColors.Control;
            this.txtStravaUser.Enabled = false;
            this.txtStravaUser.Location = new System.Drawing.Point(890, 5);
            this.txtStravaUser.Name = "txtStravaUser";
            this.txtStravaUser.ReadOnly = true;
            this.txtStravaUser.Size = new System.Drawing.Size(145, 20);
            this.txtStravaUser.TabIndex = 5;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(785, 8);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(97, 13);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "Strava User Name:";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(10, 8);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(40, 13);
            this.lbStatus.TabIndex = 3;
            this.lbStatus.Text = "Status:";
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(530, 8);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(78, 13);
            this.lblUserId.TabIndex = 2;
            this.lblUserId.Text = "Strava User Id:";
            // 
            // txtStravaId
            // 
            this.txtStravaId.BackColor = System.Drawing.SystemColors.Control;
            this.txtStravaId.Enabled = false;
            this.txtStravaId.Location = new System.Drawing.Point(615, 5);
            this.txtStravaId.Name = "txtStravaId";
            this.txtStravaId.ReadOnly = true;
            this.txtStravaId.Size = new System.Drawing.Size(145, 20);
            this.txtStravaId.TabIndex = 1;
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.SystemColors.Control;
            this.txtStatus.Enabled = false;
            this.txtStatus.Location = new System.Drawing.Point(60, 5);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(455, 20);
            this.txtStatus.TabIndex = 0;
            // 
            // webWorker
            // 
            this.webWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.webWorker_DoWork);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // komTimeDataGridViewTextBoxColumn
            // 
            this.komTimeDataGridViewTextBoxColumn.DataPropertyName = "KomTime";
            this.komTimeDataGridViewTextBoxColumn.HeaderText = "KOM Time";
            this.komTimeDataGridViewTextBoxColumn.Name = "komTimeDataGridViewTextBoxColumn";
            this.komTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stravaSegmentsBindingSource
            // 
            this.stravaSegmentsBindingSource.DataSource = typeof(SegmentSyncer.StravaSegments);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1584, 462);
            this.Controls.Add(this.menuMain);
            this.Controls.Add(this.layoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuMain;
            this.Name = "frmMain";
            this.Text = "Tony\'s Live Segments";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataStravaSegments)).EndInit();
            this.pTop.ResumeLayout(false);
            this.pTop.PerformLayout();
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.layoutPanel.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMap)).EndInit();
            this.tab2.ResumeLayout(false);
            this.pBottom.ResumeLayout(false);
            this.pBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stravaSegmentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataStravaSegments;
        private System.Windows.Forms.Panel pTop;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tboxSegment;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TableLayoutPanel layoutPanel;
        private System.Windows.Forms.BindingSource stravaSegmentsBindingSource;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox picMap;
        private System.Windows.Forms.Panel pBottom;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridViewImageColumn UserIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn KomName;
        private System.Windows.Forms.DataGridViewTextBoxColumn komTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn KomDate;
        private System.Windows.Forms.Button btnSetUser;
        private System.Windows.Forms.TextBox txtStravaUser;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.TextBox txtStravaId;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog2;
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.ComponentModel.BackgroundWorker webWorker;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
    }
}

