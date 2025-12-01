using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugaspraktik_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int total = 0;

            while (i <= 5)
            {
                total += i; //menjumlahkan nilai i ke total
                i++;        //menaikkan nilai i 
            }

            Console.WriteLine("Total = {0}", total);

        }
    }
}
