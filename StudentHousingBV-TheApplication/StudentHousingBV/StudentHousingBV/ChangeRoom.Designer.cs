
namespace StudentHousingBV
{
    partial class ChangeRoom
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
            this.pnlChangeRoom = new System.Windows.Forms.Panel();
            this.gbBookNewRoom = new System.Windows.Forms.GroupBox();
            this.cbTypeOfAccomodation = new System.Windows.Forms.ComboBox();
            this.rb2people = new System.Windows.Forms.RadioButton();
            this.rb1person = new System.Windows.Forms.RadioButton();
            this.rb0People = new System.Windows.Forms.RadioButton();
            this.btnBookNow = new System.Windows.Forms.Button();
            this.lboxAvailableRooms = new System.Windows.Forms.ListBox();
            this.lbNewRent = new System.Windows.Forms.Label();
            this.lbAvailableRooms = new System.Windows.Forms.Label();
            this.lbNumberOfPeople = new System.Windows.Forms.Label();
            this.lbTypeOfAccomodation = new System.Windows.Forms.Label();
            this.gbCurrentRoomDetails = new System.Windows.Forms.GroupBox();
            this.lblNewRoomNumber = new System.Windows.Forms.Label();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.lblTypeOfAccomodation = new System.Windows.Forms.Label();
            this.lblRent = new System.Windows.Forms.Label();
            this.lbCurrentRent = new System.Windows.Forms.Label();
            this.lbCurrentTypeOfAcc = new System.Windows.Forms.Label();
            this.pnlChangeRoom.SuspendLayout();
            this.gbBookNewRoom.SuspendLayout();
            this.gbCurrentRoomDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlChangeRoom
            // 
            this.pnlChangeRoom.BackColor = System.Drawing.Color.Lavender;
            this.pnlChangeRoom.Controls.Add(this.gbBookNewRoom);
            this.pnlChangeRoom.Controls.Add(this.gbCurrentRoomDetails);
            this.pnlChangeRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pnlChangeRoom.Location = new System.Drawing.Point(21, 22);
            this.pnlChangeRoom.Name = "pnlChangeRoom";
            this.pnlChangeRoom.Size = new System.Drawing.Size(783, 607);
            this.pnlChangeRoom.TabIndex = 3;
            // 
            // gbBookNewRoom
            // 
            this.gbBookNewRoom.Controls.Add(this.cbTypeOfAccomodation);
            this.gbBookNewRoom.Controls.Add(this.rb2people);
            this.gbBookNewRoom.Controls.Add(this.rb1person);
            this.gbBookNewRoom.Controls.Add(this.rb0People);
            this.gbBookNewRoom.Controls.Add(this.btnBookNow);
            this.gbBookNewRoom.Controls.Add(this.lboxAvailableRooms);
            this.gbBookNewRoom.Controls.Add(this.lbNewRent);
            this.gbBookNewRoom.Controls.Add(this.lbAvailableRooms);
            this.gbBookNewRoom.Controls.Add(this.lbNumberOfPeople);
            this.gbBookNewRoom.Controls.Add(this.lbTypeOfAccomodation);
            this.gbBookNewRoom.Location = new System.Drawing.Point(36, 273);
            this.gbBookNewRoom.Name = "gbBookNewRoom";
            this.gbBookNewRoom.Size = new System.Drawing.Size(709, 308);
            this.gbBookNewRoom.TabIndex = 3;
            this.gbBookNewRoom.TabStop = false;
            this.gbBookNewRoom.Text = "Book new room";
            // 
            // cbTypeOfAccomodation
            // 
            this.cbTypeOfAccomodation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbTypeOfAccomodation.FormattingEnabled = true;
            this.cbTypeOfAccomodation.Items.AddRange(new object[] {
            "Room",
            "Studio",
            "Apartment"});
            this.cbTypeOfAccomodation.Location = new System.Drawing.Point(290, 90);
            this.cbTypeOfAccomodation.Name = "cbTypeOfAccomodation";
            this.cbTypeOfAccomodation.Size = new System.Drawing.Size(385, 33);
            this.cbTypeOfAccomodation.TabIndex = 23;
            this.cbTypeOfAccomodation.SelectedValueChanged += new System.EventHandler(this.cbTypeOfAccomodation_SelectedValueChanged);
            // 
            // rb2people
            // 
            this.rb2people.AutoSize = true;
            this.rb2people.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb2people.Location = new System.Drawing.Point(522, 44);
            this.rb2people.Name = "rb2people";
            this.rb2people.Size = new System.Drawing.Size(44, 29);
            this.rb2people.TabIndex = 22;
            this.rb2people.TabStop = true;
            this.rb2people.Text = "2";
            this.rb2people.UseVisualStyleBackColor = true;
            // 
            // rb1person
            // 
            this.rb1person.AutoSize = true;
            this.rb1person.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb1person.Location = new System.Drawing.Point(371, 44);
            this.rb1person.Name = "rb1person";
            this.rb1person.Size = new System.Drawing.Size(44, 29);
            this.rb1person.TabIndex = 21;
            this.rb1person.TabStop = true;
            this.rb1person.Text = "1";
            this.rb1person.UseVisualStyleBackColor = true;
            // 
            // rb0People
            // 
            this.rb0People.AutoSize = true;
            this.rb0People.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb0People.Location = new System.Drawing.Point(227, 44);
            this.rb0People.Name = "rb0People";
            this.rb0People.Size = new System.Drawing.Size(44, 29);
            this.rb0People.TabIndex = 20;
            this.rb0People.TabStop = true;
            this.rb0People.Text = "0";
            this.rb0People.UseVisualStyleBackColor = true;
            // 
            // btnBookNow
            // 
            this.btnBookNow.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnBookNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBookNow.Location = new System.Drawing.Point(522, 236);
            this.btnBookNow.Name = "btnBookNow";
            this.btnBookNow.Size = new System.Drawing.Size(153, 53);
            this.btnBookNow.TabIndex = 19;
            this.btnBookNow.Text = "Book Now";
            this.btnBookNow.UseVisualStyleBackColor = false;
            this.btnBookNow.Click += new System.EventHandler(this.btnBookNow_Click);
            // 
            // lboxAvailableRooms
            // 
            this.lboxAvailableRooms.FormattingEnabled = true;
            this.lboxAvailableRooms.ItemHeight = 29;
            this.lboxAvailableRooms.Location = new System.Drawing.Point(32, 178);
            this.lboxAvailableRooms.Name = "lboxAvailableRooms";
            this.lboxAvailableRooms.Size = new System.Drawing.Size(468, 120);
            this.lboxAvailableRooms.TabIndex = 18;
            this.lboxAvailableRooms.SelectedIndexChanged += new System.EventHandler(this.lboxAvailableRooms_SelectedIndexChanged);
            // 
            // lbNewRent
            // 
            this.lbNewRent.AutoSize = true;
            this.lbNewRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbNewRent.Location = new System.Drawing.Point(506, 178);
            this.lbNewRent.Name = "lbNewRent";
            this.lbNewRent.Size = new System.Drawing.Size(12, 25);
            this.lbNewRent.TabIndex = 17;
            this.lbNewRent.Text = "\r\n";
            // 
            // lbAvailableRooms
            // 
            this.lbAvailableRooms.AutoSize = true;
            this.lbAvailableRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAvailableRooms.Location = new System.Drawing.Point(27, 138);
            this.lbAvailableRooms.Name = "lbAvailableRooms";
            this.lbAvailableRooms.Size = new System.Drawing.Size(157, 25);
            this.lbAvailableRooms.TabIndex = 16;
            this.lbAvailableRooms.Text = "Available rooms:";
            // 
            // lbNumberOfPeople
            // 
            this.lbNumberOfPeople.AutoSize = true;
            this.lbNumberOfPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbNumberOfPeople.Location = new System.Drawing.Point(27, 46);
            this.lbNumberOfPeople.Name = "lbNumberOfPeople";
            this.lbNumberOfPeople.Size = new System.Drawing.Size(172, 25);
            this.lbNumberOfPeople.TabIndex = 15;
            this.lbNumberOfPeople.Text = "Number of people:";
            // 
            // lbTypeOfAccomodation
            // 
            this.lbTypeOfAccomodation.AutoSize = true;
            this.lbTypeOfAccomodation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTypeOfAccomodation.Location = new System.Drawing.Point(27, 93);
            this.lbTypeOfAccomodation.Name = "lbTypeOfAccomodation";
            this.lbTypeOfAccomodation.Size = new System.Drawing.Size(211, 25);
            this.lbTypeOfAccomodation.TabIndex = 14;
            this.lbTypeOfAccomodation.Text = "Type of accomodation:";
            // 
            // gbCurrentRoomDetails
            // 
            this.gbCurrentRoomDetails.Controls.Add(this.lblNewRoomNumber);
            this.gbCurrentRoomDetails.Controls.Add(this.lblRoomNumber);
            this.gbCurrentRoomDetails.Controls.Add(this.lblTypeOfAccomodation);
            this.gbCurrentRoomDetails.Controls.Add(this.lblRent);
            this.gbCurrentRoomDetails.Controls.Add(this.lbCurrentRent);
            this.gbCurrentRoomDetails.Controls.Add(this.lbCurrentTypeOfAcc);
            this.gbCurrentRoomDetails.Location = new System.Drawing.Point(36, 35);
            this.gbCurrentRoomDetails.Name = "gbCurrentRoomDetails";
            this.gbCurrentRoomDetails.Size = new System.Drawing.Size(709, 222);
            this.gbCurrentRoomDetails.TabIndex = 2;
            this.gbCurrentRoomDetails.TabStop = false;
            this.gbCurrentRoomDetails.Text = "Your current room details";
            // 
            // lblNewRoomNumber
            // 
            this.lblNewRoomNumber.AutoSize = true;
            this.lblNewRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNewRoomNumber.Location = new System.Drawing.Point(580, 143);
            this.lblNewRoomNumber.Name = "lblNewRoomNumber";
            this.lblNewRoomNumber.Size = new System.Drawing.Size(0, 25);
            this.lblNewRoomNumber.TabIndex = 8;
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRoomNumber.Location = new System.Drawing.Point(331, 143);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(0, 25);
            this.lblRoomNumber.TabIndex = 7;
            // 
            // lblTypeOfAccomodation
            // 
            this.lblTypeOfAccomodation.AutoSize = true;
            this.lblTypeOfAccomodation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTypeOfAccomodation.Location = new System.Drawing.Point(285, 63);
            this.lblTypeOfAccomodation.Name = "lblTypeOfAccomodation";
            this.lblTypeOfAccomodation.Size = new System.Drawing.Size(0, 25);
            this.lblTypeOfAccomodation.TabIndex = 6;
            // 
            // lblRent
            // 
            this.lblRent.AutoSize = true;
            this.lblRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRent.Location = new System.Drawing.Point(103, 143);
            this.lblRent.Name = "lblRent";
            this.lblRent.Size = new System.Drawing.Size(0, 25);
            this.lblRent.TabIndex = 5;
            // 
            // lbCurrentRent
            // 
            this.lbCurrentRent.AutoSize = true;
            this.lbCurrentRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCurrentRent.Location = new System.Drawing.Point(34, 143);
            this.lbCurrentRent.Name = "lbCurrentRent";
            this.lbCurrentRent.Size = new System.Drawing.Size(63, 25);
            this.lbCurrentRent.TabIndex = 3;
            this.lbCurrentRent.Text = "Rent:";
            // 
            // lbCurrentTypeOfAcc
            // 
            this.lbCurrentTypeOfAcc.AutoSize = true;
            this.lbCurrentTypeOfAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCurrentTypeOfAcc.Location = new System.Drawing.Point(36, 63);
            this.lbCurrentTypeOfAcc.Name = "lbCurrentTypeOfAcc";
            this.lbCurrentTypeOfAcc.Size = new System.Drawing.Size(235, 25);
            this.lbCurrentTypeOfAcc.TabIndex = 2;
            this.lbCurrentTypeOfAcc.Text = "Type of Accomodation:";
            this.lbCurrentTypeOfAcc.Click += new System.EventHandler(this.lbCurrentTypeOfAcc_Click);
            // 
            // ChangeRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlChangeRoom);
            this.Name = "ChangeRoom";
            this.Size = new System.Drawing.Size(824, 650);
            this.Load += new System.EventHandler(this.ChangeRoom_Load);
            this.pnlChangeRoom.ResumeLayout(false);
            this.gbBookNewRoom.ResumeLayout(false);
            this.gbBookNewRoom.PerformLayout();
            this.gbCurrentRoomDetails.ResumeLayout(false);
            this.gbCurrentRoomDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlChangeRoom;
        private System.Windows.Forms.GroupBox gbBookNewRoom;
        private System.Windows.Forms.ComboBox cbTypeOfAccomodation;
        private System.Windows.Forms.RadioButton rb2people;
        private System.Windows.Forms.RadioButton rb1person;
        private System.Windows.Forms.RadioButton rb0People;
        private System.Windows.Forms.Button btnBookNow;
        private System.Windows.Forms.ListBox lboxAvailableRooms;
        private System.Windows.Forms.Label lbNewRent;
        private System.Windows.Forms.Label lbAvailableRooms;
        private System.Windows.Forms.Label lbNumberOfPeople;
        private System.Windows.Forms.Label lbTypeOfAccomodation;
        private System.Windows.Forms.GroupBox gbCurrentRoomDetails;
        private System.Windows.Forms.Label lblTypeOfAccomodation;
        private System.Windows.Forms.Label lblRent;
        private System.Windows.Forms.Label lbCurrentRent;
        private System.Windows.Forms.Label lbCurrentTypeOfAcc;
        private System.Windows.Forms.Label lblNewRoomNumber;
        private System.Windows.Forms.Label lblRoomNumber;
    }
}
