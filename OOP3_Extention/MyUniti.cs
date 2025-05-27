using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP3_Extention
{
    internal static class MyUniti
    {
        /*Câu 1 : Cài Đặt 1 hàm TongTu1ToiN 
         * vào kiểu int của microsoft
         */
        public static int TongTu1ToiN(this int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }
        public static int Cong(this int a, int b) => a + b;

        public static void SapXepTangDan(this int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        // Hoán đổi
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
        public static void TaoMang(this int[] arr)
        {
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(1, 100);
            }
        }
        public static void XuatMang(this int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + "  ");
            }
            Console.WriteLine();
        }
    }
}
