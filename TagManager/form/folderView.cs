using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Threading;
using System.Drawing.Imaging;
//------------------------------------------------------------
//文件夹类信息浏览窗口
//构造函数获取一个Folder类
//实现在一个窗体内通过翻页查看该Folder类下所有图片文件的功能
//------------------------------------------------------------
namespace TagManager
{
    public partial class folderView : Form
    {
        private Folder folder;//被打开的文件夹类
        private TableLayoutPanel tabPanel = new TableLayoutPanel();//实例化一个tablelayoutpanel对象，
        private ArrayList imglist = new ArrayList();//存放图片的Fullname
        private int maxshow = 50;//设定每一页可显示的图片的最大值
        private int maxPage;//此文件夹最大的页数

        //------------------------------
        //制作略缩图要使用的变量
        //private string ErrMessage;
        //private Image ResourceImage;
        //private int ImageWidth;
        //private int ImageHeight;
        //------------------------------
        public folderView()
        {
            InitializeComponent();
        }
        public folderView(Folder f) : this() {
            this.folder = f;
        }
        //载入该窗体,并制作该文件夹下的图片的imglist数组
        private void folderView_Load(object sender, EventArgs e)
        {            
            this.Text = folder.folderName;
            DirectoryInfo dir = new DirectoryInfo(folder.path + "\\" + folder.folderName);
            FileInfo[] file = dir.GetFiles();
            //只提取png，bmp和jpg文件，制作成imglist
            foreach (FileInfo nextFile in file){
                if (nextFile.Extension.Equals(".jpg") || nextFile.Extension.Equals(".png") || nextFile.Extension.Equals(".bmp")){
                    imglist.Add(nextFile.FullName);
                }
            }
            taglistview_refresh();//重绘tag_listview控件
            //--------------------------------------
            if (imglist.Count == 0) {
                return;
            } 
            showFirstImage(file);//调用函数显示第一张图片            
            //设置该文件夹下最大的页数
            if (imglist.Count % maxshow == 0)
                maxPage = imglist.Count / maxshow;
            else{
                maxPage = (imglist.Count / maxshow) + 1;
            }
            for (int i = 1; i < maxPage+1; i++) {
                string str = "第" + i + "页";
                pageSelect.Items.Add(str);
            }           
            pageSelect.SelectedIndex = 0;
        }
        //搜索文件夹下第一张图片文件并将其显示在thumbPicture上
        private void showFirstImage(FileInfo[] tag) {            
            foreach (FileInfo nextFile in tag){
                if (nextFile.Extension.Equals(".jpg") || nextFile.Extension.Equals(".png") || nextFile.Extension.Equals(".bmp")){
                    thumbPicture.Load(nextFile.FullName);
                    break;
                }
            }
        }
        //完成filepanel中组件的定义
        private void initFilePanel(int thisRow)
        {
            #region 释放非托管对象对内存的占用
            foreach (System.Windows.Forms.Control nextobj in tabPanel.Controls)
            {
                if (nextobj.Name == "btn_previousPage" || nextobj.Name == "btn_nextPage" || nextobj.Name == "pageSelect")
                    continue;
                nextobj.Dispose();
            }        
            tabPanel.Controls.Clear();
            tabPanel.RowStyles.Clear();
            tabPanel.ColumnStyles.Clear();
            tabPanel = null;
            filepanel.Controls.Clear(); 
            System.GC.Collect();
            tabPanel = new TableLayoutPanel();
            #endregion

            #region folderView窗体中filepanel的定义            
            tabPanel.ColumnCount = 5;
            tabPanel.RowCount = thisRow;
            tabPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tabPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tabPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tabPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tabPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tabPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            tabPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            tabPanel.AutoScroll = true;
            tabPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            for (int i = 0; i < thisRow; i++){//以thisrow为依据添加相应的行，行高150像素
                tabPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            }         
            filepanel.Controls.Add(tabPanel);
            #endregion       
    
        }
        //显示该页的tablelayout，maxshow为一页包含多少项
        private void showPage(int page)
        {
            #region 计算本页面显示的图片索引
            int startIndex = (page - 1) * maxshow;
            int lastIndex = startIndex + maxshow - 1;
            if (lastIndex > imglist.Count - 1)
                lastIndex = imglist.Count - 1;
            int thisPageRow;
            if ((lastIndex - startIndex + 1) % 5 == 0)
                thisPageRow = (lastIndex - startIndex + 1) / 5;
            else
                thisPageRow = ((lastIndex - startIndex) / 5) + 1;
            #endregion 

            loadingForm l = new loadingForm();
            l.Show();
            Application.DoEvents();

            initFilePanel(thisPageRow);//调用函数对FilePanel进行绘制

            //两个label中的信息更新-----------------------------------
            label_fileCount.Text = "共有 " + imglist.Count + " 张图片";
            label_FormTo.Text = "从第 "+ (startIndex+1) +" 项到第 " + (lastIndex+1) + " 项";

            //进行分页，避免一次性载入所有图像带来卡顿以及内存不足----
            int count = startIndex;
            for (int r = 0; r < thisPageRow; r++){
                for (int c = 0; c < 5; c++){
                    if (count == lastIndex+1)
                        break;
                    PictureBox pBox = new PictureBox();
                    //------------------------------------------------------------
                    //制作略缩图的几个方法，有待使用
                    //ResourceImage = Image.FromFile(imglist[count].ToString());
                    //Image im = GetReducedImage(20);
                    //ResourceImage = GetReducedImage(20);                 
                    //pBox.Image = im;
                    //------------------------------------------------------------
                    pBox.Load(imglist[count].ToString());
                    pBox.Tag = count;
                    pBox.Cursor = System.Windows.Forms.Cursors.Hand;
                    pBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                    pBox.Dock = System.Windows.Forms.DockStyle.Fill;
                    pBox.Click += new System.EventHandler(tab_Click);
                    tabPanel.Controls.Add(pBox, c, r);
                    count++;
                }                
            }
            

            l.Close();
            l.Dispose();

            System.GC.Collect();
        }
        //tablayout中的图片的点击事件
        private void tab_Click(object sender, EventArgs e) {
            TagManager.form.imgForm imgform = new form.imgForm(imglist,
                this.Text.ToString(),
                Convert.ToInt32( (sender as PictureBox).Tag.ToString() ));
            imgform.ShowDialog();
        }
        //上一页按钮的点击事件
        private void btn_previousPage_Click(object sender, EventArgs e)
        {
            if (pageSelect.SelectedIndex == 0)
                return;
            pageSelect.SelectedIndex--;
        }
        //下一页按钮的点击事件
        private void btn_nextPage_Click(object sender, EventArgs e)
        {
            if (pageSelect.SelectedIndex+1==maxPage)
                return;
            pageSelect.SelectedIndex++;
        }
        //下拉框选项修改时进行翻页操作
        private void pageSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            int page = pageSelect.SelectedIndex + 1;
            showPage(page);
        }
        //重绘tag_listView控件
        private void taglistview_refresh() {
            tag_listView.Items.Clear();
            this.tag_listView.BeginUpdate();
            foreach (string nextStr in folder.tagArray) {
                ListViewItem item = new ListViewItem();
                item.Text = nextStr;
                item.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                this.tag_listView.Items.Add(item);
            }            
            this.tag_listView.EndUpdate();
        }
        //窗体关闭时进行内存清理
        private void folderView_FormClosing(object sender, FormClosingEventArgs e)
        {
            tabPanel.Dispose();
            this.Dispose();
            System.GC.Collect();
        }
        //添加一个标签到该folder，并更新tag_listView控件
        private void btn_addTag_Click(object sender, EventArgs e)
        {
            inputForm form = new inputForm(folder);
            form.ShowDialog();
            form.Dispose();
            //此处需要添加函数来重绘tag_listView
            taglistview_refresh();
        }
        //在tag_listView上右击标签，显示菜单
        private void tag_listView_MouseDown(object sender, MouseEventArgs e)
        {
            Point point = new Point(e.X, e.Y);
            if (e.Button == MouseButtons.Right)
            {
                ListViewItem item = tag_listView.GetItemAt(e.X, e.Y);
                if (item!=null){
                    this.contextMenuStrip1.Show(this.tag_listView, point);
                }
            }
        }
        
        #region 略缩图制作方法
        ///// <summary>   
        ///// 生成缩略图重载方法1，返回缩略图的Image对象   
        ///// </summary>   
        ///// <param name="width">缩略图的宽度   
        ///// <param name="height">缩略图的高度   
        ///// <returns>缩略图的Image对象</returns>   
        //public Image GetReducedImage(int Width, int Height)
        //{
        //    try
        //    {
        //        Image ReducedImage;

        //        Image.GetThumbnailImageAbort callb = new Image.GetThumbnailImageAbort(ThumbnailCallback);

        //        ReducedImage = ResourceImage.GetThumbnailImage(Width, Height, callb, IntPtr.Zero);

        //        return ReducedImage;
        //    }
        //    catch (Exception e)
        //    {
        //        ErrMessage = e.Message;
        //        return null;
        //    }
        //}
        ///// <summary>   
        ///// 生成缩略图重载方法3，返回缩略图的Image对象   
        ///// </summary>   
        ///// <param name="percent">缩略图的宽度百分比 如：需要百分之80，就填0.8     
        ///// <returns>缩略图的Image对象</returns>   
        //public Image GetReducedImage(double Percent)
        //{
        //    try
        //    {
        //        Image ReducedImage;

        //        Image.GetThumbnailImageAbort callb = new Image.GetThumbnailImageAbort(ThumbnailCallback);

        //        ImageWidth = Convert.ToInt32(ResourceImage.Width * Percent);
        //        ImageHeight = Convert.ToInt32(ResourceImage.Width * Percent);

        //        ReducedImage = ResourceImage.GetThumbnailImage(ImageWidth, ImageHeight, callb, IntPtr.Zero);

        //        return ReducedImage;
        //    }
        //    catch (Exception e)
        //    {
        //        ErrMessage = e.Message;
        //        return null;
        //    }
        //}
        //public bool ThumbnailCallback()
        //{
        //    return false;
        //}
        #endregion 

        private void 删除此标签ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string str = tag_listView.SelectedItems[0].Text;
            folder.tagDel(str);
            taglistview_refresh();
        }

        private void btn_openPath_Click(object sender, EventArgs e)
        {
            string pathStr = folder.path + "\\" + folder.folderName;
            System.Diagnostics.Process.Start("explorer.exe", pathStr);
        }
    }
}
