using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaskDigit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblOutput.Text = MaskTextByPattern(txtInput.Text,txtMask.Text);
        }
        private string MaskTextByPattern(string inStr,string pattern)
        {

            string outStr = "";
            if (inStr.Length!= pattern.Length)
                return "錯誤, pattern和輸入字串長度不相同";

            for (int i = 0;i<inStr.Length;i++)
            {
                if (pattern.Substring(i, 1) == "*")
                    outStr += "*";
                else
                    outStr += inStr.Substring(i, 1);
            }
            return outStr;
        }
    }
}

