using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Security.AccessControl;
//----------------------------------------------------------
//程序的主窗口及入口
//主要负责遍历选择的根目录及制作对应的tagArray和FolderArray
//以中心式分布，调用代码启用其他子窗口并传入参数
//----------------------------------------------------------
namespace TagManager
{
    public partial class mainForm : Form
    {
        public ArrayList FolderArray = new ArrayList();
        public ArrayList tagArray = new ArrayList();

        private String path = "";
        public mainForm()
        {
            InitializeComponent();           
        }
        //打开一个资源管理器，从中选择操作根目录
        private void btn_setRootPath_Click(object sender, EventArgs e)
        {            
            FolderBrowserDialog openFile = new FolderBrowserDialog();
            openFile.ShowDialog();
            path = openFile.SelectedPath;//被选中的目录路径赋给path
            openFile.Dispose();
            if (path.Length==0)
                return;
            try
            {
                loadingForm l = new loadingForm();
                l.Show();
                Application.DoEvents();

                DirectoryInfo rootPath = new DirectoryInfo(path);
                initArray(path, rootPath);
                showTwoListBox();

                l.Close();
                l.Dispose();
            }
            catch (Exception ex) { }
        }
        //显示一个消息框，要求输入一个字符串作为标签
        private void 添加标签ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = Folder_listBox.SelectedIndex;
            inputForm form = new inputForm((Folder)FolderArray[i]);
            form.ShowDialog();
            form.Dispose();
        }
        //将被选中的项取出并传进folderView中，folderView为ShowDialog
        private void 查看详细信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = Folder_listBox.SelectedIndex;
            folderView form = new folderView((Folder)this.FolderArray[i]);
            form.ShowDialog();
            form.Dispose();
            System.GC.Collect();
        }
        //右键选定Folder_listBox中的项并弹出菜单
        private void Folder_listBox_MouseDown(object sender, MouseEventArgs e)
        {
            Point point = new Point(e.X, e.Y);
            if (e.Button == MouseButtons.Right){
                int posindex = Folder_listBox.IndexFromPoint(point);
                if (posindex == -1)
                    return;
                Folder_listBox.SelectedIndex = posindex;                
                this.contextMenuStrip1.Show(this.Folder_listBox, point);
            }
        }
        //选定Tag_listBox中的元素并在右方Folder_listBox中显示对应的Folder类
        private void Tag_listBox_MouseDown(object sender, MouseEventArgs e)
        {            
            Point point = new Point(e.X, e.Y);
            if (e.Button == MouseButtons.Left) {
                int posindex = Tag_listBox.IndexFromPoint(point);
                if (posindex == -1)
                    return;               
                Tag_listBox.SelectedIndex = posindex;
                Tag t = (Tag)tagArray[posindex];
                Folder_listBox.Items.Clear();
                foreach (int nextIndex in t.folderIndex) {
                    Folder f = (Folder)FolderArray[nextIndex];
                    Folder_listBox.Items.Add(f.folderName);
                }
                FolderCountLabel.Text = t.folderIndex.Count + "个项目";
            }
        }
        //初始化tagArray和folderArray数组，
        private void initArray(String path, DirectoryInfo rootPath){
            if (FolderArray.Count != 0)
                FolderArray.Clear();
            if (tagArray.Count != 0)
                tagArray.Clear();//清空两个数组           
            //遍历path下的所有文件夹
            foreach (DirectoryInfo NextFolder in rootPath.GetDirectories()){
                //判别该文件夹是否被系统保护，若是则不创建其相对的folder类
                DirectorySecurity s = new DirectorySecurity(path + "\\" + NextFolder.Name, AccessControlSections.Access);
                if (!s.AreAccessRulesProtected){
                    Folder folder = new Folder(path, NextFolder.Name);
                    FolderArray.Add(folder);
                    //将该Folder类中的所有tag加入tagArray数组中，留待以后进行消除重复的操作
                    foreach (string tag in folder.tagArray){
                        Tag t = new TagManager.Tag(tag);
                        tagArray.Add(t);
                    }
                    folder = null;
                }
            }

            tagArray = RemoveDuplicate_Tag(tagArray);//清除重复元素
            //制作ALLtag类，用于存放所有folder的索引
            Tag t1 = new TagManager.Tag("所有文件夹");
            for (int i = 0; i < FolderArray.Count; i++){
                t1.pushFolder(i);
                Folder f = (Folder)FolderArray[i];//取出当前Folder类
                for (int j = 0; j < tagArray.Count; j++)
                { //将当前Folder类与tagArray数组进行逐个比较，若符合则将其索引加入该Tag类
                    Tag tag = (Tag)tagArray[j];
                    if (f.tagArray.Contains(tag.tagName)){
                        tag.pushFolder(i);
                    }
                }
            }
            tagArray.Insert(0, t1);
            TagCountLabel.Text = "共有 " + tagArray.Count + " 项标签";
            FolderCountLabel.Text = FolderArray.Count + "个项目";
        }
        //将两个array的内容显示至两个listBox中
        private void showTwoListBox() {
            Folder_listBox.Items.Clear();
            Tag_listBox.Items.Clear();
            //往两个listbox中添加项
            foreach (Folder nextFolder in FolderArray){
                Folder_listBox.Items.Add(nextFolder.folderName);
                this.Folder_listBox.Focus();
            }
            foreach (Tag nextTag in tagArray){
                Tag_listBox.Items.Add(nextTag.tagName);
            }
            Tag_listBox.SelectedIndex = 0;
        }
        
        //清除arraylist中重复元素,只能用于Tag类的数组
        private ArrayList RemoveDuplicate_Tag(ArrayList list)
        {
            ArrayList tempArray = new ArrayList();           
            while(list.Count!=0){
                int i = 0;
                Tag obj = (Tag)list[i];
                tempArray.Add(obj);
                string name = obj.tagName;
                while (true) {
                    if (obj.tagName == name){
                        list.Remove(obj);
                        if (i == list.Count)
                            break;
                        obj = (Tag)list[i];
                    }
                    else { 
                        i++;
                        if (i == list.Count)
                            break;
                        obj = (Tag)list[i];
                    }
                }
            }                                
            return tempArray;
        }

        private void 打开文件夹ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = Folder_listBox.SelectedIndex;
            Folder f = (Folder)FolderArray[i];
            string pathStr = f.path + "\\" +f.folderName;
            System.Diagnostics.Process.Start("explorer.exe", pathStr);
        }
        //双击指定项后打开对应folder类的folderView窗体
        private void Folder_listBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Point point = new Point(e.X, e.Y);
            if (e.Button == MouseButtons.Left)
            {
                int posindex = Folder_listBox.IndexFromPoint(point);
                if (posindex == -1)
                    return;
                Folder_listBox.SelectedIndex = posindex;
                folderView form = new folderView((Folder)this.FolderArray[posindex]);
                form.ShowDialog();
                form.Dispose();
                System.GC.Collect();
            }
        }
        //重新获取path下的文件夹与tag信息
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            if (path.Length == 0) {
                MessageBox.Show("未选择根目录","提示");
                return;
            }
            try
            {
                loadingForm l = new loadingForm();
                l.Show();
                Application.DoEvents();

                DirectoryInfo rootPath = new DirectoryInfo(path);
                initArray(path, rootPath);
                showTwoListBox();

                l.Close();
                l.Dispose();
            }
            catch (Exception ex) { }
        }


        private void btn_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("本软件旨在以文件夹为单位通过标签来管理文件夹下的照片\r"+
                            "选择一个根目录文件夹，软件会对该目录下所有一级文件夹进行扫描", "帮助");
        } 
        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {

            System.Environment.Exit(0);
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
