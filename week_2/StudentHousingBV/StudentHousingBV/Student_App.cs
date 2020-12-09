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
        public Student_App()
        {
            InitializeComponent();
        }
        Student newStudent = new Student();
        int studentIndex;
        string newStudentName;
        public void GetStudentIndex(int index, string studentName)
        {
            studentIndex = index;
            newStudentName = studentName;

        }
        private void Student_App_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(studentIndex.ToString());
            lblName.Text = $"{newStudentName}";
        }
    }
}
