namespace PTbac_1
{
    using System.Text;
    
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Phương Trình Bậc Nhất ");
            Console.WriteLine("Hệ số a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Hệ số b");
            double b = double.Parse(Console.ReadLine());
            if(a==0 && b == 0)
            {
                Console.WriteLine("Phương trình có vô số nghiệm");
            }
            else if(a==0 && b!=0) 
            {
                    Console.WriteLine("Phương trình vô nghiệm");
            }
            else
            {
                Console.WriteLine("Phương trình có nghiệm x = " ,-b/a);
            }
            Console.ReadLine();
        }
    }
}
