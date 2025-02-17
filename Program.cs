internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("ỨNG DỤNG TÍNH TOÁN CƠ BẢN");
        double so1, so2, tong, hieu, tich, thuong=0;
        // Console.ReadLine(); sẽ trả về biến dạng chuỗi văn bản (string)

        Console.Write("Nhập số 1: ");
        so1 = Convert.ToDouble(Console.ReadLine()); // Double.Parse(Console.ReadLine());

        Console.Write("Nhập số 2: ");
        so2 = Convert.ToDouble(Console.ReadLine()); // Double.Parse(Console.ReadLine());

        tong = so1 + so2;
        hieu = so1 - so2;
        tich = so1 * so2;

        Console.WriteLine("Tổng 2 số trên là: " + tong);
        Console.WriteLine("Hiệu 2 số trên là: " + hieu);
        Console.WriteLine("Tích 2 số trên là: " + tich);

        Console.WriteLine("{0} + {1} = {2}", so1, so2, tong); // mảng gồm 3 phần tử {so1, so2, tong}

        if (so2 != 0)
        {
            thuong = so1 / so2;
            Console.WriteLine("Thương 2 số trên là: " + thuong);
        } else
        {
            // so2 == 0
            Console.WriteLine("Không thể chia cho 0");
        }
        // Ghi thêm

    }
}