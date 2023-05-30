using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
		
		//Nama  : MANARUL HIDAYAT
		//KELAS : TI-01
		//NPM   : 1101221048
		
        Dictionary<string, string> daftarBarang = new Dictionary<string, string>()
        {
            { "B001", "XIOMI MI A1" },
            { "B002", "LENOVO A1000" },
            { "B003", "SAMSUNG J1" },
            { "B004", "SAMSUNG S5" },
            { "B005", "SAMSUNG S8" }
        };

        Dictionary<string, int> hargaBarang = new Dictionary<string, int>()
        {
            { "B001", 2500000 },
            { "B002", 1800000 },
            { "B003", 1800000 },
            { "B004", 3000000 },
            { "B005", 6000000 }
        };

        Console.WriteLine("================> PHONE STORE <=================");
        Console.WriteLine();

        // Tampilkan tabel daftar barang
        Console.WriteLine("+-------------+-----------------+-----------------+");
        Console.WriteLine("| Kode Barang |   Nama Barang   |      Harga      |");
        Console.WriteLine("+-------------+-----------------+-----------------+");

        foreach (var barang in daftarBarang)
        {
            string kodeBarang = barang.Key;
            string namaBarang = barang.Value;
            int harga = hargaBarang[kodeBarang];

            Console.WriteLine("| {0,-10}  | {1,-15} | {2,9}  |", kodeBarang, namaBarang, harga.ToString("C"));
        }

        Console.WriteLine("+-------------+-----------------+-----------------+");
        Console.WriteLine();

        Console.Write("Masukkan kode barang    : ");
        string kodeInput = Console.ReadLine();

        if (daftarBarang.ContainsKey(kodeInput))
        {
            string namaBarang = daftarBarang[kodeInput];
            int harga = hargaBarang[kodeInput];

            Console.WriteLine();
            Console.WriteLine("Nama Barang             : " + namaBarang);
            Console.WriteLine("Harga Barang            : " + harga.ToString("C"));

            Console.Write("Masukkan jumlah barang  : ");
            int jumlahBarang = Convert.ToInt32(Console.ReadLine());

            int totalHarga = harga * jumlahBarang;
            double diskon = 0.0;

            if (totalHarga > 10000000)
            {
                diskon = 0.25;
            }
            else if (totalHarga > 5000000)
            {
                diskon = 0.05;
            }

            double totalDiskon = totalHarga * diskon;
            double jumlahTotalHarga = totalHarga - totalDiskon;
            double pajak = jumlahTotalHarga * 0.1;
            double totalBersih = jumlahTotalHarga + pajak;

            Console.WriteLine();
            Console.WriteLine("=================> RINCIAN PEMBAYARAN <================");
            Console.WriteLine();

            // Tampilkan tabel rincian pembelian
            Console.WriteLine("+---------------+------------------+");
            Console.WriteLine("|   Total Harga | {0,10} |", totalHarga.ToString("C"));
            Console.WriteLine("|        Diskon | {0,10} |", totalDiskon.ToString("C"));
            Console.WriteLine("| Jumlah Harga  | {0,10} |", jumlahTotalHarga.ToString("C"));
            Console.WriteLine("|   PPN (10%)   | {0,10}  |", pajak.ToString("C"));
            Console.WriteLine("|  Total Bersih | {0,10} |", totalBersih.ToString("C"));
            Console.WriteLine("+---------------+------------------+");
			Console.ReadLine();
			Console.WriteLine("Terimakasih Telah Berbelanja Di Toko Kami");
		
			//Nama  : MANARUL HIDAYAT
	    	//KELAS : TI-01
	    	//NPM   : 1101221048
		
        }
        else
        {
            Console.WriteLine("Kode barang tidak valid.");
        }
    }
}