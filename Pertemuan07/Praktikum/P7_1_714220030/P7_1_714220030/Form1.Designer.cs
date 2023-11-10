namespace P7_1_714220030
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxNama = new System.Windows.Forms.TextBox();
            this.txtBoxProdi = new System.Windows.Forms.TextBox();
            this.txtBoxKelas = new System.Windows.Forms.TextBox();
            this.btnCek = new System.Windows.Forms.Button();
            this.btnTutup = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.rdSenin = new System.Windows.Forms.RadioButton();
            this.rdMinggu = new System.Windows.Forms.RadioButton();
            this.chkuliah = new System.Windows.Forms.CheckBox();
            this.chkTravel = new System.Windows.Forms.CheckBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.chkTidur = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Prodi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kelas";
            // 
            // txtBoxNama
            // 
            this.txtBoxNama.Location = new System.Drawing.Point(180, 53);
            this.txtBoxNama.Name = "txtBoxNama";
            this.txtBoxNama.Size = new System.Drawing.Size(256, 22);
            this.txtBoxNama.TabIndex = 1;
            // 
            // txtBoxProdi
            // 
            this.txtBoxProdi.Location = new System.Drawing.Point(180, 119);
            this.txtBoxProdi.Name = "txtBoxProdi";
            this.txtBoxProdi.Size = new System.Drawing.Size(256, 22);
            this.txtBoxProdi.TabIndex = 1;
            // 
            // txtBoxKelas
            // 
            this.txtBoxKelas.Location = new System.Drawing.Point(180, 201);
            this.txtBoxKelas.Name = "txtBoxKelas";
            this.txtBoxKelas.Size = new System.Drawing.Size(256, 22);
            this.txtBoxKelas.TabIndex = 1;
            // 
            // btnCek
            // 
            this.btnCek.Location = new System.Drawing.Point(181, 262);
            this.btnCek.Name = "btnCek";
            this.btnCek.Size = new System.Drawing.Size(75, 23);
            this.btnCek.TabIndex = 2;
            this.btnCek.Text = "Cek";
            this.btnCek.UseVisualStyleBackColor = true;
            this.btnCek.Click += new System.EventHandler(this.btnCek_Click);
            // 
            // btnTutup
            // 
            this.btnTutup.Location = new System.Drawing.Point(316, 262);
            this.btnTutup.Name = "btnTutup";
            this.btnTutup.Size = new System.Drawing.Size(120, 23);
            this.btnTutup.TabIndex = 2;
            this.btnTutup.Text = "Tutup Forms";
            this.btnTutup.UseVisualStyleBackColor = true;
            this.btnTutup.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(198, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "LIST KEGIATAN";
            // 
            // rdSenin
            // 
            this.rdSenin.AutoSize = true;
            this.rdSenin.Location = new System.Drawing.Point(87, 415);
            this.rdSenin.Name = "rdSenin";
            this.rdSenin.Size = new System.Drawing.Size(62, 20);
            this.rdSenin.TabIndex = 4;
            this.rdSenin.TabStop = true;
            this.rdSenin.Text = "Senin";
            this.rdSenin.UseVisualStyleBackColor = true;
            this.rdSenin.CheckedChanged += new System.EventHandler(this.rdSenin_CheckedChanged);
            // 
            // rdMinggu
            // 
            this.rdMinggu.AutoSize = true;
            this.rdMinggu.Location = new System.Drawing.Point(87, 453);
            this.rdMinggu.Name = "rdMinggu";
            this.rdMinggu.Size = new System.Drawing.Size(72, 20);
            this.rdMinggu.TabIndex = 4;
            this.rdMinggu.TabStop = true;
            this.rdMinggu.Text = "Minggu";
            this.rdMinggu.UseVisualStyleBackColor = true;
            this.rdMinggu.CheckedChanged += new System.EventHandler(this.rdMinggu_CheckedChanged);
            // 
            // chkuliah
            // 
            this.chkuliah.AutoSize = true;
            this.chkuliah.Location = new System.Drawing.Point(87, 502);
            this.chkuliah.Name = "chkuliah";
            this.chkuliah.Size = new System.Drawing.Size(65, 20);
            this.chkuliah.TabIndex = 5;
            this.chkuliah.Text = "Kuliah";
            this.chkuliah.UseVisualStyleBackColor = true;
            // 
            // chkTravel
            // 
            this.chkTravel.AutoSize = true;
            this.chkTravel.Location = new System.Drawing.Point(87, 538);
            this.chkTravel.Name = "chkTravel";
            this.chkTravel.Size = new System.Drawing.Size(86, 20);
            this.chkTravel.TabIndex = 5;
            this.chkTravel.Text = "Traveling";
            this.chkTravel.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(181, 616);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(316, 616);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // chkTidur
            // 
            this.chkTidur.AutoSize = true;
            this.chkTidur.Location = new System.Drawing.Point(87, 582);
            this.chkTidur.Name = "chkTidur";
            this.chkTidur.Size = new System.Drawing.Size(60, 20);
            this.chkTidur.TabIndex = 5;
            this.chkTidur.Text = "Tidur";
            this.chkTidur.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 662);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.chkTidur);
            this.Controls.Add(this.chkTravel);
            this.Controls.Add(this.chkuliah);
            this.Controls.Add(this.rdMinggu);
            this.Controls.Add(this.rdSenin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTutup);
            this.Controls.Add(this.btnCek);
            this.Controls.Add(this.txtBoxKelas);
            this.Controls.Add(this.txtBoxProdi);
            this.Controls.Add(this.txtBoxNama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxNama;
        private System.Windows.Forms.TextBox txtBoxProdi;
        private System.Windows.Forms.TextBox txtBoxKelas;
        private System.Windows.Forms.Button btnCek;
        private System.Windows.Forms.Button btnTutup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdSenin;
        private System.Windows.Forms.RadioButton rdMinggu;
        private System.Windows.Forms.CheckBox chkuliah;
        private System.Windows.Forms.CheckBox chkTravel;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.CheckBox chkTidur;
    }
}

