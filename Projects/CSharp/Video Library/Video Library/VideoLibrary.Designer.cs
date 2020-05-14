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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editVideoInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnConfigure = new System.Windows.Forms.Button();
            this.niSysTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.grpCriteria = new System.Windows.Forms.GroupBox();
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.lblMovieName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLanguage = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtKeywords = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtStarCast = new System.Windows.Forms.TextBox();
            this.lblStarCast = new System.Windows.Forms.Label();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.lblDirector = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.grpResults = new System.Windows.Forms.GroupBox();
            this.lblResultsFound = new System.Windows.Forms.Label();
            this.lblResultCount = new System.Windows.Forms.Label();
            this.dgvSearchList = new System.Windows.Forms.DataGridView();
            this.Video = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Availability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsMenu.SuspendLayout();
            this.grpCriteria.SuspendLayout();
            this.grpResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchList)).BeginInit();
            this.SuspendLayout();
            // 
            // cmsMenu
            // 
            this.cmsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem,
            this.editVideoInformationToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.cmsMenu.Name = "cmsMenu";
            this.cmsMenu.Size = new System.Drawing.Size(190, 70);
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.playToolStripMenuItem.Text = "Play";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // editVideoInformationToolStripMenuItem
            // 
            this.editVideoInformationToolStripMenuItem.Name = "editVideoInformationToolStripMenuItem";
            this.editVideoInformationToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.editVideoInformationToolStripMenuItem.Text = "Edit video information";
            this.editVideoInformationToolStripMenuItem.Click += new System.EventHandler(this.editVideoInformationToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.removeToolStripMenuItem.Text = "Remove from library";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(30, 380);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 23);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(183, 380);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(100, 23);
            this.btnPlay.TabIndex = 15;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(482, 380);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 23);
            this.btnRefresh.TabIndex = 16;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnConfigure
            // 
            this.btnConfigure.Location = new System.Drawing.Point(330, 380);
            this.btnConfigure.Name = "btnConfigure";
            this.btnConfigure.Size = new System.Drawing.Size(100, 23);
            this.btnConfigure.TabIndex = 17;
            this.btnConfigure.Text = "Configure";
            this.btnConfigure.UseVisualStyleBackColor = true;
            this.btnConfigure.Click += new System.EventHandler(this.btnConfigure_Click);
            // 
            // niSysTray
            // 
            this.niSysTray.Icon = ((System.Drawing.Icon)(resources.GetObject("niSysTray.Icon")));
            this.niSysTray.Text = "Video Library";
            this.niSysTray.Visible = true;
            this.niSysTray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.niSysTray_MouseDoubleClick);
            // 
            // grpCriteria
            // 
            this.grpCriteria.Controls.Add(this.txtMovieName);
            this.grpCriteria.Controls.Add(this.lblMovieName);
            this.grpCriteria.Controls.Add(this.label1);
            this.grpCriteria.Controls.Add(this.txtLanguage);
            this.grpCriteria.Controls.Add(this.txtYear);
            this.grpCriteria.Controls.Add(this.txtKeywords);
            this.grpCriteria.Controls.Add(this.lblYear);
            this.grpCriteria.Controls.Add(this.txtStarCast);
            this.grpCriteria.Controls.Add(this.lblStarCast);
            this.grpCriteria.Controls.Add(this.txtDirector);
            this.grpCriteria.Controls.Add(this.lblLanguage);
            this.grpCriteria.Controls.Add(this.txtGenre);
            this.grpCriteria.Controls.Add(this.lblDirector);
            this.grpCriteria.Controls.Add(this.lblGenre);
            this.grpCriteria.Location = new System.Drawing.Point(12, 12);
            this.grpCriteria.Name = "grpCriteria";
            this.grpCriteria.Size = new System.Drawing.Size(213, 356);
            this.grpCriteria.TabIndex = 18;
            this.grpCriteria.TabStop = false;
            this.grpCriteria.Text = "Search Criteria";
            // 
            // txtMovieName
            // 
            this.txtMovieName.Location = new System.Drawing.Point(67, 22);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(127, 20);
            this.txtMovieName.TabIndex = 28;
            this.txtMovieName.TextChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblMovieName
            // 
            this.lblMovieName.AutoSize = true;
            this.lblMovieName.Location = new System.Drawing.Point(6, 25);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(36, 13);
            this.lblMovieName.TabIndex = 27;
            this.lblMovieName.Text = "Movie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Keywords";
            // 
            // txtLanguage
            // 
            this.txtLanguage.Location = new System.Drawing.Point(67, 56);
            this.txtLanguage.Name = "txtLanguage";
            this.txtLanguage.Size = new System.Drawing.Size(127, 20);
            this.txtLanguage.TabIndex = 16;
            this.txtLanguage.TextChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(67, 91);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(127, 20);
            this.txtYear.TabIndex = 24;
            this.txtYear.TextChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtKeywords
            // 
            this.txtKeywords.Location = new System.Drawing.Point(67, 230);
            this.txtKeywords.Name = "txtKeywords";
            this.txtKeywords.Size = new System.Drawing.Size(127, 20);
            this.txtKeywords.TabIndex = 26;
            this.txtKeywords.TextChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(6, 94);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(29, 13);
            this.lblYear.TabIndex = 23;
            this.lblYear.Text = "Year";
            // 
            // txtStarCast
            // 
            this.txtStarCast.Location = new System.Drawing.Point(67, 161);
            this.txtStarCast.Name = "txtStarCast";
            this.txtStarCast.Size = new System.Drawing.Size(127, 20);
            this.txtStarCast.TabIndex = 22;
            this.txtStarCast.TextChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblStarCast
            // 
            this.lblStarCast.AutoSize = true;
            this.lblStarCast.Location = new System.Drawing.Point(6, 164);
            this.lblStarCast.Name = "lblStarCast";
            this.lblStarCast.Size = new System.Drawing.Size(46, 13);
            this.lblStarCast.TabIndex = 21;
            this.lblStarCast.Text = "Starcast";
            // 
            // txtDirector
            // 
            this.txtDirector.Location = new System.Drawing.Point(67, 195);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(127, 20);
            this.txtDirector.TabIndex = 20;
            this.txtDirector.TextChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(6, 59);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(55, 13);
            this.lblLanguage.TabIndex = 15;
            this.lblLanguage.Text = "Language";
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(67, 126);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(127, 20);
            this.txtGenre.TabIndex = 18;
            this.txtGenre.TextChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Location = new System.Drawing.Point(6, 198);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(44, 13);
            this.lblDirector.TabIndex = 19;
            this.lblDirector.Text = "Director";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(6, 129);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(36, 13);
            this.lblGenre.TabIndex = 17;
            this.lblGenre.Text = "Genre";
            // 
            // grpResults
            // 
            this.grpResults.Controls.Add(this.lblResultsFound);
            this.grpResults.Controls.Add(this.lblResultCount);
            this.grpResults.Controls.Add(this.dgvSearchList);
            this.grpResults.Location = new System.Drawing.Point(231, 12);
            this.grpResults.Name = "grpResults";
            this.grpResults.Size = new System.Drawing.Size(400, 356);
            this.grpResults.TabIndex = 29;
            this.grpResults.TabStop = false;
            this.grpResults.Text = "Search Results";
            // 
            // lblResultsFound
            // 
            this.lblResultsFound.AutoSize = true;
            this.lblResultsFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultsFound.Location = new System.Drawing.Point(176, 340);
            this.lblResultsFound.Name = "lblResultsFound";
            this.lblResultsFound.Size = new System.Drawing.Size(85, 13);
            this.lblResultsFound.TabIndex = 15;
            this.lblResultsFound.Text = "Results found";
            // 
            // lblResultCount
            // 
            this.lblResultCount.AutoSize = true;
            this.lblResultCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultCount.Location = new System.Drawing.Point(142, 340);
            this.lblResultCount.Name = "lblResultCount";
            this.lblResultCount.Size = new System.Drawing.Size(14, 13);
            this.lblResultCount.TabIndex = 14;
            this.lblResultCount.Text = "0";
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
            this.dgvSearchList.Location = new System.Drawing.Point(6, 22);
            this.dgvSearchList.Name = "dgvSearchList";
            this.dgvSearchList.ReadOnly = true;
            this.dgvSearchList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvSearchList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvSearchList.ShowEditingIcon = false;
            this.dgvSearchList.Size = new System.Drawing.Size(388, 305);
            this.dgvSearchList.TabIndex = 12;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Availability.DefaultCellStyle = dataGridViewCellStyle1;
            this.Availability.HeaderText = "Availability";
            this.Availability.Name = "Availability";
            this.Availability.ReadOnly = true;
            // 
            // VideoLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 415);
            this.Controls.Add(this.grpResults);
            this.Controls.Add(this.grpCriteria);
            this.Controls.Add(this.btnConfigure);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnSearch);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(651, 449);
            this.MinimumSize = new System.Drawing.Size(651, 449);
            this.Name = "VideoLibrary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Video Library";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.VideoLibrary_Resize);
            this.cmsMenu.ResumeLayout(false);
            this.grpCriteria.ResumeLayout(false);
            this.grpCriteria.PerformLayout();
            this.grpResults.ResumeLayout(false);
            this.grpResults.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnConfigure;
        private System.Windows.Forms.ContextMenuStrip cmsMenu;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editVideoInformationToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon niSysTray;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpCriteria;
        private System.Windows.Forms.TextBox txtMovieName;
        private System.Windows.Forms.Label lblMovieName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLanguage;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtKeywords;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtStarCast;
        private System.Windows.Forms.Label lblStarCast;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.GroupBox grpResults;
        private System.Windows.Forms.DataGridView dgvSearchList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Video;
        private System.Windows.Forms.DataGridViewTextBoxColumn Availability;
        private System.Windows.Forms.Label lblResultsFound;
        private System.Windows.Forms.Label lblResultCount;
    }
}

