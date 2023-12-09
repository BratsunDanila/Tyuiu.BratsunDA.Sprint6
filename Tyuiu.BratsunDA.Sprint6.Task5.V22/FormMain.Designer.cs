
namespace Tyuiu.BratsunDA.Sprint6.Task5.V22
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
            this.panelTask_BDA = new System.Windows.Forms.Panel();
            this.buttonInfo_BDA = new System.Windows.Forms.Button();
            this.buttonOpenFile_BDA = new System.Windows.Forms.Button();
            this.buttonDone_BDA = new System.Windows.Forms.Button();
            this.groupBoxTask_BDA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_BDA = new System.Windows.Forms.TextBox();
            this.panelOutPut_BDA = new System.Windows.Forms.Panel();
            this.groupBoxOutPut_BDA = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutPut_BDA = new System.Windows.Forms.DataGridView();
            this.splitterOutPut_BDA = new System.Windows.Forms.Splitter();
            this.panelGraph_BDA = new System.Windows.Forms.Panel();
            this.chartGraph_BDA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTask_BDA.SuspendLayout();
            this.groupBoxTask_BDA.SuspendLayout();
            this.panelOutPut_BDA.SuspendLayout();
            this.groupBoxOutPut_BDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_BDA)).BeginInit();
            this.panelGraph_BDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraph_BDA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTask_BDA
            // 
            this.panelTask_BDA.Controls.Add(this.buttonInfo_BDA);
            this.panelTask_BDA.Controls.Add(this.buttonOpenFile_BDA);
            this.panelTask_BDA.Controls.Add(this.buttonDone_BDA);
            this.panelTask_BDA.Controls.Add(this.groupBoxTask_BDA);
            this.panelTask_BDA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_BDA.Location = new System.Drawing.Point(0, 0);
            this.panelTask_BDA.Margin = new System.Windows.Forms.Padding(2);
            this.panelTask_BDA.Name = "panelTask_BDA";
            this.panelTask_BDA.Size = new System.Drawing.Size(822, 89);
            this.panelTask_BDA.TabIndex = 0;
            // 
            // buttonInfo_BDA
            // 
            this.buttonInfo_BDA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_BDA.BackColor = System.Drawing.Color.Pink;
            this.buttonInfo_BDA.Location = new System.Drawing.Point(686, 15);
            this.buttonInfo_BDA.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInfo_BDA.Name = "buttonInfo_BDA";
            this.buttonInfo_BDA.Size = new System.Drawing.Size(117, 60);
            this.buttonInfo_BDA.TabIndex = 1;
            this.buttonInfo_BDA.Text = "Справка";
            this.buttonInfo_BDA.UseVisualStyleBackColor = false;
            this.buttonInfo_BDA.Click += new System.EventHandler(this.buttonInfo_BDA_Click);
            // 
            // buttonOpenFile_BDA
            // 
            this.buttonOpenFile_BDA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenFile_BDA.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonOpenFile_BDA.Location = new System.Drawing.Point(564, 15);
            this.buttonOpenFile_BDA.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpenFile_BDA.Name = "buttonOpenFile_BDA";
            this.buttonOpenFile_BDA.Size = new System.Drawing.Size(117, 60);
            this.buttonOpenFile_BDA.TabIndex = 1;
            this.buttonOpenFile_BDA.Text = "Открыть файл";
            this.buttonOpenFile_BDA.UseVisualStyleBackColor = false;
            this.buttonOpenFile_BDA.Click += new System.EventHandler(this.buttonSaveFile_BDA_Click);
            // 
            // buttonDone_BDA
            // 
            this.buttonDone_BDA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDone_BDA.BackColor = System.Drawing.Color.Green;
            this.buttonDone_BDA.Location = new System.Drawing.Point(442, 15);
            this.buttonDone_BDA.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDone_BDA.Name = "buttonDone_BDA";
            this.buttonDone_BDA.Size = new System.Drawing.Size(117, 60);
            this.buttonDone_BDA.TabIndex = 1;
            this.buttonDone_BDA.Text = "Выполнить";
            this.buttonDone_BDA.UseVisualStyleBackColor = false;
            this.buttonDone_BDA.Click += new System.EventHandler(this.buttonDone_BDA_Click);
            // 
            // groupBoxTask_BDA
            // 
            this.groupBoxTask_BDA.Controls.Add(this.textBoxTask_BDA);
            this.groupBoxTask_BDA.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxTask_BDA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_BDA.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxTask_BDA.Name = "groupBoxTask_BDA";
            this.groupBoxTask_BDA.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxTask_BDA.Size = new System.Drawing.Size(437, 89);
            this.groupBoxTask_BDA.TabIndex = 0;
            this.groupBoxTask_BDA.TabStop = false;
            this.groupBoxTask_BDA.Text = "Условие";
            // 
            // textBoxTask_BDA
            // 
            this.textBoxTask_BDA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_BDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_BDA.Location = new System.Drawing.Point(2, 15);
            this.textBoxTask_BDA.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTask_BDA.Multiline = true;
            this.textBoxTask_BDA.Name = "textBoxTask_BDA";
            this.textBoxTask_BDA.Size = new System.Drawing.Size(433, 72);
            this.textBoxTask_BDA.TabIndex = 0;
            this.textBoxTask_BDA.TabStop = false;
            this.textBoxTask_BDA.Text = "Прочитать данные из файла InPutFileTask5V22.txt. Вывести в DataGridView\r\nзначения" +
    " большие 5 и построить диаграмму по этим значениям.";
            // 
            // panelOutPut_BDA
            // 
            this.panelOutPut_BDA.Controls.Add(this.groupBoxOutPut_BDA);
            this.panelOutPut_BDA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOutPut_BDA.Location = new System.Drawing.Point(0, 89);
            this.panelOutPut_BDA.Margin = new System.Windows.Forms.Padding(2);
            this.panelOutPut_BDA.Name = "panelOutPut_BDA";
            this.panelOutPut_BDA.Size = new System.Drawing.Size(260, 323);
            this.panelOutPut_BDA.TabIndex = 1;
            // 
            // groupBoxOutPut_BDA
            // 
            this.groupBoxOutPut_BDA.Controls.Add(this.dataGridViewOutPut_BDA);
            this.groupBoxOutPut_BDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPut_BDA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPut_BDA.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxOutPut_BDA.Name = "groupBoxOutPut_BDA";
            this.groupBoxOutPut_BDA.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxOutPut_BDA.Size = new System.Drawing.Size(260, 323);
            this.groupBoxOutPut_BDA.TabIndex = 0;
            this.groupBoxOutPut_BDA.TabStop = false;
            this.groupBoxOutPut_BDA.Text = "Вывод данных:";
            // 
            // dataGridViewOutPut_BDA
            // 
            this.dataGridViewOutPut_BDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutPut_BDA.ColumnHeadersVisible = false;
            this.dataGridViewOutPut_BDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOutPut_BDA.Location = new System.Drawing.Point(2, 15);
            this.dataGridViewOutPut_BDA.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewOutPut_BDA.Name = "dataGridViewOutPut_BDA";
            this.dataGridViewOutPut_BDA.RowHeadersVisible = false;
            this.dataGridViewOutPut_BDA.RowHeadersWidth = 51;
            this.dataGridViewOutPut_BDA.RowTemplate.Height = 24;
            this.dataGridViewOutPut_BDA.Size = new System.Drawing.Size(256, 306);
            this.dataGridViewOutPut_BDA.TabIndex = 0;
            // 
            // splitterOutPut_BDA
            // 
            this.splitterOutPut_BDA.Location = new System.Drawing.Point(260, 89);
            this.splitterOutPut_BDA.Margin = new System.Windows.Forms.Padding(2);
            this.splitterOutPut_BDA.Name = "splitterOutPut_BDA";
            this.splitterOutPut_BDA.Size = new System.Drawing.Size(6, 323);
            this.splitterOutPut_BDA.TabIndex = 2;
            this.splitterOutPut_BDA.TabStop = false;
            // 
            // panelGraph_BDA
            // 
            this.panelGraph_BDA.Controls.Add(this.chartGraph_BDA);
            this.panelGraph_BDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGraph_BDA.Location = new System.Drawing.Point(266, 89);
            this.panelGraph_BDA.Margin = new System.Windows.Forms.Padding(2);
            this.panelGraph_BDA.Name = "panelGraph_BDA";
            this.panelGraph_BDA.Size = new System.Drawing.Size(556, 323);
            this.panelGraph_BDA.TabIndex = 3;
            // 
            // chartGraph_BDA
            // 
            chartArea1.Name = "ChartArea1";
            this.chartGraph_BDA.ChartAreas.Add(chartArea1);
            this.chartGraph_BDA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartGraph_BDA.Legends.Add(legend1);
            this.chartGraph_BDA.Location = new System.Drawing.Point(0, 0);
            this.chartGraph_BDA.Name = "chartGraph_BDA";
            this.chartGraph_BDA.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartGraph_BDA.Series.Add(series1);
            this.chartGraph_BDA.Size = new System.Drawing.Size(556, 323);
            this.chartGraph_BDA.TabIndex = 0;
            this.chartGraph_BDA.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 412);
            this.Controls.Add(this.panelGraph_BDA);
            this.Controls.Add(this.splitterOutPut_BDA);
            this.Controls.Add(this.panelOutPut_BDA);
            this.Controls.Add(this.panelTask_BDA);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 |  Вариант 22 | Брацун Д.А.";
            this.panelTask_BDA.ResumeLayout(false);
            this.groupBoxTask_BDA.ResumeLayout(false);
            this.groupBoxTask_BDA.PerformLayout();
            this.panelOutPut_BDA.ResumeLayout(false);
            this.groupBoxOutPut_BDA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_BDA)).EndInit();
            this.panelGraph_BDA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartGraph_BDA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTask_BDA;
        private System.Windows.Forms.Panel panelOutPut_BDA;
        private System.Windows.Forms.GroupBox groupBoxOutPut_BDA;
        private System.Windows.Forms.DataGridView dataGridViewOutPut_BDA;
        private System.Windows.Forms.Splitter splitterOutPut_BDA;
        private System.Windows.Forms.Panel panelGraph_BDA;
        private System.Windows.Forms.Button buttonInfo_BDA;
        private System.Windows.Forms.Button buttonOpenFile_BDA;
        private System.Windows.Forms.Button buttonDone_BDA;
        private System.Windows.Forms.GroupBox groupBoxTask_BDA;
        private System.Windows.Forms.TextBox textBoxTask_BDA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraph_BDA;
    }
}