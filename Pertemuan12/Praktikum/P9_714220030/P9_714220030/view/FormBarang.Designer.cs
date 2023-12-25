namespace P9_714220030.view
{
    partial class FormBarang
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
            this.DataBarang = new System.Windows.Forms.DataGridView();
            this.actionBtn = new System.Windows.Forms.GroupBox();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbCariData = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.formMhs = new System.Windows.Forms.GroupBox();
            this.harga = new System.Windows.Forms.TextBox();
            this.nama_barang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMhs = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataBarang)).BeginInit();
            this.actionBtn.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.formMhs.SuspendLayout();
            this.tbMhs.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataBarang
            // 
            this.DataBarang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataBarang.Location = new System.Drawing.Point(4, 17);
            this.DataBarang.Margin = new System.Windows.Forms.Padding(2);
            this.DataBarang.Name = "DataBarang";
            this.DataBarang.RowHeadersWidth = 51;
            this.DataBarang.RowTemplate.Height = 24;
            this.DataBarang.Size = new System.Drawing.Size(784, 280);
            this.DataBarang.TabIndex = 0;
            this.DataBarang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataBarang_CellClick);
            this.DataBarang.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataBarang_CellFormatting);
            // 
            // actionBtn
            // 
            this.actionBtn.Controls.Add(this.btnHapus);
            this.actionBtn.Controls.Add(this.btnUbah);
            this.actionBtn.Controls.Add(this.btnSimpan);
            this.actionBtn.Controls.Add(this.btnRefresh);
            this.actionBtn.Location = new System.Drawing.Point(565, 376);
            this.actionBtn.Margin = new System.Windows.Forms.Padding(2);
            this.actionBtn.Name = "actionBtn";
            this.actionBtn.Padding = new System.Windows.Forms.Padding(2);
            this.actionBtn.Size = new System.Drawing.Size(274, 180);
            this.actionBtn.TabIndex = 14;
            this.actionBtn.TabStop = false;
            this.actionBtn.Text = "Tombol Action";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbCariData);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(45, 497);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(500, 58);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Form Pencarian";
            // 
            // tbCariData
            // 
            this.tbCariData.Location = new System.Drawing.Point(104, 25);
            this.tbCariData.Margin = new System.Windows.Forms.Padding(2);
            this.tbCariData.Name = "tbCariData";
            this.tbCariData.Size = new System.Drawing.Size(325, 20);
            this.tbCariData.TabIndex = 1;
            this.tbCariData.TextChanged += new System.EventHandler(this.tbCariData_TextChanged_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 28);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cari Data";
            // 
            // formMhs
            // 
            this.formMhs.Controls.Add(this.harga);
            this.formMhs.Controls.Add(this.nama_barang);
            this.formMhs.Controls.Add(this.label2);
            this.formMhs.Controls.Add(this.label1);
            this.formMhs.Location = new System.Drawing.Point(45, 376);
            this.formMhs.Margin = new System.Windows.Forms.Padding(2);
            this.formMhs.Name = "formMhs";
            this.formMhs.Padding = new System.Windows.Forms.Padding(2);
            this.formMhs.Size = new System.Drawing.Size(500, 107);
            this.formMhs.TabIndex = 13;
            this.formMhs.TabStop = false;
            this.formMhs.Text = "Form Input Barang";
            // 
            // harga
            // 
            this.harga.Location = new System.Drawing.Point(104, 67);
            this.harga.Margin = new System.Windows.Forms.Padding(2);
            this.harga.Name = "harga";
            this.harga.Size = new System.Drawing.Size(325, 20);
            this.harga.TabIndex = 4;
            // 
            // nama_barang
            // 
            this.nama_barang.Location = new System.Drawing.Point(104, 37);
            this.nama_barang.Margin = new System.Windows.Forms.Padding(2);
            this.nama_barang.Name = "nama_barang";
            this.nama_barang.Size = new System.Drawing.Size(325, 20);
            this.nama_barang.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Harga";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Barang";
            // 
            // tbMhs
            // 
            this.tbMhs.Controls.Add(this.DataBarang);
            this.tbMhs.Location = new System.Drawing.Point(45, 55);
            this.tbMhs.Margin = new System.Windows.Forms.Padding(2);
            this.tbMhs.Name = "tbMhs";
            this.tbMhs.Padding = new System.Windows.Forms.Padding(2);
            this.tbMhs.Size = new System.Drawing.Size(794, 302);
            this.tbMhs.TabIndex = 12;
            this.tbMhs.TabStop = false;
            this.tbMhs.Text = "Table Data Barang";
            // 
            // FormBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.actionBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.formMhs);
            this.Controls.Add(this.tbMhs);
            this.Name = "FormBarang";
            this.Text = "FormBarang";
            this.Load += new System.EventHandler(this.FormBarang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataBarang)).EndInit();
            this.actionBtn.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.formMhs.ResumeLayout(false);
            this.formMhs.PerformLayout();
            this.tbMhs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataBarang;
        private System.Windows.Forms.GroupBox actionBtn;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbCariData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox formMhs;
        private System.Windows.Forms.TextBox harga;
        private System.Windows.Forms.TextBox nama_barang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox tbMhs;
    }
}