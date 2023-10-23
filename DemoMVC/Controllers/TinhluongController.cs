using Microsoft.AspNetCore.Mvc;
namespace DemoMVC.Controllers;
public class TinhLuong : Controller
{
    public IActionResult Tinhluong()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Tinhluong(string Luongcb, string heSo, string Phucap)
    {
        double lcb =0, hs =0, pc =0, luong = 0;
        string trave;
        if(!String.IsNullOrEmpty(Luongcb)) lcb = Convert.ToDouble(Luongcb);
        if(!String.IsNullOrEmpty(heSo)) hs = Convert.ToDouble(heSo);
        if(!String.IsNullOrEmpty(Phucap)) pc = Convert.ToDouble(Phucap);
        luong = lcb*hs+pc;
        trave = "Lương của bạn là: " + luong;
        ViewBag.tl = trave;
        return View();
    }
}