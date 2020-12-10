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
    public partial class ComplaintsStudent : UserControl
    {
        public ComplaintsStudent()
        {
            InitializeComponent();
        }

        private void btnUploadComplaint_Click(object sender, EventArgs e)
        {
            string newComplaint = txtBFillComplaint.Text.ToString();
            if(rBAnonymous.Checked)
            {
                lbFillComplaints.Items.Add($"--> {newComplaint}");
                lbViewComplaints.Items.Add($"--> {newComplaint}");
            }
            else if(!rBAnonymous.Checked)
            {
                lbFillComplaints.Items.Add($"--> {newComplaint} - *Student name*");
                lbViewComplaints.Items.Add($"--> {newComplaint} - *Student name*");
            }
        }
    }
}
