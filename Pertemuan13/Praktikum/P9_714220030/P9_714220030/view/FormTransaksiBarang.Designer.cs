namespace P9_714220030.view
{
    partial class FormTransaksiBarang
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
            this.tbMhs = new System.Windows.Forms.GroupBox();
            this.DataTransaksi = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.harga = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nama_barang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.id_barang = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.formMhs = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.TextBox();
            this.qty = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCariData = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.actionBtn = new System.Windows.Forms.GroupBox();
            this.tbMhs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTransaksi)).BeginInit();
            this.formMhs.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.actionBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbMhs
            // 
            this.tbMhs.Controls.Add(this.DataTransaksi);
            this.tbMhs.Location = new System.Drawing.Point(60, 8);
            this.tbMhs.Margin = new System.Windows.Forms.Padding(2);
            this.tbMhs.Name = "tbMhs";
            this.tbMhs.Padding = new System.Windows.Forms.Padding(2);
            this.tbMhs.Size = new System.Drawing.Size(794, 302);
            this.tbMhs.TabIndex = 12;
            this.tbMhs.TabStop = false;
            this.tbMhs.Text = "Table Transaksi Barang";
            // 
            // DataTransaksi
            // 
            this.DataTransaksi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTransaksi.Location = new System.Drawing.Point(-49, 17);
            this.DataTransaksi.Margin = new System.Windows.Forms.Padding(2);
            this.DataTransaksi.Name = "DataTransaksi";
            this.DataTransaksi.RowHeadersWidth = 51;
            this.DataTransaksi.RowTemplate.Height = 24;
            this.DataTransaksi.Size = new System.Drawing.Size(892, 280);
            this.DataTransaksi.TabIndex = 0;
            this.DataTransaksi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataTransaksi_CellClick);
            this.DataTransaksi.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataTransaksi_CellFormatting_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(195, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Rp";
            // 
            // harga
            // 
            this.harga.Location = new System.Drawing.Point(215, 60);
            this.harga.Margin = new System.Windows.Forms.Padding(2);
            this.harga.Name = "harga";
            this.harga.Size = new System.Drawing.Size(198, 20);
            this.harga.TabIndex = 9;
            this.harga.TextChanged += new System.EventHandler(this.harga_TextChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Harga Barang";
            // 
            // nama_barang
            // 
            this.nama_barang.Location = new System.Drawing.Point(4, 60);
            this.nama_barang.Margin = new System.Windows.Forms.Padding(2);
            this.nama_barang.Name = "nama_barang";
            this.nama_barang.Size = new System.Drawing.Size(187, 20);
            this.nama_barang.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nama Barang";
            // 
            // id_barang
            // 
            this.id_barang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.id_barang.FormattingEnabled = true;
            this.id_barang.Location = new System.Drawing.Point(4, 12);
            this.id_barang.Margin = new System.Windows.Forms.Padding(2);
            this.id_barang.Name = "id_barang";
            this.id_barang.Size = new System.Drawing.Size(187, 21);
            this.id_barang.TabIndex = 0;
            this.id_barang.SelectedIndexChanged += new System.EventHandler(this.id_barang_SelectedIndexChanged_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 146);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Rp";
            // 
            // formMhs
            // 
            this.formMhs.Controls.Add(this.label8);
            this.formMhs.Controls.Add(this.label6);
            this.formMhs.Controls.Add(this.total);
            this.formMhs.Controls.Add(this.qty);
            this.formMhs.Controls.Add(this.groupBox2);
            this.formMhs.Controls.Add(this.label4);
            this.formMhs.Controls.Add(this.label1);
            this.formMhs.Location = new System.Drawing.Point(60, 329);
            this.formMhs.Margin = new System.Windows.Forms.Padding(2);
            this.formMhs.Name = "formMhs";
            this.formMhs.Padding = new System.Windows.Forms.Padding(2);
            this.formMhs.Size = new System.Drawing.Size(500, 249);
            this.formMhs.TabIndex = 13;
            this.formMhs.TabStop = false;
            this.formMhs.Text = "Form Input Nilai";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 146);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Total";
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(80, 144);
            this.total.Margin = new System.Windows.Forms.Padding(2);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(187, 20);
            this.total.TabIndex = 12;
            this.total.TextChanged += new System.EventHandler(this.total_TextChanged_1);
            // 
            // qty
            // 
            this.qty.Location = new System.Drawing.Point(80, 115);
            this.qty.Margin = new System.Windows.Forms.Padding(2);
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(187, 20);
            this.qty.TabIndex = 12;
            this.qty.TextChanged += new System.EventHandler(this.qty_TextChanged_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.harga);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.nama_barang);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.id_barang);
            this.groupBox2.Location = new System.Drawing.Point(75, 17);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(420, 84);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Barang";
            // 
            // tbCariData
            // 
            this.tbCariData.Location = new System.Drawing.Point(56, 27);
            this.tbCariData.Margin = new System.Windows.Forms.Padding(2);
            this.tbCariData.Name = "tbCariData";
            this.tbCariData.Size = new System.Drawing.Size(214, 20);
            this.tbCariData.TabIndex = 1;
            this.tbCariData.TextChanged += new System.EventHandler(this.tbCariData_TextChanged_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbCariData);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(580, 329);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(274, 59);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Form Pencarian";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 29);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cari Data";
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(4, 145);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(2);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(265, 28);
            this.btnHapus.TabIndex = 3;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click_1);
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(4, 106);
            this.btnUbah.Margin = new System.Windows.Forms.Padding(2);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(265, 28);
            this.btnUbah.TabIndex = 2;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = true;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click_1);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(4, 67);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(2);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(265, 28);
            this.btnSimpan.TabIndex = 1;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click_1);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(4, 28);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(265, 28);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // actionBtn
            // 
            this.actionBtn.Controls.Add(this.btnHapus);
            this.actionBtn.Controls.Add(this.btnUbah);
            this.actionBtn.Controls.Add(this.btnSimpan);
            this.actionBtn.Controls.Add(this.btnRefresh);
            this.actionBtn.Location = new System.Drawing.Point(580, 393);
            this.actionBtn.Margin = new System.Windows.Forms.Padding(2);
            this.actionBtn.Name = "actionBtn";
            this.actionBtn.Padding = new System.Windows.Forms.Padding(2);
            this.actionBtn.Size = new System.Drawing.Size(274, 184);
            this.actionBtn.TabIndex = 14;
            this.actionBtn.TabStop = false;
            this.actionBtn.Text = "Tombol Action";
            // 
            // FormTransaksiBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 586);
            this.Controls.Add(this.tbMhs);
            this.Controls.Add(this.formMhs);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.actionBtn);
            this.Name = "FormTransaksiBarang";
            this.Text = "FormTransaksiBarang";
            this.Load += new System.EventHandler(this.FormTransaksiBarang_Load_1);
            this.tbMhs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataTransaksi)).EndInit();
            this.formMhs.ResumeLayout(false);
            this.formMhs.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.actionBtn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox tbMhs;
        private System.Windows.Forms.DataGridView DataTransaksi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox harga;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nama_barang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox id_barang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox formMhs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.TextBox qty;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCariData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox actionBtn;
    }
}