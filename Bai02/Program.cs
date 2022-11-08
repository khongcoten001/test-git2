using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so nguyen a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhap so nguyen b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("==========================================");
            int tong = a + b;
            int hieu = a - b;
            int tich = a * b;

            if(b != 0)
            {
                float thuong = (float)a / b;
                int du = a % b;
                Console.WriteLine($"Thuong {a} / {b} = {thuong}");
                Console.WriteLine($"Phan du {a} % {b} = {du}");
            }
            else
            {
                Console.WriteLine("Khong thuc hien duoc phep chia và phep lay du");
            }
            Console.ReadLine();
        }
    }
}
