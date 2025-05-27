void Calculate(double a, double b, int option)
{
    switch (option)
    {
        case 1:
            Console.WriteLine($"Cộng: {a} + {b} = {a + b}");
            break;
        case 2:
            Console.WriteLine($"Trừ: {a} - {b} = {a - b}");
            break;
        case 3:
            Console.WriteLine($"Nhân: {a} * {b} = {a * b}");
            break;
        case 4:
            if (b != 0)
            {
                Console.WriteLine($"Chia: {a} / {b} = {a / b:F2}");
            }
            else
            {
                Console.WriteLine("Lỗi: Không thể chia cho 0!");
            }
            break;
        default:
            Console.WriteLine("Lựa chọn không hợp lệ! Vui lòng nhập số từ 1 đến 4.");
            break;
    }
}
    Console.OutputEncoding = System.Text.Encoding.UTF8; 
    Console.WriteLine("Chương trình tính toán đơn giản");
    Console.WriteLine("Nhập số thứ nhất:");
    Console.Write("a = ");
    double a = double.Parse(Console.ReadLine());
    Console.WriteLine("Nhập số thứ hai:");
    Console.Write("b = ");
    double b = double.Parse(Console.ReadLine());    

    Console.WriteLine("Chọn phép toán:");
    Console.WriteLine("1. Cộng");
    Console.WriteLine("2. Trừ");
    Console.WriteLine("3. Nhân");
    Console.WriteLine("4. Chia");
    Console.Write("Lựa chọn (1-4): ");

    int option = int.Parse(Console.ReadLine());
    Calculate(a, b, option);
    Console.WriteLine("Nhấn phím bất kỳ để thoát...");