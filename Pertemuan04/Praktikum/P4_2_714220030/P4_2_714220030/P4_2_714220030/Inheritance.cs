using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220030
{
    internal class Inheritance
    {

    }

   class Barcelona
{
    public string Nama { get; set; }
    public int Umur { get; set; }

    public Barcelona(string nama, int umur)
        {
            Nama = nama;
            Umur = umur;
        }

        public void Tanding()
        {
            Console.WriteLine($"{Nama} sedang Bertanding.");
        }
    }

    // Kelas turunan (derived class) yang mewarisi dari Barcelona
    class Pemain : Barcelona
    {
        public Pemain(string nama, int umur)
            : base(nama, umur)
        {
        }

        public void Menyerang()
        {
            Console.WriteLine($"{Nama} sedang Menyerang.");
        }
    }

    // Kelas turunan lainnya
    class Player : Barcelona
    {
        public Player(string nama, int umur)
            : base(nama, umur)
        {
        }

        public void Bertahan()
        {
            Console.WriteLine($"{Nama} sedang Bertahan.");
        }
    }

    
}
