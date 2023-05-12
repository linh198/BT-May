using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_May
{
    internal class EX10
    {
        
        public static void BT10()
        {
            Console.WriteLine("Nhap vao so nguyen N");
            int N = int.Parse(Console.ReadLine());

            int sotruoc = 0, sosau = 1;
            Console.Write(sotruoc + " ");
            Console.Write(sosau + " ");
            for (int i = 3; i <=N; i++)
            {
                int soketiep = sotruoc + sosau;
                sotruoc = sosau;
                sosau = soketiep;
                Console.Write(soketiep + " ");
            }
            Console.ReadKey();
        }

        
    }

}
