namespace StudentHousingBV
{
    partial class ComplaintsStudent
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
            this.pnlComplaints = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbPFill = new System.Windows.Forms.TabPage();
            this.tbPView = new System.Windows.Forms.TabPage();
            this.lbFillComplaints = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBFillComplaint = new System.Windows.Forms.TextBox();
            this.rBAnonymous = new System.Windows.Forms.RadioButton();
            this.btnUploadComplaint = new System.Windows.Forms.Button();
            this.lbViewComplaints = new System.Windows.Forms.ListBox();
            this.pnlComplaints.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbPFill.SuspendLayout();
            this.tbPView.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlComplaints
            // 
            this.pnlComplaints.BackColor = System.Drawing.Color.Lavender;
            this.pnlComplaints.Controls.Add(this.tabControl1);
            this.pnlComplaints.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pnlComplaints.Location = new System.Drawing.Point(15, 21);
            this.pnlComplaints.Name = "pnlComplaints";
            this.pnlComplaints.Size = new System.Drawing.Size(783, 607);
            this.pnlComplaints.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbPFill);
            this.tabControl1.Controls.Add(this.tbPView);
            this.tabControl1.Location = new System.Drawing.Point(32, 35);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(716, 537);
            this.tabControl1.TabIndex = 0;
            // 
            // tbPFill
            // 
            this.tbPFill.BackColor = System.Drawing.Color.Lavender;
            this.tbPFill.Controls.Add(this.btnUploadComplaint);
            this.tbPFill.Controls.Add(this.rBAnonymous);
            this.tbPFill.Controls.Add(this.txtBFillComplaint);
            this.tbPFill.Controls.Add(this.label1);
            this.tbPFill.Controls.Add(this.lbFillComplaints);
            this.tbPFill.Location = new System.Drawing.Point(4, 38);
            this.tbPFill.Name = "tbPFill";
            this.tbPFill.Padding = new System.Windows.Forms.Padding(3);
            this.tbPFill.Size = new System.Drawing.Size(708, 495);
            this.tbPFill.TabIndex = 0;
            this.tbPFill.Text = "Fill complaints";
            // 
            // tbPView
            // 
            this.tbPView.BackColor = System.Drawing.Color.Lavender;
            this.tbPView.Controls.Add(this.lbViewComplaints);
            this.tbPView.Location = new System.Drawing.Point(4, 38);
            this.tbPView.Name = "tbPView";
            this.tbPView.Padding = new System.Windows.Forms.Padding(3);
            this.tbPView.Size = new System.Drawing.Size(708, 495);
            this.tbPView.TabIndex = 1;
            this.tbPView.Text = "View complaints";
            // 
            // lbFillComplaints
            // 
            this.lbFillComplaints.FormattingEnabled = true;
            this.lbFillComplaints.ItemHeight = 29;
            this.lbFillComplaints.Location = new System.Drawing.Point(23, 22);
            this.lbFillComplaints.Name = "lbFillComplaints";
            this.lbFillComplaints.Size = new System.Drawing.Size(655, 265);
            this.lbFillComplaints.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(509, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Do you have a complaint? Write it down below:";
            // 
            // txtBFillComplaint
            // 
            this.txtBFillComplaint.Location = new System.Drawing.Point(23, 350);
            this.txtBFillComplaint.Name = "txtBFillComplaint";
            this.txtBFillComplaint.Size = new System.Drawing.Size(655, 34);
            this.txtBFillComplaint.TabIndex = 2;
            // 
            // rBAnonymous
            // 
            this.rBAnonymous.AutoSize = true;
            this.rBAnonymous.Location = new System.Drawing.Point(23, 414);
            this.rBAnonymous.Name = "rBAnonymous";
            this.rBAnonymous.Size = new System.Drawing.Size(209, 33);
            this.rBAnonymous.TabIndex = 3;
            this.rBAnonymous.TabStop = true;
            this.rBAnonymous.Text = "Stay anonymous";
            this.rBAnonymous.UseVisualStyleBackColor = true;
            // 
            // btnUploadComplaint
            // 
            this.btnUploadComplaint.Location = new System.Drawing.Point(325, 414);
            this.btnUploadComplaint.Name = "btnUploadComplaint";
            this.btnUploadComplaint.Size = new System.Drawing.Size(353, 44);
            this.btnUploadComplaint.TabIndex = 4;
            this.btnUploadComplaint.Text = "Upload your complaint";
            this.btnUploadComplaint.UseVisualStyleBackColor = true;
            this.btnUploadComplaint.Click += new System.EventHandler(this.btnUploadComplaint_Click);
            // 
            // lbViewComplaints
            // 
            this.lbViewComplaints.FormattingEnabled = true;
            this.lbViewComplaints.ItemHeight = 29;
            this.lbViewComplaints.Location = new System.Drawing.Point(18, 30);
            this.lbViewComplaints.Name = "lbViewComplaints";
            this.lbViewComplaints.Size = new System.Drawing.Size(672, 439);
            this.lbViewComplaints.TabIndex = 0;
            // 
            // ComplaintsStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlComplaints);
            this.Name = "ComplaintsStudent";
            this.Size = new System.Drawing.Size(824, 650);
            this.pnlComplaints.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tbPFill.ResumeLayout(false);
            this.tbPFill.PerformLayout();
            this.tbPView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlComplaints;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbPFill;
        private System.Windows.Forms.TabPage tbPView;
        private System.Windows.Forms.Button btnUploadComplaint;
        private System.Windows.Forms.RadioButton rBAnonymous;
        private System.Windows.Forms.TextBox txtBFillComplaint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbFillComplaints;
        private System.Windows.Forms.ListBox lbViewComplaints;
    }
}
