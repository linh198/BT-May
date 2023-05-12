using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_May
{
    internal class EX2
    {
        public static void BT2()
        {
            Console.WriteLine("nhap vao so nguyen duong n");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine("{0}x{1}={2}", i, j, i * j);

                }
                Console.ReadKey();
            }
        }
    }
}
