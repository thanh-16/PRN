/*Dề bài
 * Nhập vào 1 số >= 0 sai nhập lại, đúng mới được dừng dòng lệnh
 * Nhập đúng thì tính giai thừa của số đó 
 * 
 */
Console.OutputEncoding = System.Text.Encoding.UTF8;
int n = -1;
while (n<0)
{
    Console.WriteLine("nhập n >= 0");
    string intput = Console.ReadLine();
    if (int.TryParse(intput, out n) == true)
        if (n >= 0)
            break;
        else
            Console.WriteLine("Nhập >= 0 bro");
    else
        Console.WriteLine("nhập số đi bro");

}
long giaithua = 1;
for (int i = 1; i <= n; i++)
    giaithua *= i;

Console.WriteLine($"Giai thừa của {n} là: {giaithua}");