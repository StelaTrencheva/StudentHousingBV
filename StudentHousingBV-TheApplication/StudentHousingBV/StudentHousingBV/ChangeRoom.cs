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
    public partial class ChangeRoom : UserControl
    {
        public Student student;
        private string accomodation;
        private int rent;
        private string newAccomodation;
        private int rentDigitsLength;
        Random random = new Random();
        public ChangeRoom()
        {
            InitializeComponent();
        }
        public void SetStudent(Student student)
        {
            this.student = student;
        }


        private int CalculateRent()
        {
            if (accomodation == "Single room")
            {
                rent = 350;
            }
            else if (accomodation == "Double room")
            {
                rent = 320;
            }
            else if (accomodation == "Triple room")
            {
                rent = 290;
            }
            else if (accomodation == "Studio")
            {
                rent = 680;
            }
            else if (accomodation == "Apartment")
            {
                rent = 1100;
            }
            return rent;
        }
        private void btnBookNow_Click(object sender, EventArgs e)
        {
            
            int roomNumber = random.Next(200);
            student.SetRoomNumber(roomNumber);
            lblRoomNumber.Text= $" {student.GetRoomNumber()}";
            lblRoomNumber.Text = "Room number: ";
            lblNewRoomNumber.Text = roomNumber.ToString();
            lblTypeOfAccomodation.Text= $" {accomodation}";
            lblRent.Text= $" {rent}";      
         }

        private void cbTypeOfAccomodation_SelectedValueChanged(object sender, EventArgs e)
        {
            int numberOfHousemates;
            if (rb1person.Checked)
            {
                numberOfHousemates = 1;
            }
            else if (rb2people.Checked)
            {
                numberOfHousemates = 2;
            }
            else
            {
                numberOfHousemates = 0;
                rb0People.Checked = true;
            }

            string typeOfAccomodation = cbTypeOfAccomodation.SelectedItem.ToString();
            switch (typeOfAccomodation)
            {
                case "Room":
                    {
                        lboxAvailableRooms.Items.Clear();

                        switch (numberOfHousemates)
                        {
                            case 0:
                                {
                                    lboxAvailableRooms.Items.Add("Single room - 12 sq.m - 350 Euro");
                                    lboxAvailableRooms.Items.Add("Single room - 16 sq.m - 360 Euro");
                                    accomodation = "Single room";
                                    rentDigitsLength = 3;
                                }
                                break;
                            case 1:
                                {
                                    lboxAvailableRooms.Items.Add("Double room - 20 sq.m - 310 Euro");
                                    lboxAvailableRooms.Items.Add("Double room - 24 sq.m - 320 Euro");
                                    accomodation = "Double room";
                                    rentDigitsLength = 3;
                                }
                                break;
                            case 2:
                                {
                                    lboxAvailableRooms.Items.Add("Triple room - 26 sq.m - 270 Euro");
                                    lboxAvailableRooms.Items.Add("Triple room - 28 sq.m - 290 Euro");
                                    accomodation = "Triple room";
                                    rentDigitsLength = 3;
                                }
                                break;
                        }

                    }
                    break;
                case "Studio":
                    {
                        lboxAvailableRooms.Items.Clear();
                        accomodation = "Studio";
                        switch (numberOfHousemates)
                        {
                            case 0:
                                {
                                    lboxAvailableRooms.Items.Add("Studio - 40 sq.m - 690 Euro");
                                    lboxAvailableRooms.Items.Add("Studio - 36 sq.m - 620 Euro");
                                    rentDigitsLength = 3;
                                }
                                break;
                            case 1:
                                {
                                    lboxAvailableRooms.Items.Add("Studio - 42 sq.m - 480 Euro");
                                    lboxAvailableRooms.Items.Add("Studio - 46 sq.m - 520 Euro");
                                    rentDigitsLength = 3;
                                }
                                break;
                            case 2:
                                {
                                    lboxAvailableRooms.Items.Add("You can stay in a studio only with one more student!");
                                    rentDigitsLength = 0;
                                }
                                break;
                        }
                    }
                    break;
                case "Apartment":
                    {
                        lboxAvailableRooms.Items.Clear();
                        accomodation = "Apartment";
                        switch (numberOfHousemates)
                        {

                            case 0:
                                {
                                    lboxAvailableRooms.Items.Add("Apartment - 72 sq.m - 1000 Euro");
                                    lboxAvailableRooms.Items.Add("Apartment - 86 sq.m - 1300 Euro");
                                    rentDigitsLength = 4;
                                }
                                break;
                            case 1:
                                {
                                    lboxAvailableRooms.Items.Add("Apartment - 90 sq.m - 650 Euro");
                                    lboxAvailableRooms.Items.Add("Apartment - 94 sq.m - 730 Euro");
                                    rentDigitsLength = 3;
                                }
                                break;
                            case 2:
                                {
                                    lboxAvailableRooms.Items.Add("Apartment - 106 sq.m - 580 Euro");
                                    lboxAvailableRooms.Items.Add("Apartment - 102 sq.m - 540 Euro");
                                    rentDigitsLength = 3;
                                }
                                break;
                        }
                    }
                    break;
            }
        }

        private void lboxAvailableRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            newAccomodation = lboxAvailableRooms.SelectedItem.ToString();
            string newRent = newAccomodation.Substring(newAccomodation.Length - 5-rentDigitsLength, 5+rentDigitsLength);
            lbNewRent.Text = $"New rent: {newRent}";
            rent = Convert.ToInt32(newRent.Substring(0, rentDigitsLength));
        }

        private void ChangeRoom_Load(object sender, EventArgs e)
        {
            string[] typeOfAccomodations = new string[5] { "Single room", "Studio", "Apartment", "Double room", "Triple room" };
            accomodation = typeOfAccomodations[random.Next(5)];
            lblTypeOfAccomodation.Text = accomodation;
            lblRent.Text = CalculateRent().ToString();
        }

        private void lbCurrentTypeOfAcc_Click(object sender, EventArgs e)
        {

        }
    }
}
