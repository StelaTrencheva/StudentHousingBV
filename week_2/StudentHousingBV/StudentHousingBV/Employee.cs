using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingBV
{
    public class Employee
    {
        private string EmployeeFirstName;
        private string EmployeeLastName;
        private int EmployeeAge;
        private string EmployeeSex;
        private int EmployeeNumber;
       
        public Employee(
            string FirstName,
            string LastName,
            int Age,
            string Sex,
            int Number
            )
        {
            this.EmployeeFirstName = FirstName;
            this.EmployeeLastName = LastName;
            this.EmployeeAge = Age;
            this.EmployeeSex = Sex;
            this.EmployeeNumber = Number;
        }
        public string GetEmployeeInfo()
        {
            return $"{this.EmployeeFirstName} {this.EmployeeLastName} - Employee number: {this.EmployeeNumber}";
        }
        public string GetName()
        {
            return $"{EmployeeFirstName} {EmployeeLastName}";
        }
        public int GetAge()
        {
            return EmployeeAge;
        }
        public string GetSex()
        {
            return EmployeeSex;
        }
        public int GetEmployeeNumber()
        {
            return EmployeeNumber;
        }
    }
}
