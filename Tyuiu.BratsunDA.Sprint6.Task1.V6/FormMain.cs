using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.BratsunDA.Sprint6.Task1.V6.Lib;

namespace Tyuiu.BratsunDA.Sprint6.Task1.V6
{
    public partial class FormMain_BDA : Form
    {
        public FormMain_BDA()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_BDA.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_BDA.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_BDA.Text = "";
                textBoxResult_BDA.AppendText("+-----------+-----------+" + Environment.NewLine);
                textBoxResult_BDA.AppendText("|     X     |    f(x)   |" + Environment.NewLine);
                textBoxResult_BDA.AppendText("+-----------+-----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,6:d}     |   {1, 6:f2}  |", startStep, valueArray[i]);
                    textBoxResult_BDA.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxResult_BDA.AppendText("+-----------+-----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void labelTask_BDA_Click(object sender, EventArgs e)
        {

        }

        private void labelResult_BDA_Click(object sender, EventArgs e)
        {

        }

        private void buttonInfo_BDA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ПКТБ-23-1 Брацун Данила Александрович", "Сообщение", MessageBoxButtons.OK);
        }

        private void textBoxStartStep_BDA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}