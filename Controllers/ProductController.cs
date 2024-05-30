using Microsoft.AspNetCore.Mvc;

namespace FirstPartialExam.Controllers;

public class ProductController : Controller
{
    public ProductController()
    {
    }

    public IActionResult ProductList()
    {
        return View();
    }
}