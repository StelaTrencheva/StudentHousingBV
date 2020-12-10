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
            pnlHouseRulesEmployee.Visible = true;
            pnlHouseRulesEmployee.BringToFront();
            pnlEmployeeAccount.SendToBack();
            btnHouseRulesEmp.BackColor = Color.LightSteelBlue;
            btnMyAccountEmp.BackColor = Color.AliceBlue;

        }

        private void btnMyAccountEmp_Click(object sender, EventArgs e)
        {
            pnlEmployeeAccount.BringToFront();
            pnlHouseRulesEmployee.Visible = false;
            btnHouseRulesEmp.BackColor = Color.AliceBlue; 
            btnMyAccountEmp.BackColor = Color.LightSteelBlue;
        }

        private void profilePicture_Click(object sender, EventArgs e)
        {

        }
    }
}
