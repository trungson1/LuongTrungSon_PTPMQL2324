using ConsoleApp.Models;
public class Program
{
    private static void Main(string[] args)
    {
        Student std = new Student();
        std.EnterData();
        std.StudentCode = "1234567";
        std.Display();    
    }
}

