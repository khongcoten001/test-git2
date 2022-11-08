using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;

namespace Bai03
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap 4 so nguyen: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());

            int min = a;

            if (min > b)
                min = b;
            if (min > c)
                min = c;
            if (min > d)
                min = d;
            Console.WriteLine("=========================================");
            Console.WriteLine("Min: " + min);
            Console.ReadLine();
        }

        
    }
}
