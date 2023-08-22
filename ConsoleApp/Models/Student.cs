namespace ConsoleApp.Models
{
    public class Employee
    {
       public string MaSV { get; set; }
       public string TenSV { get; set; } 
       public int NamSinh { get; set; }
       public void EnterData()
       {
        System.Console.Write("Ma nhan vien = ");
        MaSV = Console.ReadLine();
        System.Console.Write("Ten nhan vien = ");
        TenSV = Console.ReadLine();
        System.Console.Write("Tuoi = ");
        NamSinh = Convert.ToInt16(Console.ReadLine());
        
       }
        public void Display()
       {
        System.Console.WriteLine("Ma SV: {0} - Ten SV: {1} - Nam Sinh: {2} ",MaSV,TenSV,NamSinh);
       }
    }
}