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
    public partial class Wallet : UserControl
    {
        public Student student;
        public double currentBalance;
        
         public void SetStudent(Student student)
        {
            this.student = student;
            currentBalance = this.student.GetInitialBalance();
        }
        public Wallet()
        {
            InitializeComponent(); 

        }
        
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            
            double amount = Convert.ToDouble(tbAmount.Text);
            string reason = tbReason.Text;
            currentBalance += amount;
            lblBalance.Text = (currentBalance).ToString();
            lbxHistory.Items.Add($"Deposit {amount} Euro - {reason}");
            btnWithdraw.Enabled = true;
            ClearTextBoxes();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
           
            double amount = Convert.ToDouble(tbAmount.Text);
            string reason = tbReason.Text;
            if (currentBalance - amount <= 0)
            {
                MessageBox.Show("You do not have enough money in your balance!");
                lbxHistory.Items.Add($"Failed withdraw for {amount} Euro - {reason}");
            }
            else
            {
                currentBalance -= amount;
                lblBalance.Text = (currentBalance).ToString();
                lbxHistory.Items.Add($"Withdraw {amount} Euro - {reason}");
            }
            ClearTextBoxes();

        }
        private void ClearTextBoxes()
        {
            tbAmount.Text = "";
            tbReason.Text = "";
        }
        private void Wallet_Load(object sender, EventArgs e)
        {
            if (student == null)
                return;

            lblName.Text += $"{student.GetName()}";
            lblBankAccount.Text += $"{student.GetBankAccount()}";
            lblBalance.Text = $"{currentBalance}";
        }
    }
}
