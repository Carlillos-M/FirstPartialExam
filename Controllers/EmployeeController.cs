using FirstPartialExam.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstPartialExam.Controllers;

public class EmployeeController : Controller
{
    public EmployeeController()
    {
    }

    public IActionResult EmployeeList()
    {
        return View();
    }

}