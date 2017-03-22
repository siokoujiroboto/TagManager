using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace TagManager
{
    public partial class loadingForm : Form
    {
        private string[] loadingStr = { "正在载入中", "正在载入中.", "正在载入中..", "正在载入中..." };
        private int count = 0;
        public loadingForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {//需要一条新进程
            int temp = count % 4;
            label1.Text = loadingStr[temp];
            count++;
        }
    }
}
