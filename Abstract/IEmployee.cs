

namespace Employee_Management_System.Abstract
{
    public interface IEmployee
    {
        int ID { get; }
        string Name { get; set; }
        string Department { get; set; }
        string Designation { get; set; }
        decimal Salary { get; set; }

        void DisplayEmployeeDetails();
    }
}
