using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_May
{
    internal class EX6
    {
        public static int binhphuong(int a)
        {
            int multi = 1;
            for (int i = 1; i <= a; i++)
                multi = multi * a;
            return multi;


        }
        
        public static void BT6()
        {
            Console.WriteLine("Nhap vao so nguyen N");
            int N = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int j = 1; j <= N; j ++)
            {
                sum = sum + binhphuong(j);

            }
            Console.WriteLine(" tong cac binh phuong bang {0}", sum);
            Console.Read();
        }
    }

}
