using ConsoleApp.Models;
public class Program
{
    private static void Main(string[] args)
    {
        //khoi tao 2 doi tuong thu class Person
        Person ps1 = new Person();
        Student ps2 = new Student();
        //gan gia tri cho thuoc tinh doi tuong ps1
        //ps1.FullName = "Nguyen Van A";
        //ps1.Address = "Ha Noi";
        //ps1.Age = 18;
        ps2.MaSV = "123456";
        ps2.TenSV= "Nguyen Van B";
        ps2.NamSinh = 2001;
        //goi phuong thuc hien thi thong tin
        //ps1.Display();
        ps2.Display();
    }
}

