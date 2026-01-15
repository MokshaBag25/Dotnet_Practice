using Microsoft.AspNetCore.Mvc;
using mvc_demo.Models;

namespace mvc_demo.Controllers
{
    public class EmployeeController : Controller
    {
        //public IActionResult Index(int id)
        //{
        //    return View();
        //}


        public ActionResult Index(int id)
        {
            var employee = new List<Employee>
            {
                new Employee { Id = 1, Name = "Alice", Department = "HR", Address = "123 Main", Salary = 50000M },
                new Employee { Id = 2, Name = "Bob", Department = "IT", Address = "456 Oak", Salary = 60000M },
                new Employee { Id = 3, Name = "Charlie", Department = "Finance", Address = "789 Pine", Salary = 65000M },
                new Employee { Id = 4, Name = "Diana", Department = "Marketing", Address = "321 Maple", Salary = 52000M }
            };

            ViewData["CompanyName"] = "Capgemini";
            return View(employee);

            //localhost:7243/Employee/Index/5?name=Moksha
            //public string Index(string id, string name)
            //{
            //    return "The id is " + id + " and name is " + name;
            //}
        }
    }
}
