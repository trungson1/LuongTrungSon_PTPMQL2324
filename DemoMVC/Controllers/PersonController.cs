using Microsoft.AspNetCore.Mvc;
namespace DemoMVC.Controllers;
 public class PersonController : Controller
 {
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(string fname)
    {
        ViewBag.mess = " Xin chao " + fname;
        return View();
     
    }
 }

