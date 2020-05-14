namespace GRE_Master
{
    partial class TestMode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestMode));
            this.rdbTest1 = new System.Windows.Forms.RadioButton();
            this.rdbTest2 = new System.Windows.Forms.RadioButton();
            this.btnBeginTest = new System.Windows.Forms.Button();
            this.cboWordList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTill = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboFrom = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // rdbTest1
            // 
            this.rdbTest1.AutoSize = true;
            this.rdbTest1.Location = new System.Drawing.Point(36, 25);
            this.rdbTest1.Name = "rdbTest1";
            this.rdbTest1.Size = new System.Drawing.Size(101, 17);
            this.rdbTest1.TabIndex = 0;
            this.rdbTest1.TabStop = true;
            this.rdbTest1.Text = "Meaning->Word";
            this.rdbTest1.UseVisualStyleBackColor = true;
            // 
            // rdbTest2
            // 
            this.rdbTest2.AutoSize = true;
            this.rdbTest2.Location = new System.Drawing.Point(36, 59);
            this.rdbTest2.Name = "rdbTest2";
            this.rdbTest2.Size = new System.Drawing.Size(101, 17);
            this.rdbTest2.TabIndex = 1;
            this.rdbTest2.TabStop = true;
            this.rdbTest2.Text = "Word->Meaning";
            this.rdbTest2.UseVisualStyleBackColor = true;
            // 
            // btnBeginTest
            // 
            this.btnBeginTest.Location = new System.Drawing.Point(59, 197);
            this.btnBeginTest.Name = "btnBeginTest";
            this.btnBeginTest.Size = new System.Drawing.Size(95, 37);
            this.btnBeginTest.TabIndex = 2;
            this.btnBeginTest.Text = "Begin Test";
            this.btnBeginTest.UseVisualStyleBackColor = true;
            this.btnBeginTest.Click += new System.EventHandler(this.btnBeginTest_Click);
            // 
            // cboWordList
            // 
            this.cboWordList.FormattingEnabled = true;
            this.cboWordList.Items.AddRange(new object[] {
            "All",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.cboWordList.Location = new System.Drawing.Point(104, 95);
            this.cboWordList.Name = "cboWordList";
            this.cboWordList.Size = new System.Drawing.Size(50, 21);
            this.cboWordList.TabIndex = 3;
            this.cboWordList.Text = "All";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Wordlist";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Test me till";
            // 
            // cboTill
            // 
            this.cboTill.FormattingEnabled = true;
            this.cboTill.Location = new System.Drawing.Point(104, 160);
            this.cboTill.Name = "cboTill";
            this.cboTill.Size = new System.Drawing.Size(98, 21);
            this.cboTill.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Test me from";
            // 
            // cboFrom
            // 
            this.cboFrom.FormattingEnabled = true;
            this.cboFrom.Location = new System.Drawing.Point(104, 128);
            this.cboFrom.Name = "cboFrom";
            this.cboFrom.Size = new System.Drawing.Size(98, 21);
            this.cboFrom.TabIndex = 7;
            // 
            // TestMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 246);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboTill);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboWordList);
            this.Controls.Add(this.btnBeginTest);
            this.Controls.Add(this.rdbTest2);
            this.Controls.Add(this.rdbTest1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TestMode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Test mode";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TestMode_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbTest1;
        private System.Windows.Forms.RadioButton rdbTest2;
        private System.Windows.Forms.Button btnBeginTest;
        private System.Windows.Forms.ComboBox cboWordList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTill;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboFrom;
    }
}