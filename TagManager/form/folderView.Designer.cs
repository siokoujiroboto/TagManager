namespace TagManager
{
    partial class folderView
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.thumbPicture = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_openPath = new System.Windows.Forms.Button();
            this.btn_addTag = new System.Windows.Forms.Button();
            this.tag_listView = new System.Windows.Forms.ListView();
            this.filepanel = new System.Windows.Forms.Panel();
            this.pageSelect = new System.Windows.Forms.ComboBox();
            this.btn_nextPage = new System.Windows.Forms.Button();
            this.btn_previousPage = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_FormTo = new System.Windows.Forms.Label();
            this.label_fileCount = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除此标签ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thumbPicture)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.filepanel);
            this.splitContainer1.Size = new System.Drawing.Size(1008, 583);
            this.splitContainer1.SplitterDistance = 212;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(83)))), ((int)(((byte)(91)))));
            this.splitContainer2.Panel1.Controls.Add(this.thumbPicture);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(83)))), ((int)(((byte)(91)))));
            this.splitContainer2.Panel2.Controls.Add(this.panel1);
            this.splitContainer2.Panel2.Controls.Add(this.tag_listView);
            this.splitContainer2.Size = new System.Drawing.Size(1008, 212);
            this.splitContainer2.SplitterDistance = 369;
            this.splitContainer2.SplitterWidth = 2;
            this.splitContainer2.TabIndex = 0;
            // 
            // thumbPicture
            // 
            this.thumbPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.thumbPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.thumbPicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.thumbPicture.Location = new System.Drawing.Point(94, 2);
            this.thumbPicture.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.thumbPicture.Name = "thumbPicture";
            this.thumbPicture.Size = new System.Drawing.Size(252, 206);
            this.thumbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.thumbPicture.TabIndex = 0;
            this.thumbPicture.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_openPath);
            this.panel1.Controls.Add(this.btn_addTag);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 36);
            this.panel1.TabIndex = 0;
            // 
            // btn_openPath
            // 
            this.btn_openPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_openPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(59)))));
            this.btn_openPath.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_openPath.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_openPath.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_openPath.Location = new System.Drawing.Point(470, 0);
            this.btn_openPath.Name = "btn_openPath";
            this.btn_openPath.Size = new System.Drawing.Size(115, 25);
            this.btn_openPath.TabIndex = 2;
            this.btn_openPath.Text = "打开所在文件夹";
            this.btn_openPath.UseVisualStyleBackColor = false;
            this.btn_openPath.Click += new System.EventHandler(this.btn_openPath_Click);
            // 
            // btn_addTag
            // 
            this.btn_addTag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addTag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(59)))));
            this.btn_addTag.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_addTag.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_addTag.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_addTag.Location = new System.Drawing.Point(381, 0);
            this.btn_addTag.Name = "btn_addTag";
            this.btn_addTag.Size = new System.Drawing.Size(83, 25);
            this.btn_addTag.TabIndex = 1;
            this.btn_addTag.Text = "增加标签";
            this.btn_addTag.UseVisualStyleBackColor = false;
            this.btn_addTag.Click += new System.EventHandler(this.btn_addTag_Click);
            // 
            // tag_listView
            // 
            this.tag_listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tag_listView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(64)))));
            this.tag_listView.ForeColor = System.Drawing.SystemColors.Info;
            this.tag_listView.Location = new System.Drawing.Point(39, 29);
            this.tag_listView.Name = "tag_listView";
            this.tag_listView.Size = new System.Drawing.Size(546, 145);
            this.tag_listView.TabIndex = 0;
            this.tag_listView.UseCompatibleStateImageBehavior = false;
            this.tag_listView.View = System.Windows.Forms.View.SmallIcon;
            this.tag_listView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tag_listView_MouseDown);
            // 
            // filepanel
            // 
            this.filepanel.AutoScroll = true;
            this.filepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(83)))), ((int)(((byte)(91)))));
            this.filepanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filepanel.Location = new System.Drawing.Point(0, 0);
            this.filepanel.Name = "filepanel";
            this.filepanel.Size = new System.Drawing.Size(1008, 369);
            this.filepanel.TabIndex = 0;
            // 
            // pageSelect
            // 
            this.pageSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pageSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(192)))), ((int)(((byte)(211)))));
            this.pageSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pageSelect.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pageSelect.FormattingEnabled = true;
            this.pageSelect.Location = new System.Drawing.Point(527, 3);
            this.pageSelect.MaxDropDownItems = 100;
            this.pageSelect.Name = "pageSelect";
            this.pageSelect.Size = new System.Drawing.Size(102, 24);
            this.pageSelect.TabIndex = 2;
            this.pageSelect.SelectedIndexChanged += new System.EventHandler(this.pageSelect_SelectedIndexChanged);
            // 
            // btn_nextPage
            // 
            this.btn_nextPage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_nextPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(59)))));
            this.btn_nextPage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_nextPage.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_nextPage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_nextPage.Location = new System.Drawing.Point(635, 3);
            this.btn_nextPage.Name = "btn_nextPage";
            this.btn_nextPage.Size = new System.Drawing.Size(128, 23);
            this.btn_nextPage.TabIndex = 1;
            this.btn_nextPage.Text = "下一页";
            this.btn_nextPage.UseVisualStyleBackColor = false;
            this.btn_nextPage.Click += new System.EventHandler(this.btn_nextPage_Click);
            // 
            // btn_previousPage
            // 
            this.btn_previousPage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_previousPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(59)))));
            this.btn_previousPage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_previousPage.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_previousPage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_previousPage.Location = new System.Drawing.Point(393, 3);
            this.btn_previousPage.Name = "btn_previousPage";
            this.btn_previousPage.Size = new System.Drawing.Size(128, 23);
            this.btn_previousPage.TabIndex = 0;
            this.btn_previousPage.Text = "上一页";
            this.btn_previousPage.UseVisualStyleBackColor = false;
            this.btn_previousPage.Click += new System.EventHandler(this.btn_previousPage_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(83)))), ((int)(((byte)(91)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pageSelect);
            this.panel3.Controls.Add(this.btn_nextPage);
            this.panel3.Controls.Add(this.label_FormTo);
            this.panel3.Controls.Add(this.btn_previousPage);
            this.panel3.Controls.Add(this.label_fileCount);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 581);
            this.panel3.MaximumSize = new System.Drawing.Size(9999, 30);
            this.panel3.MinimumSize = new System.Drawing.Size(2, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1008, 30);
            this.panel3.TabIndex = 1;
            // 
            // label_FormTo
            // 
            this.label_FormTo.AutoSize = true;
            this.label_FormTo.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_FormTo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_FormTo.Location = new System.Drawing.Point(151, 5);
            this.label_FormTo.Name = "label_FormTo";
            this.label_FormTo.Size = new System.Drawing.Size(45, 19);
            this.label_FormTo.TabIndex = 1;
            this.label_FormTo.Text = "label2";
            // 
            // label_fileCount
            // 
            this.label_fileCount.AutoSize = true;
            this.label_fileCount.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_fileCount.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_fileCount.Location = new System.Drawing.Point(25, 5);
            this.label_fileCount.Name = "label_fileCount";
            this.label_fileCount.Size = new System.Drawing.Size(45, 19);
            this.label_fileCount.TabIndex = 0;
            this.label_fileCount.Text = "label1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除此标签ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 26);
            // 
            // 删除此标签ToolStripMenuItem
            // 
            this.删除此标签ToolStripMenuItem.Name = "删除此标签ToolStripMenuItem";
            this.删除此标签ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.删除此标签ToolStripMenuItem.Text = "删除此标签";
            this.删除此标签ToolStripMenuItem.Click += new System.EventHandler(this.删除此标签ToolStripMenuItem_Click);
            // 
            // folderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1008, 611);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("华文中宋", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "folderView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "folderView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.folderView_FormClosing);
            this.Load += new System.EventHandler(this.folderView_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.thumbPicture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox thumbPicture;
        private System.Windows.Forms.Panel filepanel;
        private System.Windows.Forms.ComboBox pageSelect;
        private System.Windows.Forms.Button btn_nextPage;
        private System.Windows.Forms.Button btn_previousPage;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label_FormTo;
        private System.Windows.Forms.Label label_fileCount;
        private System.Windows.Forms.Button btn_addTag;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除此标签ToolStripMenuItem;
        private System.Windows.Forms.ListView tag_listView;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_openPath;
    }
}