﻿namespace EDDiscovery
{
    partial class TravelHistoryControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TravelHistoryControl));
            this.dataGridViewTravel = new System.Windows.Forms.DataGridView();
            this.ColumnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSystem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDistance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mapColour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historyContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.starMapColourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveToAnotherCommanderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToTrilaterationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_system = new System.Windows.Forms.Panel();
            this.label_warning = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.buttonRoss = new System.Windows.Forms.Button();
            this.buttonEDDB = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_Z = new System.Windows.Forms.Label();
            this.labelDistEnter = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.toolTipEddb = new System.Windows.Forms.ToolTip(this.components);
            this.labelDistanceToNextSystem = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.dataGridViewNearest = new System.Windows.Forms.DataGridView();
            this.Col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBoxEDSMSyncFrom = new System.Windows.Forms.CheckBox();
            this.checkBoxEDSMSyncTo = new System.Windows.Forms.CheckBox();
            this.comboBoxCommander = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.mapColorDialog = new System.Windows.Forms.ColorDialog();
            this.textBoxFilter = new ExtendedControls.TextBoxBorder();
            this.button_RefreshHistory = new ExtendedControls.ButtonExt();
            this.comboBoxHistoryWindow = new ExtendedControls.ComboBoxCustom();
            this.richTextBox_History = new ExtendedControls.RichTextBoxBorder();
            this.textBoxDistanceToNextSystem = new ExtendedControls.TextBoxBorder();
            this.buttonMap = new ExtendedControls.ButtonExt();
            this.buttonSync = new ExtendedControls.ButtonExt();
            this.textBoxSolDist = new ExtendedControls.TextBoxBorder();
            this.buttonTrilaterate = new ExtendedControls.ButtonExt();
            this.textBoxState = new ExtendedControls.TextBoxBorder();
            this.textBoxEconomy = new ExtendedControls.TextBoxBorder();
            this.textBoxGovernment = new ExtendedControls.TextBoxBorder();
            this.textBoxAllegiance = new ExtendedControls.TextBoxBorder();
            this.textBoxVisits = new ExtendedControls.TextBoxBorder();
            this.richTextBoxNote = new ExtendedControls.RichTextBoxBorder();
            this.buttonUpdate = new ExtendedControls.ButtonExt();
            this.textBoxDistance = new ExtendedControls.TextBoxBorder();
            this.textBoxPrevSystem = new ExtendedControls.TextBoxBorder();
            this.textBoxZ = new ExtendedControls.TextBoxBorder();
            this.textBoxY = new ExtendedControls.TextBoxBorder();
            this.textBoxX = new ExtendedControls.TextBoxBorder();
            this.textBoxSystem = new ExtendedControls.TextBoxBorder();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTravel)).BeginInit();
            this.historyContextMenu.SuspendLayout();
            this.panel_system.SuspendLayout();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNearest)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewTravel
            // 
            this.dataGridViewTravel.AllowUserToAddRows = false;
            this.dataGridViewTravel.AllowUserToDeleteRows = false;
            this.dataGridViewTravel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTravel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTravel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTime,
            this.ColumnSystem,
            this.ColumnDistance,
            this.ColumnNote,
            this.mapColour});
            this.dataGridViewTravel.ContextMenuStrip = this.historyContextMenu;
            this.dataGridViewTravel.Location = new System.Drawing.Point(3, 34);
            this.dataGridViewTravel.Name = "dataGridViewTravel";
            this.dataGridViewTravel.Size = new System.Drawing.Size(589, 508);
            this.dataGridViewTravel.TabIndex = 3;
            this.dataGridViewTravel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridViewTravel.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridViewTravel.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_ColumnHeaderMouseClick);
            this.dataGridViewTravel.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // ColumnTime
            // 
            this.ColumnTime.HeaderText = "Time";
            this.ColumnTime.Name = "ColumnTime";
            this.ColumnTime.ReadOnly = true;
            this.ColumnTime.Width = 150;
            // 
            // ColumnSystem
            // 
            this.ColumnSystem.HeaderText = "System";
            this.ColumnSystem.Name = "ColumnSystem";
            this.ColumnSystem.ReadOnly = true;
            this.ColumnSystem.Width = 200;
            // 
            // ColumnDistance
            // 
            this.ColumnDistance.HeaderText = "Distance";
            this.ColumnDistance.Name = "ColumnDistance";
            this.ColumnDistance.ReadOnly = true;
            this.ColumnDistance.Width = 70;
            // 
            // ColumnNote
            // 
            this.ColumnNote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnNote.HeaderText = "Note";
            this.ColumnNote.Name = "ColumnNote";
            this.ColumnNote.ReadOnly = true;
            // 
            // mapColour
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.mapColour.DefaultCellStyle = dataGridViewCellStyle2;
            this.mapColour.HeaderText = "Map";
            this.mapColour.Name = "mapColour";
            this.mapColour.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.mapColour.ToolTipText = "Colour used for this sytem in the 3D star map if shown";
            this.mapColour.Width = 30;
            // 
            // historyContextMenu
            // 
            this.historyContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.starMapColourToolStripMenuItem,
            this.hideSystemToolStripMenuItem,
            this.moveToAnotherCommanderToolStripMenuItem,
            this.addToTrilaterationToolStripMenuItem});
            this.historyContextMenu.Name = "historyContextMenu";
            this.historyContextMenu.Size = new System.Drawing.Size(233, 92);
            // 
            // starMapColourToolStripMenuItem
            // 
            this.starMapColourToolStripMenuItem.Name = "starMapColourToolStripMenuItem";
            this.starMapColourToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.starMapColourToolStripMenuItem.Text = "Star Map Colour...";
            this.starMapColourToolStripMenuItem.Click += new System.EventHandler(this.starMapColourToolStripMenuItem_Click);
            // 
            // hideSystemToolStripMenuItem
            // 
            this.hideSystemToolStripMenuItem.Name = "hideSystemToolStripMenuItem";
            this.hideSystemToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.hideSystemToolStripMenuItem.Text = "Hide system";
            this.hideSystemToolStripMenuItem.Click += new System.EventHandler(this.hideSystemToolStripMenuItem_Click);
            // 
            // moveToAnotherCommanderToolStripMenuItem
            // 
            this.moveToAnotherCommanderToolStripMenuItem.Name = "moveToAnotherCommanderToolStripMenuItem";
            this.moveToAnotherCommanderToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.moveToAnotherCommanderToolStripMenuItem.Text = "Move to another Commander";
            this.moveToAnotherCommanderToolStripMenuItem.Click += new System.EventHandler(this.moveToAnotherCommanderToolStripMenuItem_Click);
            // 
            // addToTrilaterationToolStripMenuItem
            // 
            this.addToTrilaterationToolStripMenuItem.Name = "addToTrilaterationToolStripMenuItem";
            this.addToTrilaterationToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.addToTrilaterationToolStripMenuItem.Text = "Add to Trilateration";
            this.addToTrilaterationToolStripMenuItem.Click += new System.EventHandler(this.addToTrilaterationToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Show History ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Closest systems  (from last known position)";
            // 
            // panel_system
            // 
            this.panel_system.Controls.Add(this.label_warning);
            this.panel_system.Controls.Add(this.label14);
            this.panel_system.Controls.Add(this.textBoxSolDist);
            this.panel_system.Controls.Add(this.buttonTrilaterate);
            this.panel_system.Controls.Add(this.buttonRoss);
            this.panel_system.Controls.Add(this.buttonEDDB);
            this.panel_system.Controls.Add(this.textBoxState);
            this.panel_system.Controls.Add(this.textBoxEconomy);
            this.panel_system.Controls.Add(this.label12);
            this.panel_system.Controls.Add(this.label13);
            this.panel_system.Controls.Add(this.textBoxGovernment);
            this.panel_system.Controls.Add(this.textBoxAllegiance);
            this.panel_system.Controls.Add(this.label11);
            this.panel_system.Controls.Add(this.label10);
            this.panel_system.Controls.Add(this.label9);
            this.panel_system.Controls.Add(this.textBoxVisits);
            this.panel_system.Controls.Add(this.label8);
            this.panel_system.Controls.Add(this.richTextBoxNote);
            this.panel_system.Controls.Add(this.buttonUpdate);
            this.panel_system.Controls.Add(this.textBoxDistance);
            this.panel_system.Controls.Add(this.label7);
            this.panel_system.Controls.Add(this.textBoxPrevSystem);
            this.panel_system.Controls.Add(this.label_Z);
            this.panel_system.Controls.Add(this.textBoxZ);
            this.panel_system.Controls.Add(this.labelDistEnter);
            this.panel_system.Controls.Add(this.label5);
            this.panel_system.Controls.Add(this.textBoxY);
            this.panel_system.Controls.Add(this.textBoxX);
            this.panel_system.Controls.Add(this.label4);
            this.panel_system.Controls.Add(this.textBoxSystem);
            this.panel_system.Location = new System.Drawing.Point(7, 110);
            this.panel_system.Name = "panel_system";
            this.panel_system.Size = new System.Drawing.Size(293, 250);
            this.panel_system.TabIndex = 6;
            // 
            // label_warning
            // 
            this.label_warning.AutoSize = true;
            this.label_warning.Location = new System.Drawing.Point(3, 221);
            this.label_warning.MaximumSize = new System.Drawing.Size(280, 50);
            this.label_warning.Name = "label_warning";
            this.label_warning.Size = new System.Drawing.Size(245, 26);
            this.label_warning.TabIndex = 44;
            this.label_warning.Text = "Important!!  Use galaxy map to get distance with 2 decimals. Ex 17.44";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 84);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(22, 13);
            this.label14.TabIndex = 43;
            this.label14.Text = "Sol";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // buttonRoss
            // 
            this.buttonRoss.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRoss.BackgroundImage")));
            this.buttonRoss.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRoss.FlatAppearance.BorderSize = 0;
            this.buttonRoss.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRoss.Location = new System.Drawing.Point(274, 6);
            this.buttonRoss.Name = "buttonRoss";
            this.buttonRoss.Size = new System.Drawing.Size(16, 20);
            this.buttonRoss.TabIndex = 40;
            this.buttonRoss.TabStop = false;
            this.toolTipEddb.SetToolTip(this.buttonRoss, "Click to edit system in Ross");
            this.buttonRoss.UseVisualStyleBackColor = true;
            this.buttonRoss.Click += new System.EventHandler(this.buttonRoss_Click);
            // 
            // buttonEDDB
            // 
            this.buttonEDDB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEDDB.BackgroundImage")));
            this.buttonEDDB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonEDDB.FlatAppearance.BorderSize = 0;
            this.buttonEDDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEDDB.Location = new System.Drawing.Point(259, 6);
            this.buttonEDDB.Name = "buttonEDDB";
            this.buttonEDDB.Size = new System.Drawing.Size(16, 20);
            this.buttonEDDB.TabIndex = 39;
            this.buttonEDDB.TabStop = false;
            this.toolTipEddb.SetToolTip(this.buttonEDDB, "Click to show system in EDDB");
            this.buttonEDDB.UseVisualStyleBackColor = true;
            this.buttonEDDB.Click += new System.EventHandler(this.buttonEDDB_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(144, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 38;
            this.label12.Text = "State";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(149, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 13);
            this.label13.TabIndex = 36;
            this.label13.Text = "Gov";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(125, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Economy";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(120, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Allegiance";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(145, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Visits";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Note";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Distance from";
            // 
            // label_Z
            // 
            this.label_Z.AutoSize = true;
            this.label_Z.Location = new System.Drawing.Point(30, 64);
            this.label_Z.Name = "label_Z";
            this.label_Z.Size = new System.Drawing.Size(14, 13);
            this.label_Z.TabIndex = 20;
            this.label_Z.Text = "Z";
            this.label_Z.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelDistEnter
            // 
            this.labelDistEnter.AutoSize = true;
            this.labelDistEnter.ForeColor = System.Drawing.Color.Black;
            this.labelDistEnter.Location = new System.Drawing.Point(30, 46);
            this.labelDistEnter.Name = "labelDistEnter";
            this.labelDistEnter.Size = new System.Drawing.Size(14, 13);
            this.labelDistEnter.TabIndex = 18;
            this.labelDistEnter.Text = "Y";
            this.labelDistEnter.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "X";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "System";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Commander";
            // 
            // labelDistanceToNextSystem
            // 
            this.labelDistanceToNextSystem.AutoSize = true;
            this.labelDistanceToNextSystem.Location = new System.Drawing.Point(4, 68);
            this.labelDistanceToNextSystem.Name = "labelDistanceToNextSystem";
            this.labelDistanceToNextSystem.Size = new System.Drawing.Size(122, 13);
            this.labelDistanceToNextSystem.TabIndex = 20;
            this.labelDistanceToNextSystem.Text = "Distance to next system:";
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.dataGridViewNearest);
            this.panelRight.Controls.Add(this.checkBoxEDSMSyncFrom);
            this.panelRight.Controls.Add(this.checkBoxEDSMSyncTo);
            this.panelRight.Controls.Add(this.comboBoxCommander);
            this.panelRight.Controls.Add(this.label6);
            this.panelRight.Controls.Add(this.textBoxDistanceToNextSystem);
            this.panelRight.Controls.Add(this.label3);
            this.panelRight.Controls.Add(this.labelDistanceToNextSystem);
            this.panelRight.Controls.Add(this.buttonMap);
            this.panelRight.Controls.Add(this.buttonSync);
            this.panelRight.Controls.Add(this.panel_system);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(594, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(297, 650);
            this.panelRight.TabIndex = 1;
            // 
            // dataGridViewNearest
            // 
            this.dataGridViewNearest.AllowUserToAddRows = false;
            this.dataGridViewNearest.AllowUserToDeleteRows = false;
            this.dataGridViewNearest.AllowUserToResizeColumns = false;
            this.dataGridViewNearest.AllowUserToResizeRows = false;
            this.dataGridViewNearest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewNearest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNearest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col1,
            this.Distance});
            this.dataGridViewNearest.Location = new System.Drawing.Point(7, 380);
            this.dataGridViewNearest.Name = "dataGridViewNearest";
            this.dataGridViewNearest.RowHeadersVisible = false;
            this.dataGridViewNearest.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewNearest.Size = new System.Drawing.Size(290, 255);
            this.dataGridViewNearest.TabIndex = 23;
            this.dataGridViewNearest.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Col1
            // 
            this.Col1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Col1.HeaderText = "Name";
            this.Col1.Name = "Col1";
            // 
            // Distance
            // 
            this.Distance.HeaderText = "Distance";
            this.Distance.Name = "Distance";
            // 
            // checkBoxEDSMSyncFrom
            // 
            this.checkBoxEDSMSyncFrom.AutoSize = true;
            this.checkBoxEDSMSyncFrom.Location = new System.Drawing.Point(217, 57);
            this.checkBoxEDSMSyncFrom.Name = "checkBoxEDSMSyncFrom";
            this.checkBoxEDSMSyncFrom.Size = new System.Drawing.Size(83, 17);
            this.checkBoxEDSMSyncFrom.TabIndex = 22;
            this.checkBoxEDSMSyncFrom.Text = "From EDSM";
            this.checkBoxEDSMSyncFrom.UseVisualStyleBackColor = true;
            this.checkBoxEDSMSyncFrom.CheckedChanged += new System.EventHandler(this.checkBoxEDSMSyncFrom_CheckedChanged);
            // 
            // checkBoxEDSMSyncTo
            // 
            this.checkBoxEDSMSyncTo.AutoSize = true;
            this.checkBoxEDSMSyncTo.Location = new System.Drawing.Point(217, 36);
            this.checkBoxEDSMSyncTo.Name = "checkBoxEDSMSyncTo";
            this.checkBoxEDSMSyncTo.Size = new System.Drawing.Size(73, 17);
            this.checkBoxEDSMSyncTo.TabIndex = 21;
            this.checkBoxEDSMSyncTo.Text = "To EDSM";
            this.checkBoxEDSMSyncTo.UseVisualStyleBackColor = true;
            this.checkBoxEDSMSyncTo.CheckedChanged += new System.EventHandler(this.checkBoxEDSMSyncTo_CheckedChanged);
            // 
            // comboBoxCommander
            // 
            this.comboBoxCommander.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCommander.FormattingEnabled = true;
            this.comboBoxCommander.Location = new System.Drawing.Point(114, 9);
            this.comboBoxCommander.Name = "comboBoxCommander";
            this.comboBoxCommander.Size = new System.Drawing.Size(162, 21);
            this.comboBoxCommander.TabIndex = 0;
            this.comboBoxCommander.SelectedIndexChanged += new System.EventHandler(this.comboBoxCommander_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Search";
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.richTextBox_History);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 548);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(594, 102);
            this.panelBottom.TabIndex = 2;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.textBoxFilter);
            this.panelMain.Controls.Add(this.dataGridViewTravel);
            this.panelMain.Controls.Add(this.button_RefreshHistory);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.comboBoxHistoryWindow);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(594, 548);
            this.panelMain.TabIndex = 0;
            // 
            // mapColorDialog
            // 
            this.mapColorDialog.SolidColorOnly = true;
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.BorderColor = System.Drawing.Color.Transparent;
            this.textBoxFilter.BorderPadding = 1;
            this.textBoxFilter.BorderSize = 1;
            this.textBoxFilter.Location = new System.Drawing.Point(312, 7);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(148, 20);
            this.textBoxFilter.TabIndex = 1;
            this.textBoxFilter.TextChanged += new System.EventHandler(this.textBoxFilter_TextChanged);
            this.textBoxFilter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxFilter_KeyUp);
            // 
            // button_RefreshHistory
            // 
            this.button_RefreshHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_RefreshHistory.BorderColorScaling = 1.25F;
            this.button_RefreshHistory.ButtonColorScaling = 0.5F;
            this.button_RefreshHistory.Location = new System.Drawing.Point(517, 5);
            this.button_RefreshHistory.Name = "button_RefreshHistory";
            this.button_RefreshHistory.Size = new System.Drawing.Size(69, 23);
            this.button_RefreshHistory.TabIndex = 2;
            this.button_RefreshHistory.Text = "Refresh";
            this.button_RefreshHistory.UseVisualStyleBackColor = true;
            this.button_RefreshHistory.Click += new System.EventHandler(this.button_RefreshHistory_Click);
            // 
            // comboBoxHistoryWindow
            // 
            this.comboBoxHistoryWindow.ArrowWidth = 1;
            this.comboBoxHistoryWindow.BorderColor = System.Drawing.Color.Red;
            this.comboBoxHistoryWindow.ButtonColorScaling = 0.5F;
            this.comboBoxHistoryWindow.DropDownBackgroundColor = System.Drawing.Color.Gray;
            this.comboBoxHistoryWindow.DropDownHeight = 200;
            this.comboBoxHistoryWindow.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxHistoryWindow.ItemHeight = 20;
            this.comboBoxHistoryWindow.Items = ((System.Collections.Generic.List<string>)(resources.GetObject("comboBoxHistoryWindow.Items")));
            this.comboBoxHistoryWindow.Location = new System.Drawing.Point(101, 6);
            this.comboBoxHistoryWindow.MouseOverBackgroundColor = System.Drawing.Color.Silver;
            this.comboBoxHistoryWindow.Name = "comboBoxHistoryWindow";
            this.comboBoxHistoryWindow.ScrollBarWidth = 16;
            this.comboBoxHistoryWindow.SelectedIndex = -1;
            this.comboBoxHistoryWindow.SelectedItem = null;
            this.comboBoxHistoryWindow.Size = new System.Drawing.Size(94, 20);
            this.comboBoxHistoryWindow.TabIndex = 0;
            this.comboBoxHistoryWindow.SelectedIndexChanged += new ExtendedControls.ComboBoxCustom.OnSelectedIndexChanged(this.comboBoxHistoryWindow_SelectedIndexChanged);
            // 
            // richTextBox_History
            // 
            this.richTextBox_History.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_History.BorderColor = System.Drawing.Color.Transparent;
            this.richTextBox_History.BorderPadding = 1;
            this.richTextBox_History.BorderSize = 1;
            this.richTextBox_History.Location = new System.Drawing.Point(3, 3);
            this.richTextBox_History.Name = "richTextBox_History";
            this.richTextBox_History.Size = new System.Drawing.Size(588, 91);
            this.richTextBox_History.TabIndex = 0;
            this.richTextBox_History.TabStop = false;
            this.richTextBox_History.Text = "";
            // 
            // textBoxDistanceToNextSystem
            // 
            this.textBoxDistanceToNextSystem.BorderColor = System.Drawing.Color.Transparent;
            this.textBoxDistanceToNextSystem.BorderPadding = 1;
            this.textBoxDistanceToNextSystem.BorderSize = 1;
            this.textBoxDistanceToNextSystem.Location = new System.Drawing.Point(76, 86);
            this.textBoxDistanceToNextSystem.Name = "textBoxDistanceToNextSystem";
            this.textBoxDistanceToNextSystem.Size = new System.Drawing.Size(48, 20);
            this.textBoxDistanceToNextSystem.TabIndex = 5;
            this.textBoxDistanceToNextSystem.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxDistanceToNextSystem_Validating);
            // 
            // buttonMap
            // 
            this.buttonMap.BorderColorScaling = 1.25F;
            this.buttonMap.ButtonColorScaling = 0.5F;
            this.buttonMap.Location = new System.Drawing.Point(199, 80);
            this.buttonMap.Name = "buttonMap";
            this.buttonMap.Size = new System.Drawing.Size(83, 23);
            this.buttonMap.TabIndex = 4;
            this.buttonMap.Text = "3D star map";
            this.buttonMap.UseVisualStyleBackColor = true;
            this.buttonMap.Click += new System.EventHandler(this.buttonMap_Click);
            // 
            // buttonSync
            // 
            this.buttonSync.BorderColorScaling = 1.25F;
            this.buttonSync.ButtonColorScaling = 0.5F;
            this.buttonSync.Location = new System.Drawing.Point(114, 38);
            this.buttonSync.Name = "buttonSync";
            this.buttonSync.Size = new System.Drawing.Size(100, 23);
            this.buttonSync.TabIndex = 1;
            this.buttonSync.Text = "Sync with EDSM";
            this.buttonSync.UseVisualStyleBackColor = true;
            this.buttonSync.Click += new System.EventHandler(this.buttonSync_Click);
            // 
            // textBoxSolDist
            // 
            this.textBoxSolDist.BorderColor = System.Drawing.Color.Transparent;
            this.textBoxSolDist.BorderPadding = 1;
            this.textBoxSolDist.BorderSize = 1;
            this.textBoxSolDist.Location = new System.Drawing.Point(50, 82);
            this.textBoxSolDist.Name = "textBoxSolDist";
            this.textBoxSolDist.ReadOnly = true;
            this.textBoxSolDist.Size = new System.Drawing.Size(67, 20);
            this.textBoxSolDist.TabIndex = 42;
            this.textBoxSolDist.TabStop = false;
            // 
            // buttonTrilaterate
            // 
            this.buttonTrilaterate.BorderColorScaling = 1.25F;
            this.buttonTrilaterate.ButtonColorScaling = 0.5F;
            this.buttonTrilaterate.Location = new System.Drawing.Point(168, 196);
            this.buttonTrilaterate.Name = "buttonTrilaterate";
            this.buttonTrilaterate.Size = new System.Drawing.Size(99, 22);
            this.buttonTrilaterate.TabIndex = 3;
            this.buttonTrilaterate.Text = "Trilaterate";
            this.buttonTrilaterate.UseVisualStyleBackColor = true;
            this.buttonTrilaterate.Click += new System.EventHandler(this.buttonTrilaterate_Click);
            // 
            // textBoxState
            // 
            this.textBoxState.BorderColor = System.Drawing.Color.Transparent;
            this.textBoxState.BorderPadding = 1;
            this.textBoxState.BorderSize = 1;
            this.textBoxState.Location = new System.Drawing.Point(182, 82);
            this.textBoxState.Name = "textBoxState";
            this.textBoxState.ReadOnly = true;
            this.textBoxState.Size = new System.Drawing.Size(71, 20);
            this.textBoxState.TabIndex = 37;
            this.textBoxState.TabStop = false;
            // 
            // textBoxEconomy
            // 
            this.textBoxEconomy.BorderColor = System.Drawing.Color.Transparent;
            this.textBoxEconomy.BorderPadding = 1;
            this.textBoxEconomy.BorderSize = 1;
            this.textBoxEconomy.Location = new System.Drawing.Point(182, 64);
            this.textBoxEconomy.Name = "textBoxEconomy";
            this.textBoxEconomy.ReadOnly = true;
            this.textBoxEconomy.Size = new System.Drawing.Size(71, 20);
            this.textBoxEconomy.TabIndex = 33;
            this.textBoxEconomy.TabStop = false;
            // 
            // textBoxGovernment
            // 
            this.textBoxGovernment.BorderColor = System.Drawing.Color.Transparent;
            this.textBoxGovernment.BorderPadding = 1;
            this.textBoxGovernment.BorderSize = 1;
            this.textBoxGovernment.Location = new System.Drawing.Point(182, 100);
            this.textBoxGovernment.Name = "textBoxGovernment";
            this.textBoxGovernment.ReadOnly = true;
            this.textBoxGovernment.Size = new System.Drawing.Size(71, 20);
            this.textBoxGovernment.TabIndex = 35;
            this.textBoxGovernment.TabStop = false;
            // 
            // textBoxAllegiance
            // 
            this.textBoxAllegiance.BorderColor = System.Drawing.Color.Transparent;
            this.textBoxAllegiance.BorderPadding = 1;
            this.textBoxAllegiance.BorderSize = 1;
            this.textBoxAllegiance.Location = new System.Drawing.Point(182, 46);
            this.textBoxAllegiance.Name = "textBoxAllegiance";
            this.textBoxAllegiance.ReadOnly = true;
            this.textBoxAllegiance.Size = new System.Drawing.Size(71, 20);
            this.textBoxAllegiance.TabIndex = 31;
            this.textBoxAllegiance.TabStop = false;
            // 
            // textBoxVisits
            // 
            this.textBoxVisits.BorderColor = System.Drawing.Color.Transparent;
            this.textBoxVisits.BorderPadding = 1;
            this.textBoxVisits.BorderSize = 1;
            this.textBoxVisits.Location = new System.Drawing.Point(182, 28);
            this.textBoxVisits.Name = "textBoxVisits";
            this.textBoxVisits.ReadOnly = true;
            this.textBoxVisits.Size = new System.Drawing.Size(71, 20);
            this.textBoxVisits.TabIndex = 29;
            this.textBoxVisits.TabStop = false;
            // 
            // richTextBoxNote
            // 
            this.richTextBoxNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxNote.BorderColor = System.Drawing.Color.Transparent;
            this.richTextBoxNote.BorderPadding = 1;
            this.richTextBoxNote.BorderSize = 1;
            this.richTextBoxNote.Location = new System.Drawing.Point(29, 123);
            this.richTextBoxNote.Name = "richTextBoxNote";
            this.richTextBoxNote.Size = new System.Drawing.Size(238, 47);
            this.richTextBoxNote.TabIndex = 0;
            this.richTextBoxNote.Text = "";
            this.richTextBoxNote.TextChanged += new System.EventHandler(this.richTextBoxNote_TextChanged);
            this.richTextBoxNote.Leave += new System.EventHandler(this.richTextBoxNote_Leave);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BorderColorScaling = 1.25F;
            this.buttonUpdate.ButtonColorScaling = 0.5F;
            this.buttonUpdate.Location = new System.Drawing.Point(6, 196);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(69, 22);
            this.buttonUpdate.TabIndex = 2;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxDistance
            // 
            this.textBoxDistance.BorderColor = System.Drawing.Color.Transparent;
            this.textBoxDistance.BorderPadding = 1;
            this.textBoxDistance.BorderSize = 1;
            this.textBoxDistance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxDistance.Location = new System.Drawing.Point(81, 197);
            this.textBoxDistance.Name = "textBoxDistance";
            this.textBoxDistance.Size = new System.Drawing.Size(70, 20);
            this.textBoxDistance.TabIndex = 1;
            // 
            // textBoxPrevSystem
            // 
            this.textBoxPrevSystem.BorderColor = System.Drawing.Color.Transparent;
            this.textBoxPrevSystem.BorderPadding = 1;
            this.textBoxPrevSystem.BorderSize = 1;
            this.textBoxPrevSystem.Location = new System.Drawing.Point(90, 174);
            this.textBoxPrevSystem.Name = "textBoxPrevSystem";
            this.textBoxPrevSystem.ReadOnly = true;
            this.textBoxPrevSystem.Size = new System.Drawing.Size(186, 20);
            this.textBoxPrevSystem.TabIndex = 1;
            this.textBoxPrevSystem.TabStop = false;
            this.textBoxPrevSystem.Enter += new System.EventHandler(this.textBoxPrevSystem_Enter);
            // 
            // textBoxZ
            // 
            this.textBoxZ.BorderColor = System.Drawing.Color.Transparent;
            this.textBoxZ.BorderPadding = 1;
            this.textBoxZ.BorderSize = 1;
            this.textBoxZ.Location = new System.Drawing.Point(50, 64);
            this.textBoxZ.Name = "textBoxZ";
            this.textBoxZ.ReadOnly = true;
            this.textBoxZ.Size = new System.Drawing.Size(67, 20);
            this.textBoxZ.TabIndex = 19;
            this.textBoxZ.TabStop = false;
            // 
            // textBoxY
            // 
            this.textBoxY.BorderColor = System.Drawing.Color.Transparent;
            this.textBoxY.BorderPadding = 1;
            this.textBoxY.BorderSize = 1;
            this.textBoxY.Location = new System.Drawing.Point(50, 46);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.ReadOnly = true;
            this.textBoxY.Size = new System.Drawing.Size(67, 20);
            this.textBoxY.TabIndex = 17;
            this.textBoxY.TabStop = false;
            // 
            // textBoxX
            // 
            this.textBoxX.BorderColor = System.Drawing.Color.Transparent;
            this.textBoxX.BorderPadding = 1;
            this.textBoxX.BorderSize = 1;
            this.textBoxX.Location = new System.Drawing.Point(50, 28);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.ReadOnly = true;
            this.textBoxX.Size = new System.Drawing.Size(67, 20);
            this.textBoxX.TabIndex = 17;
            this.textBoxX.TabStop = false;
            // 
            // textBoxSystem
            // 
            this.textBoxSystem.BorderColor = System.Drawing.Color.Transparent;
            this.textBoxSystem.BorderPadding = 1;
            this.textBoxSystem.BorderSize = 1;
            this.textBoxSystem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSystem.Location = new System.Drawing.Point(50, 9);
            this.textBoxSystem.Name = "textBoxSystem";
            this.textBoxSystem.ReadOnly = true;
            this.textBoxSystem.Size = new System.Drawing.Size(203, 13);
            this.textBoxSystem.TabIndex = 15;
            this.textBoxSystem.TabStop = false;
            // 
            // TravelHistoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelRight);
            this.Name = "TravelHistoryControl";
            this.Size = new System.Drawing.Size(891, 650);
            this.Load += new System.EventHandler(this.TravelHistoryControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTravel)).EndInit();
            this.historyContextMenu.ResumeLayout(false);
            this.panel_system.ResumeLayout(false);
            this.panel_system.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNearest)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ExtendedControls.ButtonExt button_RefreshHistory;
        private ExtendedControls.ComboBoxCustom comboBoxHistoryWindow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ExtendedControls.ButtonExt buttonMap;
        internal ExtendedControls.RichTextBoxBorder richTextBox_History;
        private ExtendedControls.TextBoxBorder textBoxSystem;
        private System.Windows.Forms.Panel panel_system;
        private ExtendedControls.TextBoxBorder textBoxDistance;
        private System.Windows.Forms.Label label7;
        private ExtendedControls.TextBoxBorder textBoxPrevSystem;
        private System.Windows.Forms.Label label_Z;
        private ExtendedControls.TextBoxBorder textBoxZ;
        private System.Windows.Forms.Label labelDistEnter;
        private System.Windows.Forms.Label label5;
        private ExtendedControls.TextBoxBorder textBoxY;
        private ExtendedControls.TextBoxBorder textBoxX;
        private System.Windows.Forms.Label label4;
        private ExtendedControls.ButtonExt buttonUpdate;
        private System.Windows.Forms.Label label6;
        private ExtendedControls.RichTextBoxBorder richTextBoxNote;
        private ExtendedControls.ButtonExt buttonSync;
        private System.Windows.Forms.Label label9;
        private ExtendedControls.TextBoxBorder textBoxVisits;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private ExtendedControls.TextBoxBorder textBoxEconomy;
        private System.Windows.Forms.Label label10;
        private ExtendedControls.TextBoxBorder textBoxAllegiance;
        private System.Windows.Forms.Label label12;
        private ExtendedControls.TextBoxBorder textBoxState;
        private System.Windows.Forms.Label label13;
        private ExtendedControls.TextBoxBorder textBoxGovernment;
        private System.Windows.Forms.Button buttonEDDB;
        private System.Windows.Forms.ToolTip toolTipEddb;
        private System.Windows.Forms.Button buttonRoss;
        private ExtendedControls.ButtonExt buttonTrilaterate;
        private System.Windows.Forms.Label labelDistanceToNextSystem;
        private System.Windows.Forms.Panel panelRight;
        private ExtendedControls.TextBoxBorder textBoxFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelMain;
        public System.Windows.Forms.DataGridView dataGridViewTravel;
        private System.Windows.Forms.Label label14;
        private ExtendedControls.TextBoxBorder textBoxSolDist;
        private System.Windows.Forms.ContextMenuStrip historyContextMenu;
        private System.Windows.Forms.ToolStripMenuItem starMapColourToolStripMenuItem;
        private System.Windows.Forms.ColorDialog mapColorDialog;
        internal ExtendedControls.TextBoxBorder textBoxDistanceToNextSystem;
        private System.Windows.Forms.ToolStripMenuItem hideSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveToAnotherCommanderToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBoxCommander;
        private System.Windows.Forms.ToolStripMenuItem addToTrilaterationToolStripMenuItem;
        internal System.Windows.Forms.CheckBox checkBoxEDSMSyncFrom;
        internal System.Windows.Forms.CheckBox checkBoxEDSMSyncTo;
        private System.Windows.Forms.DataGridView dataGridViewNearest;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distance;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSystem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDistance;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn mapColour;
        private System.Windows.Forms.Label label_warning;
    }
}
