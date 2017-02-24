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

namespace TagManager
{
    public partial class mainForm : Form
    {
        //this.listView1.BeginUpdate(); 
        //this.listView1.EndUpdate(); 
        public ArrayList FolderArray = new ArrayList();
        public ArrayList tagArray = new ArrayList();
        public string tempStr;
        public mainForm()
        {
            InitializeComponent();
        }
        //打开一个资源管理器，从中选择操作根目录
        private void 指定操作根目录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FolderArray.Count != 0)
                FolderArray.Clear();
            if (tagArray.Count != 0)
                tagArray.Clear();//清空两个数组
            FolderBrowserDialog openFile = new FolderBrowserDialog();
            openFile.ShowDialog();
            String path = openFile.SelectedPath;//被选中的目录路径赋给path
            DirectoryInfo rootPath = new DirectoryInfo(path);
            //遍历path下的所有文件夹
            foreach (DirectoryInfo NextFolder in rootPath.GetDirectories()){
                //判别该文件夹是否被系统保护，若是则不创建其相对的folder类
                DirectorySecurity s = new DirectorySecurity(path + "\\" + NextFolder.Name, AccessControlSections.Access);
                if (!s.AreAccessRulesProtected){
                    Folder folder = new Folder(path, NextFolder.Name);
                    FolderArray.Add(folder);
                    //将该Folder类中的所有tag加入tagArray数组中，留待以后进行消除重复的操作
                    foreach (string tag in folder.tagArray) {
                        Tag t = new TagManager.Tag(tag);
                        tagArray.Add(t);
                    }
                    folder = null;
                }
            }
            
            tagArray = RemoveDuplicate_Tag(tagArray);//清除重复元素
            //制作ALLtag类，用于存放所有folder的索引
            Tag t1 = new TagManager.Tag("All");       
            for (int i = 0; i < FolderArray.Count; i++) {
                t1.pushFolder(i);
                Folder f = (Folder)FolderArray[i];//取出当前Folder类
                for (int j = 0; j < tagArray.Count; j++) { //将当前Folder类与tagArray数组进行逐个比较，若符合则将其索引加入该Tag类
                    Tag tag = (Tag)tagArray[j];
                    if (f.tagArray.Contains(tag.tagName)){
                        tag.pushFolder(i);
                    }
                }             
            }
            tagArray.Insert(0, t1);
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
        }
        //测试用按钮，release时需要修改
        private void 关于ToolStripMenuItem1_Click(object sender, EventArgs e)
        {            
        }
        //显示一个消息框，要求输入一个字符串作为标签
        private void 添加标签ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = Folder_listBox.SelectedIndex;
            Folder folder = (Folder)FolderArray[i];            
            new inputForm(this).ShowDialog();
            folder.tagAdd(tempStr);
        }
        //将被选中的项取出并传进folderView中，folderView为ShowDialog
        private void 查看详细信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = Folder_listBox.SelectedIndex;
            new folderView((Folder)this.FolderArray[i]).ShowDialog();
        }
        //右键选定Folder_listBox中的项并弹出菜单
        private void Folder_listBox_MouseDown(object sender, MouseEventArgs e)
        {
            Point point = new Point(e.X, e.Y);
            if (e.Button == MouseButtons.Right){
                int posindex = Folder_listBox.IndexFromPoint(point);
                Folder_listBox.SelectedIndex = posindex;                
                this.contextMenuStrip1.Show(this.Folder_listBox, point);
            }
        }
        //选定Tag_listBox中的元素并在右方Folder_listBox中显示对应的Folder类
        private void Tag_listBox_MouseDown(object sender, MouseEventArgs e)
        {
            Folder_listBox.Items.Clear();
            Point point = new Point(e.X, e.Y);
            if (e.Button == MouseButtons.Left) {
                int posindex = Tag_listBox.IndexFromPoint(point);
                Tag_listBox.SelectedIndex = posindex;
                Tag t = (Tag)tagArray[posindex];
                foreach (int nextIndex in t.folderIndex) {
                    Folder f = (Folder)FolderArray[nextIndex];
                    Folder_listBox.Items.Add(f.folderName);
                }
            }
        }
        //清除arraylist中重复元素
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

        private void label1_Click(object sender, EventArgs e)
        {
            int i = 0;
        }
    }
}
