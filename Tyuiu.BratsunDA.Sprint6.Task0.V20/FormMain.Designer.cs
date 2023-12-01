
namespace Tyuiu.BratsunDA.Sprint6.Task0.V20
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxTask_BDA = new System.Windows.Forms.GroupBox();
            this.pictureBoxFormula_BDA = new System.Windows.Forms.PictureBox();
            this.textBoxTask_BDA = new System.Windows.Forms.TextBox();
            this.groupBoxInput_BDA = new System.Windows.Forms.GroupBox();
            this.labelVarX_BDA = new System.Windows.Forms.Label();
            this.textBoxVarX_BDA = new System.Windows.Forms.TextBox();
            this.groupBoxOutput_BDA = new System.Windows.Forms.GroupBox();
            this.textBoxResult_BDA = new System.Windows.Forms.TextBox();
            this.labelResult_BDA = new System.Windows.Forms.Label();
            this.buttonDone_BDA = new System.Windows.Forms.Button();
            this.buttonHelp_BDA = new System.Windows.Forms.Button();
            this.groupBoxTask_BDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_BDA)).BeginInit();
            this.groupBoxInput_BDA.SuspendLayout();
            this.groupBoxOutput_BDA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_BDA
            // 
            this.groupBoxTask_BDA.Controls.Add(this.pictureBoxFormula_BDA);
            this.groupBoxTask_BDA.Controls.Add(this.textBoxTask_BDA);
            this.groupBoxTask_BDA.Location = new System.Drawing.Point(27, 26);
            this.groupBoxTask_BDA.Name = "groupBoxTask_BDA";
            this.groupBoxTask_BDA.Size = new System.Drawing.Size(468, 118);
            this.groupBoxTask_BDA.TabIndex = 0;
            this.groupBoxTask_BDA.TabStop = false;
            this.groupBoxTask_BDA.Text = "Условие";
            // 
            // pictureBoxFormula_BDA
            // 
            this.pictureBoxFormula_BDA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_BDA.Image")));
            this.pictureBoxFormula_BDA.Location = new System.Drawing.Point(326, 19);
            this.pictureBoxFormula_BDA.Name = "pictureBoxFormula_BDA";
            this.pictureBoxFormula_BDA.Size = new System.Drawing.Size(122, 60);
            this.pictureBoxFormula_BDA.TabIndex = 3;
            this.pictureBoxFormula_BDA.TabStop = false;
            // 
            // textBoxTask_BDA
            // 
            this.textBoxTask_BDA.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxTask_BDA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_BDA.Location = new System.Drawing.Point(19, 19);
            this.textBoxTask_BDA.Multiline = true;
            this.textBoxTask_BDA.Name = "textBoxTask_BDA";
            this.textBoxTask_BDA.ReadOnly = true;
            this.textBoxTask_BDA.Size = new System.Drawing.Size(278, 78);
            this.textBoxTask_BDA.TabIndex = 0;
            this.textBoxTask_BDA.Text = "Дано выражение вычислить его значение при x = 3.";
            // 
            // groupBoxInput_BDA
            // 
            this.groupBoxInput_BDA.Controls.Add(this.labelVarX_BDA);
            this.groupBoxInput_BDA.Controls.Add(this.textBoxVarX_BDA);
            this.groupBoxInput_BDA.Location = new System.Drawing.Point(27, 166);
            this.groupBoxInput_BDA.Name = "groupBoxInput_BDA";
            this.groupBoxInput_BDA.Size = new System.Drawing.Size(190, 87);
            this.groupBoxInput_BDA.TabIndex = 1;
            this.groupBoxInput_BDA.TabStop = false;
            this.groupBoxInput_BDA.Text = "Ввод данных";
            // 
            // labelVarX_BDA
            // 
            this.labelVarX_BDA.AutoSize = true;
            this.labelVarX_BDA.Location = new System.Drawing.Point(16, 30);
            this.labelVarX_BDA.Name = "labelVarX_BDA";
            this.labelVarX_BDA.Size = new System.Drawing.Size(84, 13);
            this.labelVarX_BDA.TabIndex = 1;
            this.labelVarX_BDA.Text = "Переменная X:";
            // 
            // textBoxVarX_BDA
            // 
            this.textBoxVarX_BDA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxVarX_BDA.Location = new System.Drawing.Point(19, 46);
            this.textBoxVarX_BDA.Name = "textBoxVarX_BDA";
            this.textBoxVarX_BDA.Size = new System.Drawing.Size(152, 20);
            this.textBoxVarX_BDA.TabIndex = 0;
            this.textBoxVarX_BDA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarX_BDA_KeyPress);
            // 
            // groupBoxOutput_BDA
            // 
            this.groupBoxOutput_BDA.Controls.Add(this.textBoxResult_BDA);
            this.groupBoxOutput_BDA.Controls.Add(this.labelResult_BDA);
            this.groupBoxOutput_BDA.Location = new System.Drawing.Point(290, 166);
            this.groupBoxOutput_BDA.Name = "groupBoxOutput_BDA";
            this.groupBoxOutput_BDA.Size = new System.Drawing.Size(205, 87);
            this.groupBoxOutput_BDA.TabIndex = 2;
            this.groupBoxOutput_BDA.TabStop = false;
            this.groupBoxOutput_BDA.Text = "Вывод данных";
            // 
            // textBoxResult_BDA
            // 
            this.textBoxResult_BDA.Location = new System.Drawing.Point(26, 46);
            this.textBoxResult_BDA.Name = "textBoxResult_BDA";
            this.textBoxResult_BDA.ReadOnly = true;
            this.textBoxResult_BDA.Size = new System.Drawing.Size(159, 20);
            this.textBoxResult_BDA.TabIndex = 4;
            // 
            // labelResult_BDA
            // 
            this.labelResult_BDA.AutoSize = true;
            this.labelResult_BDA.Location = new System.Drawing.Point(23, 30);
            this.labelResult_BDA.Name = "labelResult_BDA";
            this.labelResult_BDA.Size = new System.Drawing.Size(62, 13);
            this.labelResult_BDA.TabIndex = 3;
            this.labelResult_BDA.Text = "Результат:";
            // 
            // buttonDone_BDA
            // 
            this.buttonDone_BDA.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDone_BDA.Location = new System.Drawing.Point(353, 270);
            this.buttonDone_BDA.Name = "buttonDone_BDA";
            this.buttonDone_BDA.Size = new System.Drawing.Size(122, 40);
            this.buttonDone_BDA.TabIndex = 3;
            this.buttonDone_BDA.Text = "Выполнить";
            this.buttonDone_BDA.UseVisualStyleBackColor = false;
            this.buttonDone_BDA.Click += new System.EventHandler(this.buttonDone_BDA_Click);
            // 
            // buttonHelp_BDA
            // 
            this.buttonHelp_BDA.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonHelp_BDA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_BDA.Location = new System.Drawing.Point(290, 270);
            this.buttonHelp_BDA.Name = "buttonHelp_BDA";
            this.buttonHelp_BDA.Size = new System.Drawing.Size(48, 40);
            this.buttonHelp_BDA.TabIndex = 4;
            this.buttonHelp_BDA.Text = "?";
            this.buttonHelp_BDA.UseVisualStyleBackColor = false;
            this.buttonHelp_BDA.Click += new System.EventHandler(this.buttonHelp_BDA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(511, 335);
            this.Controls.Add(this.buttonHelp_BDA);
            this.Controls.Add(this.buttonDone_BDA);
            this.Controls.Add(this.groupBoxOutput_BDA);
            this.Controls.Add(this.groupBoxInput_BDA);
            this.Controls.Add(this.groupBoxTask_BDA);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 0 | Вариант 20 | Брацун Д. А.";
            this.groupBoxTask_BDA.ResumeLayout(false);
            this.groupBoxTask_BDA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_BDA)).EndInit();
            this.groupBoxInput_BDA.ResumeLayout(false);
            this.groupBoxInput_BDA.PerformLayout();
            this.groupBoxOutput_BDA.ResumeLayout(false);
            this.groupBoxOutput_BDA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_BDA;
        private System.Windows.Forms.PictureBox pictureBoxFormula_BDA;
        private System.Windows.Forms.TextBox textBoxTask_BDA;
        private System.Windows.Forms.GroupBox groupBoxInput_BDA;
        private System.Windows.Forms.Label labelVarX_BDA;
        private System.Windows.Forms.TextBox textBoxVarX_BDA;
        private System.Windows.Forms.GroupBox groupBoxOutput_BDA;
        private System.Windows.Forms.Label labelResult_BDA;
        private System.Windows.Forms.Button buttonDone_BDA;
        private System.Windows.Forms.Button buttonHelp_BDA;
        private System.Windows.Forms.TextBox textBoxResult_BDA;
    }
}
