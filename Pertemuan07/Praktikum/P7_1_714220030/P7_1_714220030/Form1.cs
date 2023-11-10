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

namespace P7_1_714220030
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(582, 310);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnCek_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if(string.IsNullOrWhiteSpace(txtBoxNama.Text))
            {
                errorMessage += " Nama belom diisi\n";
            }

            if (string.IsNullOrWhiteSpace(txtBoxProdi.Text))
            {
                errorMessage += " Prodi belom diisi\n";
            }

            else if (Regex.IsMatch(txtBoxProdi.Text, @"^[A-Za-z0-9]+-[A-Za-z0-9]+$"))
            {
                errorMessage += "Prodi harus berformat [Strata] \n";
            }

            if (string.IsNullOrWhiteSpace(txtBoxKelas.Text))
            {
                errorMessage += " Kelas belom diisi\n";
            }

            if (string.IsNullOrWhiteSpace(errorMessage))
            {
                MessageBox.Show(
                    "Lengkap",
                    "Informasi Data Submit",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                    );

                this.Size = new Size(643, 709);
            }
            else
            {
                MessageBox.Show(
                    errorMessage,
                    "Informasi Data Submit",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning
                    );
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Size = new Size(582, 310);
            //txtBoxNama.Text = null;
            //txtBoxProdi.Text = null;
            //txtBoxKelas.Text = null;

            foreach(Control control in Controls)
            {
                if (control is TextBox)
                    ((TextBox)control).Text = string.Empty;
                else if (control is RadioButton)
                    ((RadioButton)control).Checked = false;
                else if (control is CheckBox)
                    ((CheckBox)control).Checked = false;
                else if (control is ComboBox)
                    ((ComboBox)control).SelectedIndex = -1;
            }

            this.Size = new Size(582, 310);

        }

        private void rdSenin_CheckedChanged(object sender, EventArgs e)
        {
            if(rdSenin.Checked)
            {
                chkuliah.Enabled = true; chkuliah.Checked = true;
                chkTravel.Enabled = false; chkTravel.Checked = false;
                chkTidur.Enabled = false;  chkTidur.Checked = false;
            }

            
        }

        private void rdMinggu_CheckedChanged(object sender, EventArgs e)
        {
            if (rdMinggu.Checked)
            {
                chkuliah.Enabled = false; chkuliah.Checked= false;
                chkTravel.Enabled = true; chkTravel.Checked = true;
                chkTidur.Enabled = true; chkTidur.Checked= true;
            }
        }
    }
}
