using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectReference
{
    public partial class frmForm1 : Form
    {
        private List<Student> _students;
        public frmForm1()
        {
            InitializeComponent();
        }

        private void btnAddObjectToList_Click(object sender, EventArgs e)
        {
            _students = new List<Student>();
            for (int i = 0;i<=3; i++)
            {
                Student std = new Student();
                std.ID = i.ToString();
                std.Name = DateTime.Now.ToShortTimeString();
                _students.Add(std);
            }
            dvShow.DataSource = _students;
        }
    }
    public class Student
    {
        public string ID { get; set; }
        public string Name { get; set; }
    }
}
