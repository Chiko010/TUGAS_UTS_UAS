using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Implementasi___Visualisasi_Maximum_Subarray_Problem
{
    public partial class Form1 : Form
    {
        // ─── Data Hardcode ────────────────────────────────────────────────────
        private readonly string[] hari = {
            "Hari 1",  "Hari 2",  "Hari 3",  "Hari 4",  "Hari 5",
            "Hari 6",  "Hari 7",  "Hari 8",  "Hari 9",  "Hari 10",
            "Hari 11", "Hari 12", "Hari 13", "Hari 14", "Hari 15"
        };

        private readonly int[] dataSahamAwal = {
            12, -15, 20, -5, 30,
            -10, 45, -60, 25, 10,
            -15, 35, -20, 15, -5
        };

        // Data kerja
        private string[] namaHari;
        private int[] fluktuasiSaham;

        // ─── Step state ───────────────────────────────────────────────────────
        // Setiap step akan menyimpan informasi highlight untuk grid dan keterangan log
        private struct StepState
        {
            public int KuningStart, KuningEnd;
            public int MidIndex;                 // -1 = tidak ada
            public int HijauStart, HijauEnd;     // -1 = tidak ada
            public string Keterangan;
            public int BestSum;
        }

        // ─── Brute Force state ────────────────────────────────────────────────
        private List<StepState> bfSteps = new List<StepState>();
        private int bfCurrent = -1;
        private bool bfAutoPlaying = false;
        private int bfResultSum, bfResultL, bfResultR;

        // ─── Divide & Conquer state ───────────────────────────────────────────
        private List<StepState> dcSteps = new List<StepState>();
        private int dcCurrent = -1;
        private bool dcAutoPlaying = false;
        private int dcResultSum, dcResultL, dcResultR;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        // Dipanggil saat form dibuka. Tugasnya: salin data awal,
        // inisialisasi semua grid,
        // lalu pre-generate semua langkah kedua algoritma sekaligus agar navigasi step cepat tanpa hitung ulang.
        {
            namaHari = (string[])hari.Clone();
            fluktuasiSaham = (int[])dataSahamAwal.Clone();

            InitMainGrid();
            InitAlgoGrid(dgvBF);
            InitAlgoGrid(dgvDC);

            // Pre-generate all steps at startup
            GenerateBFSteps();
            GenerateDCSteps();

            UpdateBFLabels();
            UpdateDCLabels();
        }

        //  GRID INITIALISATION
        private void InitMainGrid()
        // BerfungsiMembuat tabel visual dengan kolom = hari,
        // baris = nilai saham. Nilai positif berwarna hijau,
        // Nilai negatif  berwarna merah.
        {
            dgvMain.Columns.Clear();
            dgvMain.Rows.Clear();
            dgvMain.ColumnCount = fluktuasiSaham.Length;

            for (int i = 0; i < fluktuasiSaham.Length; i++)
                dgvMain.Columns[i].HeaderText = namaHari[i];

            // Single row: Nilai
            dgvMain.Rows.Add();
            dgvMain.Rows[0].HeaderCell.Value = "Nilai";
            for (int i = 0; i < fluktuasiSaham.Length; i++)
            {
                dgvMain.Rows[0].Cells[i].Value = fluktuasiSaham[i];
                dgvMain.Rows[0].Cells[i].Style.ForeColor =
                    fluktuasiSaham[i] >= 0 ? Color.FromArgb(0, 140, 0) : Color.Crimson;
            }
            dgvMain.RowTemplate.Height = 28;
        }

        private void InitAlgoGrid(DataGridView dgv)
        {
            dgv.Columns.Clear();
            dgv.Rows.Clear();
            dgv.ColumnCount = fluktuasiSaham.Length;

            for (int i = 0; i < fluktuasiSaham.Length; i++)
                dgv.Columns[i].HeaderText = namaHari[i];

            dgv.Rows.Add();
            dgv.Rows[0].HeaderCell.Value = "Nilai";
            for (int i = 0; i < fluktuasiSaham.Length; i++)
            {
                dgv.Rows[0].Cells[i].Value = fluktuasiSaham[i];
                dgv.Rows[0].Cells[i].Style.ForeColor =
                    fluktuasiSaham[i] >= 0 ? Color.FromArgb(0, 140, 0) : Color.Crimson;
            }
            dgv.RowTemplate.Height = 28;
        }

        //  CELL PAINTING  (custom highlight)
        private void dgvBF_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (bfCurrent < 0 || bfCurrent >= bfSteps.Count) return;
            PaintCell(e, bfSteps[bfCurrent]);
        }

        private void dgvDC_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dcCurrent < 0 || dcCurrent >= dcSteps.Count) return;
            PaintCell(e, dcSteps[dcCurrent]);
        }

        private void PaintCell(DataGridViewCellPaintingEventArgs e, StepState s)
        {
            int col = e.ColumnIndex;
            Color bg = Color.Transparent;

            if (s.HijauStart != -1 && col >= s.HijauStart && col <= s.HijauEnd)
                bg = Color.LightGreen;
            else if (s.MidIndex != -1 && col == s.MidIndex)
                bg = Color.Tomato;
            else if (s.KuningStart != -1 && col >= s.KuningStart && col <= s.KuningEnd)
                bg = Color.Yellow;

            if (bg == Color.Transparent) return;

            e.Graphics.FillRectangle(new SolidBrush(bg), e.CellBounds);

            // value text
            var val = e.FormattedValue?.ToString() ?? "";
            var fgColor = val.StartsWith("-") ? Color.Crimson : Color.FromArgb(0, 110, 0);
            if (bg == Color.Tomato) fgColor = Color.White;

            TextRenderer.DrawText(e.Graphics, val,
                e.CellStyle.Font ?? SystemFonts.DefaultFont,
                e.CellBounds, fgColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

            // border
            e.Graphics.DrawRectangle(Pens.Gray, e.CellBounds.X, e.CellBounds.Y,
                e.CellBounds.Width - 1, e.CellBounds.Height - 1);

            e.Handled = true;
        }

        //  GENERATE STEPS: BRUTE FORCE
        // Menggunakan dua loop bersarang O(n²): setiap kombinasi [i..j] dicoba,
        // Nilai sumnya dihitung, dan jika merupakan Nilai maksimum baru, dicatat sebagai HijauStart/End.
        // Setiap iterasi menghasilkan satu StepState yang disimpan ke bfSteps.
        private void GenerateBFSteps()
        {
            bfSteps.Clear();
            int n = fluktuasiSaham.Length;
            int maxSum = int.MinValue;
            int bestL = 0, bestR = 0;

            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                for (int j = i; j < n; j++)
                {
                    sum += fluktuasiSaham[j];
                    bool newMax = sum > maxSum;
                    if (newMax) { maxSum = sum; bestL = i; bestR = j; }

                    bfSteps.Add(new StepState
                    {
                        KuningStart = i,
                        KuningEnd = j,
                        MidIndex = -1,
                        HijauStart = bestL,
                        HijauEnd = bestR,
                        BestSum = maxSum,
                        Keterangan = $"Menguji subarray [{i}..{j}]  sum={sum}" +
                                      (newMax ? $"  ← BARU MAKSIMUM = {maxSum}" : "")
                    });
                }
            }

            // Final step
            bfSteps.Add(new StepState
            {
                KuningStart = -1,
                KuningEnd = -1,
                MidIndex = -1,
                HijauStart = bestL,
                HijauEnd = bestR,
                BestSum = maxSum,
                Keterangan = $"✔ SELESAI — Subarray [{bestL}..{bestR}]  ({namaHari[bestL]} s/d {namaHari[bestR]})  Profit = {maxSum}"
            });

            bfResultSum = maxSum;
            bfResultL = bestL;
            bfResultR = bestR;
        }
        //  GENERATE STEPS: DIVIDE & CONQUER
        private void GenerateDCSteps()
        {
            dcSteps.Clear();
            int bestL = 0, bestR = 0;
            int result = DCRecurse(fluktuasiSaham, 0, fluktuasiSaham.Length - 1,
                                   ref bestL, ref bestR, int.MinValue, -1, -1);

            dcSteps.Add(new StepState
            {
                KuningStart = -1,
                KuningEnd = -1,
                MidIndex = -1,
                HijauStart = bestL,
                HijauEnd = bestR,
                BestSum = result,
                Keterangan = $"✔ SELESAI — Subarray [{bestL}..{bestR}]  ({namaHari[bestL]} s/d {namaHari[bestR]})  Profit = {result}"
            });

            dcResultSum = result;
            dcResultL = bestL;
            dcResultR = bestR;
        }

        private int DCRecurse(int[] arr, int low, int high,
            ref int resL, ref int resR,
            int curBestSum, int curBestL, int curBestR)
        // memanggil fungsi rekursif yang akan menhitung langkah-langkahnya, dan langsung dicatat sebagai step.

        {
            if (low == high)
            {
                bool newMax = arr[low] > curBestSum;
                if (newMax) { curBestSum = arr[low]; curBestL = low; curBestR = high; }

                dcSteps.Add(new StepState
                {
                    KuningStart = low,
                    KuningEnd = high,
                    MidIndex = -1,
                    HijauStart = curBestL,
                    HijauEnd = curBestR,
                    BestSum = curBestSum,
                    Keterangan = $"Base case indeks {low}  nilai={arr[low]}" +
                                  (newMax ? $"  ← BARU MAKSIMUM = {curBestSum}" : "")
                });

                resL = low; resR = high;
                return arr[low];
            }

            int mid = (low + high) / 2;

            dcSteps.Add(new StepState
            {
                KuningStart = low,
                KuningEnd = high,
                MidIndex = mid,
                HijauStart = curBestL,
                HijauEnd = curBestR,
                BestSum = curBestSum,
                Keterangan = $"Membagi [{low}..{high}] → [{low}..{mid}] dan [{mid + 1}..{high}]  (mid={mid})"
            });

            int ll = 0, lr = 0;
            int leftSum = DCRecurse(arr, low, mid, ref ll, ref lr, curBestSum, curBestL, curBestR);
            if (leftSum > curBestSum) { curBestSum = leftSum; curBestL = ll; curBestR = lr; }

            int rl = 0, rr = 0;
            int rightSum = DCRecurse(arr, mid + 1, high, ref rl, ref rr, curBestSum, curBestL, curBestR);
            if (rightSum > curBestSum) { curBestSum = rightSum; curBestL = rl; curBestR = rr; }

            int cl = 0, cr = 0;
            int crossSum = FindMaxCrossing(arr, low, mid, high, ref cl, ref cr, curBestSum, curBestL, curBestR);
            if (crossSum > curBestSum) { curBestSum = crossSum; curBestL = cl; curBestR = cr; }

            if (leftSum >= rightSum && leftSum >= crossSum) { resL = ll; resR = lr; return leftSum; }
            if (rightSum >= leftSum && rightSum >= crossSum) { resL = rl; resR = rr; return rightSum; }
            resL = cl; resR = cr; return crossSum;
        }

        private int FindMaxCrossing(int[] arr, int low, int mid, int high,
            ref int crossL, ref int crossR,
            int curBestSum, int curBestL, int curBestR)
         // FindMaxCrossing menghitung subarray maksimum yang melewati titik tengah, dengan scan dari mid ke kiri dan mid + 1 ke kanan, lalu menjumlahkan keduanya.
        {
            int lSum = int.MinValue, sum = 0; crossL = mid;
            for (int i = mid; i >= low; i--)
            {
                sum += arr[i];
                if (sum > lSum) { lSum = sum; crossL = i; }
            }

            int rSum = int.MinValue; sum = 0; crossR = mid + 1;
            for (int j = mid + 1; j <= high; j++)
            {
                sum += arr[j];
                if (sum > rSum) { rSum = sum; crossR = j; }
            }

            int total = lSum + rSum;
            bool newMax = total > curBestSum;
            if (newMax) { curBestL = crossL; curBestR = crossR; curBestSum = total; }

            dcSteps.Add(new StepState
            {
                KuningStart = crossL,
                KuningEnd = crossR,
                MidIndex = mid,
                HijauStart = curBestL,
                HijauEnd = curBestR,
                BestSum = curBestSum,
                Keterangan = $"Crossing [{crossL}..{crossR}] lewat mid={mid}  crossSum={total}" +
                              (newMax ? $"  ← BARU MAKSIMUM = {total}" : "")
            });

            return total;
        }
 
        //  BRUTE FORCE BUTTON HANDLERS         
        private void btnBFNext_Click(object sender, EventArgs e) => BFAdvance(+1);
        private void btnBFPrev_Click(object sender, EventArgs e) => BFAdvance(-1);

        private void btnBFAuto_Click(object sender, EventArgs e)
        {
            if (bfAutoPlaying) { timerBF.Stop(); bfAutoPlaying = false; btnBFAuto.Text = "Auto Play"; }
            else { bfAutoPlaying = true; btnBFAuto.Text = "⏸ Pause"; timerBF.Start(); }
        }

        private void timerBF_Tick(object sender, EventArgs e)
        {
            BFAdvance(+1);
            if (bfCurrent >= bfSteps.Count - 1)
            {
                timerBF.Stop(); bfAutoPlaying = false; btnBFAuto.Text = "Auto Play";
            }
        }

        private void btnBFReset_Click(object sender, EventArgs e)
        {
            timerBF.Stop(); bfAutoPlaying = false; btnBFAuto.Text = "Auto Play";
            bfCurrent = -1;
            txtBFLog.Clear();
            lblBFProfit.Text = "Profit Maksimal: -";
            lblBFStep.Text = $"Step: 0 / {bfSteps.Count}";
            dgvBF.Refresh();
        }

        private void BFAdvance(int delta)
        {
            int next = bfCurrent + delta;
            if (next < 0 || next >= bfSteps.Count) return;
            bfCurrent = next;
            UpdateBFLabels();
            dgvBF.Refresh();
            AppendBFLog(bfSteps[bfCurrent].Keterangan);
        }

        private void UpdateBFLabels()
        {
            int total = bfSteps.Count;
            lblBFStep.Text = $"Step: {Math.Max(0, bfCurrent + 1)} / {total}";
            if (bfCurrent >= 0)
            {
                var s = bfSteps[bfCurrent];
                lblBFProfit.Text = s.BestSum == int.MinValue
                    ? "Profit Maksimal: -"
                    : $"Profit Maksimal: {s.BestSum}";
            }
        }

        private void AppendBFLog(string text)
        {
            txtBFLog.AppendText(text + "\n");
            txtBFLog.ScrollToCaret();
        }

        
        //  DIVIDE & CONQUER BUTTON HANDLERS
      
        private void btnDCNext_Click(object sender, EventArgs e) => DCAdvance(+1);
        private void btnDCPrev_Click(object sender, EventArgs e) => DCAdvance(-1);

        private void btnDCAuto_Click(object sender, EventArgs e)
        {
            if (dcAutoPlaying) { timerDC.Stop(); dcAutoPlaying = false; btnDCAuto.Text = "Auto Play"; }
            else { dcAutoPlaying = true; btnDCAuto.Text = "⏸ Pause"; timerDC.Start(); }
        }

        private void timerDC_Tick(object sender, EventArgs e)
        {
            DCAdvance(+1);
            if (dcCurrent >= dcSteps.Count - 1)
            {
                timerDC.Stop(); dcAutoPlaying = false; btnDCAuto.Text = "Auto Play";
            }
        }

        private void btnDCReset_Click(object sender, EventArgs e)
        {
            timerDC.Stop(); dcAutoPlaying = false; btnDCAuto.Text = "Auto Play";
            dcCurrent = -1;
            txtDCLog.Clear();
            lblDCProfit.Text = "Profit Maksimal: -";
            lblDCStep.Text = $"Step: 0 / {dcSteps.Count}";
            dgvDC.Refresh();
        }

        private void DCAdvance(int delta)
        {
            int next = dcCurrent + delta;
            if (next < 0 || next >= dcSteps.Count) return;
            dcCurrent = next;
            UpdateDCLabels();
            dgvDC.Refresh();
            AppendDCLog(dcSteps[dcCurrent].Keterangan);
        }

        private void UpdateDCLabels()
        {
            int total = dcSteps.Count;
            lblDCStep.Text = $"Step: {Math.Max(0, dcCurrent + 1)} / {total}";
            if (dcCurrent >= 0)
            {
                var s = dcSteps[dcCurrent];
                lblDCProfit.Text = s.BestSum == int.MinValue
                    ? "Profit Maksimal: -"
                    : $"Profit Maksimal: {s.BestSum}";
            }
        }

        private void AppendDCLog(string text)
        {
            txtDCLog.AppendText(text + "\n");
            txtDCLog.ScrollToCaret();
        }

        //  BENCHMARK 
        // Berfungsi Membandingkan performa nyata kedua algoritma pada 10.000 elemen acak menggunakan Stopwatch:
        // Hasilnya ditampilkan di label dan log, termasuk selisih waktu dan verdict mana yang lebih cepat.
        private void btnBenchmark_Click(object sender, EventArgs e)
        {
            const int N = 10_000;
            var rnd = new Random();
            int[] big = new int[N];
            for (int i = 0; i < N; i++) big[i] = rnd.Next(-500, 501);

            // Brute Force
            var sw = Stopwatch.StartNew();
            BenchBF(big);
            sw.Stop();
            long bfMs = sw.ElapsedMilliseconds;

            // D&C
            int dl = 0, dr = 0;
            sw.Restart();
            BenchDC(big, 0, N - 1, ref dl, ref dr);
            sw.Stop();
            long dcMs = sw.ElapsedMilliseconds;

            lblBenchBF.Text = $"Brute Force     : {bfMs} ms";
            lblBenchDC.Text = $"Divide & Conquer: {dcMs} ms";

            txtBenchLog.AppendText($"[BENCHMARK] {N} elemen acak\n");
            txtBenchLog.AppendText($"  Brute Force O(n²)     : {bfMs} ms\n");
            txtBenchLog.AppendText($"  Divide & Conquer O(n log n): {dcMs} ms\n");
            string verdict = bfMs > dcMs
                ? $"  → D&C lebih cepat {bfMs - dcMs} ms"
                : $"  → Brute Force lebih cepat {dcMs - bfMs} ms (ukuran data mungkin terlalu kecil)";
            txtBenchLog.AppendText(verdict + "\n");
            txtBenchLog.AppendText("──────────────────────────────────────────\n");
            txtBenchLog.ScrollToCaret();
        }

        private int BenchBF(int[] arr)
        {
            int max = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                int s = 0;
                for (int j = i; j < arr.Length; j++) { s += arr[j]; if (s > max) max = s; }
            }
            return max;
        }

        private int BenchDC(int[] arr, int lo, int hi, ref int rl, ref int rr)
        {
            if (lo == hi) { rl = lo; rr = hi; return arr[lo]; }
            int mid = (lo + hi) / 2;
            int ll2 = 0, lr2 = 0, rl2 = 0, rr2 = 0;
            int left = BenchDC(arr, lo, mid, ref ll2, ref lr2);
            int right = BenchDC(arr, mid + 1, hi, ref rl2, ref rr2);
            int cl = 0, cr = 0;
            int cross = BenchCross(arr, lo, mid, hi, ref cl, ref cr);
            if (left >= right && left >= cross) { rl = ll2; rr = lr2; return left; }
            if (right >= left && right >= cross) { rl = rl2; rr = rr2; return right; }
            rl = cl; rr = cr; return cross;
        }

        private int BenchCross(int[] arr, int lo, int mid, int hi, ref int cl, ref int cr)
        {
            int ls = int.MinValue, s = 0; cl = mid;
            for (int i = mid; i >= lo; i--) { s += arr[i]; if (s > ls) { ls = s; cl = i; } }
            int rs = int.MinValue; s = 0; cr = mid + 1;
            for (int j = mid + 1; j <= hi; j++) { s += arr[j]; if (s > rs) { rs = s; cr = j; } }
            return ls + rs;
        }
    }
}