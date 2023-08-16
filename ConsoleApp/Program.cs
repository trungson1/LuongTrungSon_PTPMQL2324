internal class Program
{
    private static void Main(string[] args)
    {
        
        string str = "123";//gia tri dau vao de chuyen doi
        int ketqua; //bien luu ket qua sau chuyen doi
        // bien kiem tra chuyen doi co thanh cong hay khong
        bool KiemTra = false;
        //chuyen doi kieu du lieu
        KiemTra = int.TryParse(str,out(ketqua));
        System.Console.WriteLine("ket qua = " + ketqua);
        
    }
}
