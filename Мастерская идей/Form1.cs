using System; 
using System.Drawing; 
using System.Windows.Forms; 
  
namespace IdeaBoard 
{ 
    public partial class Form1 : Form 
    { 
        private string[] ideas = 
        { 
            "Видеоблог", "Подкаст", "Квиз", "Фотовыставка" 
        }; 
  
        public Form1() 
        { 
            InitializeComponent(); 
            ClientSize = new Size(1000, 640); 
            dgvIdeas.Columns[1].HeaderCell.Style.Alignment = 
                DataGridViewContentAlignment.MiddleCenter; 
            Shown += Form1_Shown; 
            btnAdd.Click += btnAdd_Click; 
            btnDelete.Click += btnDelete_Click; 
            btnSort.Click += btnSort_Click; 
            chkNoSpaces.CheckedChanged += chkNoSpaces_CheckedChanged; 
        } 
  
        private void Form1_Shown(object? sender, EventArgs e) 
        { 
            RefreshViews(); 
        } 
  
        private int NameLength(string title) 
        { 
            if (chkNoSpaces.Checked) 
                return title.Replace(" ", "").Length; 
            return title.Length; 
        } 
  
        private void RefreshViews() 
        { 
            dgvIdeas.Rows.Clear(); 
            for (int i = 0; i < ideas.Length; i++) 
                dgvIdeas.Rows.Add(ideas[i], NameLength(ideas[i])); 
  
            lblCount.Text = "Идей: " + ideas.Length; 
            dgvIdeas.ClearSelection(); 
            dgvIdeas.CurrentCell = null; 
            ShowShortest(); 
        }
        private void ShowShortest() 
        { 
            lstShortest.Items.Clear(); 
            if (ideas.Length == 0) 
            { 
                lblMinimum.Text = "Список пуст"; 
                return; 
            } 
            // Первый проход ищет минимальную длину. 
            int minLength = NameLength(ideas[0]); 
            for (int i = 1; i < ideas.Length; i++) 
            { 
                if (NameLength(ideas[i]) < minLength) 
                    minLength = NameLength(ideas[i]); 
            } 
            // Второй проход выводит ВСЕ идеи этой длины. 
            for (int i = 0; i < ideas.Length; i++) 
            { 
                if (NameLength(ideas[i]) == minLength) 
                    lstShortest.Items.Add(ideas[i]); 
            } 
            lstShortest.SelectedIndex = -1; 
            lblMinimum.Text = "Минимальная длина: " + minLength; 
        } 
  
        private void chkNoSpaces_CheckedChanged(object? sender, EventArgs e) 
        { 
            RefreshViews(); 
        } 
  
        private void btnAdd_Click(object? sender, EventArgs e) 
        { 
            string title = txtIdea.Text.Trim(); 
            if (title.Length == 0) 
            { 
                MessageBox.Show("Введите название идеи."); 
                txtIdea.Focus(); 
                return; 
            } 
            Array.Resize(ref ideas, ideas.Length + 1); 
            ideas[ideas.Length - 1] = title; 
            txtIdea.Clear(); 
            RefreshViews(); 
        }
        private void btnDelete_Click(object? sender, EventArgs e) 
        { 
            if (dgvIdeas.SelectedRows.Count == 0) 
            { 
                MessageBox.Show("Выберите строку в таблице слева."); 
                return; 
            } 
            int index = dgvIdeas.SelectedRows[0].Index; 
            for (int i = index; i < ideas.Length - 1; i++) 
                ideas[i] = ideas[i + 1]; 
  
            Array.Resize(ref ideas, ideas.Length - 1); 
            RefreshViews(); 
        } 
  
        private void btnSort_Click(object? sender, EventArgs e) 
        { 
            // Та же сортировка, но сравниваем длины названий. 
            for (int pass = 0; pass < ideas.Length - 1; pass++) 
            { 
                for (int i = 0; i < ideas.Length - 1 - pass; i++) 
                { 
                    if (NameLength(ideas[i]) > NameLength(ideas[i + 1])) 
                    { 
                        string temp = ideas[i]; 
                        ideas[i] = ideas[i + 1]; 
                        ideas[i + 1] = temp; 
                    } 
                } 
            } 
            RefreshViews(); 
        } 
    } 
}
