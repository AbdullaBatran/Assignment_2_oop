namespace Assignment_2_oop
{
    internal class Program
    {
        struct Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
        struct Point
        {
            public double X { get; set; }
            public double Y { get; set; }
        }
        static int BoxingUnboxingCount = 0;
        static void Main(string[] args)
        {
            //************************************* Assignment_2_oop *********************************************//
            //***************************************   Part_1 ***************************************************//
            #region Question 1
            ////Define a struct "Person" with properties "Name" and "Age".
            ////Create an array of three "Person" objects and populate it with data.
            ////Then, write a C# program to display the details of all the persons in the array.

            //// Create an array of Person objects
            //Person[] people = new Person[3];

            //// Populate the array with data
            //people[0] = new Person { Name = "Alice", Age = 25 };
            //people[1] = new Person { Name = "Bob", Age = 30 };
            //people[2] = new Person { Name = "Charlie", Age = 35 };

            //// Display the details of all persons
            //Console.WriteLine("Details of persons:");
            //foreach (var person in people)
            //{
            //    Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            //}



            #endregion

            #region Question 2
            //// Create a struct called "Point" to represent a 2D point with properties "X" and "Y".
            //// Write a C# program that takes two points as input from the user and calculates the distance between them.


            //// Read first point from the user
            //Console.WriteLine("Enter the coordinates for the first point:");
            //Console.Write("X1: ");
            //double x1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Y1: ");
            //double y1 = Convert.ToDouble(Console.ReadLine());

            //// Read second point from the user
            //Console.WriteLine("Enter the coordinates for the second point:");
            //Console.Write("X2: ");
            //double x2 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Y2: ");
            //double y2 = Convert.ToDouble(Console.ReadLine());

            //// Create Point objects
            //Point point1 = new Point { X = x1, Y = y1 };
            //Point point2 = new Point { X = x2, Y = y2 };

            //// Calculate the distance
            //double distance = CalculateDistance(point1, point2);

            //// Display the result
            //Console.WriteLine($"The distance between the two points is: {distance:F2}");


            #endregion

            #region Question 3
            //// Create a struct called "Person" with properties "Name" and "Age".
            //// Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.


            //// Array to store 3 persons
            //Person[] people = new Person[3];

            //// Take input for each person
            //for (int i = 0; i < people.Length; i++)
            //{
            //    Console.WriteLine($"Enter details for person {i + 1}:");
            //    Console.Write("Name: ");
            //    string name = Console.ReadLine();

            //    Console.Write("Age: ");
            //    int age = int.Parse(Console.ReadLine());

            //    people[i] = new Person { Name = name, Age = age };
            //}

            //// Find the oldest person
            //Person oldestPerson = people[0];
            //foreach (var person in people)
            //{
            //    if (person.Age > oldestPerson.Age)
            //    {
            //        oldestPerson = person;
            //    }
            //}

            //// Display the name and age of the oldest person
            //Console.WriteLine($"The oldest person is {oldestPerson.Name} with an age of {oldestPerson.Age}.");
            #endregion


            //*************************************** Part_2 ******************************************//

            #region Question 1
            //try
            //{
            //    // Create Employee instances
            //    Employee emp1 = new Employee(1, "Alice", "F", SecurityLevel.Developer, 75000.50m, new DateTime(2020, 6, 15));
            //    Employee emp2 = new Employee(2, "Bob", "M", SecurityLevel.DBA, 85000.75m, new DateTime(2019, 3, 1));

            //    // Display employee details
            //    Console.WriteLine("Employee Details:");
            //    Console.WriteLine(emp1);
            //    Console.WriteLine(emp2);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}
            #endregion

            #region Question  2
            //try
            //{
            //    // Create a HiringDate instance
            //    HiringDate hireDate = new HiringDate(15, 6, 2020);
            //    Console.WriteLine($"Hiring Date: {hireDate}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}
            #endregion

            #region Question 3
            //try
            //{
            //    // Create an array of Employees with size 3
            //    Employee[] EmpArr = new Employee[3];

            //    // Initialize employees
            //    EmpArr[0] = new Employee(1, "Alice", "F", SecurityLevel.DBA, 85000.50m, new DateTime(2019, 5, 10));
            //    EmpArr[1] = new Employee(2, "Bob", "M", SecurityLevel.Guest, 35000.00m, new DateTime(2021, 8, 15));
            //    EmpArr[2] = new Employee(3, "Charlie", "M", SecurityLevel.SecurityOfficer, 95000.75m, new DateTime(2018, 3, 1));

            //    // Display details of all employees
            //    Console.WriteLine("Employee Details:");
            //    foreach (var emp in EmpArr)
            //    {
            //        Console.WriteLine(emp);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}
            #endregion

            #region  Question 4
            //try
            //{
            //    // Create an array of Employees with size 3
            //    Employee[] EmpArr = new Employee[3];
            //    EmpArr[0] = new Employee(1, "Alice", "F", SecurityLevel.DBA, 85000.50m, new DateTime(2019, 5, 10));
            //    EmpArr[1] = new Employee(2, "Bob", "M", SecurityLevel.Guest, 35000.00m, new DateTime(2021, 8, 15));
            //    EmpArr[2] = new Employee(3, "Charlie", "M", SecurityLevel.SecurityOfficer, 95000.75m, new DateTime(2018, 3, 1));

            //    // Sort employees by hire date
            //    Array.Sort(EmpArr, CompareHireDate);

            //    // Display sorted employees
            //    Console.WriteLine("Employees sorted by hire date:");
            //    foreach (var emp in EmpArr)
            //    {
            //        Console.WriteLine(emp);
            //    }

            //    // Display boxing/unboxing count
            //    Console.WriteLine($"\nNumber of Boxing/Unboxing operations during sorting: {BoxingUnboxingCount}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}
            #endregion 
        }
        static double CalculateDistance(Point p1, Point p2)
        {
            double deltaX = p2.X - p1.X;
            double deltaY = p2.Y - p1.Y;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }
        // Comparison function for sorting by hire date
        static int CompareHireDate(Employee emp1, Employee emp2)
        {
            // Increment boxing/unboxing count
            BoxingUnboxingCount += 2; // Each comparison involves boxing for DateTime.Compare
            return DateTime.Compare(emp1.HireDate, emp2.HireDate);
        }
    }
}
