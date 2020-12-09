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
    public partial class LogInPage : Form
    {
        Student StudentUser;
        Employee EmployeeUser;
        List<Student> ListOfAllStudents = new List<Student>();
        List<Employee> ListOfAllEmployees = new List<Employee>();

        public LogInPage()
        {
            InitializeComponent();
        }

        private void rBEmployee_CheckedChanged(object sender, EventArgs e)
        {
            ListOfAllEmployees.Clear();
            cbbProfiles.Items.Clear();
            for (int i = 0; i < 5; i++)
            {
                EmployeeUser = new Employee(i); 
                cbbProfiles.Items.Add(EmployeeUser.GetEmployeeInfo());
                ListOfAllEmployees.Add(EmployeeUser);
            }
        }

        private void rBStudents_CheckedChanged(object sender, EventArgs e)
        {
            ListOfAllStudents.Clear();
            cbbProfiles.Items.Clear();
            for (int i = 0; i < 10; i++)
            {
                StudentUser = new Student(i);
                cbbProfiles.Items.Add(StudentUser.GetStudentInfo());
                ListOfAllStudents.Add(StudentUser);
            }
        }
        
        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            if (rBStudents.Checked)
            {
                int SelectedStudentIndex = cbbProfiles.SelectedIndex;
            }
            else if (rBEmployee.Checked)
            {
                int SelectedEmployeeIndex = cbbProfiles.SelectedIndex;
            }
        }
    }
}
