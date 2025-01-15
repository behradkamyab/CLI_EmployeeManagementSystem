

using Employee_Management_System.Models;
using System.Xml.Linq;

namespace Employee_Management_System
{
    public static class InputValidator
    {

        //public static GetValidID(string id , EmployeeManager emp)
        //{
        //    while (true)
        //    {
        //        if (id == null)
        //        {
        //            Console.WriteLine("ID must not be null");
        //        }
        //    }
        //}


        public static string GetValidName(string prompt)
        {
            string name = "";

            while (true)
            {
                Console.WriteLine(prompt);

                name = Console.ReadLine();


                if (string.IsNullOrEmpty(name))
                {

                    Console.WriteLine("Name field must not be empty!");


                }
                else
                {
                    if (int.TryParse(name, out _))
                    {
                        Console.WriteLine("Name cannot be a number!");
                    }
                    else
                    {
                        return name;
                    }
                }
            }
        }

        public static string GetValidDepartment(string prompt)
        {
            string department = "";
            while (true)
            {
                Console.WriteLine(prompt);

                department = Console.ReadLine();

                if (string.IsNullOrEmpty(department))
                {

                    Console.WriteLine("Department field must not be empty!");


                }
                else
                {
                    if (int.TryParse(department, out _))
                    {
                        Console.WriteLine("Department cannot be a number!");
                    }
                    else
                    {
                        return department;
                    }
                }
            }
        }

        public static string GetValidDesignation(string prompt)
        {
            string designation = "";
            while (true)
            {
                Console.WriteLine(prompt);
                designation = Console.ReadLine();

                if (string.IsNullOrEmpty(designation))
                {

                    Console.WriteLine("Designation field must not be empty!");


                }
                else
                {
                    if (int.TryParse(designation, out _))
                    {
                        Console.WriteLine("Designation cannot be a number!");
                    }
                    else
                    {
                        return designation;
                    }
                }
            }
        }

        public static decimal GetValidSalary(string prompt)
        {
            decimal salary = 0;
            while (true)
            {
                Console.WriteLine(prompt);

                if(decimal.TryParse(Console.ReadLine(), out salary))
                {
                    if (salary <= 0)
                    {

                        Console.WriteLine("Salary must not be lower than 0!");
                    }
                    else
                    {
                        return salary;
                    }
                }
                else
                {
                    Console.WriteLine("Enter the right salary ( must not be empty or non-Integer! )");
                }

            }

        }


        public static int IsValidID(string prompt , List<Employee> employees)
        {
            int id = -1;
            while (true)
            {
                Console.WriteLine(prompt);
                Console.WriteLine("Or Enter b To Take Back To Main Menu ");
                var input = Console.ReadLine();

                if(input == "b")
                {
                    return id;

                }
                if(int.TryParse(input, out id))
                {
                    if (employees.Any(e => e.ID == id))
                    {
                        return id;
                    }
                    else
                    {
                        Console.WriteLine("There is no employee with this ID!");

                    }
                }
                else
                {
                    Console.WriteLine("The chosen ID must not be empty or non-Integer!");
                }


            }
        }
        public static bool GetValidInputForDeletion(string prompt)
        {
            while (true)
            {
                Console.WriteLine(prompt);

                var input = Console.ReadLine();

                switch (input)
                {
                    case "y":
                        return true;

                    case "n":
                        return false;
                    default:
                        Console.WriteLine("Wrong input");
                        break;

                }
            }
        }
    }
}
