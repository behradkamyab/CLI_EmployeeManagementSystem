using Employee_Management_System.Abstract;


namespace Employee_Management_System.Models
{
    public class Employee : IEmployee
    {
        public int ID { get;  set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Designation { get; set; }
        public decimal Salary { get; set; }


        public Employee(int id ,string name , string department , string designation , decimal salary)
        {
            ID = id;
            Name = name;
            Department = department;
            Designation = designation;
            Salary = salary;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("Employee with name {0}, working in {1} department and is {2}" , Name , Department ,Designation);
        }
    }
}
