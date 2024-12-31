using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_oop
{
    enum SecurityLevel
    {
        Guest,
        Developer,
        Secretary,
        DBA,
        SecurityOfficer
    }
    internal class Employee
    {
        // Properties
        public int ID { get; set; }
        public string Name { get; set; }
        private string gender;
        public string Gender
        {
            get => gender;
            set
            {
                if (value == "M" || value == "F")
                    gender = value;
                else
                    throw new ArgumentException("Gender must be 'M' or 'F'.");
            }
        }
        public SecurityLevel Security { get; set; }
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }

        // Default Constructor
        public Employee()
        {
            ID = 0;
            Name = "Unknown";
            Gender = "M";
            Security = SecurityLevel.Guest;
            Salary = 0;
            HireDate = DateTime.Now;
        }

        // Constructor
        public Employee(int id, string name, string gender, SecurityLevel security, decimal salary, DateTime hireDate)
        {
            ID = id;
            Name = name;
            Gender = gender; // This will validate the gender via the property
            Security = security;
            Salary = salary;
            HireDate = hireDate;
        }

        // Override ToString to represent Employee data
        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Gender: {Gender}, Security Level: {Security}, Salary: {String.Format("{0:C}", Salary)}, Hire Date: {HireDate:yyyy-MM-dd}";
        }
    }
}
