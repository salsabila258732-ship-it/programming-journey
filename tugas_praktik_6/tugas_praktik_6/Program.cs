using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas_praktik_6
{
    internal class Program
    {
        
            struct Siswa
        {
            public string nama;
            public char jeniskelamin;
            public string kelas;
     
        }
        static void Main()
        {
            Siswa[] siswa = new Siswa[3];
            for (int i = 0; i < siswa.Length; i++)
            {
                Console.Write("Masukkan nama siswa ke-{0}:", i + 1);
                siswa[i].nama = Console.ReadLine();

                Console.Write("Masukkan jenis kelamin (L/P): ");
                siswa[i].jeniskelamin = char.ToUpper(Console.ReadLine()[0]);

                Console.Write("Masukkan kelas:");
                siswa[i].kelas = Console.ReadLine();
            }

            Console.WriteLine("\n === Data Siswa ===");
            for (int i = 0; i < siswa.Length; i++)

            {
                Console.WriteLine("Nama : {0} | JK : {1} | Kelas : {2}", siswa[i].nama, siswa[i].jeniskelamin, siswa[i].kelas);
            }
        }
    }

}
