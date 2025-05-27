
Console.OutputEncoding=Console.OutputEncoding;  
void ham1(int n)
{
    n = 8;
    Console.WriteLine($"Trong hàm 1: n = {n}");

}
int n = 5;
ham1(n);
Console.WriteLine($"n trước khi vào hàm { n } ");
ham1(n);
Console.WriteLine($"n sau khi vào hàm { n } ");
void ham2(ref int n)
{
    n = 8;
    Console.WriteLine($"n trong hàm là {n}");

}

Console.WriteLine("-------REF-------");
n = 5;
Console.WriteLine($"n trước hàm là {n}");
ham2( ref n);
Console.WriteLine($"n sau hàm là {n}");

// ref : phải khởi tạo giá trị cho biến trước khi gọi
//int m;
//ham2( ref m); // m chưa có giá trị nên không nhận 
void ham3 (out int n)
{
    n = 8; // buộc phải có giá trị mới chuyền vào 
}