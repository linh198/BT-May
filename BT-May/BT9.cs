using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_May
{
    internal class EX9
    {
        public static void BT9()
        {
            Console.WriteLine("Nhap vao so hang la N");
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <=N; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
            Console.ReadKey();
        }
    }
}
