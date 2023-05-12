using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_May
{
    internal class EX3

    {
        public static int giaithua(int n)
        {
            int multi = 1;
            for (int i = 1; i <= n; i++)
            {
                multi = multi * i;
            }
            return multi;
        }

        public static void BT3()
        {
            Console.WriteLine("nhap vao so nguyen duong m");
            int m = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int j = 1; j <= m; j++)
            {
                sum = sum + giaithua(j);
            }
            Console.WriteLine("tong cac giai thua tu 1 den m {0}", sum);
            Console.ReadKey();
        }

    }
}
