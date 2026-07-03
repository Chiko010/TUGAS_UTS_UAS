namespace Implementasi___Visualisasi_Maximum_Subarray_Problem
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDataTitle = new System.Windows.Forms.Label();
            this.pnlDataGrid = new System.Windows.Forms.Panel();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.pnlLegend = new System.Windows.Forms.Panel();
            this.lblLegendTitle = new System.Windows.Forms.Label();
            this.lblLegKuning = new System.Windows.Forms.Label();
            this.lblLegMerah = new System.Windows.Forms.Label();
            this.lblLegHijau = new System.Windows.Forms.Label();
            this.lblLegNote = new System.Windows.Forms.Label();
            this.grpBF = new System.Windows.Forms.GroupBox();
            this.lblBFTitle = new System.Windows.Forms.Label();
            this.dgvBF = new System.Windows.Forms.DataGridView();
            this.pnlBFLog = new System.Windows.Forms.Panel();
            this.txtBFLog = new System.Windows.Forms.RichTextBox();
            this.lblBFProfit = new System.Windows.Forms.Label();
            this.lblBFStep = new System.Windows.Forms.Label();
            this.btnBFPrev = new System.Windows.Forms.Button();
            this.btnBFNext = new System.Windows.Forms.Button();
            this.btnBFAuto = new System.Windows.Forms.Button();
            this.btnBFReset = new System.Windows.Forms.Button();
            this.timerBF = new System.Windows.Forms.Timer(this.components);
            this.grpDC = new System.Windows.Forms.GroupBox();
            this.lblDCTitle = new System.Windows.Forms.Label();
            this.dgvDC = new System.Windows.Forms.DataGridView();
            this.pnlDCLog = new System.Windows.Forms.Panel();
            this.txtDCLog = new System.Windows.Forms.RichTextBox();
            this.lblDCProfit = new System.Windows.Forms.Label();
            this.lblDCStep = new System.Windows.Forms.Label();
            this.btnDCPrev = new System.Windows.Forms.Button();
            this.btnDCNext = new System.Windows.Forms.Button();
            this.btnDCAuto = new System.Windows.Forms.Button();
            this.btnDCReset = new System.Windows.Forms.Button();
            this.timerDC = new System.Windows.Forms.Timer(this.components);
            this.lblBenchTitle = new System.Windows.Forms.Label();
            this.txtBenchLog = new System.Windows.Forms.RichTextBox();
            this.btnBenchmark = new System.Windows.Forms.Button();
            this.lblBenchBF = new System.Windows.Forms.Label();
            this.lblBenchDC = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.pnlLegend.SuspendLayout();
            this.grpBF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBF)).BeginInit();
            this.pnlBFLog.SuspendLayout();
            this.grpDC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDC)).BeginInit();
            this.pnlDCLog.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.lblTitle.Location = new System.Drawing.Point(14, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(765, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "VISUALISASI MAXIMUM SUBARRAY PROBLEM";
            // 
            // lblDataTitle
            // 
            this.lblDataTitle.AutoSize = true;
            this.lblDataTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDataTitle.Location = new System.Drawing.Point(14, 62);
            this.lblDataTitle.Name = "lblDataTitle";
            this.lblDataTitle.Size = new System.Drawing.Size(267, 25);
            this.lblDataTitle.TabIndex = 1;
            this.lblDataTitle.Text = "Data Fluktuasi Saham Harian";
            // 
            // pnlDataGrid
            // 
            this.pnlDataGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(215)))), ((int)(((byte)(250)))));
            this.pnlDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDataGrid.Controls.Add(this.dgvMain);
            this.pnlDataGrid.Location = new System.Drawing.Point(14, 84);
            this.pnlDataGrid.Name = "pnlDataGrid";
            this.pnlDataGrid.Padding = new System.Windows.Forms.Padding(2);
            this.pnlDataGrid.Size = new System.Drawing.Size(1380, 76);
            this.pnlDataGrid.TabIndex = 2;
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.AllowUserToResizeRows = false;
            this.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMain.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMain.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(200)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMain.ColumnHeadersHeight = 28;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMain.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.GridColor = System.Drawing.Color.LightSteelBlue;
            this.dgvMain.Location = new System.Drawing.Point(2, 2);
            this.dgvMain.MultiSelect = false;
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMain.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMain.RowHeadersWidth = 70;
            this.dgvMain.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvMain.Size = new System.Drawing.Size(1374, 70);
            this.dgvMain.TabIndex = 0;
            // 
            // pnlLegend
            // 
            this.pnlLegend.BackColor = System.Drawing.Color.White;
            this.pnlLegend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLegend.Controls.Add(this.lblLegendTitle);
            this.pnlLegend.Controls.Add(this.lblLegKuning);
            this.pnlLegend.Controls.Add(this.lblLegMerah);
            this.pnlLegend.Location = new System.Drawing.Point(14, 170);
            this.pnlLegend.Name = "pnlLegend";
            this.pnlLegend.Size = new System.Drawing.Size(392, 75);
            this.pnlLegend.TabIndex = 3;
            // 
            // lblLegendTitle
            // 
            this.lblLegendTitle.AutoSize = true;
            this.lblLegendTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblLegendTitle.Location = new System.Drawing.Point(8, 8);
            this.lblLegendTitle.Name = "lblLegendTitle";
            this.lblLegendTitle.Size = new System.Drawing.Size(171, 25);
            this.lblLegendTitle.TabIndex = 0;
            this.lblLegendTitle.Text = "Keterangan Warna";
            // 
            // lblLegKuning
            // 
            this.lblLegKuning.AutoSize = true;
            this.lblLegKuning.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLegKuning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
            this.lblLegKuning.Location = new System.Drawing.Point(8, 30);
            this.lblLegKuning.Name = "lblLegKuning";
            this.lblLegKuning.Size = new System.Drawing.Size(350, 23);
            this.lblLegKuning.TabIndex = 1;
            this.lblLegKuning.Text = "■  Kuning = Rentang yang sedang dianalisis";
            // 
            // lblLegMerah
            // 
            this.lblLegMerah.AutoSize = true;
            this.lblLegMerah.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLegMerah.ForeColor = System.Drawing.Color.Crimson;
            this.lblLegMerah.Location = new System.Drawing.Point(8, 50);
            this.lblLegMerah.Name = "lblLegMerah";
            this.lblLegMerah.Size = new System.Drawing.Size(370, 23);
            this.lblLegMerah.TabIndex = 2;
            this.lblLegMerah.Text = "■  Merah = Titik potong (mid) Divide & Conquer";
            // 
            // lblLegHijau
            // 
            this.lblLegHijau.AutoSize = true;
            this.lblLegHijau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLegHijau.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblLegHijau.Location = new System.Drawing.Point(14, 7);
            this.lblLegHijau.Name = "lblLegHijau";
            this.lblLegHijau.Size = new System.Drawing.Size(348, 23);
            this.lblLegHijau.TabIndex = 3;
            this.lblLegHijau.Text = "■  Hijau = Subarray dengan profit maksimal";
            // 
            // lblLegNote
            // 
            this.lblLegNote.AutoSize = true;
            this.lblLegNote.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLegNote.ForeColor = System.Drawing.Color.DimGray;
            this.lblLegNote.Location = new System.Drawing.Point(14, 39);
            this.lblLegNote.Name = "lblLegNote";
            this.lblLegNote.Size = new System.Drawing.Size(369, 23);
            this.lblLegNote.TabIndex = 4;
            this.lblLegNote.Text = "Gunakan tombol Next/Prev untuk step-by-step";
            // 
            // grpBF
            // 
            this.grpBF.BackColor = System.Drawing.Color.White;
            this.grpBF.Controls.Add(this.lblBFTitle);
            this.grpBF.Controls.Add(this.dgvBF);
            this.grpBF.Controls.Add(this.pnlBFLog);
            this.grpBF.Controls.Add(this.lblBFProfit);
            this.grpBF.Controls.Add(this.lblBFStep);
            this.grpBF.Controls.Add(this.btnBFPrev);
            this.grpBF.Controls.Add(this.btnBFNext);
            this.grpBF.Controls.Add(this.btnBFAuto);
            this.grpBF.Controls.Add(this.btnBFReset);
            this.grpBF.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpBF.Location = new System.Drawing.Point(14, 255);
            this.grpBF.Name = "grpBF";
            this.grpBF.Size = new System.Drawing.Size(690, 305);
            this.grpBF.TabIndex = 4;
            this.grpBF.TabStop = false;
            // 
            // lblBFTitle
            // 
            this.lblBFTitle.AutoSize = true;
            this.lblBFTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblBFTitle.Location = new System.Drawing.Point(10, 12);
            this.lblBFTitle.Name = "lblBFTitle";
            this.lblBFTitle.Size = new System.Drawing.Size(373, 30);
            this.lblBFTitle.TabIndex = 0;
            this.lblBFTitle.Text = "ALGORITMA BRUTE FORCE (O(n^2))";
            // 
            // dgvBF
            // 
            this.dgvBF.AllowUserToAddRows = false;
            this.dgvBF.AllowUserToDeleteRows = false;
            this.dgvBF.AllowUserToResizeRows = false;
            this.dgvBF.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBF.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.dgvBF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBF.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBF.ColumnHeadersHeight = 26;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBF.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBF.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dgvBF.Location = new System.Drawing.Point(10, 40);
            this.dgvBF.MultiSelect = false;
            this.dgvBF.Name = "dgvBF";
            this.dgvBF.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBF.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvBF.RowHeadersWidth = 60;
            this.dgvBF.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvBF.Size = new System.Drawing.Size(668, 65);
            this.dgvBF.TabIndex = 0;
            this.dgvBF.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvBF_CellPainting);
            // 
            // pnlBFLog
            // 
            this.pnlBFLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(195)))));
            this.pnlBFLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBFLog.Controls.Add(this.txtBFLog);
            this.pnlBFLog.Location = new System.Drawing.Point(10, 115);
            this.pnlBFLog.Name = "pnlBFLog";
            this.pnlBFLog.Size = new System.Drawing.Size(668, 92);
            this.pnlBFLog.TabIndex = 1;
            // 
            // txtBFLog
            // 
            this.txtBFLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtBFLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBFLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBFLog.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBFLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtBFLog.Location = new System.Drawing.Point(0, 0);
            this.txtBFLog.Name = "txtBFLog";
            this.txtBFLog.ReadOnly = true;
            this.txtBFLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtBFLog.Size = new System.Drawing.Size(666, 90);
            this.txtBFLog.TabIndex = 0;
            this.txtBFLog.Text = "";
            // 
            // lblBFProfit
            // 
            this.lblBFProfit.AutoSize = true;
            this.lblBFProfit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBFProfit.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblBFProfit.Location = new System.Drawing.Point(10, 217);
            this.lblBFProfit.Name = "lblBFProfit";
            this.lblBFProfit.Size = new System.Drawing.Size(170, 25);
            this.lblBFProfit.TabIndex = 2;
            this.lblBFProfit.Text = "Profit Maksimal: -";
            // 
            // lblBFStep
            // 
            this.lblBFStep.AutoSize = true;
            this.lblBFStep.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblBFStep.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblBFStep.Location = new System.Drawing.Point(390, 219);
            this.lblBFStep.Name = "lblBFStep";
            this.lblBFStep.Size = new System.Drawing.Size(93, 25);
            this.lblBFStep.TabIndex = 3;
            this.lblBFStep.Text = "Step: 0 / 0";
            // 
            // btnBFPrev
            // 
            this.btnBFPrev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.btnBFPrev.FlatAppearance.BorderSize = 0;
            this.btnBFPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBFPrev.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBFPrev.ForeColor = System.Drawing.Color.Black;
            this.btnBFPrev.Location = new System.Drawing.Point(10, 248);
            this.btnBFPrev.Name = "btnBFPrev";
            this.btnBFPrev.Size = new System.Drawing.Size(143, 44);
            this.btnBFPrev.TabIndex = 2;
            this.btnBFPrev.Text = "Prev";
            this.btnBFPrev.UseVisualStyleBackColor = false;
            this.btnBFPrev.Click += new System.EventHandler(this.btnBFPrev_Click);
            // 
            // btnBFNext
            // 
            this.btnBFNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(205)))), ((int)(((byte)(125)))));
            this.btnBFNext.FlatAppearance.BorderSize = 0;
            this.btnBFNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBFNext.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBFNext.ForeColor = System.Drawing.Color.Black;
            this.btnBFNext.Location = new System.Drawing.Point(163, 248);
            this.btnBFNext.Name = "btnBFNext";
            this.btnBFNext.Size = new System.Drawing.Size(143, 44);
            this.btnBFNext.TabIndex = 3;
            this.btnBFNext.Text = "Next";
            this.btnBFNext.UseVisualStyleBackColor = false;
            this.btnBFNext.Click += new System.EventHandler(this.btnBFNext_Click);
            // 
            // btnBFAuto
            // 
            this.btnBFAuto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(190)))), ((int)(((byte)(90)))));
            this.btnBFAuto.FlatAppearance.BorderSize = 0;
            this.btnBFAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBFAuto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBFAuto.ForeColor = System.Drawing.Color.Black;
            this.btnBFAuto.Location = new System.Drawing.Point(316, 248);
            this.btnBFAuto.Name = "btnBFAuto";
            this.btnBFAuto.Size = new System.Drawing.Size(143, 44);
            this.btnBFAuto.TabIndex = 4;
            this.btnBFAuto.Text = "Auto Play";
            this.btnBFAuto.UseVisualStyleBackColor = false;
            this.btnBFAuto.Click += new System.EventHandler(this.btnBFAuto_Click);
            // 
            // btnBFReset
            // 
            this.btnBFReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.btnBFReset.FlatAppearance.BorderSize = 0;
            this.btnBFReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBFReset.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBFReset.ForeColor = System.Drawing.Color.Black;
            this.btnBFReset.Location = new System.Drawing.Point(469, 248);
            this.btnBFReset.Name = "btnBFReset";
            this.btnBFReset.Size = new System.Drawing.Size(143, 44);
            this.btnBFReset.TabIndex = 5;
            this.btnBFReset.Text = "Reset";
            this.btnBFReset.UseVisualStyleBackColor = false;
            this.btnBFReset.Click += new System.EventHandler(this.btnBFReset_Click);
            // 
            // timerBF
            // 
            this.timerBF.Interval = 600;
            this.timerBF.Tick += new System.EventHandler(this.timerBF_Tick);
            // 
            // grpDC
            // 
            this.grpDC.BackColor = System.Drawing.Color.White;
            this.grpDC.Controls.Add(this.lblDCTitle);
            this.grpDC.Controls.Add(this.dgvDC);
            this.grpDC.Controls.Add(this.pnlDCLog);
            this.grpDC.Controls.Add(this.lblDCProfit);
            this.grpDC.Controls.Add(this.lblDCStep);
            this.grpDC.Controls.Add(this.btnDCPrev);
            this.grpDC.Controls.Add(this.btnDCNext);
            this.grpDC.Controls.Add(this.btnDCAuto);
            this.grpDC.Controls.Add(this.btnDCReset);
            this.grpDC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpDC.Location = new System.Drawing.Point(715, 255);
            this.grpDC.Name = "grpDC";
            this.grpDC.Size = new System.Drawing.Size(690, 305);
            this.grpDC.TabIndex = 5;
            this.grpDC.TabStop = false;
            // 
            // lblDCTitle
            // 
            this.lblDCTitle.AutoSize = true;
            this.lblDCTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblDCTitle.Location = new System.Drawing.Point(10, 12);
            this.lblDCTitle.Name = "lblDCTitle";
            this.lblDCTitle.Size = new System.Drawing.Size(450, 30);
            this.lblDCTitle.TabIndex = 0;
            this.lblDCTitle.Text = "ALGORITMA DIVIDE & CONQUER (O(n log n))";
            // 
            // dgvDC
            // 
            this.dgvDC.AllowUserToAddRows = false;
            this.dgvDC.AllowUserToDeleteRows = false;
            this.dgvDC.AllowUserToResizeRows = false;
            this.dgvDC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDC.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.dgvDC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(105)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDC.ColumnHeadersHeight = 26;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDC.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDC.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvDC.Location = new System.Drawing.Point(10, 40);
            this.dgvDC.MultiSelect = false;
            this.dgvDC.Name = "dgvDC";
            this.dgvDC.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(85)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDC.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDC.RowHeadersWidth = 60;
            this.dgvDC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvDC.Size = new System.Drawing.Size(668, 65);
            this.dgvDC.TabIndex = 0;
            this.dgvDC.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvDC_CellPainting);
            // 
            // pnlDCLog
            // 
            this.pnlDCLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(212)))), ((int)(((byte)(245)))));
            this.pnlDCLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDCLog.Controls.Add(this.txtDCLog);
            this.pnlDCLog.Location = new System.Drawing.Point(10, 115);
            this.pnlDCLog.Name = "pnlDCLog";
            this.pnlDCLog.Size = new System.Drawing.Size(668, 92);
            this.pnlDCLog.TabIndex = 1;
            // 
            // txtDCLog
            // 
            this.txtDCLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDCLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDCLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDCLog.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDCLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtDCLog.Location = new System.Drawing.Point(0, 0);
            this.txtDCLog.Name = "txtDCLog";
            this.txtDCLog.ReadOnly = true;
            this.txtDCLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtDCLog.Size = new System.Drawing.Size(666, 90);
            this.txtDCLog.TabIndex = 0;
            this.txtDCLog.Text = "";
            // 
            // lblDCProfit
            // 
            this.lblDCProfit.AutoSize = true;
            this.lblDCProfit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDCProfit.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblDCProfit.Location = new System.Drawing.Point(10, 217);
            this.lblDCProfit.Name = "lblDCProfit";
            this.lblDCProfit.Size = new System.Drawing.Size(170, 25);
            this.lblDCProfit.TabIndex = 2;
            this.lblDCProfit.Text = "Profit Maksimal: -";
            // 
            // lblDCStep
            // 
            this.lblDCStep.AutoSize = true;
            this.lblDCStep.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDCStep.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblDCStep.Location = new System.Drawing.Point(390, 219);
            this.lblDCStep.Name = "lblDCStep";
            this.lblDCStep.Size = new System.Drawing.Size(93, 25);
            this.lblDCStep.TabIndex = 3;
            this.lblDCStep.Text = "Step: 0 / 0";
            // 
            // btnDCPrev
            // 
            this.btnDCPrev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.btnDCPrev.FlatAppearance.BorderSize = 0;
            this.btnDCPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDCPrev.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDCPrev.ForeColor = System.Drawing.Color.Black;
            this.btnDCPrev.Location = new System.Drawing.Point(10, 248);
            this.btnDCPrev.Name = "btnDCPrev";
            this.btnDCPrev.Size = new System.Drawing.Size(143, 44);
            this.btnDCPrev.TabIndex = 2;
            this.btnDCPrev.Text = "Prev";
            this.btnDCPrev.UseVisualStyleBackColor = false;
            this.btnDCPrev.Click += new System.EventHandler(this.btnDCPrev_Click);
            // 
            // btnDCNext
            // 
            this.btnDCNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(205)))), ((int)(((byte)(125)))));
            this.btnDCNext.FlatAppearance.BorderSize = 0;
            this.btnDCNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDCNext.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDCNext.ForeColor = System.Drawing.Color.Black;
            this.btnDCNext.Location = new System.Drawing.Point(163, 248);
            this.btnDCNext.Name = "btnDCNext";
            this.btnDCNext.Size = new System.Drawing.Size(143, 44);
            this.btnDCNext.TabIndex = 3;
            this.btnDCNext.Text = "Next";
            this.btnDCNext.UseVisualStyleBackColor = false;
            this.btnDCNext.Click += new System.EventHandler(this.btnDCNext_Click);
            // 
            // btnDCAuto
            // 
            this.btnDCAuto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(190)))), ((int)(((byte)(90)))));
            this.btnDCAuto.FlatAppearance.BorderSize = 0;
            this.btnDCAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDCAuto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDCAuto.ForeColor = System.Drawing.Color.Black;
            this.btnDCAuto.Location = new System.Drawing.Point(316, 248);
            this.btnDCAuto.Name = "btnDCAuto";
            this.btnDCAuto.Size = new System.Drawing.Size(143, 44);
            this.btnDCAuto.TabIndex = 4;
            this.btnDCAuto.Text = "Auto Play";
            this.btnDCAuto.UseVisualStyleBackColor = false;
            this.btnDCAuto.Click += new System.EventHandler(this.btnDCAuto_Click);
            // 
            // btnDCReset
            // 
            this.btnDCReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.btnDCReset.FlatAppearance.BorderSize = 0;
            this.btnDCReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDCReset.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDCReset.ForeColor = System.Drawing.Color.Black;
            this.btnDCReset.Location = new System.Drawing.Point(469, 248);
            this.btnDCReset.Name = "btnDCReset";
            this.btnDCReset.Size = new System.Drawing.Size(143, 44);
            this.btnDCReset.TabIndex = 5;
            this.btnDCReset.Text = "Reset";
            this.btnDCReset.UseVisualStyleBackColor = false;
            this.btnDCReset.Click += new System.EventHandler(this.btnDCReset_Click);
            // 
            // timerDC
            // 
            this.timerDC.Interval = 600;
            this.timerDC.Tick += new System.EventHandler(this.timerDC_Tick);
            // 
            // lblBenchTitle
            // 
            this.lblBenchTitle.AutoSize = true;
            this.lblBenchTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblBenchTitle.Location = new System.Drawing.Point(17, 563);
            this.lblBenchTitle.Name = "lblBenchTitle";
            this.lblBenchTitle.Size = new System.Drawing.Size(389, 30);
            this.lblBenchTitle.TabIndex = 6;
            this.lblBenchTitle.Text = "FITUR BENCHMARKING (10.000 Data)";
            // 
            // txtBenchLog
            // 
            this.txtBenchLog.BackColor = System.Drawing.Color.Black;
            this.txtBenchLog.Font = new System.Drawing.Font("Consolas", 9.5F);
            this.txtBenchLog.ForeColor = System.Drawing.Color.Cyan;
            this.txtBenchLog.Location = new System.Drawing.Point(12, 600);
            this.txtBenchLog.Name = "txtBenchLog";
            this.txtBenchLog.ReadOnly = true;
            this.txtBenchLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtBenchLog.Size = new System.Drawing.Size(1060, 140);
            this.txtBenchLog.TabIndex = 7;
            this.txtBenchLog.Text = "";
            // 
            // btnBenchmark
            // 
            this.btnBenchmark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(155)))), ((int)(((byte)(0)))));
            this.btnBenchmark.FlatAppearance.BorderSize = 0;
            this.btnBenchmark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBenchmark.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBenchmark.ForeColor = System.Drawing.Color.White;
            this.btnBenchmark.Location = new System.Drawing.Point(1079, 600);
            this.btnBenchmark.Name = "btnBenchmark";
            this.btnBenchmark.Size = new System.Drawing.Size(315, 55);
            this.btnBenchmark.TabIndex = 8;
            this.btnBenchmark.Text = "Jalankan Benchmark";
            this.btnBenchmark.UseVisualStyleBackColor = false;
            this.btnBenchmark.Click += new System.EventHandler(this.btnBenchmark_Click);
            // 
            // lblBenchBF
            // 
            this.lblBenchBF.AutoSize = true;
            this.lblBenchBF.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBenchBF.ForeColor = System.Drawing.Color.Crimson;
            this.lblBenchBF.Location = new System.Drawing.Point(1078, 667);
            this.lblBenchBF.Name = "lblBenchBF";
            this.lblBenchBF.Size = new System.Drawing.Size(188, 25);
            this.lblBenchBF.TabIndex = 9;
            this.lblBenchBF.Text = "Brute Force     : - ms";
            // 
            // lblBenchDC
            // 
            this.lblBenchDC.AutoSize = true;
            this.lblBenchDC.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBenchDC.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblBenchDC.Location = new System.Drawing.Point(1078, 692);
            this.lblBenchDC.Name = "lblBenchDC";
            this.lblBenchDC.Size = new System.Drawing.Size(205, 25);
            this.lblBenchDC.TabIndex = 10;
            this.lblBenchDC.Text = "Divide & Conquer: - ms";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblLegHijau);
            this.panel1.Controls.Add(this.lblLegNote);
            this.panel1.Location = new System.Drawing.Point(412, 169);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 75);
            this.panel1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1423, 805);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblDataTitle);
            this.Controls.Add(this.pnlDataGrid);
            this.Controls.Add(this.pnlLegend);
            this.Controls.Add(this.grpBF);
            this.Controls.Add(this.grpDC);
            this.Controls.Add(this.lblBenchTitle);
            this.Controls.Add(this.txtBenchLog);
            this.Controls.Add(this.btnBenchmark);
            this.Controls.Add(this.lblBenchBF);
            this.Controls.Add(this.lblBenchDC);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maximum Subarray Problem - Brute Force vs Divide & Conquer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.pnlLegend.ResumeLayout(false);
            this.pnlLegend.PerformLayout();
            this.grpBF.ResumeLayout(false);
            this.grpBF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBF)).EndInit();
            this.pnlBFLog.ResumeLayout(false);
            this.grpDC.ResumeLayout(false);
            this.grpDC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDC)).EndInit();
            this.pnlDCLog.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDataTitle;
        private System.Windows.Forms.Panel pnlDataGrid;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Panel pnlLegend;
        private System.Windows.Forms.Label lblLegendTitle;
        private System.Windows.Forms.Label lblLegKuning;
        private System.Windows.Forms.Label lblLegMerah;
        private System.Windows.Forms.Label lblLegHijau;
        private System.Windows.Forms.Label lblLegNote;
        private System.Windows.Forms.GroupBox grpBF;
        private System.Windows.Forms.Label lblBFTitle;
        private System.Windows.Forms.DataGridView dgvBF;
        private System.Windows.Forms.Panel pnlBFLog;
        private System.Windows.Forms.RichTextBox txtBFLog;
        private System.Windows.Forms.Label lblBFProfit;
        private System.Windows.Forms.Label lblBFStep;
        private System.Windows.Forms.Button btnBFPrev;
        private System.Windows.Forms.Button btnBFNext;
        private System.Windows.Forms.Button btnBFAuto;
        private System.Windows.Forms.Button btnBFReset;
        private System.Windows.Forms.Timer timerBF;
        private System.Windows.Forms.GroupBox grpDC;
        private System.Windows.Forms.Label lblDCTitle;
        private System.Windows.Forms.DataGridView dgvDC;
        private System.Windows.Forms.Panel pnlDCLog;
        private System.Windows.Forms.RichTextBox txtDCLog;
        private System.Windows.Forms.Label lblDCProfit;
        private System.Windows.Forms.Label lblDCStep;
        private System.Windows.Forms.Button btnDCPrev;
        private System.Windows.Forms.Button btnDCNext;
        private System.Windows.Forms.Button btnDCAuto;
        private System.Windows.Forms.Button btnDCReset;
        private System.Windows.Forms.Timer timerDC;
        private System.Windows.Forms.Label lblBenchTitle;
        private System.Windows.Forms.RichTextBox txtBenchLog;
        private System.Windows.Forms.Button btnBenchmark;
        private System.Windows.Forms.Label lblBenchBF;
        private System.Windows.Forms.Label lblBenchDC;
        private System.Windows.Forms.Panel panel1;
    }
}