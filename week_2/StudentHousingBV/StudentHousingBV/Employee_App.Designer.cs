namespace StudentHousingBV
{
    partial class Employee_App
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEmployeeNumber = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDownloadContract = new System.Windows.Forms.Button();
            this.contractPicture = new System.Windows.Forms.PictureBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.lblDownloadResult = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEmployeeNumber
            // 
            this.lblEmployeeNumber.AutoSize = true;
            this.lblEmployeeNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEmployeeNumber.Location = new System.Drawing.Point(389, 244);
            this.lblEmployeeNumber.Name = "lblEmployeeNumber";
            this.lblEmployeeNumber.Size = new System.Drawing.Size(222, 29);
            this.lblEmployeeNumber.TabIndex = 4;
            this.lblEmployeeNumber.Text = "Employee number: ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(389, 110);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(90, 29);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name: ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Controls.Add(this.lblDownloadResult);
            this.panel2.Controls.Add(this.btnDownloadContract);
            this.panel2.Controls.Add(this.contractPicture);
            this.panel2.Controls.Add(this.lblEmployeeNumber);
            this.panel2.Controls.Add(this.lblSex);
            this.panel2.Controls.Add(this.lblAge);
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Controls.Add(this.profilePicture);
            this.panel2.Location = new System.Drawing.Point(257, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(828, 650);
            this.panel2.TabIndex = 5;
            // 
            // btnDownloadContract
            // 
            this.btnDownloadContract.BackColor = System.Drawing.Color.Lavender;
            this.btnDownloadContract.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDownloadContract.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDownloadContract.Location = new System.Drawing.Point(480, 543);
            this.btnDownloadContract.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDownloadContract.Name = "btnDownloadContract";
            this.btnDownloadContract.Size = new System.Drawing.Size(205, 45);
            this.btnDownloadContract.TabIndex = 19;
            this.btnDownloadContract.Text = "Download Contract";
            this.btnDownloadContract.UseVisualStyleBackColor = false;
            this.btnDownloadContract.Click += new System.EventHandler(this.btnDownloadContract_Click);
            // 
            // contractPicture
            // 
            this.contractPicture.Image = global::StudentHousingBV.Properties.Resources.ContractLaw;
            this.contractPicture.Location = new System.Drawing.Point(394, 296);
            this.contractPicture.Name = "contractPicture";
            this.contractPicture.Size = new System.Drawing.Size(364, 233);
            this.contractPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.contractPicture.TabIndex = 5;
            this.contractPicture.TabStop = false;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSex.Location = new System.Drawing.Point(389, 200);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(66, 29);
            this.lblSex.TabIndex = 3;
            this.lblSex.Text = "Sex: ";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAge.Location = new System.Drawing.Point(389, 153);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(68, 29);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Age: ";
            // 
            // profilePicture
            // 
            this.profilePicture.Image = global::StudentHousingBV.Properties.Resources.woman_avatar;
            this.profilePicture.Location = new System.Drawing.Point(51, 91);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(259, 272);
            this.profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePicture.TabIndex = 0;
            this.profilePicture.TabStop = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button5.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(9, 325);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(237, 52);
            this.button5.TabIndex = 13;
            this.button5.Text = "My Account";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AliceBlue;
            this.button1.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(9, 25);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 52);
            this.button1.TabIndex = 9;
            this.button1.Text = "House Rules";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.AliceBlue;
            this.button8.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(9, 564);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(237, 52);
            this.button8.TabIndex = 16;
            this.button8.Text = "Log out";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.AliceBlue;
            this.button2.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(9, 91);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(237, 52);
            this.button2.TabIndex = 10;
            this.button2.Text = "Announcements";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.AliceBlue;
            this.button3.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(9, 158);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(237, 52);
            this.button3.TabIndex = 11;
            this.button3.Text = "Complaints";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.AliceBlue;
            this.button6.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(9, 494);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(237, 52);
            this.button6.TabIndex = 14;
            this.button6.Text = "Wallet";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.AliceBlue;
            this.button4.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(9, 226);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(237, 52);
            this.button4.TabIndex = 12;
            this.button4.Text = "Contact Page";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Location = new System.Drawing.Point(-3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 650);
            this.panel1.TabIndex = 4;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.AliceBlue;
            this.button9.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.Location = new System.Drawing.Point(9, 391);
            this.button9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(237, 87);
            this.button9.TabIndex = 17;
            this.button9.Text = "Common Questions";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // lblDownloadResult
            // 
            this.lblDownloadResult.AutoSize = true;
            this.lblDownloadResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDownloadResult.Location = new System.Drawing.Point(351, 596);
            this.lblDownloadResult.Name = "lblDownloadResult";
            this.lblDownloadResult.Size = new System.Drawing.Size(0, 20);
            this.lblDownloadResult.TabIndex = 20;
            // 
            // Employee_App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Employee_App";
            this.Text = "Employee_App";
            this.Load += new System.EventHandler(this.Employee_App_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblEmployeeNumber;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.PictureBox profilePicture;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.PictureBox contractPicture;
        private System.Windows.Forms.Button btnDownloadContract;
        private System.Windows.Forms.Label lblDownloadResult;
    }
}