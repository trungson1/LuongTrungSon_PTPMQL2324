internal class Program
{
    private static void Main(string[] args)
    {
        for(int i = 0; i < 10; i++ )
        {
            if(i==5) continue;
            System.Console.WriteLine("Vong lap thu {0}", i);
        }
    }
}
