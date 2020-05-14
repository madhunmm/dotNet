namespace GRE_Master
{
    partial class WordListDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WordListDialog));
            this.grpWordList = new System.Windows.Forms.GroupBox();
            this.lstWordList = new System.Windows.Forms.ListBox();
            this.grpEntry = new System.Windows.Forms.GroupBox();
            this.lblOtherInfo = new System.Windows.Forms.Label();
            this.lblUsages = new System.Windows.Forms.Label();
            this.lblMeanings = new System.Windows.Forms.Label();
            this.lblWord = new System.Windows.Forms.Label();
            this.txtOtherInfo = new System.Windows.Forms.TextBox();
            this.txtUsages = new System.Windows.Forms.TextBox();
            this.txtMeanings = new System.Windows.Forms.TextBox();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblWordsLabel = new System.Windows.Forms.Label();
            this.grpWordList.SuspendLayout();
            this.grpEntry.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpWordList
            // 
            this.grpWordList.Controls.Add(this.lblWordsLabel);
            this.grpWordList.Controls.Add(this.lblCount);
            this.grpWordList.Controls.Add(this.lstWordList);
            this.grpWordList.Location = new System.Drawing.Point(12, 12);
            this.grpWordList.Name = "grpWordList";
            this.grpWordList.Size = new System.Drawing.Size(135, 251);
            this.grpWordList.TabIndex = 1;
            this.grpWordList.TabStop = false;
            this.grpWordList.Text = "Word List";
            // 
            // lstWordList
            // 
            this.lstWordList.FormattingEnabled = true;
            this.lstWordList.Location = new System.Drawing.Point(6, 19);
            this.lstWordList.Name = "lstWordList";
            this.lstWordList.Size = new System.Drawing.Size(120, 199);
            this.lstWordList.TabIndex = 1;
            this.lstWordList.SelectedIndexChanged += new System.EventHandler(this.lstWordList_SelectedIndexChanged);
            this.lstWordList.Click += new System.EventHandler(this.lstWordList_Click);
            // 
            // grpEntry
            // 
            this.grpEntry.Controls.Add(this.lblOtherInfo);
            this.grpEntry.Controls.Add(this.lblUsages);
            this.grpEntry.Controls.Add(this.lblMeanings);
            this.grpEntry.Controls.Add(this.lblWord);
            this.grpEntry.Controls.Add(this.txtOtherInfo);
            this.grpEntry.Controls.Add(this.txtUsages);
            this.grpEntry.Controls.Add(this.txtMeanings);
            this.grpEntry.Controls.Add(this.txtWord);
            this.grpEntry.Location = new System.Drawing.Point(153, 12);
            this.grpEntry.Name = "grpEntry";
            this.grpEntry.Size = new System.Drawing.Size(299, 251);
            this.grpEntry.TabIndex = 2;
            this.grpEntry.TabStop = false;
            this.grpEntry.Text = "Word Entry";
            // 
            // lblOtherInfo
            // 
            this.lblOtherInfo.AutoSize = true;
            this.lblOtherInfo.Location = new System.Drawing.Point(17, 204);
            this.lblOtherInfo.Name = "lblOtherInfo";
            this.lblOtherInfo.Size = new System.Drawing.Size(88, 13);
            this.lblOtherInfo.TabIndex = 17;
            this.lblOtherInfo.Text = "Other Information";
            // 
            // lblUsages
            // 
            this.lblUsages.AutoSize = true;
            this.lblUsages.Location = new System.Drawing.Point(17, 139);
            this.lblUsages.Name = "lblUsages";
            this.lblUsages.Size = new System.Drawing.Size(49, 13);
            this.lblUsages.TabIndex = 16;
            this.lblUsages.Text = "Usage(s)";
            // 
            // lblMeanings
            // 
            this.lblMeanings.AutoSize = true;
            this.lblMeanings.Location = new System.Drawing.Point(17, 73);
            this.lblMeanings.Name = "lblMeanings";
            this.lblMeanings.Size = new System.Drawing.Size(59, 13);
            this.lblMeanings.TabIndex = 15;
            this.lblMeanings.Text = "Meaning(s)";
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Location = new System.Drawing.Point(17, 26);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(33, 13);
            this.lblWord.TabIndex = 14;
            this.lblWord.Text = "Word";
            // 
            // txtOtherInfo
            // 
            this.txtOtherInfo.Location = new System.Drawing.Point(111, 181);
            this.txtOtherInfo.Multiline = true;
            this.txtOtherInfo.Name = "txtOtherInfo";
            this.txtOtherInfo.Size = new System.Drawing.Size(170, 59);
            this.txtOtherInfo.TabIndex = 13;
            this.txtOtherInfo.TextChanged += new System.EventHandler(this.txtOtherInfo_TextChanged);
            // 
            // txtUsages
            // 
            this.txtUsages.Location = new System.Drawing.Point(111, 115);
            this.txtUsages.Multiline = true;
            this.txtUsages.Name = "txtUsages";
            this.txtUsages.Size = new System.Drawing.Size(170, 59);
            this.txtUsages.TabIndex = 12;
            this.txtUsages.TextChanged += new System.EventHandler(this.txtUsages_TextChanged);
            // 
            // txtMeanings
            // 
            this.txtMeanings.Location = new System.Drawing.Point(111, 49);
            this.txtMeanings.Multiline = true;
            this.txtMeanings.Name = "txtMeanings";
            this.txtMeanings.Size = new System.Drawing.Size(170, 59);
            this.txtMeanings.TabIndex = 11;
            this.txtMeanings.TextChanged += new System.EventHandler(this.txtMeanings_TextChanged);
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(111, 22);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(170, 20);
            this.txtWord.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(63, 276);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(183, 276);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(310, 276);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(23, 228);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(13, 13);
            this.lblCount.TabIndex = 2;
            this.lblCount.Text = "0";
            // 
            // lblWordsLabel
            // 
            this.lblWordsLabel.AutoSize = true;
            this.lblWordsLabel.Location = new System.Drawing.Point(56, 228);
            this.lblWordsLabel.Name = "lblWordsLabel";
            this.lblWordsLabel.Size = new System.Drawing.Size(38, 13);
            this.lblWordsLabel.TabIndex = 3;
            this.lblWordsLabel.Text = "Words";
            // 
            // WordListDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 311);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpEntry);
            this.Controls.Add(this.grpWordList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(472, 345);
            this.MinimumSize = new System.Drawing.Size(472, 345);
            this.Name = "WordListDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Word List";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WordListDialog_FormClosed);
            this.grpWordList.ResumeLayout(false);
            this.grpWordList.PerformLayout();
            this.grpEntry.ResumeLayout(false);
            this.grpEntry.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpWordList;
        private System.Windows.Forms.ListBox lstWordList;
        private System.Windows.Forms.GroupBox grpEntry;
        private System.Windows.Forms.Label lblOtherInfo;
        private System.Windows.Forms.Label lblUsages;
        private System.Windows.Forms.Label lblMeanings;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.TextBox txtOtherInfo;
        private System.Windows.Forms.TextBox txtUsages;
        private System.Windows.Forms.TextBox txtMeanings;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblWordsLabel;
    }
}