using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace BT_May
{
    internal class EX5
    {
        public static void BT5()
        {
            Console.WriteLine("nhap vao thang:");
            int month = int.Parse(Console.ReadLine());
            switch(month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                   
                    Console.WriteLine("Thang nay co so ngay la 31 ngay");
                    break;

                case 2:

                    if(DateTime.IsLeapYear(DateTime.Now.Year))
                    {
                        Console.WriteLine("Thang nay co so ngay la 29");
                    }
                    else
                    {
                        Console.WriteLine("Thang nay co so ngay la 28");
                    }
                     break;

                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("Thang nay co so ngay la 30");
                    break;

            }
            Console.ReadKey();
        }
    }
}
