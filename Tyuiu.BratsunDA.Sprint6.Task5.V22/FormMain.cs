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
using Tyuiu.BratsunDA.Sprint6.Task5.V22.Lib;

namespace Tyuiu.BratsunDA.Sprint6.Task5.V22
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\Users\беброн\source\repos\Tyuiu.BratsunDA.Sprint6\Tyuiu.BratsunDA.Sprint6.Task5.V22\bin\Debug\InPutFileTask5V22.txt";
        private void buttonDone_BDA_Click(object sender, EventArgs e)
        {
            dataGridViewOutPut_BDA.ColumnCount = 2;
            dataGridViewOutPut_BDA.Columns[0].Width = 40;
            dataGridViewOutPut_BDA.Columns[1].Width = 60;

            this.chartGraph_BDA.ChartAreas[0].AxisX.Title = "Ось Х";
            this.chartGraph_BDA.ChartAreas[0].AxisY.Title = "Ось Y";
            this.chartGraph_BDA.Series[0].Points.Clear();

            double[] nums = new double[ds.len];
            nums = ds.LoadFromDataFile(path);
            for (int i = 0; i < nums.Length; i++)
            {
                dataGridViewOutPut_BDA.Rows.Add(Convert.ToString(i), Convert.ToString(nums[i]));
                chartGraph_BDA.Series[0].Points.AddXY(i, nums[i]);
            }
        }

        private void buttonSaveFile_BDA_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\Users\беброн\source\repos\Tyuiu.BratsunDA.Sprint6\Tyuiu.BratsunDA.Sprint6.Task5.V22\bin\Debug\InPutFileTask5V22.txt";

                System.Diagnostics.Process txt = new System.Diagnostics.Process();
                txt.StartInfo.FileName = "notepad.exe";
                txt.StartInfo.Arguments = path;
                txt.Start();
            }
            catch
            {
                MessageBox.Show("Сбой при открытии файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_BDA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ПКТБ-23-1 Брацун Данила Александрович", "Сообщение");
        }
    }
}
