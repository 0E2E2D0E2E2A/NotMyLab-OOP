using System.ComponentModel;
using System.Windows.Forms;

namespace MethodMonteCarlo
{
    partial class MonteCarlo
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Figures = new System.Windows.Forms.MenuStrip();
            this.Ellipse = new System.Windows.Forms.ToolStripMenuItem();
            this.Rhombus = new System.Windows.Forms.ToolStripMenuItem();
            this.Triangle = new System.Windows.Forms.ToolStripMenuItem();
            this.Сlear = new System.Windows.Forms.ToolStripMenuItem();
            this.Calculate = new System.Windows.Forms.Button();
            this.resultTable = new System.Windows.Forms.DataGridView();
            this.Figure = new System.Windows.Forms.DataGridViewImageColumn();
            this.expected_area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calculated_area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountOfPoints = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DrawingField = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.Figures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrawingField)).BeginInit();
            this.SuspendLayout();
            // 
            // Figures
            // 
            this.Figures.Dock = System.Windows.Forms.DockStyle.None;
            this.Figures.ImageScalingSize = new System.Drawing.Size(16, 30);
            this.Figures.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Ellipse,
            this.Rhombus,
            this.Triangle,
            this.Сlear});
            this.Figures.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.Figures.Location = new System.Drawing.Point(677, 11);
            this.Figures.Name = "Figures";
            this.Figures.Size = new System.Drawing.Size(49, 136);
            this.Figures.TabIndex = 1;
            this.Figures.Text = "menuStrip1";
            // 
            // Ellipse
            // 
            this.Ellipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Ellipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Ellipse.Image = global::MethodMonteCarlo.Properties.Resources.Ellipse;
            this.Ellipse.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Ellipse.Name = "Ellipse";
            this.Ellipse.ShowShortcutKeys = false;
            this.Ellipse.Size = new System.Drawing.Size(43, 33);
            this.Ellipse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Rhombus
            // 
            this.Rhombus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Rhombus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Rhombus.Image = global::MethodMonteCarlo.Properties.Resources.Rhombus;
            this.Rhombus.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Rhombus.Name = "Rhombus";
            this.Rhombus.Size = new System.Drawing.Size(43, 33);
            this.Rhombus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Triangle
            // 
            this.Triangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Triangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Triangle.Image = global::MethodMonteCarlo.Properties.Resources.Triangle;
            this.Triangle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Triangle.Name = "Triangle";
            this.Triangle.Size = new System.Drawing.Size(43, 33);
            this.Triangle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Сlear
            // 
            this.Сlear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Сlear.Image = global::MethodMonteCarlo.Properties.Resources.Clear;
            this.Сlear.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Сlear.Name = "Сlear";
            this.Сlear.Size = new System.Drawing.Size(43, 33);
            this.Сlear.Text = "Clear";
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(705, 472);
            this.Calculate.Margin = new System.Windows.Forms.Padding(4);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(100, 28);
            this.Calculate.TabIndex = 2;
            this.Calculate.Text = "Вычислить";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // resultTable
            // 
            this.resultTable.AllowUserToAddRows = false;
            this.resultTable.AllowUserToDeleteRows = false;
            this.resultTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resultTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Figure,
            this.expected_area,
            this.calculated_area});
            this.resultTable.Location = new System.Drawing.Point(705, 197);
            this.resultTable.Margin = new System.Windows.Forms.Padding(4);
            this.resultTable.Name = "resultTable";
            this.resultTable.ReadOnly = true;
            this.resultTable.RowHeadersWidth = 50;
            this.resultTable.Size = new System.Drawing.Size(429, 230);
            this.resultTable.TabIndex = 3;
            // 
            // Figure
            // 
            this.Figure.HeaderText = "Фигура";
            this.Figure.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Figure.MinimumWidth = 6;
            this.Figure.Name = "Figure";
            this.Figure.ReadOnly = true;
            this.Figure.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Figure.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Figure.Width = 55;
            // 
            // expected_area
            // 
            this.expected_area.HeaderText = "Ожидаемая S";
            this.expected_area.MinimumWidth = 6;
            this.expected_area.Name = "expected_area";
            this.expected_area.ReadOnly = true;
            this.expected_area.Width = 105;
            // 
            // calculated_area
            // 
            this.calculated_area.HeaderText = "Вычисленная S";
            this.calculated_area.MinimumWidth = 6;
            this.calculated_area.Name = "calculated_area";
            this.calculated_area.ReadOnly = true;
            this.calculated_area.Width = 110;
            // 
            // amountOfPoints
            // 
            this.amountOfPoints.Location = new System.Drawing.Point(842, 164);
            this.amountOfPoints.Margin = new System.Windows.Forms.Padding(4);
            this.amountOfPoints.Name = "amountOfPoints";
            this.amountOfPoints.Size = new System.Drawing.Size(132, 22);
            this.amountOfPoints.TabIndex = 4;
            this.amountOfPoints.Text = "5000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(701, 167);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Количество точек:";
            // 
            // DrawingField
            // 
            this.DrawingField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DrawingField.Location = new System.Drawing.Point(7, 6);
            this.DrawingField.Margin = new System.Windows.Forms.Padding(4);
            this.DrawingField.Name = "DrawingField";
            this.DrawingField.Size = new System.Drawing.Size(666, 615);
            this.DrawingField.TabIndex = 0;
            this.DrawingField.TabStop = false;
            this.DrawingField.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawingField_MouseDown);
            this.DrawingField.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawingField_MouseMove);
            this.DrawingField.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawingField_MouseUp);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(704, 434);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(430, 31);
            this.progressBar1.TabIndex = 6;
            // 
            // buttonPause
            // 
            this.buttonPause.Location = new System.Drawing.Point(863, 472);
            this.buttonPause.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(100, 28);
            this.buttonPause.TabIndex = 8;
            this.buttonPause.Text = "Пауза";
            this.buttonPause.UseVisualStyleBackColor = true;
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(1034, 472);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(100, 28);
            this.buttonStop.TabIndex = 9;
            this.buttonStop.Text = "Отмена";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // MonteCarlo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 625);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.amountOfPoints);
            this.Controls.Add(this.resultTable);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.DrawingField);
            this.Controls.Add(this.Figures);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MonteCarlo";
            this.Text = "Monte Carlo";
            this.Figures.ResumeLayout(false);
            this.Figures.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrawingField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox DrawingField;
        private MenuStrip Figures;
        private ToolStripMenuItem Ellipse;
        private ToolStripMenuItem Rhombus;
        private ToolStripMenuItem Triangle;
        private Button Calculate;
        private DataGridView resultTable;
        private TextBox amountOfPoints;
        private Label label1;
        private DataGridViewImageColumn Figure;
        private DataGridViewTextBoxColumn expected_area;
        private DataGridViewTextBoxColumn calculated_area;
        private ToolStripMenuItem Сlear;
        private BackgroundWorker backgroundWorker1;
        private ProgressBar progressBar1;
        private Button buttonPause;
        private Button buttonStop;
    }
}

