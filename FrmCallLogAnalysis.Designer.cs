namespace CallLogAnalyser
{
    partial class FrmCallLogAnalysis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCallLogAnalysis));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCalleeMobileNumber = new System.Windows.Forms.ComboBox();
            this.cmbCallerMobileNumber = new System.Windows.Forms.ComboBox();
            this.chkCalleeMobileNumber = new System.Windows.Forms.CheckBox();
            this.chkCallerNumber = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnResetTime = new System.Windows.Forms.Button();
            this.dtpToTime = new System.Windows.Forms.DateTimePicker();
            this.chkToTime = new System.Windows.Forms.CheckBox();
            this.dtpFromTime = new System.Windows.Forms.DateTimePicker();
            this.chkFromTime = new System.Windows.Forms.CheckBox();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.chkToDate = new System.Windows.Forms.CheckBox();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.chkFromDate = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbTowerId = new System.Windows.Forms.ComboBox();
            this.chkStartTower = new System.Windows.Forms.CheckBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgInputCallLog = new System.Windows.Forms.DataGridView();
            this.SerialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CallerNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalleeNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CallDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CallTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstCellId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastCellId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CallType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CallerIMEI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalleeIMEI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cmbImeiNumber = new System.Windows.Forms.ComboBox();
            this.chkImeiNumber = new System.Windows.Forms.CheckBox();
            this.btnPaste = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dgFilteredCallLog = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInputCallLog)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFilteredCallLog)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbCalleeMobileNumber);
            this.groupBox1.Controls.Add(this.cmbCallerMobileNumber);
            this.groupBox1.Controls.Add(this.chkCalleeMobileNumber);
            this.groupBox1.Controls.Add(this.chkCallerNumber);
            this.groupBox1.Location = new System.Drawing.Point(4, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(526, 61);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mobile number:";
            // 
            // cmbCalleeMobileNumber
            // 
            this.cmbCalleeMobileNumber.FormattingEnabled = true;
            this.cmbCalleeMobileNumber.Location = new System.Drawing.Point(375, 24);
            this.cmbCalleeMobileNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCalleeMobileNumber.Name = "cmbCalleeMobileNumber";
            this.cmbCalleeMobileNumber.Size = new System.Drawing.Size(102, 21);
            this.cmbCalleeMobileNumber.Sorted = true;
            this.cmbCalleeMobileNumber.TabIndex = 5;
            // 
            // cmbCallerMobileNumber
            // 
            this.cmbCallerMobileNumber.FormattingEnabled = true;
            this.cmbCallerMobileNumber.Location = new System.Drawing.Point(133, 24);
            this.cmbCallerMobileNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCallerMobileNumber.Name = "cmbCallerMobileNumber";
            this.cmbCallerMobileNumber.Size = new System.Drawing.Size(102, 21);
            this.cmbCallerMobileNumber.Sorted = true;
            this.cmbCallerMobileNumber.TabIndex = 4;
            // 
            // chkCalleeMobileNumber
            // 
            this.chkCalleeMobileNumber.AutoSize = true;
            this.chkCalleeMobileNumber.Location = new System.Drawing.Point(262, 27);
            this.chkCalleeMobileNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkCalleeMobileNumber.Name = "chkCalleeMobileNumber";
            this.chkCalleeMobileNumber.Size = new System.Drawing.Size(112, 17);
            this.chkCalleeMobileNumber.TabIndex = 1;
            this.chkCalleeMobileNumber.Text = "Callee Mobile No.:";
            this.chkCalleeMobileNumber.UseVisualStyleBackColor = true;
            this.chkCalleeMobileNumber.CheckedChanged += new System.EventHandler(this.chkToMobileNo_CheckedChanged);
            // 
            // chkCallerNumber
            // 
            this.chkCallerNumber.AutoSize = true;
            this.chkCallerNumber.Location = new System.Drawing.Point(22, 27);
            this.chkCallerNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkCallerNumber.Name = "chkCallerNumber";
            this.chkCallerNumber.Size = new System.Drawing.Size(109, 17);
            this.chkCallerNumber.TabIndex = 0;
            this.chkCallerNumber.Text = "Caller Mobile No.:";
            this.chkCallerNumber.UseVisualStyleBackColor = true;
            this.chkCallerNumber.CheckedChanged += new System.EventHandler(this.chkFromMobileNo_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnResetTime);
            this.groupBox2.Controls.Add(this.dtpToTime);
            this.groupBox2.Controls.Add(this.chkToTime);
            this.groupBox2.Controls.Add(this.dtpFromTime);
            this.groupBox2.Controls.Add(this.chkFromTime);
            this.groupBox2.Controls.Add(this.dtpToDate);
            this.groupBox2.Controls.Add(this.chkToDate);
            this.groupBox2.Controls.Add(this.dtpFromDate);
            this.groupBox2.Controls.Add(this.chkFromDate);
            this.groupBox2.Location = new System.Drawing.Point(4, 86);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(526, 98);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Date and Time Range:";
            // 
            // btnResetTime
            // 
            this.btnResetTime.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnResetTime.BackgroundImage")));
            this.btnResetTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnResetTime.Location = new System.Drawing.Point(488, 54);
            this.btnResetTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnResetTime.Name = "btnResetTime";
            this.btnResetTime.Size = new System.Drawing.Size(30, 28);
            this.btnResetTime.TabIndex = 12;
            this.btnResetTime.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btnResetTime, "Reset Time");
            this.btnResetTime.UseVisualStyleBackColor = true;
            this.btnResetTime.Click += new System.EventHandler(this.btnResetTime_Click);
            // 
            // dtpToTime
            // 
            this.dtpToTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpToTime.Location = new System.Drawing.Point(375, 63);
            this.dtpToTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpToTime.Name = "dtpToTime";
            this.dtpToTime.ShowUpDown = true;
            this.dtpToTime.Size = new System.Drawing.Size(102, 20);
            this.dtpToTime.TabIndex = 11;
            // 
            // chkToTime
            // 
            this.chkToTime.AutoSize = true;
            this.chkToTime.Location = new System.Drawing.Point(262, 63);
            this.chkToTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkToTime.Name = "chkToTime";
            this.chkToTime.Size = new System.Drawing.Size(68, 17);
            this.chkToTime.TabIndex = 10;
            this.chkToTime.Text = "To Time:";
            this.chkToTime.UseVisualStyleBackColor = true;
            this.chkToTime.CheckedChanged += new System.EventHandler(this.chkToTime_CheckedChanged);
            // 
            // dtpFromTime
            // 
            this.dtpFromTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpFromTime.Location = new System.Drawing.Point(133, 63);
            this.dtpFromTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFromTime.Name = "dtpFromTime";
            this.dtpFromTime.ShowUpDown = true;
            this.dtpFromTime.Size = new System.Drawing.Size(102, 20);
            this.dtpFromTime.TabIndex = 9;
            this.dtpFromTime.ValueChanged += new System.EventHandler(this.dtpFromTime_ValueChanged);
            // 
            // chkFromTime
            // 
            this.chkFromTime.AutoSize = true;
            this.chkFromTime.Location = new System.Drawing.Point(22, 63);
            this.chkFromTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkFromTime.Name = "chkFromTime";
            this.chkFromTime.Size = new System.Drawing.Size(78, 17);
            this.chkFromTime.TabIndex = 8;
            this.chkFromTime.Text = "From Time:";
            this.chkFromTime.UseVisualStyleBackColor = true;
            this.chkFromTime.CheckedChanged += new System.EventHandler(this.chkFromTime_CheckedChanged);
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "dd/MM/yyyy";
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(375, 26);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(102, 20);
            this.dtpToDate.TabIndex = 7;
            // 
            // chkToDate
            // 
            this.chkToDate.AutoSize = true;
            this.chkToDate.Location = new System.Drawing.Point(262, 28);
            this.chkToDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkToDate.Name = "chkToDate";
            this.chkToDate.Size = new System.Drawing.Size(68, 17);
            this.chkToDate.TabIndex = 6;
            this.chkToDate.Text = "To Date:";
            this.chkToDate.UseVisualStyleBackColor = true;
            this.chkToDate.CheckedChanged += new System.EventHandler(this.chkToDate_CheckedChanged);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "dd/MM/yyyy";
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(133, 24);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(102, 20);
            this.dtpFromDate.TabIndex = 5;
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpFromDate_ValueChanged);
            // 
            // chkFromDate
            // 
            this.chkFromDate.AutoSize = true;
            this.chkFromDate.Location = new System.Drawing.Point(22, 29);
            this.chkFromDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkFromDate.Name = "chkFromDate";
            this.chkFromDate.Size = new System.Drawing.Size(78, 17);
            this.chkFromDate.TabIndex = 4;
            this.chkFromDate.Text = "From Date:";
            this.chkFromDate.UseVisualStyleBackColor = true;
            this.chkFromDate.CheckedChanged += new System.EventHandler(this.chkFromDate_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbTowerId);
            this.groupBox3.Controls.Add(this.chkStartTower);
            this.groupBox3.Location = new System.Drawing.Point(536, 20);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(304, 61);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Calls made on tower:";
            // 
            // cmbTowerId
            // 
            this.cmbTowerId.FormattingEnabled = true;
            this.cmbTowerId.Location = new System.Drawing.Point(128, 24);
            this.cmbTowerId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbTowerId.Name = "cmbTowerId";
            this.cmbTowerId.Size = new System.Drawing.Size(166, 21);
            this.cmbTowerId.Sorted = true;
            this.cmbTowerId.TabIndex = 1;
            // 
            // chkStartTower
            // 
            this.chkStartTower.AutoSize = true;
            this.chkStartTower.Location = new System.Drawing.Point(22, 27);
            this.chkStartTower.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkStartTower.Name = "chkStartTower";
            this.chkStartTower.Size = new System.Drawing.Size(71, 17);
            this.chkStartTower.TabIndex = 0;
            this.chkStartTower.Text = "Tower Id:";
            this.chkStartTower.UseVisualStyleBackColor = true;
            this.chkStartTower.CheckedChanged += new System.EventHandler(this.chkStartTower_CheckedChanged);
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(728, 158);
            this.btnExecute.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(100, 26);
            this.btnExecute.TabIndex = 3;
            this.btnExecute.Text = "&Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgInputCallLog);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(943, 232);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "1: Input: Original Call Log";
            // 
            // dgInputCallLog
            // 
            this.dgInputCallLog.AllowUserToAddRows = false;
            this.dgInputCallLog.AllowUserToDeleteRows = false;
            this.dgInputCallLog.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgInputCallLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgInputCallLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInputCallLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SerialNo,
            this.CallerNumber,
            this.CalleeNumber,
            this.CallDate,
            this.CallTime,
            this.Duration,
            this.FirstCellId,
            this.LastCellId,
            this.CallType,
            this.CallerIMEI,
            this.CalleeIMEI});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgInputCallLog.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgInputCallLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgInputCallLog.Location = new System.Drawing.Point(2, 15);
            this.dgInputCallLog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgInputCallLog.Name = "dgInputCallLog";
            this.dgInputCallLog.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgInputCallLog.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgInputCallLog.RowTemplate.Height = 24;
            this.dgInputCallLog.Size = new System.Drawing.Size(939, 215);
            this.dgInputCallLog.TabIndex = 0;
            // 
            // SerialNo
            // 
            this.SerialNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SerialNo.HeaderText = "Serial No.";
            this.SerialNo.Name = "SerialNo";
            this.SerialNo.ReadOnly = true;
            this.SerialNo.Width = 78;
            // 
            // CallerNumber
            // 
            this.CallerNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CallerNumber.HeaderText = "Caller Number";
            this.CallerNumber.Name = "CallerNumber";
            this.CallerNumber.ReadOnly = true;
            this.CallerNumber.Width = 98;
            // 
            // CalleeNumber
            // 
            this.CalleeNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CalleeNumber.HeaderText = "Callee Number";
            this.CalleeNumber.Name = "CalleeNumber";
            this.CalleeNumber.ReadOnly = true;
            this.CalleeNumber.Width = 101;
            // 
            // CallDate
            // 
            this.CallDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CallDate.HeaderText = "Call Date";
            this.CallDate.Name = "CallDate";
            this.CallDate.ReadOnly = true;
            this.CallDate.Width = 75;
            // 
            // CallTime
            // 
            this.CallTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CallTime.HeaderText = "CallTime";
            this.CallTime.Name = "CallTime";
            this.CallTime.ReadOnly = true;
            this.CallTime.Width = 72;
            // 
            // Duration
            // 
            this.Duration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Duration.HeaderText = "Duration";
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            this.Duration.Width = 72;
            // 
            // FirstCellId
            // 
            this.FirstCellId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.FirstCellId.HeaderText = "First Cell Id";
            this.FirstCellId.Name = "FirstCellId";
            this.FirstCellId.ReadOnly = true;
            this.FirstCellId.Width = 83;
            // 
            // LastCellId
            // 
            this.LastCellId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.LastCellId.HeaderText = "Last Cell Id";
            this.LastCellId.Name = "LastCellId";
            this.LastCellId.ReadOnly = true;
            this.LastCellId.Width = 84;
            // 
            // CallType
            // 
            this.CallType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CallType.HeaderText = "Call Type";
            this.CallType.Name = "CallType";
            this.CallType.ReadOnly = true;
            this.CallType.Width = 76;
            // 
            // CallerIMEI
            // 
            this.CallerIMEI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CallerIMEI.HeaderText = "Caller IMEI";
            this.CallerIMEI.Name = "CallerIMEI";
            this.CallerIMEI.ReadOnly = true;
            this.CallerIMEI.Width = 83;
            // 
            // CalleeIMEI
            // 
            this.CalleeIMEI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CalleeIMEI.HeaderText = "CalleeIMEI";
            this.CalleeIMEI.Name = "CalleeIMEI";
            this.CalleeIMEI.ReadOnly = true;
            this.CalleeIMEI.Width = 83;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox7);
            this.groupBox5.Controls.Add(this.groupBox1);
            this.groupBox5.Controls.Add(this.btnPaste);
            this.groupBox5.Controls.Add(this.groupBox2);
            this.groupBox5.Controls.Add(this.groupBox3);
            this.groupBox5.Controls.Add(this.btnExecute);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(0, 232);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Size = new System.Drawing.Size(943, 195);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "2: Filter on Criteria";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.cmbImeiNumber);
            this.groupBox7.Controls.Add(this.chkImeiNumber);
            this.groupBox7.Location = new System.Drawing.Point(536, 86);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox7.Size = new System.Drawing.Size(304, 61);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Calls made on cell:";
            // 
            // cmbImeiNumber
            // 
            this.cmbImeiNumber.FormattingEnabled = true;
            this.cmbImeiNumber.Location = new System.Drawing.Point(128, 24);
            this.cmbImeiNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbImeiNumber.Name = "cmbImeiNumber";
            this.cmbImeiNumber.Size = new System.Drawing.Size(166, 21);
            this.cmbImeiNumber.Sorted = true;
            this.cmbImeiNumber.TabIndex = 1;
            // 
            // chkImeiNumber
            // 
            this.chkImeiNumber.AutoSize = true;
            this.chkImeiNumber.Location = new System.Drawing.Point(22, 27);
            this.chkImeiNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkImeiNumber.Name = "chkImeiNumber";
            this.chkImeiNumber.Size = new System.Drawing.Size(68, 17);
            this.chkImeiNumber.TabIndex = 0;
            this.chkImeiNumber.Text = "IMEI No.";
            this.chkImeiNumber.UseVisualStyleBackColor = true;
            this.chkImeiNumber.CheckedChanged += new System.EventHandler(this.chkImeiNumber_CheckedChanged);
            // 
            // btnPaste
            // 
            this.btnPaste.Location = new System.Drawing.Point(536, 158);
            this.btnPaste.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(100, 26);
            this.btnPaste.TabIndex = 6;
            this.btnPaste.Text = "&Paste Call Log";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dgFilteredCallLog);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox6.Location = new System.Drawing.Point(0, 431);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox6.Size = new System.Drawing.Size(943, 171);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "3: Result - Filtered Call Log";
            // 
            // dgFilteredCallLog
            // 
            this.dgFilteredCallLog.AllowUserToAddRows = false;
            this.dgFilteredCallLog.AllowUserToDeleteRows = false;
            this.dgFilteredCallLog.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgFilteredCallLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgFilteredCallLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFilteredCallLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgFilteredCallLog.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgFilteredCallLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgFilteredCallLog.Location = new System.Drawing.Point(2, 15);
            this.dgFilteredCallLog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgFilteredCallLog.Name = "dgFilteredCallLog";
            this.dgFilteredCallLog.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgFilteredCallLog.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgFilteredCallLog.RowTemplate.Height = 24;
            this.dgFilteredCallLog.Size = new System.Drawing.Size(939, 154);
            this.dgFilteredCallLog.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "Serial No.";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 78;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn2.HeaderText = "Caller Number";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 98;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn3.HeaderText = "Callee Number";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 101;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn4.HeaderText = "Call Date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 75;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn5.HeaderText = "CallTime";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 72;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn6.HeaderText = "Duration";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 72;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn7.HeaderText = "First Cell Id";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 83;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn8.HeaderText = "Last Cell Id";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 84;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn9.HeaderText = "Call Type";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 76;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn10.HeaderText = "Caller IMEI";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 83;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn11.HeaderText = "CalleeIMEI";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 83;
            // 
            // FrmCallLogAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 602);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmCallLogAnalysis";
            this.Text = "Call log analyzer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCallLogAnalysis_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgInputCallLog)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgFilteredCallLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkCalleeMobileNumber;
        private System.Windows.Forms.CheckBox chkCallerNumber;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.CheckBox chkFromDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.CheckBox chkToDate;
        private System.Windows.Forms.DateTimePicker dtpToTime;
        private System.Windows.Forms.CheckBox chkToTime;
        private System.Windows.Forms.DateTimePicker dtpFromTime;
        private System.Windows.Forms.CheckBox chkFromTime;
        private System.Windows.Forms.Button btnResetTime;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkStartTower;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgInputCallLog;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dgFilteredCallLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CallerNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalleeNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CallDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CallTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstCellId;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastCellId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CallType;
        private System.Windows.Forms.DataGridViewTextBoxColumn CallerIMEI;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalleeIMEI;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox chkImeiNumber;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cmbTowerId;
        private System.Windows.Forms.ComboBox cmbImeiNumber;
        private System.Windows.Forms.ComboBox cmbCallerMobileNumber;
        private System.Windows.Forms.ComboBox cmbCalleeMobileNumber;
    }
}

