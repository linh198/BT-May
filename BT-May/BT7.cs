using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_May
{
    internal class EX7
    {
        
        public static void BT7()
        {
            Console.WriteLine("Nhap vao so nguyen N");
            int N = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= N; i=i+2)
            {
                //if (i % 2 != 0)
                //{
                    sum = sum + i;
                //}
            }
            Console.WriteLine("Tong cac so le bang {0}", sum);
            Console.ReadKey();
        }
    }
}
