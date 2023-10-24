using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1_714220030
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------Masukkan Nilai yang diinginkan :-----");
            int angka =Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("------Masukkan nilai satu lagi");
            int angka2 = Convert.ToInt32 (Console.ReadLine());
            
            

            int penjumlahan = angka + angka2;
            Console.WriteLine("{0} + {1} =  {2}", angka, angka2, penjumlahan);

           

            int pengurangan = angka - angka2;
            Console.WriteLine("{0} - {1} =  {2}", angka, angka2, pengurangan);

           
            int perkalian = angka * angka2;
            Console.WriteLine("{0} * {1} =  {2}", angka, angka2, perkalian);

            

            double pembagian = (double) angka / angka2;
            Console.WriteLine("{0} / {1} =  {2}", angka, angka2, pembagian);
        }
    }
}
