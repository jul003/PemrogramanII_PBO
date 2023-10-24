using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_3_714220030
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Menu Persegi Panjang");
                Console.WriteLine("1. Hitung Luas");
                Console.WriteLine("2. Hitung Keliling");

                Console.Write("Menu Pilihan: ");
                int input_menu = Convert.ToInt32(Console.ReadLine());

                if (input_menu == 1)
                {
                    HitungLuasPersegiPanjang();
                }
                else if (input_menu == 2)
                {
                    HitungKelilingPersegiPanjang();
                }
                else
                {
                    Console.WriteLine("Menu tidak ada");
                }

                Console.Write("\nIngin Mengulang kembali? (Y/T): ");
            } while (Console.ReadLine().ToUpper() == "Y");
        }

        static void HitungLuasPersegiPanjang()
        {
            Console.WriteLine("Menghitung luas persegi panjang");
            Console.Write("Masukkan Panjang: ");
            int panjang = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan Lebar: ");
            int lebar = Convert.ToInt32(Console.ReadLine());

            int luas = panjang * lebar;
            Console.WriteLine("Luas Persegi Panjang = {0}", luas);
        }

        static void HitungKelilingPersegiPanjang()
        {
            Console.WriteLine("Menghitung Keliling Persegi Panjang");
            Console.Write("Masukkan Panjang: ");
            int panjang = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan Lebar: ");
            int lebar = Convert.ToInt32(Console.ReadLine());

            int keliling = 2 * (panjang + lebar);
            Console.WriteLine("Keliling Persegi Panjang = {0}", keliling);
        }
    }
}

