using System; 
using System.Drawing; 
using System.Windows.Forms; 
  
namespace StagePlaylist 
{ 
    public partial class Form1 : Form 
    { 
        private string[] tracks = 
        { 
            "Открытие", "Танцевальный блок", 
            "Финальная песня", "Выход ведущих" 
        }; 
  
        public Form1() 
        { 
            InitializeComponent(); 
            ClientSize = new Size(1000, 640); 
            dgvMatches.Columns[0].HeaderCell.Style.Alignment = 
                DataGridViewContentAlignment.MiddleCenter; 
            Shown += Form1_Shown; 
            btnAdd.Click += btnAdd_Click; 
            btnDelete.Click += btnDelete_Click; 
            btnSort.Click += btnSort_Click; 
            btnFind.Click += btnFind_Click; 
        } 
  
        private void Form1_Shown(object? sender, EventArgs e) 
        { 
            RefreshViews(); 
        } 
  
        private void RefreshViews() 
        { 
            lstTracks.Items.Clear(); 
            for (int i = 0; i < tracks.Length; i++) 
                lstTracks.Items.Add(tracks[i]); 
  
            lstTracks.SelectedIndex = -1; 
            lblCount.Text = "Треков: " + tracks.Length; 
            ShowMatches(); 
        } 
  
        private void ShowMatches() 
        { 
            string query = txtSearch.Text.Trim(); 
            dgvMatches.Rows.Clear(); 
            // Проверяем каждый элемент массива по очереди. 
            for (int i = 0; i < tracks.Length; i++) 
            { 
                if (tracks[i].IndexOf(query, 
                    StringComparison.CurrentCultureIgnoreCase) >= 0) 
                { 
                    dgvMatches.Rows.Add(i + 1, tracks[i]); 
                } 
            } 
            dgvMatches.ClearSelection(); 
            dgvMatches.CurrentCell = null; 
        }
        private void btnFind_Click(object? sender, EventArgs e) 
        { 
            ShowMatches(); 
        } 
  
        private void btnAdd_Click(object? sender, EventArgs e) 
        { 
            string title = txtTitle.Text.Trim(); 
            if (title.Length == 0) 
            { 
                MessageBox.Show("Введите название трека."); 
                txtTitle.Focus(); 
                return; 
            } 
            Array.Resize(ref tracks, tracks.Length + 1); 
            tracks[tracks.Length - 1] = title; 
            txtTitle.Clear(); 
            RefreshViews(); 
        } 
  
        private void btnDelete_Click(object? sender, EventArgs e) 
        { 
            int index = lstTracks.SelectedIndex; 
            if (index < 0) 
            { 
                MessageBox.Show("Выберите трек в списке слева."); 
                return; 
            } 
            // Закрываем освободившуюся позицию сдвигом влево. 
            for (int i = index; i < tracks.Length - 1; i++) 
                tracks[i] = tracks[i + 1]; 
  
            Array.Resize(ref tracks, tracks.Length - 1); 
            RefreshViews(); 
        } 
  
        private void btnSort_Click(object? sender, EventArgs e) 
        { 
            Array.Sort(tracks, StringComparer.CurrentCultureIgnoreCase); 
            RefreshViews(); 
        } 
    } 
}
