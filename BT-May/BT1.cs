using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_May
{
    internal class EX1
    {
        public static void BT1()
        {
            Console.WriteLine("Nhap vao so nguyen A");
            int A = int.Parse(Console.ReadLine());
            if (A % 3 == 0)
            {
                Console.WriteLine("So nguyen A chia het cho 3");
            }
            else if (A % 3 != 0)
            {
                Console.WriteLine("So nguyen A khong chia het cho 3");
            }

            Console.ReadKey();
        }
    }
}
