using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.BratsunDA.Sprint6.Task3.V8.Lib;

namespace Tyuiu.BratsunDA.Sprint6.Task3.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5] { { -10, 10, -7, 19, 6},
                                      { 15, -13, -19, 9, 1},
                                      { -20, -15, -6, 8, -4},
                                      { 10, 18, -5, 9, -6},
                                      { 16, -10, 4, 15, 16} };

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewOriginalMatrix_BDA.ColumnCount = columns;
            dataGridViewOriginalMatrix_BDA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewOriginalMatrix_BDA.Columns[i].Width = 40;
                dataGridViewOriginalMatrix_BDA.Rows[i].Height = 40;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewOriginalMatrix_BDA.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

        private void buttonDone_BDA_Click(object sender, EventArgs e)
        {
            int[,] resultmtrx = ds.Calculate(mtrx);
            int rows = resultmtrx.GetUpperBound(0) + 1;
            int columns = resultmtrx.Length / rows;

            dataGridViewResultMatrix_BDA.ColumnCount = columns;
            dataGridViewResultMatrix_BDA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewResultMatrix_BDA.Columns[i].Width = 40;
                dataGridViewResultMatrix_BDA.Rows[i].Height = 40;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResultMatrix_BDA.Rows[i].Cells[j].Value = Convert.ToString(resultmtrx[i, j]);
                }
            }
        }

        private void buttonHelp_BDA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ПКТб-23-1 Брацун Данила Александрович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
