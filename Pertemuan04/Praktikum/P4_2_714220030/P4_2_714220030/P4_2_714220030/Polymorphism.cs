using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220030
{
    internal class polymorphism
    {

    }

    class PemainBarcelona
    {
        public string Nama { get; set; }

        public PemainBarcelona(string nama)
        {
            Nama = nama;
        }

        public virtual void Peran()
        {
            Console.WriteLine("Seorang pemain Barcelona.");
        }
    }

    // Kelas turunan pertama
    class Penyerang : PemainBarcelona
    {
        public Penyerang(string nama)
            : base(nama)
        {
        }

        public override void Peran()
        {
            Console.WriteLine("Seorang penyerang Barcelona.");
        }
    }

    // Kelas turunan kedua
    class Gelandang : PemainBarcelona
    {
        public Gelandang(string nama)
            : base(nama)
        {
        }

        public override void Peran()
        {
            Console.WriteLine("Seorang gelandang Barcelona.");
        }
    }

    // Kelas turunan ketiga
    class Bek : PemainBarcelona
    {
        public Bek(string nama)
            : base(nama)
        {
        }

        public override void Peran()
        {
            Console.WriteLine("Seorang bek Barcelona.");
        }
        

    }

}






