using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingBV
{
    class Student
    {
        private string StudentFirstName;
        private string StudentLastName;
        private int StudentAge;
        private string StudentSex;
        private int StudentNumber;
        private int StudentRoomNumber;
        private int StudentBankAccount;
        private int StudentInitialBalance;
        private int index;


        List<string> StFirstNames = new List<string>(){ "Alex", "Charlie", "Carter", "Morgan", "Taylor", "Blake", "Brooke", "Sky", "Dallas", "Dakota" };
        List<string> StLastNames = new List<string>() { "Smith", "Jones", "Johnson", "Williams", "Brown", "Davis", "Miller", "Wilson", "Young", "Coleman" };
        int[] StAge = new int[4] { 18, 19, 20, 21 };
        string[] UserSex = new string[2] { "female", "male" };
        List<int> StNumber = new List<int>() { 1256, 1408, 8967, 1583, 4506, 6964, 3158, 7543, 2486, 2990 };
        List<int> StRoomNumber = new List<int>() { 101, 102, 103, 104, 105, 201, 202, 203, 204, 205 };
        List<int> StBankAccount = new List<int>() { 38289, 12478, 16904, 45963, 75963, 60450, 35902, 75930, 15830, 65803 };
        List<int> StInitialBalance = new List<int>() { 100, 110, 120, 130, 140, 150, 160, 170, 180, 190 };
        
        Random RandomNumber = new Random();

        public void SetStudent(int index)
        {
            this.StudentFirstName = StFirstNames[index];
            this.StudentLastName = StLastNames[index];
            this.StudentAge = StAge[RandomNumber.Next(0, 3)];
            this.StudentSex = UserSex[RandomNumber.Next(0, 1)];
            this.StudentNumber = StNumber[index];
            this.StudentRoomNumber = StRoomNumber[index];
            this.StudentBankAccount = StBankAccount[index];
            this.StudentInitialBalance = StInitialBalance[index];

        }
        
       
        public string GetStudentInfo()
        {
            return $"{this.StudentFirstName} {this.StudentLastName} - Student number: {this.StudentNumber} / Room: {this.StudentRoomNumber}";
        }
        
        
        public void GetIndex(int index)
        {
            this.index = index;
        }
        public string GetName()
        {
            return $"{StFirstNames[index]}"; 
        }
    }
}
