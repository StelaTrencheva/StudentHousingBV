using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentHousingBV
{
    public partial class ManageAccountsEmployee : UserControl
    {
        public List<Student> ListOfStudents;
        public ManageAccountsEmployee()
        {
            InitializeComponent();
        }

        public void SetListOfAllStudents(List<Student> listOfstudents)
        {
            this.ListOfStudents = listOfstudents;
        }
        private void btnAccountInfo_Click(object sender, EventArgs e)
        {
            int index = -1;
            index = lsbAllStudents.SelectedIndex;
            if (index != -1)
            {
                txtbAccountInfo.Text = "";
                foreach (Student student in ListOfStudents)
                {
                    if (student == ListOfStudents[index])
                    {
                        txtbAccountInfo.Text = student.GetStudentInfo();
                    }
                }
            }
            else
            {
                MessageBox.Show("Select a student");
            }


        }

        private void btnShowAllStudents_Click(object sender, EventArgs e)
        {
            lsbAllStudents.Items.Clear();
            foreach (Student student in ListOfStudents)
            {
                lsbAllStudents.Items.Add(student.GetName());
            }
        }
    }
}
