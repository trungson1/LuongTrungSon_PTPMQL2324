using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.TagHelpers;

namespace DemoMVC.Controllers;
public class GiaiPTController : Controller 
{
    public IActionResult Giaiptb2()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Giaiptb2(string hesoA, string hesoB, string hesoC)
    {
            
        double delta, x1, x2, a =0, b=0, c=0;
        string ketqua;
            
        if(!String.IsNullOrEmpty(hesoA)) a = Convert.ToDouble(hesoA);
        if(!String.IsNullOrEmpty(hesoB)) b = Convert.ToDouble(hesoB);
        if(!String.IsNullOrEmpty(hesoC)) c = Convert.ToDouble(hesoC);
        if(a==0) ketqua = "Khong phai phuong trinh bac 2";
        else{
                
                delta = b*b - 4*a*c;
                
                if(delta<0) ketqua ="Phuong trinh vo nghiem";
                else if(delta==0)
                {
                    x1 = -b/(2*a);
                    ketqua ="Phuong trinh co nghiem kep = "+ x1;
                }
                else 
                {
                    x1= (-b + Math.Sqrt(delta))/(2*a);
                    x2= (-b - Math.Sqrt(delta))/(2*a);
                    ketqua = "Phuong trinh co 2 nghiem phan biet: x1= "+ x1 + ", x2= "+x2;
                }
            }
            ViewBag.message = ketqua;
            return View();
    }
}