using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace P4_2_714220030
{
    internal class Constructor
    {
    }

    class BarcaPlayer
    {
        public string Name { get; }
        public int NomorPunggung { get; }
        public string role { get; }

        // Konstruktor untuk kelas BarcaPlayer
        public BarcaPlayer(string nama, int nomorPunggung, string peran)
        {
            Name = nama;
            NomorPunggung = nomorPunggung;
            role = peran;
        }

        // Metode untuk menampilkan informasi pemain
        public void InfoPemain()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Nomor Punggung: {NomorPunggung}");
            Console.WriteLine($"Role: {role}");
            Console.WriteLine();
        }

        
        }
    }

