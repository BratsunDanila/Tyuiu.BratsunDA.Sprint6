
namespace Tyuiu.BratsunDA.Sprint6.Task6.V17
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
            this.buttonDone_BDA = new System.Windows.Forms.Button();
            this.buttonOpenFile_BDA = new System.Windows.Forms.Button();
            this.panelTask_BDA = new System.Windows.Forms.Panel();
            this.groupBoxTask_BDA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_BDA = new System.Windows.Forms.TextBox();
            this.panelInput_BDA = new System.Windows.Forms.Panel();
            this.groupBoxInPut_BDA = new System.Windows.Forms.GroupBox();
            this.textBoxInPut_BDA = new System.Windows.Forms.TextBox();
            this.splitterOutPut_BDA = new System.Windows.Forms.Splitter();
            this.panelOutPut_BDA = new System.Windows.Forms.Panel();
            this.groupBoxOutPut_BDA = new System.Windows.Forms.GroupBox();
            this.textBoxOutPut_BDA = new System.Windows.Forms.TextBox();
            this.openFileDialogTask_BDA = new System.Windows.Forms.OpenFileDialog();
            this.toolTipTask_BDA = new System.Windows.Forms.ToolTip(this.components);
            this.panelButtons_BDA.SuspendLayout();
            this.panelTask_BDA.SuspendLayout();
            this.groupBoxTask_BDA.SuspendLayout();
            this.panelInput_BDA.SuspendLayout();
            this.groupBoxInPut_BDA.SuspendLayout();
            this.panelOutPut_BDA.SuspendLayout();
            this.groupBoxOutPut_BDA.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButtons_BDA
            // 
            this.panelButtons_BDA.Controls.Add(this.buttonHelp_BDA);
            this.panelButtons_BDA.Controls.Add(this.buttonDone_BDA);
            this.panelButtons_BDA.Controls.Add(this.buttonOpenFile_BDA);
            this.panelButtons_BDA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons_BDA.Location = new System.Drawing.Point(0, 0);
            this.panelButtons_BDA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelButtons_BDA.Name = "panelButtons_BDA";
            this.panelButtons_BDA.Size = new System.Drawing.Size(778, 66);
            this.panelButtons_BDA.TabIndex = 0;
            // 
            // buttonHelp_BDA
            // 
            this.buttonHelp_BDA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_BDA.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_BDA.Image")));
            this.buttonHelp_BDA.Location = new System.Drawing.Point(702, 2);
            this.buttonHelp_BDA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonHelp_BDA.Name = "buttonHelp_BDA";
            this.buttonHelp_BDA.Size = new System.Drawing.Size(67, 62);
            this.buttonHelp_BDA.TabIndex = 0;
            this.toolTipTask_BDA.SetToolTip(this.buttonHelp_BDA, "Сведения о программе");
            this.buttonHelp_BDA.UseVisualStyleBackColor = true;
            this.buttonHelp_BDA.Click += new System.EventHandler(this.buttonHelp_BDA_Click);
            // 
            // buttonDone_BDA
            // 
            this.buttonDone_BDA.Enabled = false;
            this.buttonDone_BDA.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_BDA.Image")));
            this.buttonDone_BDA.Location = new System.Drawing.Point(87, 2);
            this.buttonDone_BDA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDone_BDA.Name = "buttonDone_BDA";
            this.buttonDone_BDA.Size = new System.Drawing.Size(76, 62);
            this.buttonDone_BDA.TabIndex = 0;
            this.toolTipTask_BDA.SetToolTip(this.buttonDone_BDA, "Выводит третье слово каждой строки\r\nв результирующую строку");
            this.buttonDone_BDA.UseVisualStyleBackColor = true;
            this.buttonDone_BDA.Click += new System.EventHandler(this.buttonDone_BDA_Click);
            // 
            // buttonOpenFile_BDA
            // 
            this.buttonOpenFile_BDA.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_BDA.Image")));
            this.buttonOpenFile_BDA.Location = new System.Drawing.Point(6, 2);
            this.buttonOpenFile_BDA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOpenFile_BDA.Name = "buttonOpenFile_BDA";
            this.buttonOpenFile_BDA.Size = new System.Drawing.Size(76, 62);
            this.buttonOpenFile_BDA.TabIndex = 0;
            this.toolTipTask_BDA.SetToolTip(this.buttonOpenFile_BDA, "Открыть файл\r\nВыберите нужный файл для обработки");
            this.buttonOpenFile_BDA.UseVisualStyleBackColor = true;
            this.buttonOpenFile_BDA.Click += new System.EventHandler(this.buttonOpenFile_BDA_Click);
            // 
            // panelTask_BDA
            // 
            this.panelTask_BDA.Controls.Add(this.groupBoxTask_BDA);
            this.panelTask_BDA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_BDA.Location = new System.Drawing.Point(0, 66);
            this.panelTask_BDA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelTask_BDA.Name = "panelTask_BDA";
            this.panelTask_BDA.Size = new System.Drawing.Size(778, 72);
            this.panelTask_BDA.TabIndex = 1;
            // 
            // groupBoxTask_BDA
            // 
            this.groupBoxTask_BDA.Controls.Add(this.textBoxTask_BDA);
            this.groupBoxTask_BDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTask_BDA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_BDA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxTask_BDA.Name = "groupBoxTask_BDA";
            this.groupBoxTask_BDA.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxTask_BDA.Size = new System.Drawing.Size(778, 72);
            this.groupBoxTask_BDA.TabIndex = 0;
            this.groupBoxTask_BDA.TabStop = false;
            this.groupBoxTask_BDA.Text = "Условие:";
            // 
            // textBoxTask_BDA
            // 
            this.textBoxTask_BDA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_BDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_BDA.Location = new System.Drawing.Point(2, 15);
            this.textBoxTask_BDA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxTask_BDA.Multiline = true;
            this.textBoxTask_BDA.Name = "textBoxTask_BDA";
            this.textBoxTask_BDA.Size = new System.Drawing.Size(774, 55);
            this.textBoxTask_BDA.TabIndex = 0;
            this.textBoxTask_BDA.Text = resources.GetString("textBoxTask_BDA.Text");
            // 
            // panelInput_BDA
            // 
            this.panelInput_BDA.Controls.Add(this.groupBoxInPut_BDA);
            this.panelInput_BDA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInput_BDA.Location = new System.Drawing.Point(0, 138);
            this.panelInput_BDA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelInput_BDA.Name = "panelInput_BDA";
            this.panelInput_BDA.Size = new System.Drawing.Size(390, 330);
            this.panelInput_BDA.TabIndex = 2;
            // 
            // groupBoxInPut_BDA
            // 
            this.groupBoxInPut_BDA.Controls.Add(this.textBoxInPut_BDA);
            this.groupBoxInPut_BDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInPut_BDA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInPut_BDA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxInPut_BDA.Name = "groupBoxInPut_BDA";
            this.groupBoxInPut_BDA.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxInPut_BDA.Size = new System.Drawing.Size(390, 330);
            this.groupBoxInPut_BDA.TabIndex = 0;
            this.groupBoxInPut_BDA.TabStop = false;
            this.groupBoxInPut_BDA.Text = "Ввод:";
            // 
            // textBoxInPut_BDA
            // 
            this.textBoxInPut_BDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInPut_BDA.Location = new System.Drawing.Point(2, 15);
            this.textBoxInPut_BDA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxInPut_BDA.Multiline = true;
            this.textBoxInPut_BDA.Name = "textBoxInPut_BDA";
            this.textBoxInPut_BDA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInPut_BDA.Size = new System.Drawing.Size(386, 313);
            this.textBoxInPut_BDA.TabIndex = 0;
            // 
            // splitterOutPut_BDA
            // 
            this.splitterOutPut_BDA.Location = new System.Drawing.Point(390, 138);
            this.splitterOutPut_BDA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitterOutPut_BDA.Name = "splitterOutPut_BDA";
            this.splitterOutPut_BDA.Size = new System.Drawing.Size(8, 330);
            this.splitterOutPut_BDA.TabIndex = 3;
            this.splitterOutPut_BDA.TabStop = false;
            // 
            // panelOutPut_BDA
            // 
            this.panelOutPut_BDA.Controls.Add(this.groupBoxOutPut_BDA);
            this.panelOutPut_BDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOutPut_BDA.Location = new System.Drawing.Point(398, 138);
            this.panelOutPut_BDA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelOutPut_BDA.Name = "panelOutPut_BDA";
            this.panelOutPut_BDA.Size = new System.Drawing.Size(380, 330);
            this.panelOutPut_BDA.TabIndex = 4;
            // 
            // groupBoxOutPut_BDA
            // 
            this.groupBoxOutPut_BDA.Controls.Add(this.textBoxOutPut_BDA);
            this.groupBoxOutPut_BDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPut_BDA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPut_BDA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxOutPut_BDA.Name = "groupBoxOutPut_BDA";
            this.groupBoxOutPut_BDA.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxOutPut_BDA.Size = new System.Drawing.Size(380, 330);
            this.groupBoxOutPut_BDA.TabIndex = 0;
            this.groupBoxOutPut_BDA.TabStop = false;
            this.groupBoxOutPut_BDA.Text = "Вывод:";
            // 
            // textBoxOutPut_BDA
            // 
            this.textBoxOutPut_BDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOutPut_BDA.Location = new System.Drawing.Point(2, 15);
            this.textBoxOutPut_BDA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxOutPut_BDA.Multiline = true;
            this.textBoxOutPut_BDA.Name = "textBoxOutPut_BDA";
            this.textBoxOutPut_BDA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutPut_BDA.Size = new System.Drawing.Size(376, 313);
            this.textBoxOutPut_BDA.TabIndex = 0;
            // 
            // openFileDialogTask_BDA
            // 
            this.openFileDialogTask_BDA.FileName = "openFileDialogTask_BDA";
            // 
            // toolTipTask_BDA
            // 
            this.toolTipTask_BDA.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipTask_BDA.ToolTipTitle = "Подсказка";
            this.toolTipTask_BDA.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTipTask_BDA_Popup);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 468);
            this.Controls.Add(this.panelOutPut_BDA);
            this.Controls.Add(this.splitterOutPut_BDA);
            this.Controls.Add(this.panelInput_BDA);
            this.Controls.Add(this.panelTask_BDA);
            this.Controls.Add(this.panelButtons_BDA);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 |  Вариант 17 | Брацун Д.А.";
            this.panelButtons_BDA.ResumeLayout(false);
            this.panelTask_BDA.ResumeLayout(false);
            this.groupBoxTask_BDA.ResumeLayout(false);
            this.groupBoxTask_BDA.PerformLayout();
            this.panelInput_BDA.ResumeLayout(false);
            this.groupBoxInPut_BDA.ResumeLayout(false);
            this.groupBoxInPut_BDA.PerformLayout();
            this.panelOutPut_BDA.ResumeLayout(false);
            this.groupBoxOutPut_BDA.ResumeLayout(false);
            this.groupBoxOutPut_BDA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons_BDA;
        private System.Windows.Forms.Panel panelTask_BDA;
        private System.Windows.Forms.GroupBox groupBoxTask_BDA;
        private System.Windows.Forms.TextBox textBoxTask_BDA;
        private System.Windows.Forms.Panel panelInput_BDA;
        private System.Windows.Forms.GroupBox groupBoxInPut_BDA;
        private System.Windows.Forms.Splitter splitterOutPut_BDA;
        private System.Windows.Forms.Panel panelOutPut_BDA;
        private System.Windows.Forms.GroupBox groupBoxOutPut_BDA;
        private System.Windows.Forms.Button buttonHelp_BDA;
        private System.Windows.Forms.Button buttonDone_BDA;
        private System.Windows.Forms.Button buttonOpenFile_BDA;
        private System.Windows.Forms.ToolTip toolTipTask_BDA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_BDA;
        private System.Windows.Forms.TextBox textBoxInPut_BDA;
        private System.Windows.Forms.TextBox textBoxOutPut_BDA;
    }
}

