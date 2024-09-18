using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {


            //Done: Print the Sum of numbers
            Console.WriteLine("Print the Sum of numbers");
            Console.WriteLine(numbers.Sum());
            Console.WriteLine("");

            //Done: Print the Average of numbers
            Console.WriteLine("Print the Average of numbers");
            Console.WriteLine(numbers.Average());
            Console.WriteLine("");

            //Done: Order numbers in ascending order and print to the console
            Console.WriteLine("Order numbers in ascending order and print to the console");
            var ascendingNumbers = numbers.OrderBy(num => num);
            foreach (var number in ascendingNumbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("");

            //Done: Order numbers in descending order and print to the console
            Console.WriteLine("Order numbers in descending order and print to the console");
            var descendingNumbers = numbers.OrderByDescending(num => num);
            foreach (var number in descendingNumbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("");

            //Done: Print to the console only the numbers greater than 6
            Console.WriteLine("Print to the console only the numbers greater than 6");
            var greaterThan6 = numbers.Where(num => num > 6);
            foreach (var number in greaterThan6)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("");

            //Done: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**
            Console.WriteLine("Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**");
           var firstFourNumbers = numbers.Take(4);
            foreach (var number in firstFourNumbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("");

            //TODO: Change the value at index 4 to your age, then print the numbers in descending order
            Console.WriteLine("Change the value at index 4 to your age, then print the numbers in descending order");
            numbers[4] = 52;
            var change4thElement = numbers.OrderByDescending(num =>num);

            foreach (var number in change4thElement)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("");

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            
            //Done: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            Console.WriteLine("Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.");
            var sortedEmployees = employees
                .Where(e => e.FirstName.StartsWith("C") || e.FirstName.StartsWith("S"))
                .OrderBy(e => e.FirstName);

            foreach (var employee in sortedEmployees)
            {
                Console.WriteLine(employee.FullName);
            }
            Console.WriteLine("");

            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            Console.WriteLine("Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.");
            var employeesOver26 = employees
                .Where(e => e.Age > 26)
                .OrderBy(e => e.Age)
                .ThenBy(e => e.FirstName);
            foreach (var employee in employeesOver26)
            {
                Console.WriteLine($"Fullname: {employee.FullName}, Age: {employee.Age}");
            }
            Console.WriteLine("");

            //Done: Print the Sum of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            Console.WriteLine("Print the Sum of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.");
            var sumOfEmpoyeesExperience = employees
                .Where(e => e.YearsOfExperience <= 10 && e.Age > 35)
                .Sum(e => e.YearsOfExperience);
            Console.WriteLine(sumOfEmpoyeesExperience);
            Console.WriteLine("");

            //TODO: Now print the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            Console.WriteLine("Now print the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.");
            var averageOfEmployeesExperience = employees
                .Where(e => e.YearsOfExperience <= 10 && e.Age > 35)
                .Average(e => e.YearsOfExperience);
            Console.WriteLine(averageOfEmployeesExperience);
            Console.WriteLine("");

            //TODO: Add an employee to the end of the list without using employees.Add()
            Console.WriteLine("Add an employee to the end of the list without using employees.Add()");
            employees = employees.Concat(new List<Employee> { new Employee("Rick", "Jones", 32, 10) }).ToList();
            foreach (var employee in employees) 
            {
                Console.WriteLine($"Name: {employee.FullName}, Age: {employee.Age}, YOE: {employee.YearsOfExperience}");
            }
            Console.WriteLine("");
            

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
