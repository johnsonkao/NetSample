using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpAddEvent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //增加事件
        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            btnOri.Click += btnOri_Click;
        }
        //移除事件
        private void btnRemoveEvent_Click(object sender, EventArgs e)
        {
            btnOri.Click -= btnOri_Click;
        }
        //btnOri事件執行的Method
        private void btnOri_Click(object sender, EventArgs e)
        {
            MessageBox.Show("已加入事件");
        }
    }
}
