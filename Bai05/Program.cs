using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap 3 he so a, b và c cua phuong trinh bac hai ax^2 + bx + x = 0");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("=========================================");
            int delta = b*b - 4*a*c;
            if (delta < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
            else
            {
                if (delta == 0)
                {
                    Console.WriteLine("Phuong trinh co nghiem kep:");
                    Console.WriteLine("x = " + (-b / (2 * a)));
                }
                else
                {
                    Console.WriteLine("Phuong trinh co 2 nghiem phan biet:");
                    Console.WriteLine("x1 = " + ((-b - Math.Sqrt(delta)) / (2 * a)));
                    Console.WriteLine("x1 = " + ((-b + Math.Sqrt(delta)) / (2 * a)));
                }
            }
            Console.ReadLine();
        }
    }
}
