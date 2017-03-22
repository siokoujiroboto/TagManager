using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TagManager.form
{
    public partial class imgForm : Form
    {
        private ArrayList imglist = null;
        private String titleStr = null;
        private int showPage = 0;

        public imgForm()
        {
            InitializeComponent();
        }
        public imgForm(ArrayList imglist, String title, int showPage) : this(){
            this.imglist = imglist;
            this.titleStr = title;
            this.showPage = showPage;
        }
        //翻到上一页操作
        private void previousPage(){
            if (showPage == 0)
                return;
            showPage--;
            refreshForm();
        }
        //翻到下一页操作
        private void nextPage(){
            if (showPage == imglist.Count - 1)
                return;
            showPage++;
            refreshForm();
        }
        //对窗体控件进行重绘
        private void refreshForm(){
            String strPage = (showPage + 1) + "/" + imglist.Count;
            page_label.Text = strPage;
            page_label_bottom.Text = strPage;

            //Bitmap bmp = new Bitmap(imglist[showPage].ToString());

            //panel1.Size = bmp.Size;
            //pictureBox.BackgroundImage = bmp;
            pictureBox.Load(imglist[showPage].ToString());
            pictureBox.Width = pictureBox.Image.Width;
            pictureBox.Height = pictureBox.Image.Height;

            back_panel.VerticalScroll.Value = 0;

            object sender = new object();
            EventArgs e = new EventArgs();
            imgForm_SizeChanged(sender,e);
        }
        private void imgForm_Load(object sender, EventArgs e)
        {
            title_textBox.Text = titleStr;
            refreshForm();
            
        }

        #region 四个按钮以及picturebox的点击事件
        private void btn_previouspage_Click(object sender, EventArgs e)
        {
            previousPage();
        }

        private void btn_previouspage_bottom_Click(object sender, EventArgs e)
        {
            previousPage();
        }

        private void btn_nextpage_Click(object sender, EventArgs e)
        {
            nextPage();
        }

        private void btn_nextpage_bottom_Click(object sender, EventArgs e)
        {
            nextPage();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            nextPage();
        }
        #endregion

        private void imgForm_SizeChanged(object sender, EventArgs e)
        {
            //pictureBox.Location.X = //(this.Size.Width - pictureBox.Size.Width) / 2;
            pictureBox.SetBounds((this.Size.Width - pictureBox.Size.Width) / 2, TopBar_panel.Height + 8, 
                pictureBox.Width, pictureBox.Height);
            Bottom_panel.SetBounds(0, TopBar_panel.Height + pictureBox.Height + 16,
                Bottom_panel.Width, Bottom_panel.Height);
        }

        private void imgForm_Paint(object sender, PaintEventArgs e)
        {
            refreshForm();
        }

    }
}
