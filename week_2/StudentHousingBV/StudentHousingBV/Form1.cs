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
        Student StudentUser=new Student();
        Employee EmployeeUser;
        List<Employee> ListOfAllEmployees;
        int SelectedStudentIndex;
        int SelectedEmployeeIndex = 0;
        List<Student> ListOfAllStudents;
        public LogInPage()
        {
            InitializeComponent();
        }

        private void rBEmployee_CheckedChanged(object sender, EventArgs e)
        {
            ListOfAllEmployees = new List<Employee>();
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
            ListOfAllStudents = new List<Student>();
            cbbProfiles.Items.Clear();
            for (int i = 0; i < 10; i++)
            {
                StudentUser.SetStudent(i);
                cbbProfiles.Items.Add(StudentUser.GetStudentInfo());
                ListOfAllStudents.Add(StudentUser);
            }

            
        }
        
        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            if (rBStudents.Checked)
            {
                SelectedStudentIndex = cbbProfiles.SelectedIndex;
                Student_App student_app = new Student_App();
                StudentUser.GetIndex(SelectedStudentIndex);
                string f = ListOfAllStudents[SelectedStudentIndex].GetName();
                student_app.GetStudentIndex(SelectedStudentIndex, f);
                student_app.Show();
                this.Hide();
            }
            else if (rBEmployee.Checked)
            {
                SelectedEmployeeIndex = cbbProfiles.SelectedIndex;
            }
        }
      
    }
}
