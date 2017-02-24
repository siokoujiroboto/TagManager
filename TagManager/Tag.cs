using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;

//--------------------------------------------------------
// 用于标签的函数，只在Form1中作为tagArray的成员使用。
//--------------------------------------------------------
namespace TagManager
{
    public class Tag
    {
        public ArrayList folderIndex = new ArrayList();//保存属于标签的文件夹在folderArray中的位置，
        public String tagName;//该tag的名字
        public Tag() { }
        public Tag(String name) {
            this.tagName = name;
        }

        //往该标签中的folderIndex放入Folder类的索引
        public void pushFolder(int index) {
            folderIndex.Add(index);
        }

        //从该标签中的folderIndex删除Folder类的索引
        public void popFolder(int index) {
            folderIndex.Remove(index);
        }
    }
}
