using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TagManager
{
    public partial class inputForm : Form
    {
        private Folder folder;

        public inputForm()
        {
            InitializeComponent();
        }

        public inputForm(Folder f) : this() {
            this.folder = f;
        }
        private void inputForm_Load(object sender, EventArgs e)
        {            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (input_textBox.Text.Length == 0) {
                MessageBox.Show("标签不能为空！");
                return;
            }
            folder.tagAdd(input_textBox.Text.ToString().Trim());
            this.Close();
        }

        private void input_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.button1_Click(sender, e);
        }
    }
}
