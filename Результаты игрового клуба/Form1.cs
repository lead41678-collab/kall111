using System; 
using System.Drawing; 
using System.Windows.Forms; 
  
namespace GameScores 
{ 
    public partial class Form1 : Form 
    { 
        private int[] scores = { 42, 88, 61, 95 }; 
  
        public Form1() 
        { 
            InitializeComponent(); 
            ClientSize = new Size(1000, 640); 
            Shown += Form1_Shown; 
            btnAdd.Click += btnAdd_Click; 
            btnDelete.Click += btnDelete_Click; 
            btnSort.Click += btnSort_Click; 
            btnFilter.Click += btnFilter_Click; 
        } 
  
        private void Form1_Shown(object? sender, EventArgs e) 
        { 
            RefreshViews(); 
        } 
  
        private void RefreshViews() 
        { 
            dgvScores.Rows.Clear(); 
            for (int i = 0; i < scores.Length; i++) 
                dgvScores.Rows.Add(i + 1, scores[i]); 
  
            lblCount.Text = "Результатов: " + scores.Length; 
            dgvScores.ClearSelection(); 
            dgvScores.CurrentCell = null; 
            ShowBest(); 
        } 
  
        private void ShowBest() 
        { 
            int threshold = (int)numThreshold.Value; 
            lstBest.Items.Clear(); 
            for (int i = 0; i < scores.Length; i++) 
            { 
                if (scores[i] >= threshold) 
                    lstBest.Items.Add("№ " + (i + 1) + ": " + scores[i]); 
            } 
            lstBest.SelectedIndex = -1; 
        } 
  
        private void btnFilter_Click(object? sender, EventArgs e) 
        { 
            ShowBest(); 
        }
        private void btnAdd_Click(object? sender, EventArgs e) 
        { 
            Array.Resize(ref scores, scores.Length + 1); 
            scores[scores.Length - 1] = (int)numScore.Value; 
            RefreshViews(); 
        } 
  
        private void btnDelete_Click(object? sender, EventArgs e) 
        { 
            if (dgvScores.SelectedRows.Count == 0) 
            { 
                MessageBox.Show("Выберите строку в таблице слева."); 
                return; 
            } 
            int index = dgvScores.SelectedRows[0].Index; 
            for (int i = index; i < scores.Length - 1; i++) 
                scores[i] = scores[i + 1]; 
  
            Array.Resize(ref scores, scores.Length - 1); 
            RefreshViews(); 
        } 
  
        private void btnSort_Click(object? sender, EventArgs e) 
        { 
            // Пузырьковая сортировка по убыванию. 
            for (int pass = 0; pass < scores.Length - 1; pass++) 
            { 
                for (int i = 0; i < scores.Length - 1 - pass; i++) 
                { 
                    if (scores[i] < scores[i + 1]) 
                    { 
                        int temp = scores[i]; 
                        scores[i] = scores[i + 1]; 
                        scores[i + 1] = temp; 
                    } 
                } 
            } 
            RefreshViews(); 
        } 
    } 
}
