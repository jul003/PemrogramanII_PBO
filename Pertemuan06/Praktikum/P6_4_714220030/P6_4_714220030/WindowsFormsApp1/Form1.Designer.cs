namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHuruf = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Email = new System.Windows.Forms.TextBox();
            this.NomorTelepon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.vip = new System.Windows.Forms.CheckBox();
            this.reguler = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.jeniskelamin = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWrong = new System.Windows.Forms.ErrorProvider(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.pemesananbodo = new System.Windows.Forms.DateTimePicker();
            this.jumlahtiket = new System.Windows.Forms.NumericUpDown();
            this.namanama = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.name1 = new System.Windows.Forms.TextBox();
            this.name2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAngka1 = new System.Windows.Forms.TextBox();
            this.txtAngka2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jumlahtiket)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(267, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(538, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "FORM PEMESANAN TIKET MUSEUM CAMP NOU  ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.Transparent;
            this.name.Location = new System.Drawing.Point(41, 58);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(68, 25);
            this.name.TabIndex = 1;
            this.name.Text = "Nama";
            this.name.Click += new System.EventHandler(this.name_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(44, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(41, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nomor Telepon";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtHuruf
            // 
            this.txtHuruf.Location = new System.Drawing.Point(232, 58);
            this.txtHuruf.Name = "txtHuruf";
            this.txtHuruf.Size = new System.Drawing.Size(277, 22);
            this.txtHuruf.TabIndex = 4;
            this.txtHuruf.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtHuruf.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(355, 648);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Tampilkan Tiket";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(602, 648);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Selesai";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(232, 145);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(277, 22);
            this.Email.TabIndex = 4;
            this.Email.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.Email.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // NomorTelepon
            // 
            this.NomorTelepon.Location = new System.Drawing.Point(232, 188);
            this.NomorTelepon.MaxLength = 999999;
            this.NomorTelepon.Name = "NomorTelepon";
            this.NomorTelepon.Size = new System.Drawing.Size(277, 22);
            this.NomorTelepon.TabIndex = 4;
            this.NomorTelepon.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.NomorTelepon.Leave += new System.EventHandler(this.NomorTelepon_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(19, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Pilihan Tiket";
            // 
            // vip
            // 
            this.vip.AutoSize = true;
            this.vip.BackColor = System.Drawing.Color.Transparent;
            this.vip.ForeColor = System.Drawing.Color.White;
            this.vip.Location = new System.Drawing.Point(175, 304);
            this.vip.Name = "vip";
            this.vip.Size = new System.Drawing.Size(50, 20);
            this.vip.TabIndex = 10;
            this.vip.Text = "VIP";
            this.vip.UseVisualStyleBackColor = false;
            // 
            // reguler
            // 
            this.reguler.AutoSize = true;
            this.reguler.BackColor = System.Drawing.Color.Transparent;
            this.reguler.ForeColor = System.Drawing.Color.White;
            this.reguler.Location = new System.Drawing.Point(175, 334);
            this.reguler.Name = "reguler";
            this.reguler.Size = new System.Drawing.Size(77, 20);
            this.reguler.TabIndex = 11;
            this.reguler.Text = "Reguler";
            this.reguler.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Jumlah Tiket";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // jeniskelamin
            // 
            this.jeniskelamin.FormattingEnabled = true;
            this.jeniskelamin.Items.AddRange(new object[] {
            "Laki - Laki",
            "Perempuan"});
            this.jeniskelamin.Location = new System.Drawing.Point(232, 101);
            this.jeniskelamin.Name = "jeniskelamin";
            this.jeniskelamin.Size = new System.Drawing.Size(277, 24);
            this.jeniskelamin.TabIndex = 13;
            this.jeniskelamin.Text = "-- Pilih Jenis Kelamin --";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(41, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Jenis Kelamin";
            this.label6.Click += new System.EventHandler(this.name_Click);
            // 
            // epWarning
            // 
            this.epWarning.ContainerControl = this;
            this.epWarning.Icon = ((System.Drawing.Icon)(resources.GetObject("epWarning.Icon")));
            // 
            // epCorrect
            // 
            this.epCorrect.ContainerControl = this;
            this.epCorrect.Icon = ((System.Drawing.Icon)(resources.GetObject("epCorrect.Icon")));
            // 
            // epWrong
            // 
            this.epWrong.ContainerControl = this;
            this.epWrong.Icon = ((System.Drawing.Icon)(resources.GetObject("epWrong.Icon")));
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Snow;
            this.label7.Location = new System.Drawing.Point(41, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(211, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "Tanggal Pemesanan";
            this.label7.Click += new System.EventHandler(this.label4_Click);
            // 
            // pemesananbodo
            // 
            this.pemesananbodo.CustomFormat = "dd - MMMM -  yyyy";
            this.pemesananbodo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pemesananbodo.Location = new System.Drawing.Point(272, 255);
            this.pemesananbodo.Name = "pemesananbodo";
            this.pemesananbodo.Size = new System.Drawing.Size(200, 22);
            this.pemesananbodo.TabIndex = 14;
            // 
            // jumlahtiket
            // 
            this.jumlahtiket.Location = new System.Drawing.Point(185, 382);
            this.jumlahtiket.Name = "jumlahtiket";
            this.jumlahtiket.Size = new System.Drawing.Size(120, 22);
            this.jumlahtiket.TabIndex = 15;
            // 
            // namanama
            // 
            this.namanama.AutoSize = true;
            this.namanama.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namanama.Location = new System.Drawing.Point(494, 423);
            this.namanama.Name = "namanama";
            this.namanama.Size = new System.Drawing.Size(183, 22);
            this.namanama.TabIndex = 16;
            this.namanama.Text = "PEMBELI TIKET";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(70, 474);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "PEMBELI PERTAMA";
            this.label8.Click += new System.EventHandler(this.name_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(70, 532);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "PEMBELI KEDUA";
            this.label9.Click += new System.EventHandler(this.name_Click);
            // 
            // name1
            // 
            this.name1.Location = new System.Drawing.Point(299, 474);
            this.name1.Name = "name1";
            this.name1.Size = new System.Drawing.Size(258, 22);
            this.name1.TabIndex = 17;
            this.name1.Leave += new System.EventHandler(this.name1_Leave);
            // 
            // name2
            // 
            this.name2.Location = new System.Drawing.Point(299, 532);
            this.name2.Name = "name2";
            this.name2.Size = new System.Drawing.Size(258, 22);
            this.name2.TabIndex = 17;
            this.name2.Leave += new System.EventHandler(this.name2_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(725, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(207, 22);
            this.label10.TabIndex = 18;
            this.label10.Text = "Konfirmasi Kode Tiket";
            // 
            // txtAngka1
            // 
            this.txtAngka1.Location = new System.Drawing.Point(709, 103);
            this.txtAngka1.Name = "txtAngka1";
            this.txtAngka1.Size = new System.Drawing.Size(232, 22);
            this.txtAngka1.TabIndex = 19;
            this.txtAngka1.Leave += new System.EventHandler(this.Angka1_Leave);
            // 
            // txtAngka2
            // 
            this.txtAngka2.Location = new System.Drawing.Point(709, 149);
            this.txtAngka2.Name = "txtAngka2";
            this.txtAngka2.Size = new System.Drawing.Size(232, 22);
            this.txtAngka2.TabIndex = 19;
            this.txtAngka2.Leave += new System.EventHandler(this.txtAngka2_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(620, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 22);
            this.label11.TabIndex = 20;
            this.label11.Text = "Kode 1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(620, 149);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 22);
            this.label12.TabIndex = 20;
            this.label12.Text = "Kode 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1058, 700);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtAngka2);
            this.Controls.Add(this.txtAngka1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.name2);
            this.Controls.Add(this.name1);
            this.Controls.Add(this.namanama);
            this.Controls.Add(this.jumlahtiket);
            this.Controls.Add(this.pemesananbodo);
            this.Controls.Add(this.jeniskelamin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.reguler);
            this.Controls.Add(this.vip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.NomorTelepon);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtHuruf);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Museum Camp Nou";
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jumlahtiket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHuruf;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox NomorTelepon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox vip;
        private System.Windows.Forms.CheckBox reguler;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox jeniskelamin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider epWarning;
        private System.Windows.Forms.ErrorProvider epCorrect;
        private System.Windows.Forms.ErrorProvider epWrong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker pemesananbodo;
        private System.Windows.Forms.NumericUpDown jumlahtiket;
        private System.Windows.Forms.Label namanama;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox name2;
        private System.Windows.Forms.TextBox name1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAngka2;
        private System.Windows.Forms.TextBox txtAngka1;
    }
}

