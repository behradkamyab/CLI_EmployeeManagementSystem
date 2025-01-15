

using Employee_Management_System.Abstract;
using Employee_Management_System.Models;

namespace Employee_Management_System
{
    public class Program
    {

        // NEED SOME HUGEEEEE REFACTORING IN PROGRAM.CS AND IMPLEMENT FILTER METHOD IN CASE 4


        static void Main(string[] args)
        {
            var emp = new EmployeeManager();
            var view = new Display();

            Employee employee = null;

            string name = "";
            string department = "";
            string designation = "";
            decimal salary;
            int id;

            string choice;
            bool isRunning = true;
            //int input = -1;


            while (isRunning)
            {
                view.MainMenu();
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        name = InputValidator.GetValidName("Enter the full name of employee: ");
                        department = InputValidator.GetValidDepartment("Enter the department: ");
                        designation = InputValidator.GetValidDepartment("Enter the designation: ");
                        salary = InputValidator.GetValidSalary("Enter the salary: ");

                        emp.AddEmployee(name, department, designation, salary);
                        view.PromptMessage("Press any key to get back to main menu");
                        Console.ReadKey();
                        break;

                    case "2":
                        emp.ListAllEmployees();

                        if(emp.Employees.Count <=0)
                        {
                            view.PromptMessage("Press any key to get back to main menu");
                            Console.ReadKey();
                            break;

                        }
                        else
                        {
                            id = InputValidator.IsValidID("Enter the ID of employees: ", emp.Employees);
                            if(id == -1)
                            {
                                break;
                            }
                            else
                            {

                                employee = emp.GetEmployeeByID(id);
                                employee.DisplayEmployeeDetails();

                                var input = view.UpdateMenuAndChooseField();
                                if (input == "b")
                                {
                                    break;
                                }

                                ChooseFieldForUpdate(input, out name, out department, out designation, out salary);

                                emp.UpdateEmployee(name, department, designation, salary, employee);
                            }

                        }

                        view.PromptMessage("Press any key to get back to main menu");
                        Console.ReadKey();
                        break;
                    case "3":
                        emp.ListAllEmployees();

                        if (emp.Employees.Count <= 0)
                        {
                            view.PromptMessage("Press any key to get back to main menu");
                            Console.ReadKey();
                            break;

                        }
                        else
                        {
                            id = InputValidator.IsValidID("Enter the ID of employees: ", emp.Employees);
                            if (id == -1)
                            {
                                break;
                            }
                            else
                            {
                                employee = emp.GetEmployeeByID(id);
                                employee.DisplayEmployeeDetails();
                            }



                            bool permission = InputValidator.GetValidInputForDeletion("Do You Want To Delete This Employee? (Y/N)");
                            if (permission)
                            {
                                emp.DeleteEmployee(id);
                            }
                            else
                            {
                                view.PromptMessage("Press any key to get back to main menu");
                                Console.ReadKey();
                            }
                        }
                        view.PromptMessage("Press any key to get back to main menu");
                        Console.ReadKey();

                        break;
                    case "4":
                        emp.ListAllEmployees();

                        if (emp.Employees.Count <= 0)
                        {
                            view.PromptMessage("Press any key to get back to main menu");
                            Console.ReadKey();
                            break;

                        }
                        else
                        {
                            id = InputValidator.IsValidID("Enter the ID of employees: ", emp.Employees);


                            if (id == -1)
                            {
                                break;
                            }
                            else
                            {
                                employee = emp.GetEmployeeByID(id);
                                employee.DisplayEmployeeDetails();
                            }

                            view.PromptMessage("Press any key to get back to main menu");
                            Console.ReadKey();
                        }
                        break;
                    case "5":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        view.PromptMessage("Press any key to get back to main menu");
                        Console.ReadKey();
                        break;

                }


            }


        }




        private static void ChooseFieldForUpdate(string input ,out string name, out string department , out string designation , out decimal salary)
        {
            name = "";
            department = "";
            designation = "";
            salary = 0;
            switch (input)
            {
                case "1":
                    name = InputValidator.GetValidName("Enter the new Name: ");
                    break;
                case "2":
                    department = InputValidator.GetValidDepartment("Enter the new Department: ");
                    break;
                case "3":
                    designation = InputValidator.GetValidDesignation("Enter the new Designation: ");
                    break;
                case "4":
                    salary = InputValidator.GetValidSalary("Enter the new Salary: ");
                    break;
                default:
                    Console.WriteLine("Invalid Option!");
                    break ;
            }
        }

    }




}




//        private static (string, string, string, decimal) GetEmployeeDetails()
//        {
//            string name = "";
//            string department = "";
//            string designation = "";
//            decimal salary = 0;

//            while (true)
//            {
//                Console.Clear();
//                while (true)
//                {

//                    Console.WriteLine("Enter the full name of employee: ");
//                    name = Console.ReadLine();

//                    bool isNameValidated = Validation.GetValidName(name);
//                    if (!isNameValidated)
//                    {
//                        Console.WriteLine("Name input is wrong! Please enter a valid name.");
//                    }
//                    else
//                    {
//                        break;
//                    }
//                }


//                while (true)
//                {


//                    Console.WriteLine("Enter the Department: ");
//                    department = Console.ReadLine();

//                    bool isDepartmentValidated = Validation.GetValidDepartment(department);
//                    if (!isDepartmentValidated)
//                    {
//                        Console.WriteLine("Department input is wrong! Please enter a valid department.");
//                    }
//                    else
//                    {
//                        break;
//                    }
//                }

//                while (true)
//                {

//                    Console.WriteLine("Enter the designation: ");
//                    designation = Console.ReadLine();

//                    bool isDesignationValidated = Validation.GetValidDesignation(designation);
//                    if (!isDesignationValidated)
//                    {
//                        Console.WriteLine("Designation input is wrong! Please enter a valid designation.");
//                    }
//                    else
//                    {
//                        break;
//                    }
//                }


//                //        while (true)
//                //        {
//                //            Console.WriteLine("Enter the amount of salary: ");
//                //            bool isSalaryValidated = false;
//                //            if (decimal.TryParse(Console.ReadLine(), out salary))
//                //            {
//                //                isSalaryValidated = Validation.GetValidSalary(salary);
//                //                if (!isSalaryValidated)
//                //                {
//                //                    Console.WriteLine("Salary must be a positive number. Please enter a valid amount.");
//                //                }
//                //                else
//                //                {
//                //                    break;
//                //                }
//                //            }
//                //            else
//                //            {
//                //                Console.WriteLine("Salary input is wrong! Please enter a valid salary.");
//                //            }

//                //        }

//                //        return (name, department, designation, salary);


//                //    }



//                //}


//                //private static int GetValidatedInputFromUser(List<Employee> employees)
//                //{
//                //    int result = 0;
//                //    bool isValid = false;
//                //    if (employees.Count > 0)
//                //    {
//                //        while (!isValid)
//                //        {

//                //            Console.WriteLine("Enter the ID of the employee: ");
//                //            Console.WriteLine("Or you can enter b to get back to main menu");
//                //            var value = Console.ReadLine();
//                //            if (value == "b")
//                //            {
//                //                break;
//                //            }

//                //            if (int.TryParse(value, out result))
//                //            {
//                //                isValid = Validation.IsValidEmployeeId(result, employees);
//                //            }
//                //            else
//                //            {
//                //                Console.WriteLine("Enter the right input ( must not be null or non-integer value )");
//                //            }



//                //        }
//                //    }
//                //    else
//                //    {
//                //        Console.WriteLine("There is no employee lets add some!");
//                //    }


//                //    return result;
//                //}


//                private static void GetBackToMainMenu(string prompt)
//        {
//            Console.WriteLine(prompt);
//            Console.ReadKey();
//        }


//        //private static void ShowUpdateOptions(Employee employee)
//        //{
//        //    string newName = "";
//        //    string newDepartment = "";
//        //    string newDesignation = "";
//        //    decimal newSalary = -1;
//        //    string result = "";

//        //    while (true)
//        //    {
//        //        Console.WriteLine("Which field would you like to update?");
//        //        Console.WriteLine("1. Name");
//        //        Console.WriteLine("2. Department");
//        //        Console.WriteLine("3. Designation");
//        //        Console.WriteLine("4. Salary");
//        //        Console.WriteLine("Enter your choice: ");

//        //        result = Console.ReadLine();

//        //        if (!int.TryParse(result, out int option) || option <= 0 || option > 4)
//        //        {
//        //            Console.WriteLine("Please choose a valid option (1-4).");
//        //            continue;
//        //        }


//        //        switch (option)
//        //        {
//        //            case 1:
//        //                Console.WriteLine("Enter the new name: ");
//        //                newName = Console.ReadLine();
//        //                if (Validation.GetValidName(newName))
//        //                {
//        //                    employee.Name = newName;
//        //                    Console.WriteLine("Name updated successfully.");
//        //                    return;
//        //                }
//        //                else
//        //                {
//        //                    Console.WriteLine("Invalid name. Try again.");
//        //                }
//        //                break;
//        //            case 2:
//        //                Console.WriteLine("Enter the new Department: ");
//        //                newDepartment = Console.ReadLine();

//        //                if (Validation.GetValidDepartment(newDepartment))
//        //                {
//        //                    employee.Department = newDepartment;
//        //                    Console.WriteLine("Department updated successfully.");
//        //                    return;
//        //                }
//        //                else
//        //                {
//        //                    Console.WriteLine("Invalid department. Try again.");
//        //                }
//        //                break;
//        //            case 3:
//        //                Console.WriteLine("Enter the new Designation: ");
//        //                newDesignation = Console.ReadLine();

//        //                if (Validation.GetValidDesignation(newDesignation))
//        //                {
//        //                    employee.Designation = newDesignation;
//        //                    Console.WriteLine("Designation updated successfully.");
//        //                    return;
//        //                }
//        //                else
//        //                {
//        //                    Console.WriteLine("Invalid designation. Try again.");
//        //                }
//        //                break;
//        //            case 4:
//        //                Console.WriteLine("Enter the new Salary: ");
//        //                if (decimal.TryParse(Console.ReadLine(), out newSalary) && Validation.GetValidSalary(newSalary))
//        //                {
//        //                    employee.Salary = newSalary;
//        //                    Console.WriteLine("Salary updated successfully.");
//        //                    return;
//        //                }
//        //                else
//        //                {
//        //                    Console.WriteLine("Invalid salary. Try again.");
//        //                }
//        //                break;
//        //            default:
//        //                Console.WriteLine("Unknown option.");
//        //                break;
//        //        }
//        //    }
//        //}

//    }
//}




