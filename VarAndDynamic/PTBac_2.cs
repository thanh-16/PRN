
using System.Text;

static void Frist_Degree(double a, double b)
    {
        if (a == 0)
        {
            Console.WriteLine(b == 0 ? "Phương trình có vô số nghiệm" : "Phương trình vô nghiệm");
        }
        else
        {
            Console.WriteLine($"Nghiệm của phương trình bậc nhất: x = {-b / a:F2}");
        }
    }

    static void SolveQuadraticEquation(double a, double b, double c)
    {
        if (a == 0)
        {
        Frist_Degree(b, c);
            return;
        }

        double delta = Math.Pow(b,2) - 4 * a * c; // Có thể dùng Var nhưng mình biêt kiểu kết quả r nên không cần đỡ tốn bộ nhớ
        Console.WriteLine($"Delta = {delta}");

        if (delta > 0)
        {
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine($"Hai nghiệm phân biệt: x1 = {x1:F2}, x2 = {x2:F2}");
        }
        else if (delta == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine($"Nghiệm kép: x = {x:F2}");
        }
        else
        {
            Console.WriteLine("Phương trình vô nghiệm (Delta < 0).");
        }
    }

Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("Phương trình bậc 2 ax^2 + bx + c = 0");
Console.Write("Nhập hệ số a: ");
double a =  double.Parse(Console.ReadLine());
Console.Write("Nhập hệ số b: ");
double b = double.Parse(Console.ReadLine());
Console.Write("Nhập hệ số c: ");
double c = double.Parse(Console.ReadLine());
SolveQuadraticEquation(a, b, c);
Console.WriteLine();

