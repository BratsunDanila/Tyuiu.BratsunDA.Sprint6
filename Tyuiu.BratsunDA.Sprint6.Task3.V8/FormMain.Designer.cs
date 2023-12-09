
namespace Tyuiu.BratsunDA.Sprint6.Task3.V8
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxCondition_BDA = new System.Windows.Forms.GroupBox();
            this.dataGridViewOriginalMatrix_BDA = new System.Windows.Forms.DataGridView();
            this.labelCondition_BDA = new System.Windows.Forms.Label();
            this.groupBoxOutputData_BDA = new System.Windows.Forms.GroupBox();
            this.labelResult_BDA = new System.Windows.Forms.Label();
            this.dataGridViewResultMatrix_BDA = new System.Windows.Forms.DataGridView();
            this.buttonDone_BDA = new System.Windows.Forms.Button();
            this.buttonHelp_BDA = new System.Windows.Forms.Button();
            this.groupBoxCondition_BDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOriginalMatrix_BDA)).BeginInit();
            this.groupBoxOutputData_BDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultMatrix_BDA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition_BDA
            // 
            this.groupBoxCondition_BDA.Controls.Add(this.dataGridViewOriginalMatrix_BDA);
            this.groupBoxCondition_BDA.Controls.Add(this.labelCondition_BDA);
            this.groupBoxCondition_BDA.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxCondition_BDA.Location = new System.Drawing.Point(9, 10);
            this.groupBoxCondition_BDA.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxCondition_BDA.Name = "groupBoxCondition_BDA";
            this.groupBoxCondition_BDA.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxCondition_BDA.Size = new System.Drawing.Size(517, 275);
            this.groupBoxCondition_BDA.TabIndex = 0;
            this.groupBoxCondition_BDA.TabStop = false;
            this.groupBoxCondition_BDA.Text = "Условие";
            // 
            // dataGridViewOriginalMatrix_BDA
            // 
            this.dataGridViewOriginalMatrix_BDA.AllowUserToAddRows = false;
            this.dataGridViewOriginalMatrix_BDA.AllowUserToDeleteRows = false;
            this.dataGridViewOriginalMatrix_BDA.AllowUserToResizeColumns = false;
            this.dataGridViewOriginalMatrix_BDA.AllowUserToResizeRows = false;
            this.dataGridViewOriginalMatrix_BDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOriginalMatrix_BDA.ColumnHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOriginalMatrix_BDA.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewOriginalMatrix_BDA.Location = new System.Drawing.Point(289, 45);
            this.dataGridViewOriginalMatrix_BDA.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewOriginalMatrix_BDA.Name = "dataGridViewOriginalMatrix_BDA";
            this.dataGridViewOriginalMatrix_BDA.ReadOnly = true;
            this.dataGridViewOriginalMatrix_BDA.RowHeadersVisible = false;
            this.dataGridViewOriginalMatrix_BDA.RowHeadersWidth = 51;
            this.dataGridViewOriginalMatrix_BDA.RowTemplate.Height = 24;
            this.dataGridViewOriginalMatrix_BDA.Size = new System.Drawing.Size(203, 203);
            this.dataGridViewOriginalMatrix_BDA.TabIndex = 1;
            // 
            // labelCondition_BDA
            // 
            this.labelCondition_BDA.AutoSize = true;
            this.labelCondition_BDA.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCondition_BDA.Location = new System.Drawing.Point(5, 18);
            this.labelCondition_BDA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCondition_BDA.MaximumSize = new System.Drawing.Size(223, 406);
            this.labelCondition_BDA.Name = "labelCondition_BDA";
            this.labelCondition_BDA.Size = new System.Drawing.Size(216, 34);
            this.labelCondition_BDA.TabIndex = 0;
            this.labelCondition_BDA.Text = "Заменить четные элементы 4 строки в матрице на 0.";
            // 
            // groupBoxOutputData_BDA
            // 
            this.groupBoxOutputData_BDA.Controls.Add(this.labelResult_BDA);
            this.groupBoxOutputData_BDA.Controls.Add(this.dataGridViewResultMatrix_BDA);
            this.groupBoxOutputData_BDA.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxOutputData_BDA.Location = new System.Drawing.Point(530, 10);
            this.groupBoxOutputData_BDA.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxOutputData_BDA.Name = "groupBoxOutputData_BDA";
            this.groupBoxOutputData_BDA.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxOutputData_BDA.Size = new System.Drawing.Size(257, 275);
            this.groupBoxOutputData_BDA.TabIndex = 1;
            this.groupBoxOutputData_BDA.TabStop = false;
            this.groupBoxOutputData_BDA.Text = "Вывод данных";
            // 
            // labelResult_BDA
            // 
            this.labelResult_BDA.AutoSize = true;
            this.labelResult_BDA.Location = new System.Drawing.Point(5, 15);
            this.labelResult_BDA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelResult_BDA.Name = "labelResult_BDA";
            this.labelResult_BDA.Size = new System.Drawing.Size(88, 17);
            this.labelResult_BDA.TabIndex = 1;
            this.labelResult_BDA.Text = "Результат:";
            // 
            // dataGridViewResultMatrix_BDA
            // 
            this.dataGridViewResultMatrix_BDA.AllowUserToAddRows = false;
            this.dataGridViewResultMatrix_BDA.AllowUserToOrderColumns = true;
            this.dataGridViewResultMatrix_BDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultMatrix_BDA.ColumnHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewResultMatrix_BDA.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewResultMatrix_BDA.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewResultMatrix_BDA.Location = new System.Drawing.Point(26, 45);
            this.dataGridViewResultMatrix_BDA.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewResultMatrix_BDA.Name = "dataGridViewResultMatrix_BDA";
            this.dataGridViewResultMatrix_BDA.ReadOnly = true;
            this.dataGridViewResultMatrix_BDA.RowHeadersVisible = false;
            this.dataGridViewResultMatrix_BDA.RowHeadersWidth = 51;
            this.dataGridViewResultMatrix_BDA.RowTemplate.Height = 24;
            this.dataGridViewResultMatrix_BDA.Size = new System.Drawing.Size(203, 203);
            this.dataGridViewResultMatrix_BDA.TabIndex = 0;
            // 
            // buttonDone_BDA
            // 
            this.buttonDone_BDA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonDone_BDA.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_BDA.Location = new System.Drawing.Point(565, 289);
            this.buttonDone_BDA.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDone_BDA.Name = "buttonDone_BDA";
            this.buttonDone_BDA.Size = new System.Drawing.Size(203, 89);
            this.buttonDone_BDA.TabIndex = 2;
            this.buttonDone_BDA.Text = "Выполнить";
            this.buttonDone_BDA.UseVisualStyleBackColor = false;
            this.buttonDone_BDA.Click += new System.EventHandler(this.buttonDone_BDA_Click);
            // 
            // buttonHelp_BDA
            // 
            this.buttonHelp_BDA.BackColor = System.Drawing.Color.Aqua;
            this.buttonHelp_BDA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_BDA.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp_BDA.Location = new System.Drawing.Point(479, 289);
            this.buttonHelp_BDA.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHelp_BDA.Name = "buttonHelp_BDA";
            this.buttonHelp_BDA.Size = new System.Drawing.Size(82, 89);
            this.buttonHelp_BDA.TabIndex = 3;
            this.buttonHelp_BDA.Text = "?";
            this.buttonHelp_BDA.UseVisualStyleBackColor = false;
            this.buttonHelp_BDA.Click += new System.EventHandler(this.buttonHelp_BDA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 389);
            this.Controls.Add(this.buttonHelp_BDA);
            this.Controls.Add(this.buttonDone_BDA);
            this.Controls.Add(this.groupBoxOutputData_BDA);
            this.Controls.Add(this.groupBoxCondition_BDA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 8 | Брацун Д.А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxCondition_BDA.ResumeLayout(false);
            this.groupBoxCondition_BDA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOriginalMatrix_BDA)).EndInit();
            this.groupBoxOutputData_BDA.ResumeLayout(false);
            this.groupBoxOutputData_BDA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultMatrix_BDA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_BDA;
        private System.Windows.Forms.Label labelCondition_BDA;
        private System.Windows.Forms.DataGridView dataGridViewOriginalMatrix_BDA;
        private System.Windows.Forms.GroupBox groupBoxOutputData_BDA;
        private System.Windows.Forms.Label labelResult_BDA;
        private System.Windows.Forms.DataGridView dataGridViewResultMatrix_BDA;
        private System.Windows.Forms.Button buttonDone_BDA;
        private System.Windows.Forms.Button buttonHelp_BDA;
    }
}