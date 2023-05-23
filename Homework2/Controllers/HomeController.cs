using Microsoft.AspNetCore.Mvc;

namespace _2.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Calculate(double num1, double num2, string op)
    {
        double result;

        switch (op)
        {
            case "+":
                result = num1 + num2;
                break;
            case "-":
                result = num1 - num2;
                break;
            case "*":
                result = num1 * num2;
                break;
            case "/":
                result = num2 == 0 ? 0 : num1 / num2;
                break;
            default:
                result = 0;
                break;
        }

        ViewBag.Result = result;

        return View("Index");
    }
}
