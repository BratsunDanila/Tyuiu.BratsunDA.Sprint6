
namespace Tyuiu.BratsunDA.Sprint6.Task7.V12
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelButtons_BDA = new System.Windows.Forms.Panel();
            this.buttonHelp_BDA = new System.Windows.Forms.Button();
            this.buttonSaveFile_BDA = new System.Windows.Forms.Button();
            this.buttonDone_BDA = new System.Windows.Forms.Button();
            this.buttonOpenFile_BDA = new System.Windows.Forms.Button();
            this.panelTask_BDA = new System.Windows.Forms.Panel();
            this.groupBoxTask_BDA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_BDA = new System.Windows.Forms.TextBox();
            this.panelInput_BDA = new System.Windows.Forms.Panel();
            this.groupBoxInput_BDA = new System.Windows.Forms.GroupBox();
            this.dataGridViewInput_BDA = new System.Windows.Forms.DataGridView();
            this.splitterInput_BDA = new System.Windows.Forms.Splitter();
            this.panelOutPut_BDA = new System.Windows.Forms.Panel();
            this.groupBoxOutPut_BDA = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutPut_BDA = new System.Windows.Forms.DataGridView();
            this.openFileDialogTask_BDA = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogMatrix_BDA = new System.Windows.Forms.SaveFileDialog();
            this.toolTipButton_BDA = new System.Windows.Forms.ToolTip(this.components);
            this.panelButtons_BDA.SuspendLayout();
            this.panelTask_BDA.SuspendLayout();
            this.groupBoxTask_BDA.SuspendLayout();
            this.panelInput_BDA.SuspendLayout();
            this.groupBoxInput_BDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput_BDA)).BeginInit();
            this.panelOutPut_BDA.SuspendLayout();
            this.groupBoxOutPut_BDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_BDA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButtons_BDA
            // 
            this.panelButtons_BDA.Controls.Add(this.buttonHelp_BDA);
            this.panelButtons_BDA.Controls.Add(this.buttonSaveFile_BDA);
            this.panelButtons_BDA.Controls.Add(this.buttonDone_BDA);
            this.panelButtons_BDA.Controls.Add(this.buttonOpenFile_BDA);
            this.panelButtons_BDA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons_BDA.Location = new System.Drawing.Point(0, 0);
            this.panelButtons_BDA.Margin = new System.Windows.Forms.Padding(2);
            this.panelButtons_BDA.Name = "panelButtons_BDA";
            this.panelButtons_BDA.Size = new System.Drawing.Size(844, 72);
            this.panelButtons_BDA.TabIndex = 0;
            // 
            // buttonHelp_BDA
            // 
            this.buttonHelp_BDA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_BDA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_BDA.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_BDA.Image")));
            this.buttonHelp_BDA.Location = new System.Drawing.Point(751, 2);
            this.buttonHelp_BDA.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHelp_BDA.Name = "buttonHelp_BDA";
            this.buttonHelp_BDA.Size = new System.Drawing.Size(91, 67);
            this.buttonHelp_BDA.TabIndex = 0;
            this.toolTipButton_BDA.SetToolTip(this.buttonHelp_BDA, "Подсказка");
            this.buttonHelp_BDA.UseVisualStyleBackColor = true;
            this.buttonHelp_BDA.Click += new System.EventHandler(this.buttonHelp_BDA_Click);
            this.buttonHelp_BDA.MouseEnter += new System.EventHandler(this.buttonHelp_BDA_MouseEnter);
            // 
            // buttonSaveFile_BDA
            // 
            this.buttonSaveFile_BDA.Enabled = false;
            this.buttonSaveFile_BDA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveFile_BDA.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveFile_BDA.Image")));
            this.buttonSaveFile_BDA.Location = new System.Drawing.Point(196, 4);
            this.buttonSaveFile_BDA.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSaveFile_BDA.Name = "buttonSaveFile_BDA";
            this.buttonSaveFile_BDA.Size = new System.Drawing.Size(91, 67);
            this.buttonSaveFile_BDA.TabIndex = 0;
            this.toolTipButton_BDA.SetToolTip(this.buttonSaveFile_BDA, "Сохранить обработанные данные в файл в формате CSV");
            this.buttonSaveFile_BDA.UseVisualStyleBackColor = true;
            this.buttonSaveFile_BDA.Click += new System.EventHandler(this.buttonSaveFile_BDA_Click);
            this.buttonSaveFile_BDA.MouseEnter += new System.EventHandler(this.buttonSaveFile_BDA_MouseEnter);
            // 
            // buttonDone_BDA
            // 
            this.buttonDone_BDA.Enabled = false;
            this.buttonDone_BDA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_BDA.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_BDA.Image")));
            this.buttonDone_BDA.Location = new System.Drawing.Point(101, 4);
            this.buttonDone_BDA.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDone_BDA.Name = "buttonDone_BDA";
            this.buttonDone_BDA.Size = new System.Drawing.Size(91, 67);
            this.buttonDone_BDA.TabIndex = 0;
            this.toolTipButton_BDA.SetToolTip(this.buttonDone_BDA, "Выполнить обработку данных");
            this.buttonDone_BDA.UseVisualStyleBackColor = true;
            this.buttonDone_BDA.Click += new System.EventHandler(this.buttonDone_BDA_Click);
            this.buttonDone_BDA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_BDA_MouseDown);
            this.buttonDone_BDA.MouseEnter += new System.EventHandler(this.buttonDone_BDA_MouseEnter);
            // 
            // buttonOpenFile_BDA
            // 
            this.buttonOpenFile_BDA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFile_BDA.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_BDA.Image")));
            this.buttonOpenFile_BDA.Location = new System.Drawing.Point(6, 4);
            this.buttonOpenFile_BDA.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpenFile_BDA.Name = "buttonOpenFile_BDA";
            this.buttonOpenFile_BDA.Size = new System.Drawing.Size(91, 67);
            this.buttonOpenFile_BDA.TabIndex = 0;
            this.toolTipButton_BDA.SetToolTip(this.buttonOpenFile_BDA, "Открыть файл для обработки данных в CSV");
            this.buttonOpenFile_BDA.UseVisualStyleBackColor = true;
            this.buttonOpenFile_BDA.Click += new System.EventHandler(this.buttonOpenFile_BDA_Click);
            this.buttonOpenFile_BDA.MouseEnter += new System.EventHandler(this.buttonOpenFile_BDA_MouseEnter);
            // 
            // panelTask_BDA
            // 
            this.panelTask_BDA.Controls.Add(this.groupBoxTask_BDA);
            this.panelTask_BDA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_BDA.Location = new System.Drawing.Point(0, 72);
            this.panelTask_BDA.Margin = new System.Windows.Forms.Padding(2);
            this.panelTask_BDA.Name = "panelTask_BDA";
            this.panelTask_BDA.Size = new System.Drawing.Size(844, 73);
            this.panelTask_BDA.TabIndex = 1;
            // 
            // groupBoxTask_BDA
            // 
            this.groupBoxTask_BDA.Controls.Add(this.textBoxTask_BDA);
            this.groupBoxTask_BDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTask_BDA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_BDA.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxTask_BDA.Name = "groupBoxTask_BDA";
            this.groupBoxTask_BDA.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxTask_BDA.Size = new System.Drawing.Size(844, 73);
            this.groupBoxTask_BDA.TabIndex = 0;
            this.groupBoxTask_BDA.TabStop = false;
            this.groupBoxTask_BDA.Text = "Условие:";
            // 
            // textBoxTask_BDA
            // 
            this.textBoxTask_BDA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_BDA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_BDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_BDA.Location = new System.Drawing.Point(2, 15);
            this.textBoxTask_BDA.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTask_BDA.Multiline = true;
            this.textBoxTask_BDA.Name = "textBoxTask_BDA";
            this.textBoxTask_BDA.ReadOnly = true;
            this.textBoxTask_BDA.Size = new System.Drawing.Size(840, 56);
            this.textBoxTask_BDA.TabIndex = 0;
            this.textBoxTask_BDA.Text = resources.GetString("textBoxTask_BDA.Text");
            // 
            // panelInput_BDA
            // 
            this.panelInput_BDA.Controls.Add(this.groupBoxInput_BDA);
            this.panelInput_BDA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInput_BDA.Location = new System.Drawing.Point(0, 145);
            this.panelInput_BDA.Margin = new System.Windows.Forms.Padding(2);
            this.panelInput_BDA.Name = "panelInput_BDA";
            this.panelInput_BDA.Size = new System.Drawing.Size(569, 325);
            this.panelInput_BDA.TabIndex = 2;
            // 
            // groupBoxInput_BDA
            // 
            this.groupBoxInput_BDA.Controls.Add(this.dataGridViewInput_BDA);
            this.groupBoxInput_BDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInput_BDA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInput_BDA.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxInput_BDA.Name = "groupBoxInput_BDA";
            this.groupBoxInput_BDA.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxInput_BDA.Size = new System.Drawing.Size(569, 325);
            this.groupBoxInput_BDA.TabIndex = 0;
            this.groupBoxInput_BDA.TabStop = false;
            this.groupBoxInput_BDA.Text = "Ввод:";
            // 
            // dataGridViewInput_BDA
            // 
            this.dataGridViewInput_BDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInput_BDA.ColumnHeadersVisible = false;
            this.dataGridViewInput_BDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInput_BDA.Location = new System.Drawing.Point(2, 15);
            this.dataGridViewInput_BDA.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewInput_BDA.Name = "dataGridViewInput_BDA";
            this.dataGridViewInput_BDA.RowHeadersVisible = false;
            this.dataGridViewInput_BDA.RowHeadersWidth = 51;
            this.dataGridViewInput_BDA.RowTemplate.Height = 24;
            this.dataGridViewInput_BDA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewInput_BDA.Size = new System.Drawing.Size(565, 308);
            this.dataGridViewInput_BDA.TabIndex = 0;
            // 
            // splitterInput_BDA
            // 
            this.splitterInput_BDA.Location = new System.Drawing.Point(569, 145);
            this.splitterInput_BDA.Margin = new System.Windows.Forms.Padding(2);
            this.splitterInput_BDA.Name = "splitterInput_BDA";
            this.splitterInput_BDA.Size = new System.Drawing.Size(8, 325);
            this.splitterInput_BDA.TabIndex = 3;
            this.splitterInput_BDA.TabStop = false;
            // 
            // panelOutPut_BDA
            // 
            this.panelOutPut_BDA.Controls.Add(this.groupBoxOutPut_BDA);
            this.panelOutPut_BDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOutPut_BDA.Location = new System.Drawing.Point(577, 145);
            this.panelOutPut_BDA.Margin = new System.Windows.Forms.Padding(2);
            this.panelOutPut_BDA.Name = "panelOutPut_BDA";
            this.panelOutPut_BDA.Size = new System.Drawing.Size(267, 325);
            this.panelOutPut_BDA.TabIndex = 4;
            // 
            // groupBoxOutPut_BDA
            // 
            this.groupBoxOutPut_BDA.Controls.Add(this.dataGridViewOutPut_BDA);
            this.groupBoxOutPut_BDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPut_BDA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPut_BDA.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxOutPut_BDA.Name = "groupBoxOutPut_BDA";
            this.groupBoxOutPut_BDA.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxOutPut_BDA.Size = new System.Drawing.Size(267, 325);
            this.groupBoxOutPut_BDA.TabIndex = 0;
            this.groupBoxOutPut_BDA.TabStop = false;
            this.groupBoxOutPut_BDA.Text = "Вывод:";
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
            this.dataGridViewOutPut_BDA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewOutPut_BDA.Size = new System.Drawing.Size(263, 308);
            this.dataGridViewOutPut_BDA.TabIndex = 0;
            // 
            // openFileDialogTask_BDA
            // 
            this.openFileDialogTask_BDA.FileName = "openFileDialog1";
            // 
            // toolTipButton_BDA
            // 
            this.toolTipButton_BDA.IsBalloon = true;
            this.toolTipButton_BDA.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipButton_BDA.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 470);
            this.Controls.Add(this.panelOutPut_BDA);
            this.Controls.Add(this.splitterInput_BDA);
            this.Controls.Add(this.panelInput_BDA);
            this.Controls.Add(this.panelTask_BDA);
            this.Controls.Add(this.panelButtons_BDA);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 |  Вариант 12 | Брацун Д.А.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelButtons_BDA.ResumeLayout(false);
            this.panelTask_BDA.ResumeLayout(false);
            this.groupBoxTask_BDA.ResumeLayout(false);
            this.groupBoxTask_BDA.PerformLayout();
            this.panelInput_BDA.ResumeLayout(false);
            this.groupBoxInput_BDA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput_BDA)).EndInit();
            this.panelOutPut_BDA.ResumeLayout(false);
            this.groupBoxOutPut_BDA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_BDA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons_BDA;
        private System.Windows.Forms.Panel panelTask_BDA;
        private System.Windows.Forms.GroupBox groupBoxTask_BDA;
        private System.Windows.Forms.TextBox textBoxTask_BDA;
        private System.Windows.Forms.Panel panelInput_BDA;
        private System.Windows.Forms.GroupBox groupBoxInput_BDA;
        private System.Windows.Forms.Splitter splitterInput_BDA;
        private System.Windows.Forms.Panel panelOutPut_BDA;
        private System.Windows.Forms.GroupBox groupBoxOutPut_BDA;
        private System.Windows.Forms.DataGridView dataGridViewInput_BDA;
        private System.Windows.Forms.DataGridView dataGridViewOutPut_BDA;
        private System.Windows.Forms.Button buttonHelp_BDA;
        private System.Windows.Forms.Button buttonSaveFile_BDA;
        private System.Windows.Forms.Button buttonDone_BDA;
        private System.Windows.Forms.Button buttonOpenFile_BDA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_BDA;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_BDA;
        private System.Windows.Forms.ToolTip toolTipButton_BDA;
    }
}