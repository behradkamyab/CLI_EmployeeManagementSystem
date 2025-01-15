# Employee Management System (EMS)

This project is a **console-based Employee Management System (EMS)** built in **C#**. It allows users to manage employee data with functionalities for adding, updating, deleting, and listing employees. The data is stored persistently in a **JSON file**.

---

## **Features**

### 1. **Employee Information Management**
- **Add Employee**: Add new employee details such as name, department, designation, and salary.
- **Update Employee**: Modify existing employee details.
- **Delete Employee**: Remove an employee by their ID.
- **List All Employees**: Display a list of all employees with basic information.
- **Search Employee by ID**: Retrieve detailed information of an employee using their ID.

### 2. **Input Validation**
- Ensures all inputs (e.g., name, department, salary) are valid before processing.
- Prevents invalid or empty inputs using the `InputValidator` class.

### 3. **Data Storage**
- Employee data is stored in a **JSON file** for persistence.
- The file path is defined as:
## **Core Components**

### **1. EmployeeManager**
This class handles all the core operations related to employee management:
- **AddEmployee**: Adds a new employee and assigns an auto-incremented ID.
- **UpdateEmployee**: Updates specific details of an employee.
- **DeleteEmployee**: Removes an employee and reassigns IDs for remaining employees.
- **ListAllEmployees**: Displays a summary of all employees.
- **SaveToFile**: Saves employee data to a JSON file.
- **ReadEmployeesFile**: Reads employee data from a JSON file during initialization.

### **2. InputValidator**
A static helper class that validates user inputs:
- **GetValidName**: Ensures the name is not empty or numeric.
- **GetValidDepartment**: Ensures the department name is not empty or numeric.
- **GetValidDesignation**: Ensures the designation is valid.
- **GetValidSalary**: Ensures the salary is a positive decimal number.
- **IsValidID**: Validates if an ID exists in the system.
- **GetValidInputForDeletion**: Confirms user action for deletions.

---

## **Design Patterns and Practices**

### **1. Single Responsibility Principle (SRP)**
- **`EmployeeManager`**: Handles employee operations and data persistence.
- **`InputValidator`**: Centralized validation logic to ensure clean separation.

### **2. File-Based Storage**
- Employee data is stored in a JSON file. This makes the system lightweight and easy to set up without needing a database.

### **3. User-Friendly Interface**
- The console application guides users with clear prompts and feedback.
- Invalid inputs are gracefully handled, and users are given opportunities to re-enter correct values.

---

