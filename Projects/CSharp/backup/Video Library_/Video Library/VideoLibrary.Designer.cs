namespace Video_Library
{
    partial class VideoLibrary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoLibrary));
            this.lblLanguage = new System.Windows.Forms.Label();
            this.txtLanguage = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.lblDirector = new System.Windows.Forms.Label();
            this.txtStarCast = new System.Windows.Forms.TextBox();
            this.lblStarCast = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.dgvSearchList = new System.Windows.Forms.DataGridView();
            this.Video = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Availability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtKeywords = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnConfigure = new System.Windows.Forms.Button();
            this.cmsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editVideoInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.niSysTray = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchList)).BeginInit();
            this.cmsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(27, 25);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(55, 13);
            this.lblLanguage.TabIndex = 0;
            this.lblLanguage.Text = "Language";
            // 
            // txtLanguage
            // 
            this.txtLanguage.Location = new System.Drawing.Point(88, 22);
            this.txtLanguage.Name = "txtLanguage";
            this.txtLanguage.Size = new System.Drawing.Size(100, 20);
            this.txtLanguage.TabIndex = 1;
            this.txtLanguage.TextChanged += new System.EventHandler(this.txtLanguage_TextChanged);
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(277, 22);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(100, 20);
            this.txtGenre.TabIndex = 3;
            this.txtGenre.TextChanged += new System.EventHandler(this.txtGenre_TextChanged);
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(216, 25);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(36, 13);
            this.lblGenre.TabIndex = 2;
            this.lblGenre.Text = "Genre";
            // 
            // txtDirector
            // 
            this.txtDirector.Location = new System.Drawing.Point(482, 22);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(100, 20);
            this.txtDirector.TabIndex = 5;
            this.txtDirector.TextChanged += new System.EventHandler(this.txtDirector_TextChanged);
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Location = new System.Drawing.Point(421, 25);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(44, 13);
            this.lblDirector.TabIndex = 4;
            this.lblDirector.Text = "Director";
            // 
            // txtStarCast
            // 
            this.txtStarCast.Location = new System.Drawing.Point(277, 57);
            this.txtStarCast.Name = "txtStarCast";
            this.txtStarCast.Size = new System.Drawing.Size(100, 20);
            this.txtStarCast.TabIndex = 7;
            this.txtStarCast.TextChanged += new System.EventHandler(this.txtStarCast_TextChanged);
            // 
            // lblStarCast
            // 
            this.lblStarCast.AutoSize = true;
            this.lblStarCast.Location = new System.Drawing.Point(216, 60);
            this.lblStarCast.Name = "lblStarCast";
            this.lblStarCast.Size = new System.Drawing.Size(46, 13);
            this.lblStarCast.TabIndex = 6;
            this.lblStarCast.Text = "Starcast";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(88, 57);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 20);
            this.txtYear.TabIndex = 9;
            this.txtYear.TextChanged += new System.EventHandler(this.txtYear_TextChanged);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(27, 60);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(29, 13);
            this.lblYear.TabIndex = 8;
            this.lblYear.Text = "Year";
            // 
            // dgvSearchList
            // 
            this.dgvSearchList.AllowUserToAddRows = false;
            this.dgvSearchList.AllowUserToDeleteRows = false;
            this.dgvSearchList.AllowUserToResizeColumns = false;
            this.dgvSearchList.AllowUserToResizeRows = false;
            this.dgvSearchList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Video,
            this.Availability});
            this.dgvSearchList.ContextMenuStrip = this.cmsMenu;
            this.dgvSearchList.Location = new System.Drawing.Point(30, 100);
            this.dgvSearchList.MultiSelect = false;
            this.dgvSearchList.Name = "dgvSearchList";
            this.dgvSearchList.ReadOnly = true;
            this.dgvSearchList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvSearchList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvSearchList.ShowEditingIcon = false;
            this.dgvSearchList.Size = new System.Drawing.Size(552, 242);
            this.dgvSearchList.TabIndex = 11;
            this.dgvSearchList.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSearchList_CellMouseDown);
            // 
            // Video
            // 
            this.Video.HeaderText = "Video";
            this.Video.Name = "Video";
            this.Video.ReadOnly = true;
            // 
            // Availability
            // 
            this.Availability.HeaderText = "Availability";
            this.Availability.Name = "Availability";
            this.Availability.ReadOnly = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(30, 357);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 23);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtKeywords
            // 
            this.txtKeywords.Location = new System.Drawing.Point(482, 57);
            this.txtKeywords.Name = "txtKeywords";
            this.txtKeywords.Size = new System.Drawing.Size(100, 20);
            this.txtKeywords.TabIndex = 14;
            this.txtKeywords.TextChanged += new System.EventHandler(this.txtKeywords_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(421, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Keywords";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(183, 357);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(100, 23);
            this.btnPlay.TabIndex = 15;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(482, 357);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 23);
            this.btnRefresh.TabIndex = 16;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnConfigure
            // 
            this.btnConfigure.Location = new System.Drawing.Point(330, 357);
            this.btnConfigure.Name = "btnConfigure";
            this.btnConfigure.Size = new System.Drawing.Size(100, 23);
            this.btnConfigure.TabIndex = 17;
            this.btnConfigure.Text = "Configure";
            this.btnConfigure.UseVisualStyleBackColor = true;
            this.btnConfigure.Click += new System.EventHandler(this.btnConfigure_Click);
            // 
            // cmsMenu
            // 
            this.cmsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem,
            this.editVideoInformationToolStripMenuItem});
            this.cmsMenu.Name = "cmsMenu";
            this.cmsMenu.Size = new System.Drawing.Size(190, 70);
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.playToolStripMenuItem.Text = "Play";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.playToolStripMenuItem_Click);
            // 
            // editVideoInformationToolStripMenuItem
            // 
            this.editVideoInformationToolStripMenuItem.Name = "editVideoInformationToolStripMenuItem";
            this.editVideoInformationToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.editVideoInformationToolStripMenuItem.Text = "Edit video information";
            this.editVideoInformationToolStripMenuItem.Click += new System.EventHandler(this.editVideoInformationToolStripMenuItem_Click);
            // 
            // niSysTray
            // 
            this.niSysTray.Icon = ((System.Drawing.Icon)(resources.GetObject("niSysTray.Icon")));
            this.niSysTray.Text = "Video Library";
            this.niSysTray.Visible = true;
            this.niSysTray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.niSysTray_MouseDoubleClick);
            // 
            // VideoLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 392);
            this.Controls.Add(this.btnConfigure);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.txtKeywords);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvSearchList);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.txtStarCast);
            this.Controls.Add(this.lblStarCast);
            this.Controls.Add(this.txtDirector);
            this.Controls.Add(this.lblDirector);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.txtLanguage);
            this.Controls.Add(this.lblLanguage);
            this.MaximizeBox = false;
            this.Name = "VideoLibrary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Video Library";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.VideoLibrary_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchList)).EndInit();
            this.cmsMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.TextBox txtLanguage;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.TextBox txtStarCast;
        private System.Windows.Forms.Label lblStarCast;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.DataGridView dgvSearchList;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtKeywords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Video;
        private System.Windows.Forms.DataGridViewTextBoxColumn Availability;
        private System.Windows.Forms.Button btnConfigure;
        private System.Windows.Forms.ContextMenuStrip cmsMenu;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editVideoInformationToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon niSysTray;
    }
}

