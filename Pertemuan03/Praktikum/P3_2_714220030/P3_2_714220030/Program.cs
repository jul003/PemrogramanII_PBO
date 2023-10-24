using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_2_714220030
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.Write("Masukkan Nilai N:");
            N = int.Parse(Console.ReadLine());

            if (N >= 1 && N < 10)
            {
                Console.WriteLine($"ANAK AYAM TURUN {N}");

                for (int i = N; i > 1; i--)
                {
                    Console.WriteLine($"Anak ayam turunlah {i}, mati satu tinggallah {i - 1}");
                }

                Console.WriteLine("Anak ayam turunlah 1, mati satu tinggal induknya");
            }
            else if (N <= 0 || N >= 10)
            {
                Console.WriteLine("Nilai tidak boleh kurang dari atau sama dengan 0, atau lebih dari atau sama dengan 10");
            }
            else
            {
                Console.WriteLine("Masukkan nilai yang benar");
            }

        }
    }
    
}

