
namespace Tyuiu.BratsunDA.Sprint6.Task1.V6
{
    partial class FormMain_BDA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_BDA));
            this.buttonDone_BDA = new System.Windows.Forms.Button();
            this.buttonInfo_BDA = new System.Windows.Forms.Button();
            this.groupBoxInput_BDA = new System.Windows.Forms.GroupBox();
            this.labelStopStep_BDA = new System.Windows.Forms.Label();
            this.labelStartStep_BDA = new System.Windows.Forms.Label();
            this.textBoxStopStep_BDA = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_BDA = new System.Windows.Forms.TextBox();
            this.groupBoxTask_BDA = new System.Windows.Forms.GroupBox();
            this.pictureBoxTask_BDA = new System.Windows.Forms.PictureBox();
            this.textBoxTask_BDA = new System.Windows.Forms.TextBox();
            this.groupBoxResult_BDA = new System.Windows.Forms.GroupBox();
            this.labelResult_BDA = new System.Windows.Forms.Label();
            this.textBoxResult_BDA = new System.Windows.Forms.TextBox();
            this.groupBoxInput_BDA.SuspendLayout();
            this.groupBoxTask_BDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask_BDA)).BeginInit();
            this.groupBoxResult_BDA.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDone_BDA
            // 
            this.buttonDone_BDA.BackColor = System.Drawing.Color.Green;
            this.buttonDone_BDA.Location = new System.Drawing.Point(342, 292);
            this.buttonDone_BDA.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDone_BDA.Name = "buttonDone_BDA";
            this.buttonDone_BDA.Size = new System.Drawing.Size(104, 50);
            this.buttonDone_BDA.TabIndex = 0;
            this.buttonDone_BDA.Text = "Выполнить";
            this.buttonDone_BDA.UseMnemonic = false;
            this.buttonDone_BDA.UseVisualStyleBackColor = false;
            this.buttonDone_BDA.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonInfo_BDA
            // 
            this.buttonInfo_BDA.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonInfo_BDA.Location = new System.Drawing.Point(264, 292);
            this.buttonInfo_BDA.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInfo_BDA.Name = "buttonInfo_BDA";
            this.buttonInfo_BDA.Size = new System.Drawing.Size(74, 50);
            this.buttonInfo_BDA.TabIndex = 1;
            this.buttonInfo_BDA.Text = "Справка";
            this.buttonInfo_BDA.UseVisualStyleBackColor = false;
            this.buttonInfo_BDA.Click += new System.EventHandler(this.buttonInfo_BDA_Click);
            // 
            // groupBoxInput_BDA
            // 
            this.groupBoxInput_BDA.Controls.Add(this.labelStopStep_BDA);
            this.groupBoxInput_BDA.Controls.Add(this.labelStartStep_BDA);
            this.groupBoxInput_BDA.Controls.Add(this.textBoxStopStep_BDA);
            this.groupBoxInput_BDA.Controls.Add(this.textBoxStartStep_BDA);
            this.groupBoxInput_BDA.Location = new System.Drawing.Point(9, 288);
            this.groupBoxInput_BDA.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxInput_BDA.Name = "groupBoxInput_BDA";
            this.groupBoxInput_BDA.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxInput_BDA.Size = new System.Drawing.Size(243, 55);
            this.groupBoxInput_BDA.TabIndex = 2;
            this.groupBoxInput_BDA.TabStop = false;
            this.groupBoxInput_BDA.Text = "Ввод данных";
            // 
            // labelStopStep_BDA
            // 
            this.labelStopStep_BDA.AutoSize = true;
            this.labelStopStep_BDA.Location = new System.Drawing.Point(124, 16);
            this.labelStopStep_BDA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStopStep_BDA.Name = "labelStopStep_BDA";
            this.labelStopStep_BDA.Size = new System.Drawing.Size(69, 13);
            this.labelStopStep_BDA.TabIndex = 3;
            this.labelStopStep_BDA.Text = "Конец шага:";
            // 
            // labelStartStep_BDA
            // 
            this.labelStartStep_BDA.AutoSize = true;
            this.labelStartStep_BDA.Location = new System.Drawing.Point(4, 16);
            this.labelStartStep_BDA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStartStep_BDA.Name = "labelStartStep_BDA";
            this.labelStartStep_BDA.Size = new System.Drawing.Size(67, 13);
            this.labelStartStep_BDA.TabIndex = 2;
            this.labelStartStep_BDA.Text = "Старт шага:";
            // 
            // textBoxStopStep_BDA
            // 
            this.textBoxStopStep_BDA.Location = new System.Drawing.Point(127, 32);
            this.textBoxStopStep_BDA.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxStopStep_BDA.Name = "textBoxStopStep_BDA";
            this.textBoxStopStep_BDA.Size = new System.Drawing.Size(111, 20);
            this.textBoxStopStep_BDA.TabIndex = 1;
            // 
            // textBoxStartStep_BDA
            // 
            this.textBoxStartStep_BDA.Location = new System.Drawing.Point(4, 32);
            this.textBoxStartStep_BDA.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxStartStep_BDA.Name = "textBoxStartStep_BDA";
            this.textBoxStartStep_BDA.Size = new System.Drawing.Size(109, 20);
            this.textBoxStartStep_BDA.TabIndex = 0;
            this.textBoxStartStep_BDA.TextChanged += new System.EventHandler(this.textBoxStartStep_BDA_TextChanged);
            // 
            // groupBoxTask_BDA
            // 
            this.groupBoxTask_BDA.Controls.Add(this.pictureBoxTask_BDA);
            this.groupBoxTask_BDA.Controls.Add(this.textBoxTask_BDA);
            this.groupBoxTask_BDA.Location = new System.Drawing.Point(10, 8);
            this.groupBoxTask_BDA.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxTask_BDA.Name = "groupBoxTask_BDA";
            this.groupBoxTask_BDA.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxTask_BDA.Size = new System.Drawing.Size(435, 280);
            this.groupBoxTask_BDA.TabIndex = 3;
            this.groupBoxTask_BDA.TabStop = false;
            this.groupBoxTask_BDA.Text = "Условие";
            // 
            // pictureBoxTask_BDA
            // 
            this.pictureBoxTask_BDA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTask_BDA.Image")));
            this.pictureBoxTask_BDA.Location = new System.Drawing.Point(8, 58);
            this.pictureBoxTask_BDA.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxTask_BDA.Name = "pictureBoxTask_BDA";
            this.pictureBoxTask_BDA.Size = new System.Drawing.Size(335, 39);
            this.pictureBoxTask_BDA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxTask_BDA.TabIndex = 1;
            this.pictureBoxTask_BDA.TabStop = false;
            // 
            // textBoxTask_BDA
            // 
            this.textBoxTask_BDA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_BDA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_BDA.Location = new System.Drawing.Point(8, 20);
            this.textBoxTask_BDA.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTask_BDA.Multiline = true;
            this.textBoxTask_BDA.Name = "textBoxTask_BDA";
            this.textBoxTask_BDA.Size = new System.Drawing.Size(284, 71);
            this.textBoxTask_BDA.TabIndex = 0;
            this.textBoxTask_BDA.Text = "Протабулировать функцию на заданном диапазоне. Результат вывести в  виде таблицы." +
    "";
            // 
            // groupBoxResult_BDA
            // 
            this.groupBoxResult_BDA.Controls.Add(this.labelResult_BDA);
            this.groupBoxResult_BDA.Controls.Add(this.textBoxResult_BDA);
            this.groupBoxResult_BDA.Location = new System.Drawing.Point(457, 15);
            this.groupBoxResult_BDA.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxResult_BDA.Name = "groupBoxResult_BDA";
            this.groupBoxResult_BDA.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxResult_BDA.Size = new System.Drawing.Size(242, 327);
            this.groupBoxResult_BDA.TabIndex = 4;
            this.groupBoxResult_BDA.TabStop = false;
            this.groupBoxResult_BDA.Text = "Вывод данных";
            // 
            // labelResult_BDA
            // 
            this.labelResult_BDA.AutoSize = true;
            this.labelResult_BDA.Location = new System.Drawing.Point(4, 16);
            this.labelResult_BDA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelResult_BDA.Name = "labelResult_BDA";
            this.labelResult_BDA.Size = new System.Drawing.Size(62, 13);
            this.labelResult_BDA.TabIndex = 1;
            this.labelResult_BDA.Text = "Результат:";
            this.labelResult_BDA.Click += new System.EventHandler(this.labelResult_BDA_Click);
            // 
            // textBoxResult_BDA
            // 
            this.textBoxResult_BDA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxResult_BDA.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult_BDA.Location = new System.Drawing.Point(4, 32);
            this.textBoxResult_BDA.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxResult_BDA.Multiline = true;
            this.textBoxResult_BDA.Name = "textBoxResult_BDA";
            this.textBoxResult_BDA.ReadOnly = true;
            this.textBoxResult_BDA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_BDA.Size = new System.Drawing.Size(234, 291);
            this.textBoxResult_BDA.TabIndex = 0;
            // 
            // FormMain_BDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 366);
            this.Controls.Add(this.groupBoxResult_BDA);
            this.Controls.Add(this.groupBoxTask_BDA);
            this.Controls.Add(this.groupBoxInput_BDA);
            this.Controls.Add(this.buttonInfo_BDA);
            this.Controls.Add(this.buttonDone_BDA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormMain_BDA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 |  Вариант 6 | Брацун Д.А.";
            this.groupBoxInput_BDA.ResumeLayout(false);
            this.groupBoxInput_BDA.PerformLayout();
            this.groupBoxTask_BDA.ResumeLayout(false);
            this.groupBoxTask_BDA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask_BDA)).EndInit();
            this.groupBoxResult_BDA.ResumeLayout(false);
            this.groupBoxResult_BDA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDone_BDA;
        private System.Windows.Forms.Button buttonInfo_BDA;
        private System.Windows.Forms.GroupBox groupBoxInput_BDA;
        private System.Windows.Forms.Label labelStopStep_BDA;
        private System.Windows.Forms.Label labelStartStep_BDA;
        private System.Windows.Forms.TextBox textBoxStopStep_BDA;
        private System.Windows.Forms.TextBox textBoxStartStep_BDA;
        private System.Windows.Forms.GroupBox groupBoxTask_BDA;
        private System.Windows.Forms.TextBox textBoxTask_BDA;
        private System.Windows.Forms.GroupBox groupBoxResult_BDA;
        private System.Windows.Forms.Label labelResult_BDA;
        private System.Windows.Forms.TextBox textBoxResult_BDA;
        private System.Windows.Forms.PictureBox pictureBoxTask_BDA;
    }
}