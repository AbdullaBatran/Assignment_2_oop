using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_oop
{
    internal class HiringDate
    {
        // Properties
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        // Constructor
        public HiringDate(int day, int month, int year)
        {
            if (!IsValidDate(day, month, year))
                throw new ArgumentException("Invalid date provided.");
            Day = day;
            Month = month;
            Year = year;
        }

        // Method to validate the date
        private bool IsValidDate(int day, int month, int year)
        {
            // Validate year
            if (year < 1) return false;

            // Validate month
            if (month < 1 || month > 12) return false;

            // Validate day based on month and year (consider leap years)
            int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (IsLeapYear(year))
                daysInMonth[1] = 29; // February has 29 days in a leap year

            return day > 0 && day <= daysInMonth[month - 1];
        }

        private bool IsLeapYear(int year)
        {
            // Leap year logic
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }

        // Override ToString to display the date
        public override string ToString()
        {
            return $"{Day:D2}/{Month:D2}/{Year}";
        }
    }
}
