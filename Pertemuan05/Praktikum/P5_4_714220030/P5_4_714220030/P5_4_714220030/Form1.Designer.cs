namespace P5_4_714220030
{
    partial class design
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(design));
            this.form = new System.Windows.Forms.Label();
            this.Nama = new System.Windows.Forms.Label();
            this.jk = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.namabodo = new System.Windows.Forms.TextBox();
            this.kelaminbodo = new System.Windows.Forms.ComboBox();
            this.tanggalbodo = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kombodo = new System.Windows.Forms.CheckBox();
            this.konbodo = new System.Windows.Forms.CheckBox();
            this.vokalbodo = new System.Windows.Forms.CheckBox();
            this.saxbodo = new System.Windows.Forms.CheckBox();
            this.pianobodo = new System.Windows.Forms.CheckBox();
            this.drumbodo = new System.Windows.Forms.CheckBox();
            this.gitarbodo = new System.Windows.Forms.CheckBox();
            this.biolabodo = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.jadwalbodo4 = new System.Windows.Forms.RadioButton();
            this.jadwalbodo3 = new System.Windows.Forms.RadioButton();
            this.jadwalbodo2 = new System.Windows.Forms.RadioButton();
            this.jadwalbodo1 = new System.Windows.Forms.RadioButton();
            this.tambodo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // form
            // 
            this.form.AutoSize = true;
            this.form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.form.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form.ForeColor = System.Drawing.Color.White;
            this.form.Location = new System.Drawing.Point(248, 9);
            this.form.Name = "form";
            this.form.Size = new System.Drawing.Size(330, 35);
            this.form.TabIndex = 0;
            this.form.Text = "FORM PENDAFTARAN";
            this.form.Click += new System.EventHandler(this.form_Click);
            // 
            // Nama
            // 
            this.Nama.AutoSize = true;
            this.Nama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Nama.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nama.ForeColor = System.Drawing.Color.White;
            this.Nama.Location = new System.Drawing.Point(70, 55);
            this.Nama.Name = "Nama";
            this.Nama.Size = new System.Drawing.Size(67, 23);
            this.Nama.TabIndex = 1;
            this.Nama.Text = "Nama";
            this.Nama.Click += new System.EventHandler(this.Nama_Click);
            // 
            // jk
            // 
            this.jk.AutoSize = true;
            this.jk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.jk.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jk.ForeColor = System.Drawing.Color.White;
            this.jk.Location = new System.Drawing.Point(70, 95);
            this.jk.Name = "jk";
            this.jk.Size = new System.Drawing.Size(146, 23);
            this.jk.TabIndex = 1;
            this.jk.Text = "Jenis Kelamin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(70, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tanggal Lahir";
            // 
            // namabodo
            // 
            this.namabodo.Location = new System.Drawing.Point(254, 55);
            this.namabodo.Name = "namabodo";
            this.namabodo.Size = new System.Drawing.Size(483, 22);
            this.namabodo.TabIndex = 2;
            this.namabodo.TextChanged += new System.EventHandler(this.namabodo_TextChanged);
            // 
            // kelaminbodo
            // 
            this.kelaminbodo.FormattingEnabled = true;
            this.kelaminbodo.Items.AddRange(new object[] {
            "Laki - laki",
            "Perempuan"});
            this.kelaminbodo.Location = new System.Drawing.Point(254, 93);
            this.kelaminbodo.Name = "kelaminbodo";
            this.kelaminbodo.Size = new System.Drawing.Size(483, 24);
            this.kelaminbodo.TabIndex = 3;
            this.kelaminbodo.Text = "--Pilih Jenis Kelamin--";
            // 
            // tanggalbodo
            // 
            this.tanggalbodo.CustomFormat = "dd - MMMM - yyyy";
            this.tanggalbodo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tanggalbodo.Location = new System.Drawing.Point(254, 132);
            this.tanggalbodo.Name = "tanggalbodo";
            this.tanggalbodo.Size = new System.Drawing.Size(483, 22);
            this.tanggalbodo.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.kombodo);
            this.groupBox1.Controls.Add(this.konbodo);
            this.groupBox1.Controls.Add(this.vokalbodo);
            this.groupBox1.Controls.Add(this.saxbodo);
            this.groupBox1.Controls.Add(this.pianobodo);
            this.groupBox1.Controls.Add(this.drumbodo);
            this.groupBox1.Controls.Add(this.gitarbodo);
            this.groupBox1.Controls.Add(this.biolabodo);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(31, 239);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 247);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pilihan Kelas";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // kombodo
            // 
            this.kombodo.AutoSize = true;
            this.kombodo.Location = new System.Drawing.Point(209, 162);
            this.kombodo.Name = "kombodo";
            this.kombodo.Size = new System.Drawing.Size(91, 20);
            this.kombodo.TabIndex = 1;
            this.kombodo.Text = "Komposer";
            this.kombodo.UseVisualStyleBackColor = true;
            // 
            // konbodo
            // 
            this.konbodo.AutoSize = true;
            this.konbodo.Location = new System.Drawing.Point(43, 162);
            this.konbodo.Name = "konbodo";
            this.konbodo.Size = new System.Drawing.Size(89, 20);
            this.konbodo.TabIndex = 1;
            this.konbodo.Text = "Konduktor";
            this.konbodo.UseVisualStyleBackColor = true;
            // 
            // vokalbodo
            // 
            this.vokalbodo.AutoSize = true;
            this.vokalbodo.Location = new System.Drawing.Point(209, 123);
            this.vokalbodo.Name = "vokalbodo";
            this.vokalbodo.Size = new System.Drawing.Size(64, 20);
            this.vokalbodo.TabIndex = 1;
            this.vokalbodo.Text = "Vokal";
            this.vokalbodo.UseVisualStyleBackColor = true;
            // 
            // saxbodo
            // 
            this.saxbodo.AutoSize = true;
            this.saxbodo.Location = new System.Drawing.Point(43, 123);
            this.saxbodo.Name = "saxbodo";
            this.saxbodo.Size = new System.Drawing.Size(98, 20);
            this.saxbodo.TabIndex = 1;
            this.saxbodo.Text = "Saxophone";
            this.saxbodo.UseVisualStyleBackColor = true;
            // 
            // pianobodo
            // 
            this.pianobodo.AutoSize = true;
            this.pianobodo.Location = new System.Drawing.Point(209, 48);
            this.pianobodo.Name = "pianobodo";
            this.pianobodo.Size = new System.Drawing.Size(64, 20);
            this.pianobodo.TabIndex = 0;
            this.pianobodo.Text = "Piano";
            this.pianobodo.UseVisualStyleBackColor = true;
            // 
            // drumbodo
            // 
            this.drumbodo.AutoSize = true;
            this.drumbodo.Location = new System.Drawing.Point(209, 86);
            this.drumbodo.Name = "drumbodo";
            this.drumbodo.Size = new System.Drawing.Size(61, 20);
            this.drumbodo.TabIndex = 1;
            this.drumbodo.Text = "Drum";
            this.drumbodo.UseVisualStyleBackColor = true;
            // 
            // gitarbodo
            // 
            this.gitarbodo.AutoSize = true;
            this.gitarbodo.Location = new System.Drawing.Point(43, 86);
            this.gitarbodo.Name = "gitarbodo";
            this.gitarbodo.Size = new System.Drawing.Size(57, 20);
            this.gitarbodo.TabIndex = 1;
            this.gitarbodo.Text = "Gitar";
            this.gitarbodo.UseVisualStyleBackColor = true;
            // 
            // biolabodo
            // 
            this.biolabodo.AutoSize = true;
            this.biolabodo.Location = new System.Drawing.Point(43, 48);
            this.biolabodo.Name = "biolabodo";
            this.biolabodo.Size = new System.Drawing.Size(60, 20);
            this.biolabodo.TabIndex = 0;
            this.biolabodo.Text = "Biola";
            this.biolabodo.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox2.Controls.Add(this.jadwalbodo4);
            this.groupBox2.Controls.Add(this.jadwalbodo3);
            this.groupBox2.Controls.Add(this.jadwalbodo2);
            this.groupBox2.Controls.Add(this.jadwalbodo1);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(454, 239);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 247);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pilihan Jadwal";
            // 
            // jadwalbodo4
            // 
            this.jadwalbodo4.AutoSize = true;
            this.jadwalbodo4.Location = new System.Drawing.Point(38, 188);
            this.jadwalbodo4.Name = "jadwalbodo4";
            this.jadwalbodo4.Size = new System.Drawing.Size(150, 20);
            this.jadwalbodo4.TabIndex = 3;
            this.jadwalbodo4.TabStop = true;
            this.jadwalbodo4.Text = "Minggu, 13.00 - 17.00";
            this.jadwalbodo4.UseVisualStyleBackColor = true;
            // 
            // jadwalbodo3
            // 
            this.jadwalbodo3.AutoSize = true;
            this.jadwalbodo3.Location = new System.Drawing.Point(38, 138);
            this.jadwalbodo3.Name = "jadwalbodo3";
            this.jadwalbodo3.Size = new System.Drawing.Size(211, 20);
            this.jadwalbodo3.TabIndex = 2;
            this.jadwalbodo3.TabStop = true;
            this.jadwalbodo3.Text = "Sabtu dan Minggu 09.00 - 11.00";
            this.jadwalbodo3.UseVisualStyleBackColor = true;
            // 
            // jadwalbodo2
            // 
            this.jadwalbodo2.AutoSize = true;
            this.jadwalbodo2.Location = new System.Drawing.Point(38, 86);
            this.jadwalbodo2.Name = "jadwalbodo2";
            this.jadwalbodo2.Size = new System.Drawing.Size(215, 20);
            this.jadwalbodo2.TabIndex = 1;
            this.jadwalbodo2.TabStop = true;
            this.jadwalbodo2.Text = "Selasa dan Kamis, 14.00 - 16.00";
            this.jadwalbodo2.UseVisualStyleBackColor = true;
            // 
            // jadwalbodo1
            // 
            this.jadwalbodo1.AutoSize = true;
            this.jadwalbodo1.Location = new System.Drawing.Point(38, 36);
            this.jadwalbodo1.Name = "jadwalbodo1";
            this.jadwalbodo1.Size = new System.Drawing.Size(202, 20);
            this.jadwalbodo1.TabIndex = 0;
            this.jadwalbodo1.TabStop = true;
            this.jadwalbodo1.Text = "Senin dan Rabu, 14.00 - 16.00";
            this.jadwalbodo1.UseVisualStyleBackColor = true;
            // 
            // tambodo
            // 
            this.tambodo.Location = new System.Drawing.Point(307, 566);
            this.tambodo.Name = "tambodo";
            this.tambodo.Size = new System.Drawing.Size(91, 23);
            this.tambodo.TabIndex = 7;
            this.tambodo.Text = "Tampilkan";
            this.tambodo.UseVisualStyleBackColor = true;
            this.tambodo.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(492, 566);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Selesai";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // design
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(855, 622);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tambodo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tanggalbodo);
            this.Controls.Add(this.kelaminbodo);
            this.Controls.Add(this.namabodo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jk);
            this.Controls.Add(this.Nama);
            this.Controls.Add(this.form);
            this.Name = "design";
            this.Text = "INFORMATIKA MUSIC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label form;
        private System.Windows.Forms.Label Nama;
        private System.Windows.Forms.Label jk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox namabodo;
        private System.Windows.Forms.ComboBox kelaminbodo;
        private System.Windows.Forms.DateTimePicker tanggalbodo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox biolabodo;
        private System.Windows.Forms.RadioButton jadwalbodo4;
        private System.Windows.Forms.RadioButton jadwalbodo3;
        private System.Windows.Forms.RadioButton jadwalbodo2;
        private System.Windows.Forms.RadioButton jadwalbodo1;
        private System.Windows.Forms.CheckBox kombodo;
        private System.Windows.Forms.CheckBox konbodo;
        private System.Windows.Forms.CheckBox vokalbodo;
        private System.Windows.Forms.CheckBox saxbodo;
        private System.Windows.Forms.CheckBox pianobodo;
        private System.Windows.Forms.CheckBox drumbodo;
        private System.Windows.Forms.CheckBox gitarbodo;
        private System.Windows.Forms.Button tambodo;
        private System.Windows.Forms.Button button2;
    }
}

