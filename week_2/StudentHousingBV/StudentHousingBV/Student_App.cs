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
            pnlMyAccount.BringToFront();
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
            pnlHouseRules.Visible = false;
        }

        private void btnMyAccount_Click(object sender, EventArgs e)
        {

            pnlMyAccount.BringToFront();
            btnMyAccount.BackColor = Color.LightSteelBlue;
            btnHouseRules.BackColor = Color.AliceBlue;
            pnlHouseRules.Visible=false;
        }


        private void btnHouseRules_Click_1(object sender, EventArgs e)
        {
            pnlHouseRules.Visible = true;
            pnlHouseRules.BringToFront();
            pnlMyAccount.SendToBack();
            btnHouseRules.BackColor = Color.LightSteelBlue;
            btnMyAccount.BackColor = Color.AliceBlue;

        }

        private void btnChangeRoom_Click(object sender, EventArgs e)
        {
            

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LogInPage login = new LogInPage();
            login.Show();
            this.Hide();
        }
    }
}
