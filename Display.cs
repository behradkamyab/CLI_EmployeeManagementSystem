using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System
{
    public class Display
    {
        public void MainMenu()
        {


            Console.Clear();
            Console.WriteLine("====================");
            Console.WriteLine(" Employee Management ");
            Console.WriteLine("====================");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. Update Employee");
            Console.WriteLine("3. Delete Employee");
            Console.WriteLine("4. View Employees details");
            Console.WriteLine("5. Exit");
            Console.WriteLine("====================");
            Console.Write("Select an option: ");


        }

        public string UpdateMenuAndChooseField()
        {
            while (true)
            {
                Console.WriteLine("For editing the name enter 1");
                Console.WriteLine("For editing the department enter 2");
                Console.WriteLine("For editing the designation enter 3");
                Console.WriteLine("For editing the salary enter 4");
                Console.WriteLine("Enter b to take back to main menu...");

                var input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        return "1";
                    case "2":
                        return "2";
                    case "3":
                        return "3";
                    case "4":
                        return "4";
                    case "b":
                        return "b";
                    default:
                        Console.WriteLine("Choose between (1-4) or b");
                        break;


                }
            }
        }

        public void PromptMessage(string message)
        {
            Console.WriteLine(message);
        }

    }
}
