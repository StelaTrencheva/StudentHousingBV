using System;
using System.Net;
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
    public partial class Employee_App : Form
    {
        private Employee employee;
        public Employee_App(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            pnlEmployeeAccount.BringToFront();
        }

        private void Employee_App_Load(object sender, EventArgs e)
        {
            lblName.Text += $"{employee.GetName()}";
            lblAge.Text += $"{employee.GetAge()}";
            lblSex.Text += $"{employee.GetSex()}";
            lblEmployeeNumber.Text += $"{employee.GetEmployeeNumber()}";
            if (employee.GetSex() == "male")
            {
                profilePicture.Image = Properties.Resources.man_avatar;
            }
            else
            {
                profilePicture.Image = Properties.Resources.woman_avatar;
            }
            pnlHouseRulesEmployee.Visible = false;
            pnlComplaintsEmployee1.Visible = false;
        }

        private FolderBrowserDialog d;
        private void btnDownloadContract_Click(object sender, EventArgs e)
        {
            d = new System.Windows.Forms.FolderBrowserDialog();
            DialogResult result=d.ShowDialog();
            string folderName;
            if (result == DialogResult.OK)
            {
                folderName = d.SelectedPath;
                WebClient Client = new WebClient();
                Client.DownloadFile("https://inewicdn.azureedge.net/files/Employment_Agreement.pdf", $@"{folderName}\contract.pdf");
                lblDownloadResult.Text = "Download completed! Check your Downloads folder!";
            }
            
        }

        private void btnHouseRulesEmp_Click(object sender, EventArgs e)
        {
            btnHouseRulesEmp.BackColor = Color.LightSteelBlue;
            btnMyAccountEmp.BackColor = Color.AliceBlue;
            btnAnnouncementsEmp.BackColor = Color.AliceBlue;
            btnCommonQuestionsEmp.BackColor = Color.AliceBlue;
            btnComplaintsEmp.BackColor = Color.AliceBlue;
            btnContactPageEmp.BackColor = Color.AliceBlue;
            btnWalletEmp.BackColor = Color.AliceBlue;

            pnlHouseRulesEmployee.Visible = true;
            pnlHouseRulesEmployee.BringToFront();
            pnlEmployeeAccount.SendToBack();
            pnlComplaintsEmployee1.SendToBack();

        }

        private void btnMyAccountEmp_Click(object sender, EventArgs e)
        {
             btnMyAccountEmp.BackColor = Color.LightSteelBlue;
            btnHouseRulesEmp.BackColor = Color.AliceBlue;
            btnAnnouncementsEmp.BackColor = Color.AliceBlue;
            btnCommonQuestionsEmp.BackColor = Color.AliceBlue;
            btnComplaintsEmp.BackColor = Color.AliceBlue;
            btnContactPageEmp.BackColor = Color.AliceBlue;
            btnWalletEmp.BackColor = Color.AliceBlue;

            pnlEmployeeAccount.BringToFront();
            pnlHouseRulesEmployee.Visible = false;
            pnlComplaintsEmployee1.Visible = false;
        }

        private void profilePicture_Click(object sender, EventArgs e)
        {

        }

        

        private void btnAnnouncementsEmp_Click(object sender, EventArgs e)
        {
             btnAnnouncementsEmp.BackColor = Color.LightSteelBlue;
            btnHouseRulesEmp.BackColor = Color.AliceBlue;
            btnMyAccountEmp.BackColor = Color.AliceBlue;
            btnCommonQuestionsEmp.BackColor = Color.AliceBlue;
            btnComplaintsEmp.BackColor = Color.AliceBlue;
            btnContactPageEmp.BackColor = Color.AliceBlue;
            btnWalletEmp.BackColor = Color.AliceBlue;
        }

        private void btnComplaintsEmp_Click(object sender, EventArgs e)
        {
             btnComplaintsEmp.BackColor = Color.LightSteelBlue;
            btnHouseRulesEmp.BackColor = Color.AliceBlue;
            btnMyAccountEmp.BackColor = Color.AliceBlue;
            btnCommonQuestionsEmp.BackColor = Color.AliceBlue;
            btnAnnouncementsEmp.BackColor = Color.AliceBlue;
            btnContactPageEmp.BackColor = Color.AliceBlue;
            btnWalletEmp.BackColor = Color.AliceBlue;

            pnlComplaintsEmployee1.Visible = true;
            pnlComplaintsEmployee1.BringToFront();
            pnlEmployeeAccount.SendToBack();
            pnlHouseRulesEmployee.SendToBack();
        }

        private void btnContactPageEmp_Click(object sender, EventArgs e)
        {
             btnContactPageEmp.BackColor = Color.LightSteelBlue;
            btnHouseRulesEmp.BackColor = Color.AliceBlue;
            btnMyAccountEmp.BackColor = Color.AliceBlue;
            btnCommonQuestionsEmp.BackColor = Color.AliceBlue;
            btnAnnouncementsEmp.BackColor = Color.AliceBlue;
            btnComplaintsEmp.BackColor = Color.AliceBlue;
            btnWalletEmp.BackColor = Color.AliceBlue;
        }

        private void btnCommonQuestionsEmp_Click(object sender, EventArgs e)
        {
             btnCommonQuestionsEmp.BackColor = Color.LightSteelBlue;
            btnHouseRulesEmp.BackColor = Color.AliceBlue;
            btnMyAccountEmp.BackColor = Color.AliceBlue;
            btnContactPageEmp.BackColor = Color.AliceBlue;
            btnAnnouncementsEmp.BackColor = Color.AliceBlue;
            btnComplaintsEmp.BackColor = Color.AliceBlue;
            btnWalletEmp.BackColor = Color.AliceBlue;
        }

        private void btnWalletEmp_Click(object sender, EventArgs e)
        {
             btnWalletEmp.BackColor = Color.LightSteelBlue;
            btnHouseRulesEmp.BackColor = Color.AliceBlue;
            btnMyAccountEmp.BackColor = Color.AliceBlue;
            btnContactPageEmp.BackColor = Color.AliceBlue;
            btnAnnouncementsEmp.BackColor = Color.AliceBlue;
            btnComplaintsEmp.BackColor = Color.AliceBlue;
            btnCommonQuestionsEmp.BackColor = Color.AliceBlue;
        }
        private void btnLogOutEmp_Click(object sender, EventArgs e)
        {
            LogInPage login = new LogInPage();
            login.Show();
            this.Hide();
        }
    }
}
