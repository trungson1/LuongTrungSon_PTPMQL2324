public class Program
{
    private static void Main(string[] args)
    {
        int a,b; //khai bao 2 bien so a va b kieu int
        //thong bao cho nguoi dung nhap vao a
        System.Console.Write(" a = ");
        //doc du lieu nhap tu ban phim chuyen sang kieu int va gan cho a
        a = Convert.ToInt32(Console.ReadLine());
        System.Console.Write(" b = ");
        b = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("cong : {0} + {1} = {2} ",a,b,a+b);
        System.Console.WriteLine("tru : {0} - {1} = {2} ",a,b,a-b);
        System.Console.WriteLine("nhan : {0} * {1} = {2} ",a,b,a*b);
        System.Console.WriteLine("chia : {0} / {1} = {2} ",a,b,a/b);
        System.Console.WriteLine("chia co du : {0} % {1} = {2} ",a,b,a%b);
        if (a >= b) {
				Console.WriteLine("a lon hon  b");
			} else {
				Console.WriteLine("a nho hon b");
			}
            
    }
}

