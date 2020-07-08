using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek penjualan
        static List<Penjualan> daftarPenjualan = new List<Penjualan>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;

                    case 2:
                        HapusPenjualan();
                        break;

                    case 3:
                        TampilPenjualan();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan menu
        }

        static void TambahPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan penjualan ke dalam collection
			if (pil == 1 || pil == 1)
                {
                    Console.WriteLine("Tambah Penjualan");
                    Console.Write("Nota : ");
                    string nota = Console.ReadLine();
                    Console.Write("Tanggal : ");
                    string tanggal = Console.ReadLine();
					 Console.Write("Nama : ");
                    string nama = Console.ReadLine();
                    Console.Write("Harga Barang : ");
                    double hargabarang = Convert.ToDouble(Console.ReadLine());

                    kt.Add(new KaryawanTetap() { Nik = nik, Nama = nama, GajiBulanan=gajibulanan });

                }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menghapus penjualan dari dalam collection
			 else if(pilihan == 2 || pilihan == 2)
            {


                Console.WriteLine("Pilihan Hapus Data Penjualan");
                string hapus;
                Console.WriteLine("Masukan NOTA : ");
                hapus = Console.ReadLine();
                int x = 0;
                foreach(Penjualan penjualan in kt)
                {
                    if (hapus == penjualan.NOTA)
                    {
                        kt.RemoveAt(x);
                        break;
                    }
                    x++;
                }
                x = 0;
                foreach (Penjualan penjualan in kh)
                {
                    if (hapus == penjualan.NOTA)
                    {
                        kh.RemoveAt(x);
                        break;
                    }
                    x++;
                }
                x = 0;
                foreach (Penjualan penjualan in s)
                {
                    if (hapus == penjualan.NOTA)
                    {
                        s.RemoveAt(x);
                        break;
                    }
                    x++;
                }
                Console.ReadKey(true);
                Console.Clear();
                goto menu;
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar penjualan yang ada di dalam collection
			else if (pilihan == 3 || pilihan == 3)
            {


                Console.WriteLine("List Data Penjualan Barang");
                int no = 1;
                foreach (Penjualan penjualan in kt)
                {
                    Console.WriteLine("{0}. NOTA: {1}, Tanggal: {2}, Nama: {3}, Harga Barang",
                    no, karyawan.Nik, karyawan.Nama, karyawan.TotalGaji());
                    no++;
                }
              
                Console.ReadKey(true);
                Console.Clear();
                goto menu;

            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
