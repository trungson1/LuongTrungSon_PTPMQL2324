namespace ConsoleApp.Models
{
    public class Fruit
    {
       public string FruitName { get; set; }
       public string FruitID{ get; set; } 
       public int HSD { get; set; }
       public void EnterData()
       {
        System.Console.Write("Ten = ");
        FruitName = Console.ReadLine();
        System.Console.Write("Ma = ");
        FruitID = Console.ReadLine();
        System.Console.Write("HSD = ");
        HSD = Convert.ToInt16(Console.ReadLine());
        
       }
        public void Display()
       {
        System.Console.WriteLine("Ten : {0} - Ma: {1} - HSD: {2} ",FruitName,FruitID,HSD);
       }
    }
}