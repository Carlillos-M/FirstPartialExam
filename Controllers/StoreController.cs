using Microsoft.AspNetCore.Mvc;

namespace FirstPartialExam.Controllers;

public class StoreController : Controller
{
    public IActionResult StoreList()
    {
        return View();
    }

}