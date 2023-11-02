using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Diagnostics.Eventing.Reader;

namespace P6_3_714220030
{
    public partial class Validasi : Form
    {
        public Validasi()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtHuruf_Leave(object sender, EventArgs e)
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

        private void txtAngka_TextChanged(object sender, EventArgs e)
        {
        }
        private void txtAngka_Leave(object sender, EventArgs e)
        {
            if (txtAngka.Text == "")
            {
                epWarning.SetError(txtAngka, "Textbox Angka tidak boleh kosong!");
                epWrong.SetError(txtAngka, "");
                epCorrect.SetError(txtAngka, "");
            }
            else
            {
                if ((txtAngka.Text).All(Char.IsNumber))
                {
                    epCorrect.SetError(txtAngka, "Betul!");
                    epWarning.SetError(txtAngka, "");
                    epWrong.SetError(txtAngka, "");
                }
                else
                {
                    epCorrect.SetError(txtAngka, "");
                    epWarning.SetError(txtAngka, "");
                    epWrong.SetError(txtAngka, "inputan hanya boleh angka ya bang!");
                }
            }

        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                epWarning.SetError(txtEmail, "Textbox Email tidak boleh kosong!");
                epWrong.SetError(txtEmail, "");
                epCorrect.SetError(txtEmail, "");
            }
            else
            {
                if (Regex.IsMatch(txtEmail.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))

                {
                    epWarning.SetError(txtEmail, "");
                    epWrong.SetError(txtEmail, "");
                    epCorrect.SetError(txtEmail, "Betul!");
                }
                else
                {
                    epWrong.SetError(txtEmail, "Format email salah!\nContoh: a@b.c");
                    epWarning.SetError(txtEmail, "");
                    epCorrect.SetError(txtEmail, "");
                }
            }
        }

        private void txtAngka1_Leave(object sender, EventArgs e)
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

        private void txtHuruf_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAngka1_TextChanged(object sender, EventArgs e)
        {


        }
    }
}



