using System;
using System.Collections;
using System.IO;
using System.Security.AccessControl;

//
// 文件夹类，
//

namespace TagManager
{
    public class Folder
    {
        public String folderName;//文件夹名称
        public String path;//该文件夹的路径*不包括文件夹名称
        public ArrayList tagArray = new ArrayList();//存放文件夹标签的数组

        public Folder() { }//无参数构造函数
        //path为该文件夹的上级目录，folderName为文件夹的名字
        public Folder(string path, string folderName) {
            this.path = path;
            this.folderName = folderName;
            this.getTag();
            if (tagArray.Count == 0)//若该文件夹下没有.tag文件时，将其归入None
                tagArray.Add("没有标签");
        }
 
        //获取该文件夹下的tag并放入tagArray数组
        public void getTag()
        {
            try
            {
                DirectorySecurity s = new DirectorySecurity(path + "\\" + folderName, AccessControlSections.Access);
                //判别该文件夹是否被系统保护无法进入
                if (!s.AreAccessRulesProtected) {
                    DirectoryInfo dir = new DirectoryInfo(path + "\\" + folderName);
                    FileInfo[] tag = dir.GetFiles();
                    foreach (FileInfo nextFile in tag) {
                        if (nextFile.Extension.Equals(".tag"))
                            tagArray.Add(System.IO.Path.GetFileNameWithoutExtension(nextFile.Name));//将该文件夹下的.tag文件的文件名存入tagArray中
                    }
                }                
            }
            catch (Exception e) { System.Windows.Forms.MessageBox.Show(e.ToString()); }//release时需修改
        }

        //移出该类下tagArray中的标签，并删除该文件夹下的对应的tag文件。tagDel为要删除的标签的名字
        public void tagDel(String tagDel) {
            try{
                foreach (String nextTag in tagArray){
                    if (nextTag.ToString() == tagDel){
                        FileInfo delFile = new FileInfo(path + "\\" + folderName + "\\" + nextTag.ToString() + ".tag");
                        delFile.Delete();
                        tagArray.Remove(nextTag);
                    }
                }
            }
            catch (Exception ex) { return; }
        }

        //往该类下tagArray中添加标签，并在该文件夹下新建一个tag文件。tagAdd为要添加的标签的名字
        public void tagAdd(String tagAdd) {
            if (tagArray.Contains(tagAdd))
                return;
            File.Create(path + "\\" + folderName + "\\" + tagAdd + ".tag");
            tagArray.Add(tagAdd);
        }
    }
}
