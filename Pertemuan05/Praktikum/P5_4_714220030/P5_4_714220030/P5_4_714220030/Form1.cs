using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_4_714220030
{
    public partial class design : Form
    {
        public design()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Nama_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void form_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime gettanggalbodo = tanggalbodo.Value;
            string tanggalbodoo = gettanggalbodo.ToString("dd - MMMM - yyyy");
            string kelaminbodoo = kelaminbodo.GetItemText(kelaminbodo.SelectedItem);
            string kelasbodo = "";
            string jadwalbodo = "";

            if (biolabodo.Checked)
            {
                kelasbodo += "biola, ";
            }

            if (gitarbodo.Checked)
            {
                kelasbodo += "gitar, ";
            }

            if (saxbodo.Checked)
            {
                kelasbodo += "saxophone, ";
            }

            if (konbodo.Checked)
            {
                kelasbodo += "konduktor, ";
            }

            if (pianobodo.Checked)
            {
                kelasbodo += "piano, ";
            }

            if (drumbodo.Checked)
            {
                kelasbodo += "drum, ";
            }

            if (vokalbodo.Checked)
            {
                kelasbodo += "vokal, ";
            }

            if (kombodo.Checked)
            {
                kelasbodo += "komposer, ";
            }

            if (!string.IsNullOrEmpty(kelasbodo))
            {
                kelasbodo = kelasbodo.TrimEnd(' ', ',');
            }

            if (jadwalbodo1.Checked)
            {
                jadwalbodo = "Senin dan Rabu, 14.00 - 16.00";
            }

            else if (jadwalbodo2.Checked)
            {
                jadwalbodo = "Selasa dan Kamis, 14.00 - 16.00";
            }

            else if (jadwalbodo3.Checked)
            {
                jadwalbodo = "Sabtu dan Minggu, 09.00 - 11.00";
            }

            else if (jadwalbodo4.Checked)
            {
                jadwalbodo = "Minggu, 13.00 - 17.00";
            }

            if (kelasbodo != "" && jadwalbodo != "")
            {
                MessageBox.Show("Nama : " + namabodo.Text + "\nJenis Kelamin : " + kelaminbodoo + "\nTanggal Lahir : " + tanggalbodoo + "\nPilihan Kelas : " + kelasbodo + "\nPilihan Jadwal : " + jadwalbodo, "Informasi Pendaftaran", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (namabodo.Text == "")
            {
                MessageBox.Show("Masukkan nama anda, tidak boleh kosong", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (kelaminbodoo == "")
            {
                MessageBox.Show("Pilih jenis kelamin anda, tidak boleh kosong", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (kelasbodo == "")
            {
                MessageBox.Show("Harus memilih satu dari pilihan kelas", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (jadwalbodo == "")
            {
                MessageBox.Show("Harus memilih satu dari pilihan jadwal", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void namabodo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
