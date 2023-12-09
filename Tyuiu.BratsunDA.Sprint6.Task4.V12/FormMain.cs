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
using Tyuiu.BratsunDA.Sprint6.Task4.V12.Lib;

namespace Tyuiu.BratsunDA.Sprint6.Task4.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_SDA_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxVarStart_BDA.Text);
                int stopValue = Convert.ToInt32(textBoxVarStop_BDA.Text);

                string strLine;
                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startValue, stopValue);

                this.chartFunction_BDA.Titles.Clear();
                this.chartFunction_BDA.Titles.Add("График функции");
                this.chartFunction_BDA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_BDA.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult_BDA.Text = "";
                chartFunction_BDA.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    textBoxResult_BDA.AppendText(valueArray[i] + Environment.NewLine);
                    this.chartFunction_BDA.Series[0].Points.AddXY(startValue, valueArray[i]);
                    startValue++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_SDA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ПКТБ-23-1 Брацун Данила Александрович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSave_SDA_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V13.txt";
                File.WriteAllText(path, textBoxResult_BDA.Text);

                DialogResult dialogResult = MessageBox.Show($"Файл {path} сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
