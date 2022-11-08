using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap 2 so a và b cua phuong trinh bac nhat ax+b=0");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("=========================================");

            Console.WriteLine("x = " + (float)b/a);

            Console.ReadLine();
        }
    }
}
