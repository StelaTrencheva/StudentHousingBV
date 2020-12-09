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
    public partial class Employee_App : Form
    {
        private Employee employee;
        public Employee_App(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
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
        }
    }
}
