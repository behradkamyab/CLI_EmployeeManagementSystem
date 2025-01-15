using Employee_Management_System.Models;
using System.Text.Json;



namespace Employee_Management_System
{

    public class EmployeeManager
    {
        const string path = "G:\\GAME-DEV\\Projects\\Beginners\\Employee Management System (EMS)\\Employee Management System\\Data\\Employees.json";


        private static int nextId = 0;
        public List<Employee> Employees { get; private set; }



        public EmployeeManager()
        {
            Employees = new List<Employee>();
            ReadEmployeesFile(path);
        }



        public void ListAllEmployees()
        {

            if (Employees.Count <= 0)
            {
                Console.WriteLine("list is empty please add some employees");
            }
            else
            {
                foreach (Employee emp in Employees)
                {
                    Console.WriteLine($"{emp.ID}- {emp.Name}");
                }
            }

        }

        public void AddEmployee( string name,string department , string designation,decimal salary)
        {
            if (Employees.Count <= 0)
            {
                nextId++;
            }
            else
            {
                int id = Employees[Employees.Count - 1].ID;
                nextId = id + 1;
            }
            Employee emp =  new Employee(nextId,name,department,designation,salary);

            Employees.Add(emp);
            SaveToFile(path);

        }

        public Employee GetEmployeeByID(int id)
        {
            var emp = Employees.Find(e => e.ID == id);
            if (emp != null)
            {
                return emp;
            }
            else
            {
                Console.WriteLine("There is no employee with this id in the database");
                return null;
            }
        }

        public void UpdateEmployee(string name ,string department, string designation, decimal salary , Employee employee)
        {
            if (!string.IsNullOrEmpty(name))
            {
                employee.Name = name;
            }
            else if (!string.IsNullOrEmpty(department))
            {
                employee.Department = department;
            }else if (!string.IsNullOrEmpty(designation))
            {
                employee.Designation = designation;
            }else if(salary != 0)
            {
                employee.Salary = salary;
            }

            SaveToFile(path);
        }


        public void ReadEmployeesFile(string path)
        {

            try
            {

                if (File.Exists(path))
                {
                    string jsonData = File.ReadAllText(path);

                    if (!string.IsNullOrEmpty(jsonData))
                    {
                        Employees = JsonSerializer.Deserialize<List<Employee>>(jsonData);

                    }
                }

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }



        }

        public void SaveToFile( string path)
        {
            try
            {

                var options = new JsonSerializerOptions { WriteIndented = true};

                string updatedJsonData = JsonSerializer.Serialize(Employees, options);

                File.WriteAllText(path, updatedJsonData);
                Console.WriteLine("Employee data saved to json successfully!");

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }


        }

        public void DeleteEmployee(int id)
        {
            var employee = Employees.FirstOrDefault(e => e.ID == id);
            if (employee != null)
            {
                Employees.Remove(employee);
                ReassignEmployeeIds();
                Console.WriteLine($"Employee with ID {id} has been deleted.");
                SaveToFile(path);
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }
        }



        private void ReassignEmployeeIds()
        {
            for (int i = 0; i < Employees.Count; i++)
            {
                Employees[i].ID = i + 1;
            }
        }


    }
}
