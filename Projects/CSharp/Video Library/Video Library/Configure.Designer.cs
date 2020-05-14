namespace Video_Library
{
    partial class Configure
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
            this.lblSupportedFiles = new System.Windows.Forms.Label();
            this.lstExtensions = new System.Windows.Forms.ListBox();
            this.lblSearchPaths = new System.Windows.Forms.Label();
            this.lstSearchPaths = new System.Windows.Forms.ListBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtNewPath = new System.Windows.Forms.TextBox();
            this.btnBrowsePath = new System.Windows.Forms.Button();
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.txtNewPlayer = new System.Windows.Forms.TextBox();
            this.lstMediaPlayers = new System.Windows.Forms.ListBox();
            this.lblMediaPlayers = new System.Windows.Forms.Label();
            this.txtNewFileType = new System.Windows.Forms.TextBox();
            this.btnAddFileType = new System.Windows.Forms.Button();
            this.btnFileTypeRemove = new System.Windows.Forms.Button();
            this.btnSearchPathRemove = new System.Windows.Forms.Button();
            this.btnSearchAdd = new System.Windows.Forms.Button();
            this.btnPlayerRemove = new System.Windows.Forms.Button();
            this.btnPlayerAdd = new System.Windows.Forms.Button();
            this.fbdFolderBrowse = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // lblSupportedFiles
            // 
            this.lblSupportedFiles.AutoSize = true;
            this.lblSupportedFiles.Location = new System.Drawing.Point(22, 24);
            this.lblSupportedFiles.Name = "lblSupportedFiles";
            this.lblSupportedFiles.Size = new System.Drawing.Size(80, 13);
            this.lblSupportedFiles.TabIndex = 0;
            this.lblSupportedFiles.Text = "Supported Files";
            // 
            // lstExtensions
            // 
            this.lstExtensions.FormattingEnabled = true;
            this.lstExtensions.Location = new System.Drawing.Point(24, 66);
            this.lstExtensions.Name = "lstExtensions";
            this.lstExtensions.Size = new System.Drawing.Size(189, 82);
            this.lstExtensions.TabIndex = 1;
            // 
            // lblSearchPaths
            // 
            this.lblSearchPaths.AutoSize = true;
            this.lblSearchPaths.Location = new System.Drawing.Point(22, 157);
            this.lblSearchPaths.Name = "lblSearchPaths";
            this.lblSearchPaths.Size = new System.Drawing.Size(70, 13);
            this.lblSearchPaths.TabIndex = 2;
            this.lblSearchPaths.Text = "Search paths";
            // 
            // lstSearchPaths
            // 
            this.lstSearchPaths.FormattingEnabled = true;
            this.lstSearchPaths.Location = new System.Drawing.Point(25, 195);
            this.lstSearchPaths.Name = "lstSearchPaths";
            this.lstSearchPaths.Size = new System.Drawing.Size(188, 82);
            this.lstSearchPaths.TabIndex = 3;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(242, 383);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(86, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtNewPath
            // 
            this.txtNewPath.Location = new System.Drawing.Point(25, 173);
            this.txtNewPath.Name = "txtNewPath";
            this.txtNewPath.Size = new System.Drawing.Size(146, 20);
            this.txtNewPath.TabIndex = 5;
            // 
            // btnBrowsePath
            // 
            this.btnBrowsePath.Location = new System.Drawing.Point(177, 172);
            this.btnBrowsePath.Name = "btnBrowsePath";
            this.btnBrowsePath.Size = new System.Drawing.Size(37, 20);
            this.btnBrowsePath.TabIndex = 6;
            this.btnBrowsePath.Text = "...";
            this.btnBrowsePath.UseVisualStyleBackColor = true;
            this.btnBrowsePath.Click += new System.EventHandler(this.btnBrowsePath_Click);
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.Location = new System.Drawing.Point(176, 301);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(37, 20);
            this.btnAddPlayer.TabIndex = 10;
            this.btnAddPlayer.Text = "...";
            this.btnAddPlayer.UseVisualStyleBackColor = true;
            // 
            // txtNewPlayer
            // 
            this.txtNewPlayer.Location = new System.Drawing.Point(24, 302);
            this.txtNewPlayer.Name = "txtNewPlayer";
            this.txtNewPlayer.Size = new System.Drawing.Size(146, 20);
            this.txtNewPlayer.TabIndex = 9;
            // 
            // lstMediaPlayers
            // 
            this.lstMediaPlayers.FormattingEnabled = true;
            this.lstMediaPlayers.Location = new System.Drawing.Point(24, 324);
            this.lstMediaPlayers.Name = "lstMediaPlayers";
            this.lstMediaPlayers.Size = new System.Drawing.Size(188, 82);
            this.lstMediaPlayers.TabIndex = 8;
            // 
            // lblMediaPlayers
            // 
            this.lblMediaPlayers.AutoSize = true;
            this.lblMediaPlayers.Location = new System.Drawing.Point(21, 286);
            this.lblMediaPlayers.Name = "lblMediaPlayers";
            this.lblMediaPlayers.Size = new System.Drawing.Size(73, 13);
            this.lblMediaPlayers.TabIndex = 7;
            this.lblMediaPlayers.Text = "Media Players";
            // 
            // txtNewFileType
            // 
            this.txtNewFileType.Location = new System.Drawing.Point(25, 40);
            this.txtNewFileType.Name = "txtNewFileType";
            this.txtNewFileType.Size = new System.Drawing.Size(188, 20);
            this.txtNewFileType.TabIndex = 11;
            // 
            // btnAddFileType
            // 
            this.btnAddFileType.Location = new System.Drawing.Point(242, 40);
            this.btnAddFileType.Name = "btnAddFileType";
            this.btnAddFileType.Size = new System.Drawing.Size(86, 20);
            this.btnAddFileType.TabIndex = 12;
            this.btnAddFileType.Text = "Add";
            this.btnAddFileType.UseVisualStyleBackColor = true;
            this.btnAddFileType.Click += new System.EventHandler(this.btnAddFileType_Click);
            // 
            // btnFileTypeRemove
            // 
            this.btnFileTypeRemove.Location = new System.Drawing.Point(242, 66);
            this.btnFileTypeRemove.Name = "btnFileTypeRemove";
            this.btnFileTypeRemove.Size = new System.Drawing.Size(86, 20);
            this.btnFileTypeRemove.TabIndex = 13;
            this.btnFileTypeRemove.Text = "Remove";
            this.btnFileTypeRemove.UseVisualStyleBackColor = true;
            this.btnFileTypeRemove.Click += new System.EventHandler(this.btnFileTypeRemove_Click);
            // 
            // btnSearchPathRemove
            // 
            this.btnSearchPathRemove.Location = new System.Drawing.Point(242, 198);
            this.btnSearchPathRemove.Name = "btnSearchPathRemove";
            this.btnSearchPathRemove.Size = new System.Drawing.Size(86, 20);
            this.btnSearchPathRemove.TabIndex = 15;
            this.btnSearchPathRemove.Text = "Remove";
            this.btnSearchPathRemove.UseVisualStyleBackColor = true;
            this.btnSearchPathRemove.Click += new System.EventHandler(this.btnSearchPathRemove_Click);
            // 
            // btnSearchAdd
            // 
            this.btnSearchAdd.Location = new System.Drawing.Point(242, 172);
            this.btnSearchAdd.Name = "btnSearchAdd";
            this.btnSearchAdd.Size = new System.Drawing.Size(86, 20);
            this.btnSearchAdd.TabIndex = 14;
            this.btnSearchAdd.Text = "Add";
            this.btnSearchAdd.UseVisualStyleBackColor = true;
            this.btnSearchAdd.Click += new System.EventHandler(this.btnSearchAdd_Click);
            // 
            // btnPlayerRemove
            // 
            this.btnPlayerRemove.Location = new System.Drawing.Point(242, 327);
            this.btnPlayerRemove.Name = "btnPlayerRemove";
            this.btnPlayerRemove.Size = new System.Drawing.Size(86, 20);
            this.btnPlayerRemove.TabIndex = 17;
            this.btnPlayerRemove.Text = "Remove";
            this.btnPlayerRemove.UseVisualStyleBackColor = true;
            // 
            // btnPlayerAdd
            // 
            this.btnPlayerAdd.Location = new System.Drawing.Point(242, 301);
            this.btnPlayerAdd.Name = "btnPlayerAdd";
            this.btnPlayerAdd.Size = new System.Drawing.Size(86, 20);
            this.btnPlayerAdd.TabIndex = 16;
            this.btnPlayerAdd.Text = "Add";
            this.btnPlayerAdd.UseVisualStyleBackColor = true;
            // 
            // Configure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 425);
            this.Controls.Add(this.btnPlayerRemove);
            this.Controls.Add(this.btnPlayerAdd);
            this.Controls.Add(this.btnSearchPathRemove);
            this.Controls.Add(this.btnSearchAdd);
            this.Controls.Add(this.btnFileTypeRemove);
            this.Controls.Add(this.btnAddFileType);
            this.Controls.Add(this.txtNewFileType);
            this.Controls.Add(this.btnAddPlayer);
            this.Controls.Add(this.txtNewPlayer);
            this.Controls.Add(this.lstMediaPlayers);
            this.Controls.Add(this.lblMediaPlayers);
            this.Controls.Add(this.btnBrowsePath);
            this.Controls.Add(this.txtNewPath);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lstSearchPaths);
            this.Controls.Add(this.lblSearchPaths);
            this.Controls.Add(this.lstExtensions);
            this.Controls.Add(this.lblSupportedFiles);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(360, 459);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(360, 459);
            this.Name = "Configure";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configure";
            this.Load += new System.EventHandler(this.Configure_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Configure_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSupportedFiles;
        private System.Windows.Forms.ListBox lstExtensions;
        private System.Windows.Forms.Label lblSearchPaths;
        private System.Windows.Forms.ListBox lstSearchPaths;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtNewPath;
        private System.Windows.Forms.Button btnBrowsePath;
        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.TextBox txtNewPlayer;
        private System.Windows.Forms.ListBox lstMediaPlayers;
        private System.Windows.Forms.Label lblMediaPlayers;
        private System.Windows.Forms.TextBox txtNewFileType;
        private System.Windows.Forms.Button btnAddFileType;
        private System.Windows.Forms.Button btnFileTypeRemove;
        private System.Windows.Forms.Button btnSearchPathRemove;
        private System.Windows.Forms.Button btnSearchAdd;
        private System.Windows.Forms.Button btnPlayerRemove;
        private System.Windows.Forms.Button btnPlayerAdd;
        private System.Windows.Forms.FolderBrowserDialog fbdFolderBrowse;
    }
}