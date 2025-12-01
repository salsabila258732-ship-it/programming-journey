using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas_praktik__5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int angka = 5;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", angka, i, angka * i);
            }


        }
    }
}
