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
        Random rnd = new Random();
        public Student_App(Student student)
        {
            InitializeComponent();
            this.student = student;
        }
       
        private void Student_App_Load(object sender, EventArgs e)
        {
            int building = rnd.Next(1, 10);
            lblName.Text += $"{student.GetName()}";
            lblAge.Text += $"{student.GetAge()}";
            lblSex.Text += $"{student.GetSex()}";
            lblStudentNumber.Text += $"{student.GetStudentNumber()}";
            lblUniversity.Text += "Fontys UAS";
            lblBuilding.Text += $"{building}";
            lblRoomNumber.Text += $"{student.GetRoomNumber()}";
            if (student.GetSex() == "female")
            {
                profilePicture.Image = Properties.Resources.woman_avatar;
            }
            else
            {
                profilePicture.Image = Properties.Resources.man_avatar;
            }
        }

        
    }
}
