using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (txtHuruf.Text == "")
            {
                epWarning.SetError(txtHuruf, "Textbox Huruf tidak boleh kosong!");
                epWrong.SetError(txtHuruf, "");
                epCorrect.SetError(txtHuruf, "");
            }
            else
            {
                if ((txtHuruf.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(txtHuruf, "");
                    epWrong.SetError(txtHuruf, "");
                    epCorrect.SetError(txtHuruf, "Betul!");
                }
                else
                {
                    epWrong.SetError(txtHuruf, "Inputan hanya boleh huruf!");
                    epWarning.SetError(txtHuruf, "");
                    epCorrect.SetError(txtHuruf, "");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)

        {
            DateTime getpemesananbodo = pemesananbodo.Value;
            string tanggalbodoo = getpemesananbodo.ToString("dd - MMMM - yyyy");
            string kelaminbodoo = jeniskelamin.GetItemText(jeniskelamin.SelectedItem);
            string pilihantiket = "";

            if (vip.Checked)
            {
                pilihantiket += "VIP, ";
            }

            if (reguler.Checked)
            {
                pilihantiket += "Reguler, ";
            }

            if (!string.IsNullOrEmpty(pilihantiket))
            {
                pilihantiket = pilihantiket.TrimEnd(' ', ',');
            }

            if (pilihantiket != "")
            {
                MessageBox.Show("Nama : " + txtHuruf.Text  + "\nEmail : " + Email.Text + "\nNomorTelepon : " + NomorTelepon.Text + "\nJumlahtiket : " + jumlahtiket.Text + "\nJenis Kelamin : " + kelaminbodoo + "\nTanggalPemesanan : " + tanggalbodoo + "\nPilihanTiket : " + pilihantiket + "\nPembeliTiket1 : " + name1.Text + "\nPembeliTiket2 : " + name2.Text  , "Informasi Pendaftaran Museum Camp Nou", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (txtHuruf.Text == "")
            {
                MessageBox.Show("Masukkan nama anda, tidak boleh kosong", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (jumlahtiket.Text == "")
            {
                MessageBox.Show("Masukkan jumlah  tiket anda yaaa, tidak boleh kosong", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (Email.Text == "")
            {
                MessageBox.Show("Email harus diisi yaaa kakaaaaa ", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (NomorTelepon.Text == "")
            {
                MessageBox.Show("Nomor Telepon Wajib diisi yaa untuk pengiriman kode tiket ! ", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (kelaminbodoo == "")
            {
                MessageBox.Show("Pilih jenis kelamin anda, tidak boleh kosong", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (pilihantiket == "")
            {
                MessageBox.Show("pilih dulu dong jenis tiketnyaaa !", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (txtAngka1.Text == "")
            {
                MessageBox.Show("Isilah kode tiket pertama", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (txtAngka2.Text == "")
            {
                MessageBox.Show("Isilah kode tiket kedua !", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (name1.Text == "")
            {
                MessageBox.Show("Isilah pembeli pertama", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (name2.Text == "")
            {
                MessageBox.Show("Isilah pembeli kedua !", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (Email.Text == "")
            {
                epWarning.SetError(Email, "Textbox Email tidak boleh kosong!");
                epWrong.SetError(Email, "");
                epCorrect.SetError(Email, "");
            }
            else
            {
                if (Regex.IsMatch(Email.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))

                {
                    epWarning.SetError(Email, "");
                    epWrong.SetError(Email, "");
                    epCorrect.SetError(Email, "Betul!");
                }
                else
                {
                    epWrong.SetError(Email, "Format email salah!\nContoh: a@b.c");
                    epWarning.SetError(Email, "");
                    epCorrect.SetError(Email, "");
                }
            }
        }

        private void NomorTelepon_Leave(object sender, EventArgs e)
        {
            string inputText = NomorTelepon.Text;
            int maxLength = 12; 

            if (inputText.Length > maxLength)
            {
                MessageBox.Show("Nomor terlalu melebihi batas maksimum " + maxLength + " Angka diperbolehkan.");
                NomorTelepon.Focus();
                return;
            }
            if ((NomorTelepon.Text).All(Char.IsNumber))
            {
                epCorrect.SetError(NomorTelepon, "Benar!");
                epWarning.SetError(NomorTelepon, "");
                epWrong.SetError(NomorTelepon, "");
            }

            if (NomorTelepon.Text == "")
            {
                epWarning.SetError(NomorTelepon, "Nomor Telepon harus diisi yaa untuk kirim kode tiket");
                epWrong.SetError(NomorTelepon, "");
                epCorrect.SetError(NomorTelepon, "");
            }
            else if ((NomorTelepon.Text).All(Char.IsLetter))
            {
                epCorrect.SetError(NomorTelepon, "");
                epWarning.SetError(NomorTelepon, "");
                epWrong.SetError(NomorTelepon, "Nomor Telepon hanya boleh diisi angka ya !");
            }

            

        }

        private void jumlahtiket_Leave(object sender, EventArgs e)
        {

        }

        private void name1_Leave(object sender, EventArgs e)
        {
            if ((name1.Text).All(Char.IsUpper))
            {
                epCorrect.SetError(name1, "Betul");
                epWarning.SetError(name1, "");
                epWrong.SetError(name1, "");
            }

            if (name1.Text == "")
            {
                epWarning.SetError(name1, "harus diisi yaa tidak boleh kosongg");
                epWrong.SetError(name1, "");
                epCorrect.SetError(name1, "");
            }

            else if ((name1.Text).Any(Char.IsLower))
            {
                epWarning.SetError(name1, "");
                epWrong.SetError(name1, "Kata semuanya harus UpperCase");
                epCorrect.SetError(name1, "");
            }

            
            
        }

        private void name2_Leave(object sender, EventArgs e)
        {
            if ((name2.Text).All(Char.IsLower))
            {
                epCorrect.SetError(name2, "Betul");
                epWarning.SetError(name2, "");
                epWrong.SetError(name2, "");
            }

             if (name2.Text == "")
            {
                epWarning.SetError(name2, "harus diisi yaa tidak boleh kosongg");
                epWrong.SetError(name2, "");
                epCorrect.SetError(name2, "");
            }

            else if ((name2.Text).Any(Char.IsUpper))
            {
                epWarning.SetError(name2, "");
                epWrong.SetError(name2, "Kata semuanya harus lowercase");
                epCorrect.SetError(name2, "");
            }

            
        }

        private void Angka1_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(txtAngka1.Text, out int Angka1) && int.TryParse(txtAngka2.Text, out int Angka2))
            {
                if (Angka1 > Angka2)
                {
                    epCorrect.SetError(txtAngka1, "Betul!");
                    epCorrect.SetError(txtAngka2, "Betul!");
                    epWarning.SetError(txtAngka1, "");
                    epWarning.SetError(txtAngka2, "");
                    epWrong.SetError(txtAngka1, "");
                    epWrong.SetError(txtAngka2, "");
                }
                else if (Angka1 < Angka2)
                {
                    epCorrect.SetError(txtAngka1, "");
                    epCorrect.SetError(txtAngka2, "");
                    epWarning.SetError(txtAngka1, "");
                    epWarning.SetError(txtAngka2, "");
                    epWrong.SetError(txtAngka1, "Angka 1 lebih kecil dari angka 2");
                    epWrong.SetError(txtAngka2, "Angka 1 lebih kecil dari angka 2");
                }
                else if (Angka1 == Angka2)
                {
                    epCorrect.SetError(txtAngka1, "");
                    epCorrect.SetError(txtAngka2, "");
                    epWarning.SetError(txtAngka1, "");
                    epWarning.SetError(txtAngka2, "");
                    epWrong.SetError(txtAngka1, "Angka 1 sama dengan angka 2");
                    epWrong.SetError(txtAngka2, "Angka 1 sama dengan angka 2");
                }
                else
                {
                    epCorrect.SetError(txtAngka1, "");
                    epCorrect.SetError(txtAngka2, "");
                    epWarning.SetError(txtAngka1, "");
                    epWarning.SetError(txtAngka2, "");
                    epWrong.SetError(txtAngka1, "Input salah euyyy");
                    epWrong.SetError(txtAngka2, "Input salah euyyy");
                }
            }

            else if (txtAngka2.Text == "")
            {
                epWarning.SetError(txtAngka2, "Input kosong euyyy!");
                epWrong.SetError(txtAngka2, "");
                epCorrect.SetError(txtAngka2, "");
            }

            else if (txtAngka1.Text == "" && txtAngka2.Text == "")
            {
                epWarning.SetError(txtAngka2, "Input  jangan kosong donggg!");
                epWrong.SetError(txtAngka2, "");
                epCorrect.SetError(txtAngka2, "");

                epWarning.SetError(txtAngka1, "Input jangan kosong donggg!");
                epWrong.SetError(txtAngka1, "");
                epCorrect.SetError(txtAngka1, "");
            }

            else
            {
                epWrong.SetError(txtAngka1, "Input hanya boleh angka ya guysss!");
                epWarning.SetError(txtAngka1, "");
                epCorrect.SetError(txtAngka1, "");
            }
        }

        private void txtAngka2_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(txtAngka1.Text, out int Angka1) && int.TryParse(txtAngka2.Text, out int Angka2))
            {
                if (Angka1 > Angka2)
                {
                    epCorrect.SetError(txtAngka1, "Betul!");
                    epCorrect.SetError(txtAngka2, "Betul!");
                    epWarning.SetError(txtAngka1, "");
                    epWarning.SetError(txtAngka2, "");
                    epWrong.SetError(txtAngka1, "");
                    epWrong.SetError(txtAngka2, "");
                }
                else if (Angka1 < Angka2)
                {
                    epCorrect.SetError(txtAngka1, "");
                    epCorrect.SetError(txtAngka2, "");
                    epWarning.SetError(txtAngka1, "");
                    epWarning.SetError(txtAngka2, "");
                    epWrong.SetError(txtAngka1, "Angka 1 lebih kecil dari angka 2");
                    epWrong.SetError(txtAngka2, "Angka 1 lebih kecil dari angka 2");
                }
                else if (Angka1 == Angka2)
                {
                    epCorrect.SetError(txtAngka1, "");
                    epCorrect.SetError(txtAngka2, "");
                    epWarning.SetError(txtAngka1, "");
                    epWarning.SetError(txtAngka2, "");
                    epWrong.SetError(txtAngka1, "Angka 1 sama dengan angka 2");
                    epWrong.SetError(txtAngka2, "Angka 1 sama dengan angka 2");
                }
                else
                {
                    epCorrect.SetError(txtAngka1, "");
                    epCorrect.SetError(txtAngka2, "");
                    epWarning.SetError(txtAngka1, "");
                    epWarning.SetError(txtAngka2, "");
                    epWrong.SetError(txtAngka1, "Input salah");
                    epWrong.SetError(txtAngka2, "Input salah");
                }
            }

            else if (txtAngka1.Text == "")
            {
                epWarning.SetError(txtAngka1, "Input kosong euyyy!");
                epWrong.SetError(txtAngka1, "");
                epCorrect.SetError(txtAngka1, "");
            }

            else if (txtAngka1.Text == "" && txtAngka2.Text == "")
            {
                epWarning.SetError(txtAngka2, "Inputan jangan kosong donggg!");
                epWrong.SetError(txtAngka2, "");
                epCorrect.SetError(txtAngka2, "");

                epWarning.SetError(txtAngka1, "Inputan jangan kosong dongggg!");
                epWrong.SetError(txtAngka1, "");
                epCorrect.SetError(txtAngka1, "");
            }

            else
            {
                epWrong.SetError(txtAngka2, "Input hanya boleh angka yaa guys!");
                epWarning.SetError(txtAngka2, "");
                epCorrect.SetError(txtAngka2, "");
            }
        }
    }
}
