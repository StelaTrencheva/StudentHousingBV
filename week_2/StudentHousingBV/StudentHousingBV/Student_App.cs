using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentHousingBV
{
    public partial class Student_App : Form
    {
        private Student student;
        public Student_App(Student student)
        {
            InitializeComponent();
            this.student = student;
        }
       
        private void Student_App_Load(object sender, EventArgs e)
        {
            lblName.Text += $"{student.GetName()}";
        }
    }
}
