namespace TagManager
{
    partial class mainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TagCountLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Tag_listBox = new System.Windows.Forms.ListBox();
            this.Tag_label = new System.Windows.Forms.Label();
            this.FolderCountLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Folder_listBox = new System.Windows.Forms.ListBox();
            this.Folder_label = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.查看详细信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加标签ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开文件夹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_help = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_setRootPath = new System.Windows.Forms.Button();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 29);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(168)))));
            this.splitContainer1.Panel1.Controls.Add(this.TagCountLabel);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.Tag_label);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(168)))));
            this.splitContainer1.Panel2.Controls.Add(this.FolderCountLabel);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.Folder_label);
            this.splitContainer1.Size = new System.Drawing.Size(1008, 632);
            this.splitContainer1.SplitterDistance = 222;
            this.splitContainer1.TabIndex = 1;
            // 
            // TagCountLabel
            // 
            this.TagCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TagCountLabel.AutoSize = true;
            this.TagCountLabel.Location = new System.Drawing.Point(14, 606);
            this.TagCountLabel.Name = "TagCountLabel";
            this.TagCountLabel.Size = new System.Drawing.Size(89, 12);
            this.TagCountLabel.TabIndex = 2;
            this.TagCountLabel.Text = "共有    项标签";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.Tag_listBox);
            this.panel2.Location = new System.Drawing.Point(16, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 563);
            this.panel2.TabIndex = 1;
            // 
            // Tag_listBox
            // 
            this.Tag_listBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(229)))), ((int)(((byte)(248)))));
            this.Tag_listBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tag_listBox.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tag_listBox.FormattingEnabled = true;
            this.Tag_listBox.ItemHeight = 20;
            this.Tag_listBox.Location = new System.Drawing.Point(0, 0);
            this.Tag_listBox.Name = "Tag_listBox";
            this.Tag_listBox.Size = new System.Drawing.Size(188, 563);
            this.Tag_listBox.TabIndex = 1;
            this.Tag_listBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Tag_listBox_MouseDown);
            // 
            // Tag_label
            // 
            this.Tag_label.AutoSize = true;
            this.Tag_label.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tag_label.Location = new System.Drawing.Point(12, 12);
            this.Tag_label.Name = "Tag_label";
            this.Tag_label.Size = new System.Drawing.Size(41, 19);
            this.Tag_label.TabIndex = 0;
            this.Tag_label.Text = "标签";
            // 
            // FolderCountLabel
            // 
            this.FolderCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FolderCountLabel.AutoSize = true;
            this.FolderCountLabel.Location = new System.Drawing.Point(16, 606);
            this.FolderCountLabel.Name = "FolderCountLabel";
            this.FolderCountLabel.Size = new System.Drawing.Size(53, 12);
            this.FolderCountLabel.TabIndex = 3;
            this.FolderCountLabel.Text = "项文件夹";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.Folder_listBox);
            this.panel1.Location = new System.Drawing.Point(18, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 563);
            this.panel1.TabIndex = 2;
            // 
            // Folder_listBox
            // 
            this.Folder_listBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(229)))), ((int)(((byte)(248)))));
            this.Folder_listBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Folder_listBox.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.Folder_listBox.FormattingEnabled = true;
            this.Folder_listBox.HorizontalScrollbar = true;
            this.Folder_listBox.ItemHeight = 20;
            this.Folder_listBox.Location = new System.Drawing.Point(0, 0);
            this.Folder_listBox.Name = "Folder_listBox";
            this.Folder_listBox.Size = new System.Drawing.Size(741, 563);
            this.Folder_listBox.TabIndex = 2;
            this.Folder_listBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Folder_listBox_MouseDoubleClick);
            this.Folder_listBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Folder_listBox_MouseDown);
            // 
            // Folder_label
            // 
            this.Folder_label.AutoSize = true;
            this.Folder_label.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Folder_label.Location = new System.Drawing.Point(14, 12);
            this.Folder_label.Name = "Folder_label";
            this.Folder_label.Size = new System.Drawing.Size(57, 19);
            this.Folder_label.TabIndex = 0;
            this.Folder_label.Text = "文件夹";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看详细信息ToolStripMenuItem,
            this.添加标签ToolStripMenuItem,
            this.打开文件夹ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 70);
            // 
            // 查看详细信息ToolStripMenuItem
            // 
            this.查看详细信息ToolStripMenuItem.Name = "查看详细信息ToolStripMenuItem";
            this.查看详细信息ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.查看详细信息ToolStripMenuItem.Text = "查看详细信息";
            this.查看详细信息ToolStripMenuItem.Click += new System.EventHandler(this.查看详细信息ToolStripMenuItem_Click);
            // 
            // 添加标签ToolStripMenuItem
            // 
            this.添加标签ToolStripMenuItem.Name = "添加标签ToolStripMenuItem";
            this.添加标签ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.添加标签ToolStripMenuItem.Text = "添加标签";
            this.添加标签ToolStripMenuItem.Click += new System.EventHandler(this.添加标签ToolStripMenuItem_Click);
            // 
            // 打开文件夹ToolStripMenuItem
            // 
            this.打开文件夹ToolStripMenuItem.Name = "打开文件夹ToolStripMenuItem";
            this.打开文件夹ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.打开文件夹ToolStripMenuItem.Text = "打开文件夹";
            this.打开文件夹ToolStripMenuItem.Click += new System.EventHandler(this.打开文件夹ToolStripMenuItem_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(114)))), ((int)(((byte)(129)))));
            this.panel3.Controls.Add(this.btn_help);
            this.panel3.Controls.Add(this.btn_search);
            this.panel3.Controls.Add(this.btn_refresh);
            this.panel3.Controls.Add(this.btn_setRootPath);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.MaximumSize = new System.Drawing.Size(0, 30);
            this.panel3.MinimumSize = new System.Drawing.Size(0, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1008, 30);
            this.panel3.TabIndex = 2;
            // 
            // btn_help
            // 
            this.btn_help.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(192)))), ((int)(((byte)(211)))));
            this.btn_help.Location = new System.Drawing.Point(271, 3);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(79, 27);
            this.btn_help.TabIndex = 7;
            this.btn_help.Text = "   帮助";
            this.btn_help.UseVisualStyleBackColor = false;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(192)))), ((int)(((byte)(211)))));
            this.btn_search.Location = new System.Drawing.Point(186, 3);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(79, 27);
            this.btn_search.TabIndex = 6;
            this.btn_search.Text = "   搜索";
            this.btn_search.UseVisualStyleBackColor = false;
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(192)))), ((int)(((byte)(211)))));
            this.btn_refresh.Location = new System.Drawing.Point(101, 3);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(79, 27);
            this.btn_refresh.TabIndex = 5;
            this.btn_refresh.Text = "   刷新目录";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_setRootPath
            // 
            this.btn_setRootPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(192)))), ((int)(((byte)(211)))));
            this.btn_setRootPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_setRootPath.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_setRootPath.Location = new System.Drawing.Point(16, 3);
            this.btn_setRootPath.Name = "btn_setRootPath";
            this.btn_setRootPath.Size = new System.Drawing.Size(79, 27);
            this.btn_setRootPath.TabIndex = 4;
            this.btn_setRootPath.Text = "   选择目录";
            this.btn_setRootPath.UseVisualStyleBackColor = false;
            this.btn_setRootPath.Click += new System.EventHandler(this.btn_setRootPath_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 661);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TagManager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label Tag_label;
        private System.Windows.Forms.Label Folder_label;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 添加标签ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开文件夹ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看详细信息ToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox Folder_listBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox Tag_listBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label TagCountLabel;
        private System.Windows.Forms.Label FolderCountLabel;
        private System.Windows.Forms.Button btn_setRootPath;
        private System.Windows.Forms.Button btn_help;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_refresh;
    }
}

