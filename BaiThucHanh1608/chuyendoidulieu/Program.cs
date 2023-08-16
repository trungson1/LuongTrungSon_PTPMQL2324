internal class Program
{
    private static void Main(string[] args)
    {
        
        //Chuyen doi du lieu
        //Parse
        //string str = "123";
        //int a = int.Parse(str);
        //System.Console.WriteLine("a = " + a);
        //TryParse
        //string str = "123";//gia tri dau vao de chuyen doi
        //int ketqua; //bien luu ket qua sau chuyen doi
        // bien kiem tra chuyen doi co thanh cong hay khong
        //bool KiemTra = false;
        //chuyen doi kieu du lieu
        //KiemTra = int.TryParse(str,out(ketqua));
        //System.Console.WriteLine("ket qua = " + ketqua);
        //Convert
        string str = "123"; //gia tri dau vao de chuyen doi
        //chuyen doi kieu du lieu string (gia tri = "123")
        //sang kieu du lieu int (gia tri chuyen doi = 123)
        int a = Convert.ToInt32(str);
        System.Console.WriteLine("a = " + a);
    }
}
