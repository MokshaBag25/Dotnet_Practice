namespace mvc_demo.Models;

public class EmployeeSampleData
{
    public Employee GetEmpDetails (int empId)
    {
        Employee emp = new Employee()
        {
            Id = empId,
            Name = "John Doe",
            Department = "IT",
            Address = "WhiteField",
            Salary = 60000.00M
        };
        return emp;
    }
}
