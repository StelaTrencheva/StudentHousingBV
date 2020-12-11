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
        public Student student;
        Random rnd = new Random();
        public Student_App(Student student)
        {
            InitializeComponent();
            this.student = student;
        }
        
        private void Student_App_Load(object sender, EventArgs e)
        {
            pnlMyAccount.BringToFront();
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
            HideUserControls();
            complaintsStudent.SetStudent(student);
            pnlWallet.SetStudent(student);
            contactPageStudents1.SetStudent(student);
            timerTaskReminder.Enabled = true;
            timerTaskReminder.Start();
        }

       
        private void btnAnnouncements_Click(object sender, EventArgs e)
        {

            ChangeAllColors();
            btnAnnouncements.BackColor = Color.LightSteelBlue;
        }

        private void btnChangeRoom_Click(object sender, EventArgs e)
        {


        }

       
        private void btnContactPage_Click(object sender, EventArgs e)
        {
            ChangeAllColors();
            btnContactPage.BackColor = Color.LightSteelBlue;
            contactPageStudents1.Show();
            contactPageStudents1.BringToFront();

        }
        private void btnWallet_Click(object sender, EventArgs e)
        {

            pnlWallet.Show();
            pnlWallet.BringToFront();
            ChangeAllColors();
            btnWallet.BackColor = Color.LightSteelBlue;
            
            
        }


        private void btnMyTasks_Click(object sender, EventArgs e)
        {
            ChangeAllColors();
            btnMyTasks.BackColor = Color.LightSteelBlue;
        }

        private void btnCommonQuestions_Click(object sender, EventArgs e)
        {
            ChangeAllColors();
            btnCommonQuestions.BackColor = Color.LightSteelBlue;

        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LogInPage login = new LogInPage();
            login.Show();
            this.Hide();
        }

        private void btnHouseRules_Click(object sender, EventArgs e)
        {
            pnlHouseRules.Visible = true;
            pnlHouseRules.BringToFront();
            ChangeAllColors();
            btnHouseRules.BackColor = Color.LightSteelBlue;

        }
        private void ChangeAllColors()
        {
            btnHouseRules.BackColor = Color.AliceBlue;
            btnAnnouncements.BackColor = Color.AliceBlue;
            btnComplaints.BackColor = Color.AliceBlue;
            btnContactPage.BackColor = Color.AliceBlue;
            btnMyAccount.BackColor = Color.AliceBlue;
            btnWallet.BackColor = Color.AliceBlue;
            btnMyTasks.BackColor = Color.AliceBlue;
            btnCommonQuestions.BackColor = Color.AliceBlue;
        }
        private void HideUserControls()
        {
            pnlHouseRules.Visible = false;
            complaintsStudent.Visible = false;
            pnlWallet.Visible = false;
            contactPageStudents1.Visible = false;
        }

        private void btnMyAccount_Click(object sender, EventArgs e)
        {
            HideUserControls();
            ChangeAllColors();
            btnMyAccount.BackColor = Color.LightSteelBlue;

            
        }

        private void btnComplaints_Click(object sender, EventArgs e)
        {
            complaintsStudent.Visible = true;
            complaintsStudent.BringToFront();
            ChangeAllColors();
            btnComplaints.BackColor = Color.LightSteelBlue;
        }

        private void timerTaskReminder_Tick(object sender, EventArgs e)
        {
            MessageBox.Show($"You still havent done your chores!");
        }

        private void complaintsStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
