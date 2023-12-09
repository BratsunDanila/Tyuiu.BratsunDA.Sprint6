using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.BratsunDA.Sprint6.Task6.V17.Lib;

namespace Tyuiu.BratsunDA.Sprint6.Task6.V17
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string openFilePath;
        private void buttonOpenFile_BDA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_BDA.ShowDialog();
            openFilePath = openFileDialogTask_BDA.FileName;
            textBoxInPut_BDA.Text = File.ReadAllText(openFilePath);
            groupBoxOutPut_BDA.Text = groupBoxOutPut_BDA.Text + " " + openFileDialogTask_BDA.FileName;
            buttonDone_BDA.Enabled = true;
        }

        private void toolTipTask_BDA_Popup(object sender, PopupEventArgs e)
        {

        }

        private void buttonDone_BDA_Click(object sender, EventArgs e)
        {
            textBoxOutPut_BDA.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_BDA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
