namespace GameScores
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            lblCount = new Label();
            pnlMain = new Panel();
            lblMain = new Label();
            lblHint = new Label();
            dgvScores = new DataGridView();
            colPosition = new DataGridViewTextBoxColumn();
            colScore = new DataGridViewTextBoxColumn();
            pnlTools = new Panel();
            lblSide = new Label();
            numThreshold = new NumericUpDown();
            btnFilter = new Button();
            lstBest = new ListBox();
            lblSideHint = new Label();
            pnlActions = new Panel();
            lblNew = new Label();
            btnAdd = new Button();
            btnDelete = new Button();
            btnSort = new Button();
            numScore = new NumericUpDown();
            pnlHeader.SuspendLayout();
            pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvScores).BeginInit();
            pnlTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numThreshold).BeginInit();
            pnlActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numScore).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(15, 118, 110);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Controls.Add(lblCount);
            pnlHeader.Font = new Font("Segoe UI", 10F);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1000, 106);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(24, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(720, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Результаты игрового клуба";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSubtitle
            // 
            lblSubtitle.BackColor = Color.Transparent;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.WhiteSmoke;
            lblSubtitle.Location = new Point(24, 62);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(720, 24);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Отбор результатов и сортировка баллов";
            lblSubtitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCount
            // 
            lblCount.BackColor = Color.FromArgb(11, 88, 82);
            lblCount.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblCount.ForeColor = Color.White;
            lblCount.Location = new Point(780, 26);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(196, 42);
            lblCount.TabIndex = 2;
            lblCount.Text = "Результатов: 4";
            lblCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.White;
            pnlMain.Controls.Add(lblMain);
            pnlMain.Controls.Add(lblHint);
            pnlMain.Controls.Add(dgvScores);
            pnlMain.Font = new Font("Segoe UI", 10F);
            pnlMain.Location = new Point(24, 128);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(584, 392);
            pnlMain.TabIndex = 1;
            // 
            // lblMain
            // 
            lblMain.BackColor = Color.Transparent;
            lblMain.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblMain.Location = new Point(18, 16);
            lblMain.Name = "lblMain";
            lblMain.Size = new Size(548, 26);
            lblMain.TabIndex = 0;
            lblMain.Text = "Все результаты";
            lblMain.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblHint
            // 
            lblHint.BackColor = Color.Transparent;
            lblHint.Font = new Font("Segoe UI", 9F);
            lblHint.ForeColor = Color.FromArgb(107, 114, 128);
            lblHint.Location = new Point(18, 326);
            lblHint.Name = "lblHint";
            lblHint.Size = new Size(548, 42);
            lblHint.TabIndex = 1;
            lblHint.Text = "Выберите строку для удаления.";
            lblHint.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvScores
            // 
            dgvScores.AllowUserToAddRows = false;
            dgvScores.AllowUserToDeleteRows = false;
            dgvScores.AllowUserToResizeColumns = false;
            dgvScores.AllowUserToResizeRows = false;
            dgvScores.BackgroundColor = Color.White;
            dgvScores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvScores.ColumnHeadersHeight = 32;
            dgvScores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvScores.Columns.AddRange(new DataGridViewColumn[] { colPosition, colScore });
            dgvScores.EnableHeadersVisualStyles = false;
            dgvScores.Font = new Font("Segoe UI", 10F);
            dgvScores.GridColor = Color.FromArgb(220, 226, 234);
            dgvScores.Location = new Point(18, 56);
            dgvScores.MultiSelect = false;
            dgvScores.Name = "dgvScores";
            dgvScores.ReadOnly = true;
            dgvScores.RowHeadersVisible = false;
            dgvScores.RowTemplate.Height = 30;
            dgvScores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvScores.Size = new Size(548, 250);
            dgvScores.TabIndex = 0;
            // 
            // colPosition
            // 
            colPosition.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colPosition.HeaderText = "№";
            colPosition.Name = "colPosition";
            colPosition.ReadOnly = true;
            colPosition.SortMode = DataGridViewColumnSortMode.NotSortable;
            colPosition.Width = 60;
            // 
            // colScore
            // 
            colScore.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colScore.HeaderText = "Баллы";
            colScore.Name = "colScore";
            colScore.ReadOnly = true;
            colScore.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // pnlTools
            // 
            pnlTools.BackColor = Color.White;
            pnlTools.Controls.Add(lblSide);
            pnlTools.Controls.Add(numThreshold);
            pnlTools.Controls.Add(btnFilter);
            pnlTools.Controls.Add(lstBest);
            pnlTools.Controls.Add(lblSideHint);
            pnlTools.Font = new Font("Segoe UI", 10F);
            pnlTools.Location = new Point(628, 128);
            pnlTools.Name = "pnlTools";
            pnlTools.Size = new Size(348, 392);
            pnlTools.TabIndex = 2;
            // 
            // lblSide
            // 
            lblSide.BackColor = Color.Transparent;
            lblSide.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblSide.Location = new Point(20, 16);
            lblSide.Name = "lblSide";
            lblSide.Size = new Size(312, 26);
            lblSide.TabIndex = 0;
            lblSide.Text = "Результаты от порога";
            lblSide.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numThreshold
            // 
            numThreshold.BackColor = Color.White;
            numThreshold.Font = new Font("Segoe UI", 11F);
            numThreshold.ForeColor = Color.FromArgb(31, 41, 55);
            numThreshold.Location = new Point(18, 56);
            numThreshold.Name = "numThreshold";
            numThreshold.Size = new Size(106, 27);
            numThreshold.TabIndex = 0;
            numThreshold.Value = new decimal(new int[] { 70, 0, 0, 0 });
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.FromArgb(15, 118, 110);
            btnFilter.Cursor = Cursors.Hand;
            btnFilter.FlatAppearance.BorderSize = 0;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnFilter.ForeColor = Color.White;
            btnFilter.Location = new Point(140, 52);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(190, 36);
            btnFilter.TabIndex = 1;
            btnFilter.Text = "Показать";
            btnFilter.UseVisualStyleBackColor = false;
            // 
            // lstBest
            // 
            lstBest.BackColor = Color.White;
            lstBest.BorderStyle = BorderStyle.FixedSingle;
            lstBest.Font = new Font("Segoe UI", 11F);
            lstBest.ForeColor = Color.FromArgb(31, 41, 55);
            lstBest.HorizontalScrollbar = true;
            lstBest.IntegralHeight = false;
            lstBest.Location = new Point(20, 94);
            lstBest.Name = "lstBest";
            lstBest.Size = new Size(312, 214);
            lstBest.TabIndex = 2;
            // 
            // lblSideHint
            // 
            lblSideHint.BackColor = Color.Transparent;
            lblSideHint.Font = new Font("Segoe UI", 9F);
            lblSideHint.ForeColor = Color.FromArgb(107, 114, 128);
            lblSideHint.Location = new Point(18, 330);
            lblSideHint.Name = "lblSideHint";
            lblSideHint.Size = new Size(312, 42);
            lblSideHint.TabIndex = 3;
            lblSideHint.Text = "Выводятся баллы ≥ заданного порога.";
            lblSideHint.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlActions
            // 
            pnlActions.BackColor = Color.White;
            pnlActions.Controls.Add(lblNew);
            pnlActions.Controls.Add(btnAdd);
            pnlActions.Controls.Add(btnDelete);
            pnlActions.Controls.Add(btnSort);
            pnlActions.Controls.Add(numScore);
            pnlActions.Font = new Font("Segoe UI", 10F);
            pnlActions.Location = new Point(24, 540);
            pnlActions.Name = "pnlActions";
            pnlActions.Size = new Size(952, 76);
            pnlActions.TabIndex = 3;
            // 
            // lblNew
            // 
            lblNew.BackColor = Color.Transparent;
            lblNew.Font = new Font("Segoe UI", 10F);
            lblNew.Location = new Point(16, 10);
            lblNew.Name = "lblNew";
            lblNew.Size = new Size(386, 20);
            lblNew.TabIndex = 0;
            lblNew.Text = "Новый результат";
            lblNew.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(15, 118, 110);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(418, 22);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 36);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(239, 242, 247);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDelete.ForeColor = Color.FromArgb(31, 41, 55);
            btnDelete.Location = new Point(584, 22);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(158, 36);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnSort
            // 
            btnSort.BackColor = Color.FromArgb(239, 242, 247);
            btnSort.Cursor = Cursors.Hand;
            btnSort.FlatAppearance.BorderSize = 0;
            btnSort.FlatStyle = FlatStyle.Flat;
            btnSort.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSort.ForeColor = Color.FromArgb(31, 41, 55);
            btnSort.Location = new Point(758, 22);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(178, 36);
            btnSort.TabIndex = 3;
            btnSort.Text = "По убыванию";
            btnSort.UseVisualStyleBackColor = false;
            // 
            // numScore
            // 
            numScore.BackColor = Color.White;
            numScore.Font = new Font("Segoe UI", 11F);
            numScore.ForeColor = Color.FromArgb(31, 41, 55);
            numScore.Location = new Point(16, 36);
            numScore.Name = "numScore";
            numScore.Size = new Size(386, 27);
            numScore.TabIndex = 0;
            numScore.Value = new decimal(new int[] { 75, 0, 0, 0 });
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(245, 247, 251);
            ClientSize = new Size(1000, 640);
            Controls.Add(pnlHeader);
            Controls.Add(pnlMain);
            Controls.Add(pnlTools);
            Controls.Add(pnlActions);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.FromArgb(31, 41, 55);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Результаты игрового клуба";
            pnlHeader.ResumeLayout(false);
            pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvScores).EndInit();
            pnlTools.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numThreshold).EndInit();
            pnlActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numScore).EndInit();
            ResumeLayout(false);
        }
        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblCount;
        private Panel pnlMain;
        private Panel pnlTools;
        private Panel pnlActions;
        private Label lblMain;
        private Label lblHint;
        private Label lblSide;
        private Label lblNew;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnSort;
        private DataGridView dgvScores;
        private DataGridViewTextBoxColumn colPosition;
        private DataGridViewTextBoxColumn colScore;
        private NumericUpDown numThreshold;
        private Button btnFilter;
        private ListBox lstBest;
        private NumericUpDown numScore;
        private Label lblSideHint;
    }
}
