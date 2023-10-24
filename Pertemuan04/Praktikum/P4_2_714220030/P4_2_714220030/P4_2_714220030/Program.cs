using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220030
{

    // Kode Program FC Barcelona
    internal class inheritance
    {
        static void Main()
        {
            //inheritance 
            Pemain PemainBarca = new Pemain("Gundogan", 3);
            Player PlayerBarca = new Player("Christensen", 2);

            Console.WriteLine("Gundogan:");
            PemainBarca.Menyerang();
            PemainBarca.Menyerang();

            Console.WriteLine("\nChristensen:");
            PlayerBarca.Bertahan();
            PlayerBarca.Bertahan();

            Console.ReadLine();

            //polymorphism

            List<PemainBarcelona> pemain = new List<PemainBarcelona>
        {
            new Penyerang("Lamine Yamal"),
            new Gelandang("Frenkie De Jong"),
            new Bek("Jules Kounde")
        };
            foreach (var player in pemain)
            {
                Console.WriteLine($"{player.Nama}:");
                player.Peran();
                Console.WriteLine();
            }

            Console.ReadLine();


            // Constructor

            // Membuat objek pemain Barcelona menggunakan konstruktor
            BarcaPlayer player1 = new BarcaPlayer("Lewandowskii", 9, "Penyerang");
            BarcaPlayer player2 = new BarcaPlayer("Gavi", 6, "Gelandang");
            BarcaPlayer player3 = new BarcaPlayer("Araujo", 3, "Bek");

            Console.WriteLine("Informasi Pemain Barcelona:");
            player1.InfoPemain();
            player2.InfoPemain();
            player3.InfoPemain();

            Console.ReadLine();


            // field_property

            {
                BarcaClub PPemain = new BarcaClub("FerranTorres", 7, "Penyerang");

                // Menggunakan property untuk mengakses field dan mengubah nilainya
                PPemain.Nama = "Ferran Torres (Barcelona)";
                PPemain.NomorPunggung = 7;
                PPemain.Peran = "Gelandang Serang";

                Console.WriteLine("Informasi Pemain Barcelona:");
                PPemain.InfoPemain();

                Console.ReadLine();
            }

        }
    }
}

       
     

    

 

