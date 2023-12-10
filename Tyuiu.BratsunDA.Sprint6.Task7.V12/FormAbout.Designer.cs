
namespace Tyuiu.BratsunDA.Sprint6.Task7.V12
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.textBoxInfo_BDA = new System.Windows.Forms.TextBox();
            this.buttonOK_BDA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxInfo_BDA
            // 
            this.textBoxInfo_BDA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInfo_BDA.Location = new System.Drawing.Point(9, 20);
            this.textBoxInfo_BDA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxInfo_BDA.Multiline = true;
            this.textBoxInfo_BDA.Name = "textBoxInfo_BDA";
            this.textBoxInfo_BDA.ReadOnly = true;
            this.textBoxInfo_BDA.Size = new System.Drawing.Size(380, 167);
            this.textBoxInfo_BDA.TabIndex = 1;
            this.textBoxInfo_BDA.TabStop = false;
            this.textBoxInfo_BDA.Text = resources.GetString("textBoxInfo_BDA.Text");
            // 
            // buttonOK_BDA
            // 
            this.buttonOK_BDA.Location = new System.Drawing.Point(314, 191);
            this.buttonOK_BDA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOK_BDA.Name = "buttonOK_BDA";
            this.buttonOK_BDA.Size = new System.Drawing.Size(77, 24);
            this.buttonOK_BDA.TabIndex = 2;
            this.buttonOK_BDA.Text = "Ok";
            this.buttonOK_BDA.UseVisualStyleBackColor = true;
            this.buttonOK_BDA.Click += new System.EventHandler(this.buttonOK_BDA_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 224);
            this.Controls.Add(this.buttonOK_BDA);
            this.Controls.Add(this.textBoxInfo_BDA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInfo_BDA;
        private System.Windows.Forms.Button buttonOK_BDA;
    }
}