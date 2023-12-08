using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.BratsunDA.Sprint6.Task2.V7.Lib;
namespace Tyuiu.BratsunDA.Sprint6.Task2.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void labelStopStep_BDA_Click(object sender, EventArgs e)
        {

        }

        private void buttonDone_BDA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_BDA.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_BDA.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_BDA.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chartFunction_BDA.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_BDA.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    this.chartFunction_BDA.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_BDA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ПКТБ-23-1 Брацун Данила Александрович", "Сообщение");
        }

        private void buttonDone_BDA_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_BDA.BackColor = Color.Red;
        }

        private void buttonDone_BDA_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_BDA.BackColor = Color.Green;
        }

        private void buttonDone_BDA_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_BDA.BackColor = Color.Blue;
        }

        private void textBoxStartStep_BDA_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxStartStep_BDA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void textBoxStopStep_BDA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void dataGridViewFunction_BDA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}