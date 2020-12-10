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
            pnlcomplaintsStudent1.Visible = false;
        }

        private void btnMyAccount_Click(object sender, EventArgs e)
        {
            btnMyAccount.BackColor = Color.LightSteelBlue;
            btnHouseRules.BackColor = Color.AliceBlue;
            btnComplaints.BackColor = Color.AliceBlue;
            btnAnnouncements.BackColor = Color.AliceBlue;
            btnContactPage.BackColor = Color.AliceBlue;
            btnCommonQuestions.BackColor = Color.AliceBlue;
            btnWallet.BackColor = Color.AliceBlue;
            btnMyTasks.BackColor = Color.AliceBlue;
            pnlcomplaintsStudent1.SendToBack();
            pnlMyAccount.BringToFront();
            pnlHouseRules.Visible = false;
            pnlcomplaintsStudent1.Visible = false;

        }


        private void btnHouseRules_Click_1(object sender, EventArgs e)
        {
            btnHouseRules.BackColor = Color.LightSteelBlue;
            btnMyAccount.BackColor = Color.AliceBlue;
            btnComplaints.BackColor = Color.AliceBlue;
            btnAnnouncements.BackColor = Color.AliceBlue;
            btnContactPage.BackColor = Color.AliceBlue;
            btnCommonQuestions.BackColor = Color.AliceBlue;
            btnWallet.BackColor = Color.AliceBlue;
            btnMyTasks.BackColor = Color.AliceBlue;

            pnlHouseRules.Visible = true;
            pnlHouseRules.BringToFront();


        }
        private void btnAnnouncements_Click(object sender, EventArgs e)
        {
            btnAnnouncements.BackColor = Color.LightSteelBlue;
            btnMyAccount.BackColor = Color.AliceBlue;
            btnComplaints.BackColor = Color.AliceBlue;
            btnHouseRules.BackColor = Color.AliceBlue;
            btnContactPage.BackColor = Color.AliceBlue;
            btnCommonQuestions.BackColor = Color.AliceBlue;
            btnWallet.BackColor = Color.AliceBlue;
            btnMyTasks.BackColor = Color.AliceBlue;

        }

        private void btnChangeRoom_Click(object sender, EventArgs e)
        {


        }

        private void btnComplaints_Click(object sender, EventArgs e)
        {
            pnlcomplaintsStudent1.Visible = true;
            pnlcomplaintsStudent1.BringToFront();
            
            btnComplaints.BackColor = Color.LightSteelBlue;
            btnHouseRules.BackColor = Color.AliceBlue;
            btnMyAccount.BackColor = Color.AliceBlue;
            btnAnnouncements.BackColor = Color.AliceBlue;
            btnContactPage.BackColor = Color.AliceBlue;
            btnCommonQuestions.BackColor = Color.AliceBlue;
            btnWallet.BackColor = Color.AliceBlue;
            btnMyTasks.BackColor = Color.AliceBlue;


        }



        private void btnContactPage_Click(object sender, EventArgs e)
        {
            btnContactPage.BackColor = Color.LightSteelBlue;
            btnMyAccount.BackColor = Color.AliceBlue;
            btnComplaints.BackColor = Color.AliceBlue;
            btnAnnouncements.BackColor = Color.AliceBlue;
            btnHouseRules.BackColor = Color.AliceBlue;
            btnCommonQuestions.BackColor = Color.AliceBlue;
            btnWallet.BackColor = Color.AliceBlue;
            btnMyTasks.BackColor = Color.AliceBlue;

        }
        private void btnWallet_Click(object sender, EventArgs e)
        {
            btnWallet.BackColor = Color.LightSteelBlue;
            btnMyAccount.BackColor = Color.AliceBlue;
            btnComplaints.BackColor = Color.AliceBlue;
            btnAnnouncements.BackColor = Color.AliceBlue;
            btnHouseRules.BackColor = Color.AliceBlue;
            btnCommonQuestions.BackColor = Color.AliceBlue;
            btnContactPage.BackColor = Color.AliceBlue;
            btnMyTasks.BackColor = Color.AliceBlue;

        }


        private void btnMyTasks_Click(object sender, EventArgs e)
        {
            btnMyTasks.BackColor = Color.LightSteelBlue;
            btnMyAccount.BackColor = Color.AliceBlue;
            btnComplaints.BackColor = Color.AliceBlue;
            btnAnnouncements.BackColor = Color.AliceBlue;
            btnHouseRules.BackColor = Color.AliceBlue;
            btnCommonQuestions.BackColor = Color.AliceBlue;
            btnContactPage.BackColor = Color.AliceBlue;
            btnWallet.BackColor = Color.AliceBlue;

        }

        private void btnCommonQuestions_Click(object sender, EventArgs e)
        {
            btnCommonQuestions.BackColor = Color.LightSteelBlue;
            btnMyAccount.BackColor = Color.AliceBlue;
            btnComplaints.BackColor = Color.AliceBlue;
            btnAnnouncements.BackColor = Color.AliceBlue;
            btnHouseRules.BackColor = Color.AliceBlue;
            btnMyTasks.BackColor = Color.AliceBlue;
            btnContactPage.BackColor = Color.AliceBlue;
            btnWallet.BackColor = Color.AliceBlue;

        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LogInPage login = new LogInPage();
            login.Show();
            this.Hide();
        }
    }
}
