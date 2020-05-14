namespace Crossword_Indicators
{
    partial class frmIndicators
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
            this.txtClue = new System.Windows.Forms.TextBox();
            this.dgvIndicators = new System.Windows.Forms.DataGridView();
            this.Word = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Indicator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdFind = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIndicators)).BeginInit();
            this.SuspendLayout();
            // 
            // txtClue
            // 
            this.txtClue.Location = new System.Drawing.Point(54, 21);
            this.txtClue.Name = "txtClue";
            this.txtClue.Size = new System.Drawing.Size(182, 20);
            this.txtClue.TabIndex = 0;
            this.txtClue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClue_KeyPress);
            // 
            // dgvIndicators
            // 
            this.dgvIndicators.AllowUserToAddRows = false;
            this.dgvIndicators.AllowUserToDeleteRows = false;
            this.dgvIndicators.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIndicators.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Word,
            this.Indicator});
            this.dgvIndicators.Location = new System.Drawing.Point(23, 60);
            this.dgvIndicators.Name = "dgvIndicators";
            this.dgvIndicators.ReadOnly = true;
            this.dgvIndicators.Size = new System.Drawing.Size(248, 150);
            this.dgvIndicators.TabIndex = 1;
            // 
            // Word
            // 
            this.Word.HeaderText = "Word";
            this.Word.Name = "Word";
            this.Word.ReadOnly = true;
            // 
            // Indicator
            // 
            this.Indicator.HeaderText = "Indicator";
            this.Indicator.Name = "Indicator";
            this.Indicator.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Clue";
            // 
            // cmdFind
            // 
            this.cmdFind.Location = new System.Drawing.Point(235, 19);
            this.cmdFind.Name = "cmdFind";
            this.cmdFind.Size = new System.Drawing.Size(36, 23);
            this.cmdFind.TabIndex = 3;
            this.cmdFind.Text = "Find";
            this.cmdFind.UseVisualStyleBackColor = true;
            this.cmdFind.Click += new System.EventHandler(this.cmdFind_Click);
            // 
            // frmIndicators
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 228);
            this.Controls.Add(this.cmdFind);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvIndicators);
            this.Controls.Add(this.txtClue);
            this.MaximizeBox = false;
            this.Name = "frmIndicators";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crossword Indicators";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIndicators)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClue;
        private System.Windows.Forms.DataGridView dgvIndicators;
        private System.Windows.Forms.DataGridViewTextBoxColumn Word;
        private System.Windows.Forms.DataGridViewTextBoxColumn Indicator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdFind;
    }
}

