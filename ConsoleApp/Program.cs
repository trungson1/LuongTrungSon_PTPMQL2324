internal class Program
{
    private static void Main(string[] args)
    {
        
        
        int day = 2;
        switch(day)
        {
            case 1 : System.Console.WriteLine("Chu nhat"); break;
            case 2 : System.Console.WriteLine("Thu 2"); break;
            case 3 : System.Console.WriteLine("Thu 3"); break;
            case 4 : System.Console.WriteLine("Thu 4"); break;
            case 5 : System.Console.WriteLine("Thu 5"); break;
            case 6 : System.Console.WriteLine("Thu 6"); break;
            case 7 : System.Console.WriteLine("Thu 7"); break;
            default :
            System.Console.Write("Không phải ngày trong tuần");
            break;
        }
    }
}
