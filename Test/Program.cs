using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.OracleClient;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            using (EntitiesA a = new EntitiesA())
            {
                foreach (var i in a.SINHVIENs)
                {
                    Console.WriteLine(i.MSSV + " " + i.TENSV);
                }
            }
            Console.ReadLine();
        }
    }
}
