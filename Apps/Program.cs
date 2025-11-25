using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Apps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> menu = new Dictionary<string, double>
            //Daftar menu jajanan dan minumaan tradisional Indonesia di Kedai Jadul dengan harga
            
            {
                {"Onde-onde", 2000 },
                {"Bakpia", 10000 },
                {"Wingko Babat", 2000 },
                {"Klepon", 2000 },
                {"Es Pisang Ijo", 10000 },
                {"Bubur Sumsum", 5000 },
                {"Wedang Ronde", 10000 },
                {"Es Selendang Mayang",10000 },

            };

            //Variabel untuk menyimpan pesanan
            Dictionary<string, int> pesanan = new Dictionary<string, int>();
            double totalHarga = 0;

            Console.WriteLine("Selamat Datang di Kedai Jadul!");
            Console.WriteLine("Menu jajanan tradisional Indonesia:");
            foreach (var item in menu)
            {
                Console.WriteLine($"{item.Key} - Rp {item.Value}");
            }
            Console.WriteLine();

            // Loop untuk pemesanan 
            while (true)
            {
                Console.Write("Masukkan nama menu (atau 'selesai' untuk selesai):");
                string namaMenu = Console.ReadLine();

                if (namaMenu.ToLower() == "selesai")
                {
                    break;
                }

                if (!menu.ContainsKey(namaMenu))
                {
                    Console.WriteLine("Menu tidak ditemukan. Coba lagi.");
                    continue;
                }

                Console.Write("Masukkan jumlah:");
                if (!int.TryParse(Console.ReadLine(), out int jumlah) || jumlah <= 0)
                {
                    Console.WriteLine("Jumlah tidak valid. Coba Lagi.");
                    continue;
                }

                //Tambahkan ke pesanan
                if (pesanan.ContainsKey(namaMenu))
                {
                    pesanan[namaMenu] += jumlah;
                }
                else
                {
                    pesanan[namaMenu] = jumlah;
                }

                //Hitung harga
                double hargaItem = menu[namaMenu] * jumlah;
                totalHarga += hargaItem;

                Console.WriteLine($"Ditambahkan: {jumlah} x {namaMenu} = Rp {hargaItem}");
                Console.WriteLine();

            }

            //Tampilkan ringkasan pesanan
            Console.WriteLine("Ringkasan Pesanan:");
            foreach (var item in pesanan)
            {
                double harga = menu[item.Key] * item.Value;
                Console.WriteLine($"{item.Key}: {item.Value} x Rp {menu[item.Key]} = Rp {harga}");
            }

            Console.WriteLine($"Total Harga: Rp {totalHarga}");

            //Hitung diskon jika total > 30000
            if (totalHarga > 30000)
            {
                double diskon = totalHarga * 0.1;
                totalHarga -= diskon;
                Console.WriteLine($"Diskon 5%: Rp {diskon}");
                Console.WriteLine($"Total setelah diskon: Rp {totalHarga}");
            }

            Console.WriteLine("Terima Kasih telah berbelanja di Kedai Jadul!");
            Console.ReadLine();















































































        }
    }
}
