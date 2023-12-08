
namespace Tyuiu.BratsunDA.Sprint6.Task2.V7
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_BDA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_BDA = new System.Windows.Forms.TextBox();
            this.groupBoxInput_BDA = new System.Windows.Forms.GroupBox();
            this.labelStopStep_BDA = new System.Windows.Forms.Label();
            this.labelStartStep_BDA = new System.Windows.Forms.Label();
            this.textBoxStopStep_BDA = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_BDA = new System.Windows.Forms.TextBox();
            this.groupBoxResult_BDA = new System.Windows.Forms.GroupBox();
            this.labelResult_BDA = new System.Windows.Forms.Label();
            this.dataGridViewFunction_BDA = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDone_BDA = new System.Windows.Forms.Button();
            this.buttonInfo_BDA = new System.Windows.Forms.Button();
            this.chartFunction_BDA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxTask_BDA.SuspendLayout();
            this.groupBoxInput_BDA.SuspendLayout();
            this.groupBoxResult_BDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_BDA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_BDA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_BDA
            // 
            this.groupBoxTask_BDA.Controls.Add(this.textBoxTask_BDA);
            this.groupBoxTask_BDA.Location = new System.Drawing.Point(9, 10);
            this.groupBoxTask_BDA.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxTask_BDA.Name = "groupBoxTask_BDA";
            this.groupBoxTask_BDA.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxTask_BDA.Size = new System.Drawing.Size(423, 237);
            this.groupBoxTask_BDA.TabIndex = 0;
            this.groupBoxTask_BDA.TabStop = false;
            this.groupBoxTask_BDA.Text = "Условие";
            // 
            // textBoxTask_BDA
            // 
            this.textBoxTask_BDA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_BDA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_BDA.Location = new System.Drawing.Point(10, 15);
            this.textBoxTask_BDA.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTask_BDA.Multiline = true;
            this.textBoxTask_BDA.Name = "textBoxTask_BDA";
            this.textBoxTask_BDA.Size = new System.Drawing.Size(304, 200);
            this.textBoxTask_BDA.TabIndex = 0;
            this.textBoxTask_BDA.TabStop = false;
            this.textBoxTask_BDA.Text = "Протабулировать функцию на заданном диапазоне. Результат вывести в DataGridView и" +
    " построить график функции.";
            // 
            // groupBoxInput_BDA
            // 
            this.groupBoxInput_BDA.Controls.Add(this.labelStopStep_BDA);
            this.groupBoxInput_BDA.Controls.Add(this.labelStartStep_BDA);
            this.groupBoxInput_BDA.Controls.Add(this.textBoxStopStep_BDA);
            this.groupBoxInput_BDA.Controls.Add(this.textBoxStartStep_BDA);
            this.groupBoxInput_BDA.Location = new System.Drawing.Point(9, 251);
            this.groupBoxInput_BDA.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxInput_BDA.Name = "groupBoxInput_BDA";
            this.groupBoxInput_BDA.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxInput_BDA.Size = new System.Drawing.Size(247, 107);
            this.groupBoxInput_BDA.TabIndex = 1;
            this.groupBoxInput_BDA.TabStop = false;
            this.groupBoxInput_BDA.Text = "Ввод данных";
            // 
            // labelStopStep_BDA
            // 
            this.labelStopStep_BDA.AutoSize = true;
            this.labelStopStep_BDA.Location = new System.Drawing.Point(122, 27);
            this.labelStopStep_BDA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStopStep_BDA.Name = "labelStopStep_BDA";
            this.labelStopStep_BDA.Size = new System.Drawing.Size(69, 13);
            this.labelStopStep_BDA.TabIndex = 3;
            this.labelStopStep_BDA.Text = "Конец шага:";
            this.labelStopStep_BDA.Click += new System.EventHandler(this.labelStopStep_BDA_Click);
            // 
            // labelStartStep_BDA
            // 
            this.labelStartStep_BDA.AutoSize = true;
            this.labelStartStep_BDA.Location = new System.Drawing.Point(8, 27);
            this.labelStartStep_BDA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStartStep_BDA.Name = "labelStartStep_BDA";
            this.labelStartStep_BDA.Size = new System.Drawing.Size(67, 13);
            this.labelStartStep_BDA.TabIndex = 2;
            this.labelStartStep_BDA.Text = "Старт шага:";
            // 
            // textBoxStopStep_BDA
            // 
            this.textBoxStopStep_BDA.Location = new System.Drawing.Point(124, 43);
            this.textBoxStopStep_BDA.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxStopStep_BDA.Name = "textBoxStopStep_BDA";
            this.textBoxStopStep_BDA.Size = new System.Drawing.Size(109, 20);
            this.textBoxStopStep_BDA.TabIndex = 1;
            this.textBoxStopStep_BDA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStopStep_BDA_KeyPress);
            // 
            // textBoxStartStep_BDA
            // 
            this.textBoxStartStep_BDA.Location = new System.Drawing.Point(10, 43);
            this.textBoxStartStep_BDA.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxStartStep_BDA.Name = "textBoxStartStep_BDA";
            this.textBoxStartStep_BDA.Size = new System.Drawing.Size(110, 20);
            this.textBoxStartStep_BDA.TabIndex = 0;
            this.textBoxStartStep_BDA.TextChanged += new System.EventHandler(this.textBoxStartStep_BDA_TextChanged);
            this.textBoxStartStep_BDA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStartStep_BDA_KeyPress);
            // 
            // groupBoxResult_BDA
            // 
            this.groupBoxResult_BDA.Controls.Add(this.chartFunction_BDA);
            this.groupBoxResult_BDA.Controls.Add(this.labelResult_BDA);
            this.groupBoxResult_BDA.Controls.Add(this.dataGridViewFunction_BDA);
            this.groupBoxResult_BDA.Location = new System.Drawing.Point(436, 10);
            this.groupBoxResult_BDA.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxResult_BDA.Name = "groupBoxResult_BDA";
            this.groupBoxResult_BDA.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxResult_BDA.Size = new System.Drawing.Size(537, 348);
            this.groupBoxResult_BDA.TabIndex = 2;
            this.groupBoxResult_BDA.TabStop = false;
            this.groupBoxResult_BDA.Text = "Вывод данных";
            // 
            // labelResult_BDA
            // 
            this.labelResult_BDA.AutoSize = true;
            this.labelResult_BDA.Location = new System.Drawing.Point(8, 15);
            this.labelResult_BDA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelResult_BDA.Name = "labelResult_BDA";
            this.labelResult_BDA.Size = new System.Drawing.Size(62, 13);
            this.labelResult_BDA.TabIndex = 1;
            this.labelResult_BDA.Text = "Результат:";
            // 
            // dataGridViewFunction_BDA
            // 
            this.dataGridViewFunction_BDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_BDA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dataGridViewFunction_BDA.Location = new System.Drawing.Point(10, 30);
            this.dataGridViewFunction_BDA.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewFunction_BDA.Name = "dataGridViewFunction_BDA";
            this.dataGridViewFunction_BDA.RowHeadersVisible = false;
            this.dataGridViewFunction_BDA.RowHeadersWidth = 51;
            this.dataGridViewFunction_BDA.RowTemplate.Height = 24;
            this.dataGridViewFunction_BDA.Size = new System.Drawing.Size(143, 301);
            this.dataGridViewFunction_BDA.TabIndex = 0;
            this.dataGridViewFunction_BDA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFunction_BDA_CellContentClick);
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.MinimumWidth = 6;
            this.X.Name = "X";
            this.X.Width = 50;
            // 
            // Y
            // 
            this.Y.HeaderText = "F(X)";
            this.Y.MinimumWidth = 6;
            this.Y.Name = "Y";
            this.Y.Width = 50;
            // 
            // buttonDone_BDA
            // 
            this.buttonDone_BDA.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonDone_BDA.Location = new System.Drawing.Point(341, 265);
            this.buttonDone_BDA.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDone_BDA.Name = "buttonDone_BDA";
            this.buttonDone_BDA.Size = new System.Drawing.Size(91, 77);
            this.buttonDone_BDA.TabIndex = 3;
            this.buttonDone_BDA.Text = "Выполнить";
            this.buttonDone_BDA.UseVisualStyleBackColor = false;
            this.buttonDone_BDA.Click += new System.EventHandler(this.buttonDone_BDA_Click);
            this.buttonDone_BDA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_BDA_MouseDown);
            this.buttonDone_BDA.MouseEnter += new System.EventHandler(this.buttonDone_BDA_MouseEnter);
            this.buttonDone_BDA.MouseLeave += new System.EventHandler(this.buttonDone_BDA_MouseLeave);
            // 
            // buttonInfo_BDA
            // 
            this.buttonInfo_BDA.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonInfo_BDA.Location = new System.Drawing.Point(261, 265);
            this.buttonInfo_BDA.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInfo_BDA.Name = "buttonInfo_BDA";
            this.buttonInfo_BDA.Size = new System.Drawing.Size(76, 76);
            this.buttonInfo_BDA.TabIndex = 4;
            this.buttonInfo_BDA.Text = "Справка";
            this.buttonInfo_BDA.UseVisualStyleBackColor = false;
            this.buttonInfo_BDA.Click += new System.EventHandler(this.buttonInfo_BDA_Click);
            // 
            // chartFunction_BDA
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_BDA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_BDA.Legends.Add(legend1);
            this.chartFunction_BDA.Location = new System.Drawing.Point(158, 30);
            this.chartFunction_BDA.Name = "chartFunction_BDA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_BDA.Series.Add(series1);
            this.chartFunction_BDA.Size = new System.Drawing.Size(378, 300);
            this.chartFunction_BDA.TabIndex = 2;
            this.chartFunction_BDA.Text = "chartFunction_BDA";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 366);
            this.Controls.Add(this.buttonInfo_BDA);
            this.Controls.Add(this.buttonDone_BDA);
            this.Controls.Add(this.groupBoxResult_BDA);
            this.Controls.Add(this.groupBoxInput_BDA);
            this.Controls.Add(this.groupBoxTask_BDA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 |  Вариант 7 | Брацун Д.А.";
            this.groupBoxTask_BDA.ResumeLayout(false);
            this.groupBoxTask_BDA.PerformLayout();
            this.groupBoxInput_BDA.ResumeLayout(false);
            this.groupBoxInput_BDA.PerformLayout();
            this.groupBoxResult_BDA.ResumeLayout(false);
            this.groupBoxResult_BDA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_BDA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_BDA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_BDA;
        private System.Windows.Forms.GroupBox groupBoxInput_BDA;
        private System.Windows.Forms.GroupBox groupBoxResult_BDA;
        private System.Windows.Forms.Button buttonDone_BDA;
        private System.Windows.Forms.Button buttonInfo_BDA;
        private System.Windows.Forms.Label labelStopStep_BDA;
        private System.Windows.Forms.Label labelStartStep_BDA;
        private System.Windows.Forms.TextBox textBoxStopStep_BDA;
        private System.Windows.Forms.TextBox textBoxStartStep_BDA;
        private System.Windows.Forms.TextBox textBoxTask_BDA;
        private System.Windows.Forms.DataGridView dataGridViewFunction_BDA;
        private System.Windows.Forms.Label labelResult_BDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_BDA;
    }
}