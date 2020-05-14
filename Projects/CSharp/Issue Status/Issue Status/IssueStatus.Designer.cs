namespace Issue_Status
{
    partial class IssueStatus
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
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.grpReport = new System.Windows.Forms.GroupBox();
            this.grpAge = new System.Windows.Forms.GroupBox();
            this.lbl90abCount = new System.Windows.Forms.Label();
            this.lbl90ab = new System.Windows.Forms.Label();
            this.lbl90Count = new System.Windows.Forms.Label();
            this.lbl60Count = new System.Windows.Forms.Label();
            this.lbl30Count = new System.Windows.Forms.Label();
            this.lbl90 = new System.Windows.Forms.Label();
            this.lbl60 = new System.Windows.Forms.Label();
            this.lbl30 = new System.Windows.Forms.Label();
            this.grpSeverity = new System.Windows.Forms.GroupBox();
            this.lblSev4Count = new System.Windows.Forms.Label();
            this.lblSev3Count = new System.Windows.Forms.Label();
            this.lblSev2Count = new System.Windows.Forms.Label();
            this.lblSev1Count = new System.Windows.Forms.Label();
            this.lblSev4 = new System.Windows.Forms.Label();
            this.lblSev3 = new System.Windows.Forms.Label();
            this.lblSev2 = new System.Windows.Forms.Label();
            this.lblSev1 = new System.Windows.Forms.Label();
            this.grpStatusCount = new System.Windows.Forms.GroupBox();
            this.lblWorkingCount = new System.Windows.Forms.Label();
            this.lblClosedCount = new System.Windows.Forms.Label();
            this.lblOpenCount = new System.Windows.Forms.Label();
            this.lblWorking = new System.Windows.Forms.Label();
            this.lblClosed = new System.Windows.Forms.Label();
            this.lblOpen = new System.Windows.Forms.Label();
            this.grpReport.SuspendLayout();
            this.grpAge.SuspendLayout();
            this.grpSeverity.SuspendLayout();
            this.grpStatusCount.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(57, 27);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(30, 13);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "From";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(93, 23);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(79, 20);
            this.dtpFrom.TabIndex = 1;
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(313, 23);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(79, 20);
            this.dtpTo.TabIndex = 3;
            this.dtpTo.ValueChanged += new System.EventHandler(this.dtpTo_ValueChanged);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(277, 27);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(20, 13);
            this.lblTo.TabIndex = 2;
            this.lblTo.Text = "To";
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(177, 59);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(99, 23);
            this.btnGenerateReport.TabIndex = 4;
            this.btnGenerateReport.Text = "Generate report";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // grpReport
            // 
            this.grpReport.Controls.Add(this.grpAge);
            this.grpReport.Controls.Add(this.grpSeverity);
            this.grpReport.Controls.Add(this.grpStatusCount);
            this.grpReport.Location = new System.Drawing.Point(12, 98);
            this.grpReport.Name = "grpReport";
            this.grpReport.Size = new System.Drawing.Size(442, 182);
            this.grpReport.TabIndex = 28;
            this.grpReport.TabStop = false;
            this.grpReport.Text = "Report";
            // 
            // grpAge
            // 
            this.grpAge.Controls.Add(this.lbl90abCount);
            this.grpAge.Controls.Add(this.lbl90ab);
            this.grpAge.Controls.Add(this.lbl90Count);
            this.grpAge.Controls.Add(this.lbl60Count);
            this.grpAge.Controls.Add(this.lbl30Count);
            this.grpAge.Controls.Add(this.lbl90);
            this.grpAge.Controls.Add(this.lbl60);
            this.grpAge.Controls.Add(this.lbl30);
            this.grpAge.Location = new System.Drawing.Point(301, 25);
            this.grpAge.Name = "grpAge";
            this.grpAge.Size = new System.Drawing.Size(131, 144);
            this.grpAge.TabIndex = 30;
            this.grpAge.TabStop = false;
            this.grpAge.Text = "Age";
            // 
            // lbl90abCount
            // 
            this.lbl90abCount.AutoSize = true;
            this.lbl90abCount.Location = new System.Drawing.Point(71, 114);
            this.lbl90abCount.Name = "lbl90abCount";
            this.lbl90abCount.Size = new System.Drawing.Size(13, 13);
            this.lbl90abCount.TabIndex = 32;
            this.lbl90abCount.Text = "0";
            // 
            // lbl90ab
            // 
            this.lbl90ab.AutoSize = true;
            this.lbl90ab.Location = new System.Drawing.Point(9, 114);
            this.lbl90ab.Name = "lbl90ab";
            this.lbl90ab.Size = new System.Drawing.Size(28, 13);
            this.lbl90ab.TabIndex = 31;
            this.lbl90ab.Text = "> 90";
            // 
            // lbl90Count
            // 
            this.lbl90Count.AutoSize = true;
            this.lbl90Count.Location = new System.Drawing.Point(71, 83);
            this.lbl90Count.Name = "lbl90Count";
            this.lbl90Count.Size = new System.Drawing.Size(13, 13);
            this.lbl90Count.TabIndex = 30;
            this.lbl90Count.Text = "0";
            // 
            // lbl60Count
            // 
            this.lbl60Count.AutoSize = true;
            this.lbl60Count.Location = new System.Drawing.Point(71, 52);
            this.lbl60Count.Name = "lbl60Count";
            this.lbl60Count.Size = new System.Drawing.Size(13, 13);
            this.lbl60Count.TabIndex = 29;
            this.lbl60Count.Text = "0";
            // 
            // lbl30Count
            // 
            this.lbl30Count.AutoSize = true;
            this.lbl30Count.Location = new System.Drawing.Point(71, 20);
            this.lbl30Count.Name = "lbl30Count";
            this.lbl30Count.Size = new System.Drawing.Size(13, 13);
            this.lbl30Count.TabIndex = 28;
            this.lbl30Count.Text = "0";
            // 
            // lbl90
            // 
            this.lbl90.AutoSize = true;
            this.lbl90.Location = new System.Drawing.Point(9, 83);
            this.lbl90.Name = "lbl90";
            this.lbl90.Size = new System.Drawing.Size(40, 13);
            this.lbl90.TabIndex = 27;
            this.lbl90.Text = "60 - 90";
            // 
            // lbl60
            // 
            this.lbl60.AutoSize = true;
            this.lbl60.Location = new System.Drawing.Point(9, 52);
            this.lbl60.Name = "lbl60";
            this.lbl60.Size = new System.Drawing.Size(40, 13);
            this.lbl60.TabIndex = 26;
            this.lbl60.Text = "30 - 60";
            // 
            // lbl30
            // 
            this.lbl30.AutoSize = true;
            this.lbl30.Location = new System.Drawing.Point(9, 20);
            this.lbl30.Name = "lbl30";
            this.lbl30.Size = new System.Drawing.Size(34, 13);
            this.lbl30.TabIndex = 25;
            this.lbl30.Text = "0 - 30";
            // 
            // grpSeverity
            // 
            this.grpSeverity.Controls.Add(this.lblSev4Count);
            this.grpSeverity.Controls.Add(this.lblSev3Count);
            this.grpSeverity.Controls.Add(this.lblSev2Count);
            this.grpSeverity.Controls.Add(this.lblSev1Count);
            this.grpSeverity.Controls.Add(this.lblSev4);
            this.grpSeverity.Controls.Add(this.lblSev3);
            this.grpSeverity.Controls.Add(this.lblSev2);
            this.grpSeverity.Controls.Add(this.lblSev1);
            this.grpSeverity.Location = new System.Drawing.Point(158, 25);
            this.grpSeverity.Name = "grpSeverity";
            this.grpSeverity.Size = new System.Drawing.Size(126, 144);
            this.grpSeverity.TabIndex = 29;
            this.grpSeverity.TabStop = false;
            this.grpSeverity.Text = "Severity";
            // 
            // lblSev4Count
            // 
            this.lblSev4Count.AutoSize = true;
            this.lblSev4Count.Location = new System.Drawing.Point(71, 113);
            this.lblSev4Count.Name = "lblSev4Count";
            this.lblSev4Count.Size = new System.Drawing.Size(13, 13);
            this.lblSev4Count.TabIndex = 26;
            this.lblSev4Count.Text = "0";
            // 
            // lblSev3Count
            // 
            this.lblSev3Count.AutoSize = true;
            this.lblSev3Count.Location = new System.Drawing.Point(71, 82);
            this.lblSev3Count.Name = "lblSev3Count";
            this.lblSev3Count.Size = new System.Drawing.Size(13, 13);
            this.lblSev3Count.TabIndex = 25;
            this.lblSev3Count.Text = "0";
            // 
            // lblSev2Count
            // 
            this.lblSev2Count.AutoSize = true;
            this.lblSev2Count.Location = new System.Drawing.Point(71, 51);
            this.lblSev2Count.Name = "lblSev2Count";
            this.lblSev2Count.Size = new System.Drawing.Size(13, 13);
            this.lblSev2Count.TabIndex = 24;
            this.lblSev2Count.Text = "0";
            // 
            // lblSev1Count
            // 
            this.lblSev1Count.AutoSize = true;
            this.lblSev1Count.Location = new System.Drawing.Point(71, 19);
            this.lblSev1Count.Name = "lblSev1Count";
            this.lblSev1Count.Size = new System.Drawing.Size(13, 13);
            this.lblSev1Count.TabIndex = 23;
            this.lblSev1Count.Text = "0";
            // 
            // lblSev4
            // 
            this.lblSev4.AutoSize = true;
            this.lblSev4.Location = new System.Drawing.Point(19, 113);
            this.lblSev4.Name = "lblSev4";
            this.lblSev4.Size = new System.Drawing.Size(41, 13);
            this.lblSev4.TabIndex = 22;
            this.lblSev4.Text = "Sev 4 :";
            // 
            // lblSev3
            // 
            this.lblSev3.AutoSize = true;
            this.lblSev3.Location = new System.Drawing.Point(19, 82);
            this.lblSev3.Name = "lblSev3";
            this.lblSev3.Size = new System.Drawing.Size(41, 13);
            this.lblSev3.TabIndex = 21;
            this.lblSev3.Text = "Sev 3 :";
            // 
            // lblSev2
            // 
            this.lblSev2.AutoSize = true;
            this.lblSev2.Location = new System.Drawing.Point(19, 51);
            this.lblSev2.Name = "lblSev2";
            this.lblSev2.Size = new System.Drawing.Size(41, 13);
            this.lblSev2.TabIndex = 20;
            this.lblSev2.Text = "Sev 2 :";
            // 
            // lblSev1
            // 
            this.lblSev1.AutoSize = true;
            this.lblSev1.Location = new System.Drawing.Point(19, 19);
            this.lblSev1.Name = "lblSev1";
            this.lblSev1.Size = new System.Drawing.Size(41, 13);
            this.lblSev1.TabIndex = 19;
            this.lblSev1.Text = "Sev 1 :";
            // 
            // grpStatusCount
            // 
            this.grpStatusCount.Controls.Add(this.lblWorkingCount);
            this.grpStatusCount.Controls.Add(this.lblClosedCount);
            this.grpStatusCount.Controls.Add(this.lblOpenCount);
            this.grpStatusCount.Controls.Add(this.lblWorking);
            this.grpStatusCount.Controls.Add(this.lblClosed);
            this.grpStatusCount.Controls.Add(this.lblOpen);
            this.grpStatusCount.Location = new System.Drawing.Point(11, 25);
            this.grpStatusCount.Name = "grpStatusCount";
            this.grpStatusCount.Size = new System.Drawing.Size(131, 144);
            this.grpStatusCount.TabIndex = 28;
            this.grpStatusCount.TabStop = false;
            this.grpStatusCount.Text = "Status";
            // 
            // lblWorkingCount
            // 
            this.lblWorkingCount.AutoSize = true;
            this.lblWorkingCount.Location = new System.Drawing.Point(77, 86);
            this.lblWorkingCount.Name = "lblWorkingCount";
            this.lblWorkingCount.Size = new System.Drawing.Size(13, 13);
            this.lblWorkingCount.TabIndex = 16;
            this.lblWorkingCount.Text = "0";
            // 
            // lblClosedCount
            // 
            this.lblClosedCount.AutoSize = true;
            this.lblClosedCount.Location = new System.Drawing.Point(77, 55);
            this.lblClosedCount.Name = "lblClosedCount";
            this.lblClosedCount.Size = new System.Drawing.Size(13, 13);
            this.lblClosedCount.TabIndex = 15;
            this.lblClosedCount.Text = "0";
            // 
            // lblOpenCount
            // 
            this.lblOpenCount.AutoSize = true;
            this.lblOpenCount.Location = new System.Drawing.Point(77, 23);
            this.lblOpenCount.Name = "lblOpenCount";
            this.lblOpenCount.Size = new System.Drawing.Size(13, 13);
            this.lblOpenCount.TabIndex = 14;
            this.lblOpenCount.Text = "0";
            // 
            // lblWorking
            // 
            this.lblWorking.AutoSize = true;
            this.lblWorking.Location = new System.Drawing.Point(15, 86);
            this.lblWorking.Name = "lblWorking";
            this.lblWorking.Size = new System.Drawing.Size(53, 13);
            this.lblWorking.TabIndex = 13;
            this.lblWorking.Text = "Working :";
            // 
            // lblClosed
            // 
            this.lblClosed.AutoSize = true;
            this.lblClosed.Location = new System.Drawing.Point(15, 55);
            this.lblClosed.Name = "lblClosed";
            this.lblClosed.Size = new System.Drawing.Size(45, 13);
            this.lblClosed.TabIndex = 12;
            this.lblClosed.Text = "Closed :";
            // 
            // lblOpen
            // 
            this.lblOpen.AutoSize = true;
            this.lblOpen.Location = new System.Drawing.Point(15, 23);
            this.lblOpen.Name = "lblOpen";
            this.lblOpen.Size = new System.Drawing.Size(39, 13);
            this.lblOpen.TabIndex = 11;
            this.lblOpen.Text = "Open :";
            // 
            // IssueStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 292);
            this.Controls.Add(this.grpReport);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.lblFrom);
            this.MaximizeBox = false;
            this.Name = "IssueStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issue Status";
            this.Load += new System.EventHandler(this.IssueStatus_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.IssueStatus_FormClosed);
            this.grpReport.ResumeLayout(false);
            this.grpAge.ResumeLayout(false);
            this.grpAge.PerformLayout();
            this.grpSeverity.ResumeLayout(false);
            this.grpSeverity.PerformLayout();
            this.grpStatusCount.ResumeLayout(false);
            this.grpStatusCount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.GroupBox grpReport;
        private System.Windows.Forms.GroupBox grpAge;
        private System.Windows.Forms.Label lbl90Count;
        private System.Windows.Forms.Label lbl60Count;
        private System.Windows.Forms.Label lbl30Count;
        private System.Windows.Forms.Label lbl90;
        private System.Windows.Forms.Label lbl60;
        private System.Windows.Forms.Label lbl30;
        private System.Windows.Forms.GroupBox grpSeverity;
        private System.Windows.Forms.Label lblSev4Count;
        private System.Windows.Forms.Label lblSev3Count;
        private System.Windows.Forms.Label lblSev2Count;
        private System.Windows.Forms.Label lblSev1Count;
        private System.Windows.Forms.Label lblSev4;
        private System.Windows.Forms.Label lblSev3;
        private System.Windows.Forms.Label lblSev2;
        private System.Windows.Forms.Label lblSev1;
        private System.Windows.Forms.GroupBox grpStatusCount;
        private System.Windows.Forms.Label lblWorkingCount;
        private System.Windows.Forms.Label lblClosedCount;
        private System.Windows.Forms.Label lblOpenCount;
        private System.Windows.Forms.Label lblWorking;
        private System.Windows.Forms.Label lblClosed;
        private System.Windows.Forms.Label lblOpen;
        private System.Windows.Forms.Label lbl90abCount;
        private System.Windows.Forms.Label lbl90ab;
    }
}

