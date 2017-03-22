using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.IO;

namespace TagManager.classes
{

    class SQLite_sheets
    {
        public String sheetsPath = null;
        private SQLiteConnection m_dbConnection = null;
        private SQLiteCommand command = null;

        public SQLite_sheets() {
            sheetsPath = Environment.CurrentDirectory;
            if (File.Exists(sheetsPath + "\\tagManager.sqlite")) {
                m_dbConnection = new SQLiteConnection("Data Source=tagManager.sqlite;Version=3;");
                return;
            }
            creatDB();
        }
        private void creatDB() {
            SQLiteConnection.CreateFile("tagManager.sqlite");
            m_dbConnection = new SQLiteConnection("Data Source=tagManager.sqlite;Version=3;");
            m_dbConnection.Open();
            //创建文件夹表
            command = new SQLiteCommand("create table Dir (DirId integer primary key autoincrement, DirName varchar(100))",
                m_dbConnection);
            command.ExecuteNonQuery();
            //创建tag类表
            command = new SQLiteCommand("create table Tag (DirId int, TagName varchar(20))",
                m_dbConnection);
            command.ExecuteNonQuery();
            m_dbConnection.Close();
        }

        public void insertDir(String folderName) {
            m_dbConnection.Open();
            command = new SQLiteCommand("insert into Dir(DirName) values('" + folderName + "')",
                m_dbConnection);
            command.ExecuteNonQuery();
            m_dbConnection.Close();
        }
        public void insertTag(int DirId, String tag) {
            m_dbConnection.Open();
            command = new SQLiteCommand("insert into Tag(DirId, TagName) values(" + DirId + ", '" + tag + "')",
                m_dbConnection);
            command.ExecuteNonQuery();
            m_dbConnection.Close();
        }
        
    }
}
