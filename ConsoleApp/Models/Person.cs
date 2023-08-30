namespace ConsoleApp.Models
{
    public class Person
    {
       public string FullName { get; set; }
       public string Address { get; set; } 
       public int Age { get; set; }
       public int GetYearOfBirth (int age)
       {
        int yearofBirth = 2023 - age;
        return yearofBirth;
       }
       public void EnterData()
       {
        System.Console.Write("Full name = ");
        FullName = Console.ReadLine();
        System.Console.Write("Address = ");
        Address = Console.ReadLine();
        System.Console.Write("Age = ");
        Age = Convert.ToInt16(Console.ReadLine());
        try {
            Age = Convert.ToInt16(Console.ReadLine());
        } catch(Exception e)
        {
            Age = 0;
        }
       }
       public void Display()
       {
        System.Console.WriteLine("Ho Ten: {0} ",FullName);
        System.Console.WriteLine("Dia Chi: {0} ",Address);
        System.Console.WriteLine("Tuoi: {0} ",Age);
       }
       
    }
}