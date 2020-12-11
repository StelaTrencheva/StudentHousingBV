namespace StudentHousingBV
{
    partial class ContactPageStudents
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlContactPageStudents = new System.Windows.Forms.Panel();
            this.rtxtbAnswears = new System.Windows.Forms.RichTextBox();
            this.cBPersonalQuestions = new System.Windows.Forms.ComboBox();
            this.lblContactPageDescription = new System.Windows.Forms.Label();
            this.lblContactPage = new System.Windows.Forms.Label();
            this.pnlContactPageStudents.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContactPageStudents
            // 
            this.pnlContactPageStudents.BackColor = System.Drawing.Color.Lavender;
            this.pnlContactPageStudents.Controls.Add(this.rtxtbAnswears);
            this.pnlContactPageStudents.Controls.Add(this.cBPersonalQuestions);
            this.pnlContactPageStudents.Controls.Add(this.lblContactPageDescription);
            this.pnlContactPageStudents.Controls.Add(this.lblContactPage);
            this.pnlContactPageStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pnlContactPageStudents.Location = new System.Drawing.Point(20, 22);
            this.pnlContactPageStudents.Name = "pnlContactPageStudents";
            this.pnlContactPageStudents.Size = new System.Drawing.Size(783, 607);
            this.pnlContactPageStudents.TabIndex = 0;
            // 
            // rtxtbAnswears
            // 
            this.rtxtbAnswears.Location = new System.Drawing.Point(38, 327);
            this.rtxtbAnswears.Name = "rtxtbAnswears";
            this.rtxtbAnswears.Size = new System.Drawing.Size(692, 197);
            this.rtxtbAnswears.TabIndex = 3;
            this.rtxtbAnswears.Text = "";
            // 
            // cBPersonalQuestions
            // 
            this.cBPersonalQuestions.FormattingEnabled = true;
            this.cBPersonalQuestions.Items.AddRange(new object[] {
            "What is my student number?",
            "What is my bank account number?",
            "What is my room number?",
            "How can I get in touch with one of the employees?"});
            this.cBPersonalQuestions.Location = new System.Drawing.Point(38, 160);
            this.cBPersonalQuestions.Name = "cBPersonalQuestions";
            this.cBPersonalQuestions.Size = new System.Drawing.Size(692, 37);
            this.cBPersonalQuestions.TabIndex = 2;
            this.cBPersonalQuestions.SelectedIndexChanged += new System.EventHandler(this.cBPersonalQuestions_SelectedIndexChanged);
            // 
            // lblContactPageDescription
            // 
            this.lblContactPageDescription.AutoSize = true;
            this.lblContactPageDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblContactPageDescription.Location = new System.Drawing.Point(34, 90);
            this.lblContactPageDescription.Name = "lblContactPageDescription";
            this.lblContactPageDescription.Size = new System.Drawing.Size(696, 48);
            this.lblContactPageDescription.TabIndex = 1;
            this.lblContactPageDescription.Text = "Here you can find the answears to the questions regarding your account and your \r" +
    "\npersonal details";
            // 
            // lblContactPage
            // 
            this.lblContactPage.AutoSize = true;
            this.lblContactPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblContactPage.Location = new System.Drawing.Point(33, 39);
            this.lblContactPage.Name = "lblContactPage";
            this.lblContactPage.Size = new System.Drawing.Size(184, 32);
            this.lblContactPage.TabIndex = 0;
            this.lblContactPage.Text = "Contact page";
            // 
            // ContactPageStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlContactPageStudents);
            this.Name = "ContactPageStudents";
            this.Size = new System.Drawing.Size(824, 650);
            this.Load += new System.EventHandler(this.ContactPageStudents_Load);
            this.pnlContactPageStudents.ResumeLayout(false);
            this.pnlContactPageStudents.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContactPageStudents;
        private System.Windows.Forms.ComboBox cBPersonalQuestions;
        private System.Windows.Forms.Label lblContactPageDescription;
        private System.Windows.Forms.Label lblContactPage;
        private System.Windows.Forms.RichTextBox rtxtbAnswears;
    }
}
