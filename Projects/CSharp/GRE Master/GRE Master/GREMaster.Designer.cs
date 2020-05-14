namespace GRE_Master
{
    partial class GREMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GREMaster));
            this.btnWordList = new System.Windows.Forms.Button();
            this.btnTestMode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWordList
            // 
            this.btnWordList.Location = new System.Drawing.Point(12, 25);
            this.btnWordList.Name = "btnWordList";
            this.btnWordList.Size = new System.Drawing.Size(201, 31);
            this.btnWordList.TabIndex = 0;
            this.btnWordList.Text = "Word List";
            this.btnWordList.UseVisualStyleBackColor = true;
            this.btnWordList.Click += new System.EventHandler(this.btnWordList_Click);
            // 
            // btnTestMode
            // 
            this.btnTestMode.Location = new System.Drawing.Point(12, 71);
            this.btnTestMode.Name = "btnTestMode";
            this.btnTestMode.Size = new System.Drawing.Size(201, 30);
            this.btnTestMode.TabIndex = 1;
            this.btnTestMode.Text = "Test Mode";
            this.btnTestMode.UseVisualStyleBackColor = true;
            this.btnTestMode.Click += new System.EventHandler(this.btnTestMode_Click);
            // 
            // GREMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 124);
            this.Controls.Add(this.btnTestMode);
            this.Controls.Add(this.btnWordList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(235, 158);
            this.MinimumSize = new System.Drawing.Size(235, 158);
            this.Name = "GREMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GRE MASTER";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GREMaster_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWordList;
        private System.Windows.Forms.Button btnTestMode;
    }
}

