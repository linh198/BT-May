using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_May
{
    internal class EX4

    {
        public static int binhphuong(int a)
        {
            int kq = a * a;
            return kq;
        }

        public static void BT4()
        {
            Console.WriteLine("nhap so nguyen N");
            int N = int.Parse(Console.ReadLine());
            bool sochinhphuong = false;
            for (int i=1; i <= N; i++)
            {
                if (N == binhphuong(i))
                {
                    sochinhphuong = true;
                }
                                      
            }
            if (sochinhphuong == true)
            {
                Console.WriteLine("N la so chinh phuong");
            }
            else
            {
                Console.WriteLine("N khong phhai so chinh phuong");
            }
            Console.ReadKey();
        }
    }
}
