using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanh01
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            Console.WriteLine("Nhap ho va ten: ");
            string fullName = Console.ReadLine();

            Console.WriteLine("Nhap tuoi: ");
            int age = System.Int32.Parse(Console.ReadLine());

            Console.WriteLine("Nhap diem TB: ");
            float avgMark = System.Single.Parse(Console.ReadLine());

            Console.WriteLine("=========================================");
            Console.WriteLine("Hello " + fullName);
            Console.WriteLine("I am " + age);
            Console.WriteLine("My avg mark is " + avgMark);
            Console.ReadLine();
        }
    }
}
