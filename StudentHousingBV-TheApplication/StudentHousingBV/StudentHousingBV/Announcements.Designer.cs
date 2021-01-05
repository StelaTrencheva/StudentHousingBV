
namespace StudentHousingBV
{
    partial class Announcements
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
            this.pnlAnnouncements = new System.Windows.Forms.Panel();
            this.btnDeleteAnnouncement = new System.Windows.Forms.Button();
            this.btnRestrictions = new System.Windows.Forms.Button();
            this.lbRestrictions = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbRoom = new System.Windows.Forms.Label();
            this.tbRoom = new System.Windows.Forms.TextBox();
            this.time = new System.Windows.Forms.DateTimePicker();
            this.btnAddAnnouncement = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.tbAnnouncementTitle = new System.Windows.Forms.TextBox();
            this.lbDate = new System.Windows.Forms.Label();
            this.rbFormal = new System.Windows.Forms.RadioButton();
            this.rbParty = new System.Windows.Forms.RadioButton();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.tbcAnnouncements = new System.Windows.Forms.TabControl();
            this.tPPartyAnnouncements = new System.Windows.Forms.TabPage();
            this.lbPartyAnnouncements = new System.Windows.Forms.ListBox();
            this.tPFormalAnnouncements = new System.Windows.Forms.TabPage();
            this.lbFormalAnnouncements = new System.Windows.Forms.ListBox();
            this.tPCovidAnnouncements = new System.Windows.Forms.TabPage();
            this.pnlAnnouncements.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tbcAnnouncements.SuspendLayout();
            this.tPPartyAnnouncements.SuspendLayout();
            this.tPFormalAnnouncements.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAnnouncements
            // 
            this.pnlAnnouncements.BackColor = System.Drawing.Color.Lavender;
            this.pnlAnnouncements.Controls.Add(this.btnDeleteAnnouncement);
            this.pnlAnnouncements.Controls.Add(this.btnRestrictions);
            this.pnlAnnouncements.Controls.Add(this.lbRestrictions);
            this.pnlAnnouncements.Controls.Add(this.groupBox1);
            this.pnlAnnouncements.Controls.Add(this.tbcAnnouncements);
            this.pnlAnnouncements.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pnlAnnouncements.Location = new System.Drawing.Point(21, 22);
            this.pnlAnnouncements.Name = "pnlAnnouncements";
            this.pnlAnnouncements.Size = new System.Drawing.Size(783, 607);
            this.pnlAnnouncements.TabIndex = 1;
            // 
            // btnDeleteAnnouncement
            // 
            this.btnDeleteAnnouncement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteAnnouncement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteAnnouncement.Location = new System.Drawing.Point(545, 518);
            this.btnDeleteAnnouncement.Name = "btnDeleteAnnouncement";
            this.btnDeleteAnnouncement.Size = new System.Drawing.Size(199, 70);
            this.btnDeleteAnnouncement.TabIndex = 12;
            this.btnDeleteAnnouncement.Text = "Delete Announcement";
            this.btnDeleteAnnouncement.UseVisualStyleBackColor = false;
            this.btnDeleteAnnouncement.Click += new System.EventHandler(this.btnDeleteAnnouncement_Click);
            // 
            // btnRestrictions
            // 
            this.btnRestrictions.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnRestrictions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRestrictions.Location = new System.Drawing.Point(36, 518);
            this.btnRestrictions.Name = "btnRestrictions";
            this.btnRestrictions.Size = new System.Drawing.Size(158, 45);
            this.btnRestrictions.TabIndex = 9;
            this.btnRestrictions.Text = "Restrictions";
            this.btnRestrictions.UseVisualStyleBackColor = false;
            this.btnRestrictions.MouseLeave += new System.EventHandler(this.btnRestrictions_MouseLeave);
            this.btnRestrictions.MouseHover += new System.EventHandler(this.btnRestrictions_MouseHover);
            // 
            // lbRestrictions
            // 
            this.lbRestrictions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbRestrictions.FormattingEnabled = true;
            this.lbRestrictions.ItemHeight = 22;
            this.lbRestrictions.Items.AddRange(new object[] {
            "* Maximum allowed people in one room is 5",
            "* Wear your masks while being in a room with more people",
            "* Keep distance of 1.5m "});
            this.lbRestrictions.Location = new System.Drawing.Point(200, 518);
            this.lbRestrictions.Name = "lbRestrictions";
            this.lbRestrictions.Size = new System.Drawing.Size(544, 70);
            this.lbRestrictions.TabIndex = 2;
            this.lbRestrictions.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbRoom);
            this.groupBox1.Controls.Add(this.tbRoom);
            this.groupBox1.Controls.Add(this.time);
            this.groupBox1.Controls.Add(this.btnAddAnnouncement);
            this.groupBox1.Controls.Add(this.date);
            this.groupBox1.Controls.Add(this.tbAnnouncementTitle);
            this.groupBox1.Controls.Add(this.lbDate);
            this.groupBox1.Controls.Add(this.rbFormal);
            this.groupBox1.Controls.Add(this.rbParty);
            this.groupBox1.Controls.Add(this.lbTitle);
            this.groupBox1.Controls.Add(this.lbType);
            this.groupBox1.Location = new System.Drawing.Point(36, 349);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(708, 152);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add your announcement";
            // 
            // lbRoom
            // 
            this.lbRoom.AutoSize = true;
            this.lbRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbRoom.Location = new System.Drawing.Point(475, 42);
            this.lbRoom.Name = "lbRoom";
            this.lbRoom.Size = new System.Drawing.Size(69, 25);
            this.lbRoom.TabIndex = 11;
            this.lbRoom.Text = "Room:";
            // 
            // tbRoom
            // 
            this.tbRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRoom.Location = new System.Drawing.Point(550, 40);
            this.tbRoom.Name = "tbRoom";
            this.tbRoom.Size = new System.Drawing.Size(109, 30);
            this.tbRoom.TabIndex = 10;
            // 
            // time
            // 
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.time.Location = new System.Drawing.Point(414, 113);
            this.time.Name = "time";
            this.time.ShowUpDown = true;
            this.time.Size = new System.Drawing.Size(130, 30);
            this.time.TabIndex = 9;
            this.time.Value = new System.DateTime(2021, 1, 5, 12, 27, 36, 0);
            // 
            // btnAddAnnouncement
            // 
            this.btnAddAnnouncement.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAddAnnouncement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddAnnouncement.Location = new System.Drawing.Point(597, 90);
            this.btnAddAnnouncement.Name = "btnAddAnnouncement";
            this.btnAddAnnouncement.Size = new System.Drawing.Size(105, 53);
            this.btnAddAnnouncement.TabIndex = 8;
            this.btnAddAnnouncement.Text = "Add";
            this.btnAddAnnouncement.UseVisualStyleBackColor = false;
            this.btnAddAnnouncement.Click += new System.EventHandler(this.btnAddAnnouncement_Click);
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date.Location = new System.Drawing.Point(165, 113);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(243, 30);
            this.date.TabIndex = 7;
            this.date.Value = new System.DateTime(2021, 1, 4, 23, 25, 40, 0);
            // 
            // tbAnnouncementTitle
            // 
            this.tbAnnouncementTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAnnouncementTitle.Location = new System.Drawing.Point(82, 77);
            this.tbAnnouncementTitle.Name = "tbAnnouncementTitle";
            this.tbAnnouncementTitle.Size = new System.Drawing.Size(387, 30);
            this.tbAnnouncementTitle.TabIndex = 6;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDate.Location = new System.Drawing.Point(21, 118);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(138, 25);
            this.lbDate.TabIndex = 3;
            this.lbDate.Text = "Date and time:";
            // 
            // rbFormal
            // 
            this.rbFormal.AutoSize = true;
            this.rbFormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbFormal.Location = new System.Drawing.Point(281, 40);
            this.rbFormal.Name = "rbFormal";
            this.rbFormal.Size = new System.Drawing.Size(93, 29);
            this.rbFormal.TabIndex = 5;
            this.rbFormal.TabStop = true;
            this.rbFormal.Text = "Formal";
            this.rbFormal.UseVisualStyleBackColor = true;
            // 
            // rbParty
            // 
            this.rbParty.AutoSize = true;
            this.rbParty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbParty.Location = new System.Drawing.Point(114, 40);
            this.rbParty.Name = "rbParty";
            this.rbParty.Size = new System.Drawing.Size(78, 29);
            this.rbParty.TabIndex = 4;
            this.rbParty.TabStop = true;
            this.rbParty.Text = "Party";
            this.rbParty.UseVisualStyleBackColor = true;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTitle.Location = new System.Drawing.Point(21, 79);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(55, 25);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Title:";
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbType.Location = new System.Drawing.Point(21, 42);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(63, 25);
            this.lbType.TabIndex = 0;
            this.lbType.Text = "Type:";
            // 
            // tbcAnnouncements
            // 
            this.tbcAnnouncements.Controls.Add(this.tPPartyAnnouncements);
            this.tbcAnnouncements.Controls.Add(this.tPFormalAnnouncements);
            this.tbcAnnouncements.Controls.Add(this.tPCovidAnnouncements);
            this.tbcAnnouncements.Location = new System.Drawing.Point(18, 35);
            this.tbcAnnouncements.Name = "tbcAnnouncements";
            this.tbcAnnouncements.SelectedIndex = 0;
            this.tbcAnnouncements.Size = new System.Drawing.Size(748, 308);
            this.tbcAnnouncements.TabIndex = 1;
            this.tbcAnnouncements.SelectedIndexChanged += new System.EventHandler(this.tbcAnnouncements_SelectedIndexChanged);
            // 
            // tPPartyAnnouncements
            // 
            this.tPPartyAnnouncements.BackColor = System.Drawing.Color.Lavender;
            this.tPPartyAnnouncements.Controls.Add(this.lbPartyAnnouncements);
            this.tPPartyAnnouncements.Location = new System.Drawing.Point(4, 38);
            this.tPPartyAnnouncements.Name = "tPPartyAnnouncements";
            this.tPPartyAnnouncements.Size = new System.Drawing.Size(740, 266);
            this.tPPartyAnnouncements.TabIndex = 0;
            this.tPPartyAnnouncements.Text = "Party";
            // 
            // lbPartyAnnouncements
            // 
            this.lbPartyAnnouncements.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPartyAnnouncements.FormattingEnabled = true;
            this.lbPartyAnnouncements.HorizontalScrollbar = true;
            this.lbPartyAnnouncements.ItemHeight = 25;
            this.lbPartyAnnouncements.Items.AddRange(new object[] {
            "--> Birthday Party - Date: 20.01.2021 - Room: 21 - Time: 20:00h - Alex Smith"});
            this.lbPartyAnnouncements.Location = new System.Drawing.Point(5, 39);
            this.lbPartyAnnouncements.Name = "lbPartyAnnouncements";
            this.lbPartyAnnouncements.Size = new System.Drawing.Size(730, 179);
            this.lbPartyAnnouncements.TabIndex = 1; // 
            // tPFormalAnnouncements
            // 
            this.tPFormalAnnouncements.BackColor = System.Drawing.Color.Lavender;
            this.tPFormalAnnouncements.Controls.Add(this.lbFormalAnnouncements);
            this.tPFormalAnnouncements.Location = new System.Drawing.Point(4, 38);
            this.tPFormalAnnouncements.Name = "tPFormalAnnouncements";
            this.tPFormalAnnouncements.Size = new System.Drawing.Size(740, 266);
            this.tPFormalAnnouncements.TabIndex = 1;
            this.tPFormalAnnouncements.Text = "Formal";
            // 
            // lbFormalAnnouncements
            // 
            this.lbFormalAnnouncements.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbFormalAnnouncements.FormattingEnabled = true;
            this.lbFormalAnnouncements.HorizontalScrollbar = true;
            this.lbFormalAnnouncements.ItemHeight = 25;
            this.lbFormalAnnouncements.Items.AddRange(new object[] {
            "--> House meeting - Date: 23.01.2021 - Room: 0 - Time: 13:00h - Carter Johnson"});
            this.lbFormalAnnouncements.Location = new System.Drawing.Point(3, 36);
            this.lbFormalAnnouncements.Name = "lbFormalAnnouncements";
            this.lbFormalAnnouncements.Size = new System.Drawing.Size(730, 179);
            this.lbFormalAnnouncements.TabIndex = 2;
            // 
            // tPCovidAnnouncements
            // 
            this.tPCovidAnnouncements.Location = new System.Drawing.Point(4, 38);
            this.tPCovidAnnouncements.Name = "tPCovidAnnouncements";
            this.tPCovidAnnouncements.Size = new System.Drawing.Size(740, 266);
            this.tPCovidAnnouncements.TabIndex = 2;
            this.tPCovidAnnouncements.Text = "COVID-19";
            this.tPCovidAnnouncements.UseVisualStyleBackColor = true;
            // 
            // Announcements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlAnnouncements);
            this.Name = "Announcements";
            this.Size = new System.Drawing.Size(824, 650);
            this.pnlAnnouncements.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbcAnnouncements.ResumeLayout(false);
            this.tPPartyAnnouncements.ResumeLayout(false);
            this.tPFormalAnnouncements.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAnnouncements;
        private System.Windows.Forms.TabControl tbcAnnouncements;
        private System.Windows.Forms.TabPage tPPartyAnnouncements;
        private System.Windows.Forms.TabPage tPFormalAnnouncements;
        private System.Windows.Forms.TabPage tPCovidAnnouncements;
        private System.Windows.Forms.ListBox lbPartyAnnouncements;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.TextBox tbAnnouncementTitle;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.RadioButton rbFormal;
        private System.Windows.Forms.RadioButton rbParty;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Button btnRestrictions;
        private System.Windows.Forms.ListBox lbRestrictions;
        private System.Windows.Forms.Button btnAddAnnouncement;
        private System.Windows.Forms.ListBox lbFormalAnnouncements;
        private System.Windows.Forms.DateTimePicker time;
        private System.Windows.Forms.Label lbRoom;
        private System.Windows.Forms.TextBox tbRoom;
        private System.Windows.Forms.Button btnDeleteAnnouncement;
    }
}
