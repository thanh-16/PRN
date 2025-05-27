using System.Text;
using OOP3_Extention;

Console.OutputEncoding = Encoding.UTF8;

int n1 = 5;
Console.WriteLine("Tổng từ 1 đến 5 là:" + n1.TongTu1ToiN());
int n2 = 10;
Console.WriteLine($"Tổng từ 1 đến {n2} là: {n2.TongTu1ToiN()}");

Console.WriteLine("10 + 20:" + 10.Cong(20));

int[] arr = new int[10];
arr.TaoMang();
Console.WriteLine("Mảng ngẫu nhiên ch sắp xếp :");
arr.XuatMang();
Console.WriteLine("Mảng sau khi sắp xếp tăng dần:");
arr.SapXepTangDan();
arr.XuatMang();
