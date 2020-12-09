using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingBV
{
    class Employee
    {
        private string EmployeeFirstName;
        private string EmployeeLastName;
        private int EmployeeAge;
        private string EmployeeSex;
        private int EmployeeNumber;
        
        string[] EmployeeFirstNames = new string[5] { "Cameron", "Ezra", "River", "Milan", "Bailey" };
        string[] EmployeeLastNames = new string[5] { "Sanhez", "Morris", "Moore", "Adams", "Anderson" };
        int[] employeeAge = new int[5] { 24, 28, 32, 36, 26 };
        string[] UserSex = new string[2] { "female", "male" };
        int[] employeeNumber = new int[5] { 1, 2, 3, 4, 5 };

        Random RandomNumber = new Random();

        public Employee(int index)
        {
            this.EmployeeFirstName = EmployeeFirstNames[index];
            this.EmployeeLastName = EmployeeLastNames[index];
            this.EmployeeAge = employeeAge[RandomNumber.Next(0, 4)];
            this.EmployeeSex = UserSex[RandomNumber.Next(0, 1)];
            this.EmployeeNumber = employeeNumber[index];
        }
        public string GetEmployeeInfo()
        {
            return $"{this.EmployeeFirstName} {this.EmployeeLastName} - Employee number: {this.EmployeeNumber}";
        }

    }
}
