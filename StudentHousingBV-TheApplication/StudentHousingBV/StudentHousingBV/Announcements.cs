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
        public Announcements()
        {
            InitializeComponent();
            tbcAnnouncements.SelectedIndexChanged += new EventHandler(tbcAnnouncements_SelectedIndexChanged);
        }
        public void SetStudent(Student student)
        {
            this.student = student;
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
        private string CheckSelectedType()
        {
            if (rbFormal.Checked)
            {
                return "formal";
            }else if(rbParty.Checked)
            {
                return "party";
            }
            else
            {
                return "none";
            }
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
        private void btnAddAnnouncement_Click(object sender, EventArgs e)
        {
            string type = CheckSelectedType();
            string title = tbAnnouncementTitle.Text;
            string date = this.date.Value.ToString("dd-MM-yyyy");
            string time = this.time.Value.ToString("hh:mm");
            string room = tbRoom.Text;
            string announcement = $"--> {title} - Date: {date} - Room: {room} - Time: {time} - {student.GetName()}";
            if (type == "formal")
            {
                lbFormalAnnouncements.Items.Add(announcement);
            }
            else if(type=="party")
            {
                lbPartyAnnouncements.Items.Add(announcement);
            }
            ClearFields();
        }
        private string ListBoxOfSelectedItem()
        {
            if (lbFormalAnnouncements.SelectedIndex == -1 && lbPartyAnnouncements.SelectedIndex>-1)
            {
                return "party";
            }
            else if (lbPartyAnnouncements.SelectedIndex == -1 && lbFormalAnnouncements.SelectedIndex>-1)
            {
                return "formal";
            }else 
                return "none";
           
        }
        private void btnDeleteAnnouncement_Click(object sender, EventArgs e)
        {
            string name;
            ListBox listBoxOfSelectedItem;
            if (ListBoxOfSelectedItem()=="none")
            {
                MessageBox.Show("Please select an announcement!");
                
            }
            else
            {
                if (ListBoxOfSelectedItem()=="party")
                {
                    name = lbPartyAnnouncements.SelectedItem.ToString().Split('-').Last();
                    listBoxOfSelectedItem = lbPartyAnnouncements;
                }
                else
                {
                    name = lbFormalAnnouncements.SelectedItem.ToString().Split('-').Last();
                    listBoxOfSelectedItem = lbFormalAnnouncements;
                }

                name = name.Remove(0, 1);
                if (name == student.GetName())
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
