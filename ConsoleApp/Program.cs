internal class Program
{
    private static void Main(string[] args)
    {
        
       //Convert
        string str = "123"; //gia tri dau vao de chuyen doi
        //chuyen doi kieu du lieu string (gia tri = "123")
        //sang kieu du lieu int (gia tri chuyen doi = 123)
        int a = Convert.ToInt32(str);
        System.Console.WriteLine("a = " + a);
        
    }
}
