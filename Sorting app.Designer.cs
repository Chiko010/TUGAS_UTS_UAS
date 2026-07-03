namespace Tugas_Pemrograman
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAutoPlay = new System.Windows.Forms.Button();
            this.btnNextStep = new System.Windows.Forms.Button();
            this.btnPrevStep = new System.Windows.Forms.Button();
            this.lblKeterangan = new System.Windows.Forms.Label();
            this.lblLangkah = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblPertukaran = new System.Windows.Forms.Label();
            this.lblPerbandingan = new System.Windows.Forms.Label();
            this.dgvPerbandingan = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCounting = new System.Windows.Forms.Button();
            this.btnTabelPerbandingan = new System.Windows.Forms.Button();
            this.btnInsertion = new System.Windows.Forms.Button();
            this.btnSelection = new System.Windows.Forms.Button();
            this.btnBubble = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnBinary = new System.Windows.Forms.Button();
            this.btnSequential = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.trackBarKecepatan = new System.Windows.Forms.TrackBar();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerbandingan)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarKecepatan)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnAutoPlay);
            this.groupBox1.Controls.Add(this.btnNextStep);
            this.groupBox1.Controls.Add(this.btnPrevStep);
            this.groupBox1.Controls.Add(this.lblKeterangan);
            this.groupBox1.Controls.Add(this.lblLangkah);
            this.groupBox1.Controls.Add(this.dgvData);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visualisasi Data";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(254, 356);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(81, 35);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAutoPlay
            // 
            this.btnAutoPlay.Location = new System.Drawing.Point(167, 356);
            this.btnAutoPlay.Name = "btnAutoPlay";
            this.btnAutoPlay.Size = new System.Drawing.Size(81, 35);
            this.btnAutoPlay.TabIndex = 6;
            this.btnAutoPlay.Text = "Auto";
            this.btnAutoPlay.UseVisualStyleBackColor = true;
            this.btnAutoPlay.Click += new System.EventHandler(this.btnAutoPlay_Click);
            // 
            // btnNextStep
            // 
            this.btnNextStep.Location = new System.Drawing.Point(81, 356);
            this.btnNextStep.Name = "btnNextStep";
            this.btnNextStep.Size = new System.Drawing.Size(80, 35);
            this.btnNextStep.TabIndex = 5;
            this.btnNextStep.Text = "Next";
            this.btnNextStep.UseVisualStyleBackColor = true;
            this.btnNextStep.Click += new System.EventHandler(this.btnNextStep_Click);
            // 
            // btnPrevStep
            // 
            this.btnPrevStep.Location = new System.Drawing.Point(6, 356);
            this.btnPrevStep.Name = "btnPrevStep";
            this.btnPrevStep.Size = new System.Drawing.Size(69, 35);
            this.btnPrevStep.TabIndex = 3;
            this.btnPrevStep.Text = "Prev";
            this.btnPrevStep.UseVisualStyleBackColor = true;
            this.btnPrevStep.Click += new System.EventHandler(this.btnPrevStep_Click);
            // 
            // lblKeterangan
            // 
            this.lblKeterangan.AutoSize = true;
            this.lblKeterangan.Location = new System.Drawing.Point(26, 304);
            this.lblKeterangan.Name = "lblKeterangan";
            this.lblKeterangan.Size = new System.Drawing.Size(15, 16);
            this.lblKeterangan.TabIndex = 2;
            this.lblKeterangan.Text = "--";
            // 
            // lblLangkah
            // 
            this.lblLangkah.AutoSize = true;
            this.lblLangkah.Location = new System.Drawing.Point(19, 266);
            this.lblLangkah.Name = "lblLangkah";
            this.lblLangkah.Size = new System.Drawing.Size(90, 16);
            this.lblLangkah.TabIndex = 1;
            this.lblLangkah.Text = "Langkah ke: 0";
            this.lblLangkah.Click += new System.EventHandler(this.lblLangkah_Click);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvData.Location = new System.Drawing.Point(6, 21);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.RowHeadersWidth = 57;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(323, 227);
            this.dgvData.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "No";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nama";
            this.Column2.MinimumWidth = 10;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nilai";
            this.Column3.MinimumWidth = 10;
            this.Column3.Name = "Column3";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPertukaran);
            this.groupBox2.Controls.Add(this.lblPerbandingan);
            this.groupBox2.Controls.Add(this.dgvPerbandingan);
            this.groupBox2.Location = new System.Drawing.Point(347, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(456, 194);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hasil Perbandingan";
            // 
            // lblPertukaran
            // 
            this.lblPertukaran.AutoSize = true;
            this.lblPertukaran.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPertukaran.Location = new System.Drawing.Point(278, 153);
            this.lblPertukaran.Name = "lblPertukaran";
            this.lblPertukaran.Size = new System.Drawing.Size(120, 24);
            this.lblPertukaran.TabIndex = 2;
            this.lblPertukaran.Text = "Pertukaran: 0";
            // 
            // lblPerbandingan
            // 
            this.lblPerbandingan.AutoSize = true;
            this.lblPerbandingan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerbandingan.Location = new System.Drawing.Point(6, 153);
            this.lblPerbandingan.Name = "lblPerbandingan";
            this.lblPerbandingan.Size = new System.Drawing.Size(149, 24);
            this.lblPerbandingan.TabIndex = 1;
            this.lblPerbandingan.Text = "Perbandingan: 0";
            // 
            // dgvPerbandingan
            // 
            this.dgvPerbandingan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerbandingan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvPerbandingan.Location = new System.Drawing.Point(6, 21);
            this.dgvPerbandingan.Name = "dgvPerbandingan";
            this.dgvPerbandingan.RowHeadersVisible = false;
            this.dgvPerbandingan.RowHeadersWidth = 57;
            this.dgvPerbandingan.RowTemplate.Height = 24;
            this.dgvPerbandingan.Size = new System.Drawing.Size(444, 129);
            this.dgvPerbandingan.TabIndex = 0;
            this.dgvPerbandingan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPerbandingan_CellContentClick_1);
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Algoritma";
            this.Column4.MinimumWidth = 7;
            this.Column4.Name = "Column4";
            this.Column4.Width = 140;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Perbandingan";
            this.Column5.MinimumWidth = 7;
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Pertukaran";
            this.Column6.MinimumWidth = 7;
            this.Column6.Name = "Column6";
            this.Column6.Width = 145;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCounting);
            this.groupBox3.Controls.Add(this.btnTabelPerbandingan);
            this.groupBox3.Controls.Add(this.btnInsertion);
            this.groupBox3.Controls.Add(this.btnSelection);
            this.groupBox3.Controls.Add(this.btnBubble);
            this.groupBox3.Location = new System.Drawing.Point(347, 212);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(435, 130);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pilih Algoritma Sorting";
            // 
            // btnCounting
            // 
            this.btnCounting.Location = new System.Drawing.Point(236, 68);
            this.btnCounting.Name = "btnCounting";
            this.btnCounting.Size = new System.Drawing.Size(145, 39);
            this.btnCounting.TabIndex = 4;
            this.btnCounting.Text = "Counting";
            this.btnCounting.UseVisualStyleBackColor = true;
            this.btnCounting.Click += new System.EventHandler(this.btnCounting_Click);
            // 
            // btnTabelPerbandingan
            // 
            this.btnTabelPerbandingan.Location = new System.Drawing.Point(10, 68);
            this.btnTabelPerbandingan.Name = "btnTabelPerbandingan";
            this.btnTabelPerbandingan.Size = new System.Drawing.Size(194, 39);
            this.btnTabelPerbandingan.TabIndex = 3;
            this.btnTabelPerbandingan.Text = "Tampilkan Tabel";
            this.btnTabelPerbandingan.UseVisualStyleBackColor = true;
            this.btnTabelPerbandingan.Click += new System.EventHandler(this.btnTabelPerbandingan_Click);
            // 
            // btnInsertion
            // 
            this.btnInsertion.Location = new System.Drawing.Point(282, 21);
            this.btnInsertion.Name = "btnInsertion";
            this.btnInsertion.Size = new System.Drawing.Size(133, 41);
            this.btnInsertion.TabIndex = 2;
            this.btnInsertion.Text = "Insertion Sort";
            this.btnInsertion.UseVisualStyleBackColor = true;
            this.btnInsertion.Click += new System.EventHandler(this.btnInsertion_Click);
            // 
            // btnSelection
            // 
            this.btnSelection.Location = new System.Drawing.Point(139, 21);
            this.btnSelection.Name = "btnSelection";
            this.btnSelection.Size = new System.Drawing.Size(137, 41);
            this.btnSelection.TabIndex = 1;
            this.btnSelection.Text = "Selection Sort";
            this.btnSelection.UseVisualStyleBackColor = true;
            this.btnSelection.Click += new System.EventHandler(this.btnSelection_Click);
            // 
            // btnBubble
            // 
            this.btnBubble.Location = new System.Drawing.Point(6, 21);
            this.btnBubble.Name = "btnBubble";
            this.btnBubble.Size = new System.Drawing.Size(127, 41);
            this.btnBubble.TabIndex = 0;
            this.btnBubble.Text = "Bubble Sort";
            this.btnBubble.UseVisualStyleBackColor = true;
            this.btnBubble.Click += new System.EventHandler(this.btnBubble_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnBinary);
            this.groupBox4.Controls.Add(this.btnSequential);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtCari);
            this.groupBox4.Location = new System.Drawing.Point(353, 352);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(435, 106);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pilih Algoritma Searching";
            // 
            // btnBinary
            // 
            this.btnBinary.Location = new System.Drawing.Point(123, 63);
            this.btnBinary.Name = "btnBinary";
            this.btnBinary.Size = new System.Drawing.Size(115, 37);
            this.btnBinary.TabIndex = 3;
            this.btnBinary.Text = "Binary Search";
            this.btnBinary.UseVisualStyleBackColor = true;
            this.btnBinary.Click += new System.EventHandler(this.btnBinary_Click);
            // 
            // btnSequential
            // 
            this.btnSequential.Location = new System.Drawing.Point(6, 63);
            this.btnSequential.Name = "btnSequential";
            this.btnSequential.Size = new System.Drawing.Size(95, 37);
            this.btnSequential.TabIndex = 2;
            this.btnSequential.Text = "Sequential";
            this.btnSequential.UseVisualStyleBackColor = true;
            this.btnSequential.Click += new System.EventHandler(this.btnSequential_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Masukan Nilai:";
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(122, 35);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(100, 22);
            this.txtCari.TabIndex = 0;
            // 
            // trackBarKecepatan
            // 
            this.trackBarKecepatan.Location = new System.Drawing.Point(353, 464);
            this.trackBarKecepatan.Name = "trackBarKecepatan";
            this.trackBarKecepatan.Size = new System.Drawing.Size(302, 64);
            this.trackBarKecepatan.TabIndex = 4;
            this.trackBarKecepatan.Scroll += new System.EventHandler(this.trackBarKecepatan_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 565);
            this.Controls.Add(this.trackBarKecepatan);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerbandingan)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarKecepatan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvPerbandingan;
        private System.Windows.Forms.Label lblPerbandingan;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblPertukaran;
        private System.Windows.Forms.Button btnCounting;
        private System.Windows.Forms.Button btnTabelPerbandingan;
        private System.Windows.Forms.Button btnInsertion;
        private System.Windows.Forms.Button btnSelection;
        private System.Windows.Forms.Button btnBubble;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Button btnBinary;
        private System.Windows.Forms.Button btnSequential;
        private System.Windows.Forms.Button btnAutoPlay;
        private System.Windows.Forms.Button btnNextStep;
        private System.Windows.Forms.Button btnPrevStep;
        private System.Windows.Forms.Label lblKeterangan;
        private System.Windows.Forms.Label lblLangkah;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TrackBar trackBarKecepatan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}

