
namespace Tyuiu.BratsunDA.Sprint6.Task4.V12
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonHelp_BDA = new System.Windows.Forms.Button();
            this.buttonDone_BDA = new System.Windows.Forms.Button();
            this.groupBoxOutput_BDA = new System.Windows.Forms.GroupBox();
            this.chartFunction_BDA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxResult_BDA = new System.Windows.Forms.TextBox();
            this.groupBoxInput_BDA = new System.Windows.Forms.GroupBox();
            this.labelVarStop_BDA = new System.Windows.Forms.Label();
            this.textBoxVarStop_BDA = new System.Windows.Forms.TextBox();
            this.labelVarStart_BDA = new System.Windows.Forms.Label();
            this.textBoxVarStart_BDA = new System.Windows.Forms.TextBox();
            this.groupBoxTask_BDA = new System.Windows.Forms.GroupBox();
            this.pictureBoxFormula_BDA = new System.Windows.Forms.PictureBox();
            this.textBoxData_BDA = new System.Windows.Forms.TextBox();
            this.buttonSave_BDA = new System.Windows.Forms.Button();
            this.groupBoxOutput_BDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_BDA)).BeginInit();
            this.groupBoxInput_BDA.SuspendLayout();
            this.groupBoxTask_BDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_BDA)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonHelp_BDA
            // 
            this.buttonHelp_BDA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonHelp_BDA.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonHelp_BDA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonHelp_BDA.Location = new System.Drawing.Point(381, 210);
            this.buttonHelp_BDA.Name = "buttonHelp_BDA";
            this.buttonHelp_BDA.Size = new System.Drawing.Size(122, 40);
            this.buttonHelp_BDA.TabIndex = 19;
            this.buttonHelp_BDA.Text = "Справка";
            this.buttonHelp_BDA.UseVisualStyleBackColor = false;
            this.buttonHelp_BDA.Click += new System.EventHandler(this.buttonHelp_BDA_Click);
            // 
            // buttonDone_BDA
            // 
            this.buttonDone_BDA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDone_BDA.BackColor = System.Drawing.Color.Lime;
            this.buttonDone_BDA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDone_BDA.Location = new System.Drawing.Point(381, 164);
            this.buttonDone_BDA.Name = "buttonDone_BDA";
            this.buttonDone_BDA.Size = new System.Drawing.Size(122, 40);
            this.buttonDone_BDA.TabIndex = 18;
            this.buttonDone_BDA.Text = "Выполнить";
            this.buttonDone_BDA.UseVisualStyleBackColor = false;
            this.buttonDone_BDA.Click += new System.EventHandler(this.buttonDone_BDA_Click);
            // 
            // groupBoxOutput_BDA
            // 
            this.groupBoxOutput_BDA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOutput_BDA.Controls.Add(this.chartFunction_BDA);
            this.groupBoxOutput_BDA.Controls.Add(this.textBoxResult_BDA);
            this.groupBoxOutput_BDA.Location = new System.Drawing.Point(512, 12);
            this.groupBoxOutput_BDA.Name = "groupBoxOutput_BDA";
            this.groupBoxOutput_BDA.Size = new System.Drawing.Size(548, 292);
            this.groupBoxOutput_BDA.TabIndex = 17;
            this.groupBoxOutput_BDA.TabStop = false;
            this.groupBoxOutput_BDA.Text = "Вывод данных";
            // 
            // chartFunction_BDA
            // 
            chartArea3.Name = "ChartArea1";
            this.chartFunction_BDA.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartFunction_BDA.Legends.Add(legend3);
            this.chartFunction_BDA.Location = new System.Drawing.Point(184, 12);
            this.chartFunction_BDA.Name = "chartFunction_BDA";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartFunction_BDA.Series.Add(series3);
            this.chartFunction_BDA.Size = new System.Drawing.Size(358, 274);
            this.chartFunction_BDA.TabIndex = 9;
            this.chartFunction_BDA.Text = "chart1";
            // 
            // textBoxResult_BDA
            // 
            this.textBoxResult_BDA.Location = new System.Drawing.Point(16, 29);
            this.textBoxResult_BDA.Multiline = true;
            this.textBoxResult_BDA.Name = "textBoxResult_BDA";
            this.textBoxResult_BDA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_BDA.Size = new System.Drawing.Size(146, 239);
            this.textBoxResult_BDA.TabIndex = 8;
            // 
            // groupBoxInput_BDA
            // 
            this.groupBoxInput_BDA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxInput_BDA.Controls.Add(this.labelVarStop_BDA);
            this.groupBoxInput_BDA.Controls.Add(this.textBoxVarStop_BDA);
            this.groupBoxInput_BDA.Controls.Add(this.labelVarStart_BDA);
            this.groupBoxInput_BDA.Controls.Add(this.textBoxVarStart_BDA);
            this.groupBoxInput_BDA.Location = new System.Drawing.Point(12, 161);
            this.groupBoxInput_BDA.Name = "groupBoxInput_BDA";
            this.groupBoxInput_BDA.Size = new System.Drawing.Size(363, 87);
            this.groupBoxInput_BDA.TabIndex = 16;
            this.groupBoxInput_BDA.TabStop = false;
            this.groupBoxInput_BDA.Text = "Ввод данных";
            // 
            // labelVarStop_BDA
            // 
            this.labelVarStop_BDA.AutoSize = true;
            this.labelVarStop_BDA.Location = new System.Drawing.Point(188, 30);
            this.labelVarStop_BDA.Name = "labelVarStop_BDA";
            this.labelVarStop_BDA.Size = new System.Drawing.Size(69, 13);
            this.labelVarStop_BDA.TabIndex = 3;
            this.labelVarStop_BDA.Text = "Конец шага:";
            // 
            // textBoxVarStop_BDA
            // 
            this.textBoxVarStop_BDA.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxVarStop_BDA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxVarStop_BDA.Location = new System.Drawing.Point(191, 46);
            this.textBoxVarStop_BDA.Name = "textBoxVarStop_BDA";
            this.textBoxVarStop_BDA.Size = new System.Drawing.Size(152, 20);
            this.textBoxVarStop_BDA.TabIndex = 2;
            // 
            // labelVarStart_BDA
            // 
            this.labelVarStart_BDA.AutoSize = true;
            this.labelVarStart_BDA.Location = new System.Drawing.Point(16, 30);
            this.labelVarStart_BDA.Name = "labelVarStart_BDA";
            this.labelVarStart_BDA.Size = new System.Drawing.Size(67, 13);
            this.labelVarStart_BDA.TabIndex = 1;
            this.labelVarStart_BDA.Text = "Старт шага:";
            // 
            // textBoxVarStart_BDA
            // 
            this.textBoxVarStart_BDA.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxVarStart_BDA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxVarStart_BDA.Location = new System.Drawing.Point(19, 46);
            this.textBoxVarStart_BDA.Name = "textBoxVarStart_BDA";
            this.textBoxVarStart_BDA.Size = new System.Drawing.Size(152, 20);
            this.textBoxVarStart_BDA.TabIndex = 0;
            // 
            // groupBoxTask_BDA
            // 
            this.groupBoxTask_BDA.Controls.Add(this.pictureBoxFormula_BDA);
            this.groupBoxTask_BDA.Controls.Add(this.textBoxData_BDA);
            this.groupBoxTask_BDA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_BDA.Name = "groupBoxTask_BDA";
            this.groupBoxTask_BDA.Size = new System.Drawing.Size(479, 131);
            this.groupBoxTask_BDA.TabIndex = 15;
            this.groupBoxTask_BDA.TabStop = false;
            this.groupBoxTask_BDA.Text = "Условие";
            // 
            // pictureBoxFormula_BDA
            // 
            this.pictureBoxFormula_BDA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_BDA.Image")));
            this.pictureBoxFormula_BDA.Location = new System.Drawing.Point(58, 77);
            this.pictureBoxFormula_BDA.Name = "pictureBoxFormula_BDA";
            this.pictureBoxFormula_BDA.Size = new System.Drawing.Size(359, 35);
            this.pictureBoxFormula_BDA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxFormula_BDA.TabIndex = 1;
            this.pictureBoxFormula_BDA.TabStop = false;
            // 
            // textBoxData_BDA
            // 
            this.textBoxData_BDA.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxData_BDA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxData_BDA.Location = new System.Drawing.Point(19, 19);
            this.textBoxData_BDA.Multiline = true;
            this.textBoxData_BDA.Name = "textBoxData_BDA";
            this.textBoxData_BDA.ReadOnly = true;
            this.textBoxData_BDA.Size = new System.Drawing.Size(454, 64);
            this.textBoxData_BDA.TabIndex = 0;
            this.textBoxData_BDA.TabStop = false;
            this.textBoxData_BDA.Text = "Протабулировать функцию с шагом 1. Вывести значения в таблицу и создать график фу" +
    "нкции.";
            // 
            // buttonSave_BDA
            // 
            this.buttonSave_BDA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSave_BDA.BackColor = System.Drawing.Color.Yellow;
            this.buttonSave_BDA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSave_BDA.Location = new System.Drawing.Point(134, 264);
            this.buttonSave_BDA.Name = "buttonSave_BDA";
            this.buttonSave_BDA.Size = new System.Drawing.Size(122, 40);
            this.buttonSave_BDA.TabIndex = 18;
            this.buttonSave_BDA.Text = "Сохранить";
            this.buttonSave_BDA.UseVisualStyleBackColor = false;
            this.buttonSave_BDA.Click += new System.EventHandler(this.buttonSave_BDA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 321);
            this.Controls.Add(this.buttonHelp_BDA);
            this.Controls.Add(this.buttonSave_BDA);
            this.Controls.Add(this.buttonDone_BDA);
            this.Controls.Add(this.groupBoxOutput_BDA);
            this.Controls.Add(this.groupBoxInput_BDA);
            this.Controls.Add(this.groupBoxTask_BDA);
            this.MinimumSize = new System.Drawing.Size(1093, 360);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 12 | Брацун Д. А.";
            this.groupBoxOutput_BDA.ResumeLayout(false);
            this.groupBoxOutput_BDA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_BDA)).EndInit();
            this.groupBoxInput_BDA.ResumeLayout(false);
            this.groupBoxInput_BDA.PerformLayout();
            this.groupBoxTask_BDA.ResumeLayout(false);
            this.groupBoxTask_BDA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_BDA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonHelp_BDA;
        private System.Windows.Forms.Button buttonDone_BDA;
        private System.Windows.Forms.GroupBox groupBoxOutput_BDA;
        private System.Windows.Forms.GroupBox groupBoxInput_BDA;
        private System.Windows.Forms.Label labelVarStop_BDA;
        private System.Windows.Forms.TextBox textBoxVarStop_BDA;
        private System.Windows.Forms.Label labelVarStart_BDA;
        private System.Windows.Forms.TextBox textBoxVarStart_BDA;
        private System.Windows.Forms.GroupBox groupBoxTask_BDA;
        private System.Windows.Forms.PictureBox pictureBoxFormula_BDA;
        private System.Windows.Forms.TextBox textBoxData_BDA;
        private System.Windows.Forms.Button buttonSave_BDA;
        private System.Windows.Forms.TextBox textBoxResult_BDA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_BDA;
    }
}