namespace TagManager.form
{
    partial class imgForm
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
            this.TopBar_panel = new System.Windows.Forms.Panel();
            this.title_textBox = new System.Windows.Forms.TextBox();
            this.page_label = new System.Windows.Forms.Label();
            this.btn_nextpage = new System.Windows.Forms.Button();
            this.btn_previouspage = new System.Windows.Forms.Button();
            this.Bottom_panel = new System.Windows.Forms.Panel();
            this.page_label_bottom = new System.Windows.Forms.Label();
            this.btn_nextpage_bottom = new System.Windows.Forms.Button();
            this.btn_previouspage_bottom = new System.Windows.Forms.Button();
            this.back_panel = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.TopBar_panel.SuspendLayout();
            this.Bottom_panel.SuspendLayout();
            this.back_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TopBar_panel
            // 
            this.TopBar_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(83)))), ((int)(((byte)(91)))));
            this.TopBar_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TopBar_panel.Controls.Add(this.title_textBox);
            this.TopBar_panel.Controls.Add(this.page_label);
            this.TopBar_panel.Controls.Add(this.btn_nextpage);
            this.TopBar_panel.Controls.Add(this.btn_previouspage);
            this.TopBar_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBar_panel.Location = new System.Drawing.Point(1, 1);
            this.TopBar_panel.MaximumSize = new System.Drawing.Size(4096, 80);
            this.TopBar_panel.Name = "TopBar_panel";
            this.TopBar_panel.Size = new System.Drawing.Size(957, 80);
            this.TopBar_panel.TabIndex = 0;
            // 
            // title_textBox
            // 
            this.title_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(83)))), ((int)(((byte)(91)))));
            this.title_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.title_textBox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title_textBox.ForeColor = System.Drawing.SystemColors.Info;
            this.title_textBox.Location = new System.Drawing.Point(0, 17);
            this.title_textBox.Name = "title_textBox";
            this.title_textBox.ReadOnly = true;
            this.title_textBox.Size = new System.Drawing.Size(958, 19);
            this.title_textBox.TabIndex = 4;
            this.title_textBox.Text = "[siokoujiRobot] tagManager (DL)";
            this.title_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // page_label
            // 
            this.page_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.page_label.AutoSize = true;
            this.page_label.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.page_label.ForeColor = System.Drawing.SystemColors.Info;
            this.page_label.Location = new System.Drawing.Point(452, 49);
            this.page_label.Name = "page_label";
            this.page_label.Size = new System.Drawing.Size(47, 14);
            this.page_label.TabIndex = 3;
            this.page_label.Text = "20/20";
            // 
            // btn_nextpage
            // 
            this.btn_nextpage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_nextpage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(59)))));
            this.btn_nextpage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_nextpage.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_nextpage.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_nextpage.Location = new System.Drawing.Point(547, 44);
            this.btn_nextpage.Name = "btn_nextpage";
            this.btn_nextpage.Size = new System.Drawing.Size(75, 23);
            this.btn_nextpage.TabIndex = 2;
            this.btn_nextpage.Text = "下一页";
            this.btn_nextpage.UseVisualStyleBackColor = false;
            this.btn_nextpage.Click += new System.EventHandler(this.btn_nextpage_Click);
            // 
            // btn_previouspage
            // 
            this.btn_previouspage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_previouspage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(59)))));
            this.btn_previouspage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_previouspage.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_previouspage.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_previouspage.Location = new System.Drawing.Point(323, 44);
            this.btn_previouspage.Name = "btn_previouspage";
            this.btn_previouspage.Size = new System.Drawing.Size(75, 23);
            this.btn_previouspage.TabIndex = 1;
            this.btn_previouspage.Text = "上一页";
            this.btn_previouspage.UseVisualStyleBackColor = false;
            this.btn_previouspage.Click += new System.EventHandler(this.btn_previouspage_Click);
            // 
            // Bottom_panel
            // 
            this.Bottom_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(83)))), ((int)(((byte)(91)))));
            this.Bottom_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bottom_panel.Controls.Add(this.page_label_bottom);
            this.Bottom_panel.Controls.Add(this.btn_nextpage_bottom);
            this.Bottom_panel.Controls.Add(this.btn_previouspage_bottom);
            this.Bottom_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Bottom_panel.Location = new System.Drawing.Point(1, 463);
            this.Bottom_panel.MaximumSize = new System.Drawing.Size(4096, 80);
            this.Bottom_panel.MinimumSize = new System.Drawing.Size(2, 80);
            this.Bottom_panel.Name = "Bottom_panel";
            this.Bottom_panel.Size = new System.Drawing.Size(957, 80);
            this.Bottom_panel.TabIndex = 1;
            // 
            // page_label_bottom
            // 
            this.page_label_bottom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.page_label_bottom.AutoSize = true;
            this.page_label_bottom.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.page_label_bottom.ForeColor = System.Drawing.SystemColors.Info;
            this.page_label_bottom.Location = new System.Drawing.Point(452, 21);
            this.page_label_bottom.Name = "page_label_bottom";
            this.page_label_bottom.Size = new System.Drawing.Size(47, 14);
            this.page_label_bottom.TabIndex = 6;
            this.page_label_bottom.Text = "20/20";
            // 
            // btn_nextpage_bottom
            // 
            this.btn_nextpage_bottom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_nextpage_bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(59)))));
            this.btn_nextpage_bottom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_nextpage_bottom.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_nextpage_bottom.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_nextpage_bottom.Location = new System.Drawing.Point(547, 16);
            this.btn_nextpage_bottom.Name = "btn_nextpage_bottom";
            this.btn_nextpage_bottom.Size = new System.Drawing.Size(75, 23);
            this.btn_nextpage_bottom.TabIndex = 5;
            this.btn_nextpage_bottom.Text = "下一页";
            this.btn_nextpage_bottom.UseVisualStyleBackColor = false;
            this.btn_nextpage_bottom.Click += new System.EventHandler(this.btn_nextpage_bottom_Click);
            // 
            // btn_previouspage_bottom
            // 
            this.btn_previouspage_bottom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_previouspage_bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(59)))));
            this.btn_previouspage_bottom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_previouspage_bottom.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_previouspage_bottom.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_previouspage_bottom.Location = new System.Drawing.Point(323, 16);
            this.btn_previouspage_bottom.Name = "btn_previouspage_bottom";
            this.btn_previouspage_bottom.Size = new System.Drawing.Size(75, 23);
            this.btn_previouspage_bottom.TabIndex = 4;
            this.btn_previouspage_bottom.Text = "上一页";
            this.btn_previouspage_bottom.UseVisualStyleBackColor = false;
            this.btn_previouspage_bottom.Click += new System.EventHandler(this.btn_previouspage_bottom_Click);
            // 
            // back_panel
            // 
            this.back_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.back_panel.AutoScroll = true;
            this.back_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(64)))));
            this.back_panel.Controls.Add(this.pictureBox);
            this.back_panel.Controls.Add(this.Bottom_panel);
            this.back_panel.Controls.Add(this.TopBar_panel);
            this.back_panel.Location = new System.Drawing.Point(0, 0);
            this.back_panel.Name = "back_panel";
            this.back_panel.Padding = new System.Windows.Forms.Padding(1);
            this.back_panel.Size = new System.Drawing.Size(959, 523);
            this.back_panel.TabIndex = 3;
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox.Location = new System.Drawing.Point(0, 84);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(959, 380);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // imgForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(83)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(959, 523);
            this.Controls.Add(this.back_panel);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "imgForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "图片查看";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.imgForm_Load);
            this.SizeChanged += new System.EventHandler(this.imgForm_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.imgForm_Paint);
            this.TopBar_panel.ResumeLayout(false);
            this.TopBar_panel.PerformLayout();
            this.Bottom_panel.ResumeLayout(false);
            this.Bottom_panel.PerformLayout();
            this.back_panel.ResumeLayout(false);
            this.back_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopBar_panel;
        private System.Windows.Forms.Panel Bottom_panel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label page_label;
        private System.Windows.Forms.Button btn_nextpage;
        private System.Windows.Forms.Button btn_previouspage;
        private System.Windows.Forms.Label page_label_bottom;
        private System.Windows.Forms.Button btn_nextpage_bottom;
        private System.Windows.Forms.Button btn_previouspage_bottom;
        private System.Windows.Forms.Panel back_panel;
        private System.Windows.Forms.TextBox title_textBox;
    }
}