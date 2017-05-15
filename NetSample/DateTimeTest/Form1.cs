using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimeTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DateTime t1;
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            lblNow.Text = now.ToString();

            int sec = pub.CalculateDiffSeconds(t1, now);

            lblSec.Text = sec.ToString();
        }

        private void btnSaveT1_Click(object sender, EventArgs e)
        {
            t1 = DateTime.Now;
            lblT1.Text = t1.ToString();
        }



    }
    public class pub
    {
        public static int CalculateDiffSeconds(DateTime dtPast, DateTime dtFuture)
        {

            TimeSpan spanPast = dtFuture.Subtract(dtPast);
            return spanPast.Seconds;
        }
    }
}
