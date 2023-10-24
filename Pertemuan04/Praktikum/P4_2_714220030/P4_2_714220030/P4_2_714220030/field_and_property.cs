using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220030
{
    internal class field_and_property
    {
    }

    class BarcaClub
    {
        private string Ngaran;
        private int Nopung;
        private string Roles;

        public BarcaClub(string nama, int nomorPunggung, string peran)
        {
            this.Ngaran = nama;
            this.Nopung = nomorPunggung;
            this.Roles = peran;
        }

        // Property untuk mengakses field "nama"
        public string Nama
        {
            get { return Ngaran; }
            set { Ngaran = value; }
        }

        // Property untuk mengakses field "nomorPunggung"
        public int NomorPunggung
        {
            get { return Nopung; }
            set { Nopung = value; }
        }

        // Property untuk mengakses field "peran"
        public string Peran
        {
            get { return Roles; }
            set { Roles = value; }
        }

        public void InfoPemain()
        {
            Console.WriteLine($"Nama: {Nama}");
            Console.WriteLine($"Nomor Punggung: {NomorPunggung}");
            Console.WriteLine($"Peran: {Peran}");
            Console.WriteLine();
        }

        
        }
    }

