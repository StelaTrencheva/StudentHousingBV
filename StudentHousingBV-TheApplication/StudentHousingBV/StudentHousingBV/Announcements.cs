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
    public partial class Announcements : UserControl
    {
        public Student student;
        public Employee employee;
        string name;
        enum Type
        {
            party,
            formal,
            none
        }
        public Announcements()
        {
            InitializeComponent();
            date.ResetText();
            time.ResetText();
            tbcAnnouncements.SelectedIndexChanged += new EventHandler(tbcAnnouncements_SelectedIndexChanged);
        }
        public void SetEmployee(Employee employee)
        {
            this.employee = employee;
        }
        public void SetStudent(Student student)
        {
            this.student = student;
        }
        private void CheckEmployeeOrStudent()
        {
            if (student == null)
            {
                name = employee.GetName();
            }
            else if (employee == null)
            {
                name = student.GetName();
            }
        }
        private void btnRestrictions_MouseHover(object sender, EventArgs e)
        {
            lbRestrictions.Visible = true;
            lbRestrictions.BringToFront();
        }
        private void btnRestrictions_MouseLeave(object sender, EventArgs e)
        {
            lbRestrictions.Visible = false;
        }
        private void ClearFields()
        {
            rbFormal.Checked = false;
            rbParty.Checked = false;
            tbAnnouncementTitle.Text = "";
            tbRoom.Text = "";
            date.ResetText();
            time.ResetText();

        }
        private Type CheckSelectedType()
        {
            if (rbFormal.Checked)
            {
                return Type.formal;
            }
            else if (rbParty.Checked)
            {
                return Type.party;
            }
            else return Type.none;
        }
      
        private void btnAddAnnouncement_Click(object sender, EventArgs e)
        {
            Type type = CheckSelectedType();
            string title = tbAnnouncementTitle.Text;
            string date = this.date.Value.ToString("dd-MM-yyyy");
            string time = this.time.Value.ToString("hh:mm");
            string room = tbRoom.Text;
            CheckEmployeeOrStudent();
            string announcement = $"--> {title} - Date: {date} - Room: {room} - Time: {time} - {name}";
            if (type == Type.formal)
            {
                lbFormalAnnouncements.Items.Add(announcement);
            }
            else if(type==Type.party)
            {
                lbPartyAnnouncements.Items.Add(announcement);
            }
            else
            {
                MessageBox.Show("Please select type!");
            }
            ClearFields();
        }
        private Type ListBoxOfSelectedItem()
        {
            if (lbFormalAnnouncements.SelectedIndex == -1 && lbPartyAnnouncements.SelectedIndex > -1)
            {
                return Type.party;
            }
            else if (lbPartyAnnouncements.SelectedIndex == -1 && lbFormalAnnouncements.SelectedIndex > -1)
            {
                return Type.formal;
            }
            else
                return Type.none;
           
        }
        private void btnDeleteAnnouncement_Click(object sender, EventArgs e)
        {
            string authorName;
            CheckEmployeeOrStudent();
            ListBox listBoxOfSelectedItem;
            if (ListBoxOfSelectedItem()==Type.none)
            {
                MessageBox.Show("Please select an announcement!");
                
            }
            else
            {
                if (ListBoxOfSelectedItem()==Type.party)
                {
                    authorName = lbPartyAnnouncements.SelectedItem.ToString().Split('-').Last();
                    listBoxOfSelectedItem = lbPartyAnnouncements;
                }
                else
                {
                    authorName = lbFormalAnnouncements.SelectedItem.ToString().Split('-').Last();
                    listBoxOfSelectedItem = lbFormalAnnouncements;
                }

                authorName = authorName.Remove(0, 1);
                if (authorName == name)
                {
                    listBoxOfSelectedItem.Items.Remove(listBoxOfSelectedItem.SelectedItem);
                }
                else
                {
                    MessageBox.Show("This announcement is not published by you!");

                }
           }

        }
        private void tbcAnnouncements_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcAnnouncements.SelectedTab == tPPartyAnnouncements)
            {
                lbFormalAnnouncements.ClearSelected();

            }else if(tbcAnnouncements.SelectedTab == tPFormalAnnouncements)
            {
                lbPartyAnnouncements.ClearSelected();
            }
        }

       
    }
}
