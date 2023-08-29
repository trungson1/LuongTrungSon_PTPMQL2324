using System.Runtime.CompilerServices;

namespace ConsoleApp.Models
{
    public class Employee : Person
    {
        public string EmployeeCode {get; set;}
        public void EnterData()
        {
            //ke thua lai phuong thuc o class person
            base.EnterData();
            //phat trien them employeecode
            System.Console.Write("EmployeeCode = ");
            EmployeeCode = Console.ReadLine ();
        }
        public void Display()
        {
            base.Display();
            System.Console.Write("Employee : {0}",EmployeeCode);
        }
    }
       
}