internal class Program
{
    private static void Main(string[] args)
    {
        int a = 1;
        while(a < 10)
        {
            System.Console.WriteLine("Vong lap thu {0}", a);
            //tăng a lên 1 đơn vị để đảm bảo có lúc a >= 10
            //a >= 10 thì vòng lặp sẽ kết thúc
            a++;
        }
    }
}
