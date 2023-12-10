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
using Tyuiu.BratsunDA.Sprint6.Task7.V12.Lib;

namespace Tyuiu.BratsunDA.Sprint6.Task7.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            openFileDialogTask_BDA.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_BDA.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        static int rows;
        static int columns;
        static string openFilePath;

        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            string FileData = File.ReadAllText(filePath);

            FileData = FileData.Replace('\n', '\r');
            string[] lines = FileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }
        private void buttonOpenFile_BDA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_BDA.ShowDialog();
            openFilePath = openFileDialogTask_BDA.FileName;

            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewInput_BDA.ColumnCount = columns;
            dataGridViewInput_BDA.RowCount = rows;
            dataGridViewOutPut_BDA.ColumnCount = columns;
            dataGridViewOutPut_BDA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInput_BDA.Columns[i].Width = 50;
                dataGridViewOutPut_BDA.Columns[i].Width = 50;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInput_BDA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_BDA.Enabled = true;
        }

        private void buttonSaveFile_BDA_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_BDA.FileName = "OutPutFileTask7v12.csv";
            saveFileDialogMatrix_BDA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_BDA.ShowDialog();

            string path = saveFileDialogMatrix_BDA.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool FileExists = fileInfo.Exists;

            if (FileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutPut_BDA.RowCount;
            int columns = dataGridViewOutPut_BDA.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutPut_BDA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutPut_BDA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonOpenFile_BDA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_BDA.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_BDA_Click(object sender, EventArgs e)
        {
            int[,] arrayValues1 = new int[rows, columns];
            arrayValues1 = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutPut_BDA.Rows[r].Cells[c].Value = arrayValues1[r, c];
                }
            }
            buttonSaveFile_BDA.Enabled = true;
        }

        private void buttonDone_BDA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_BDA.ToolTipTitle = "Выполнить";
        }

        private void buttonDone_BDA_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void buttonSaveFile_BDA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_BDA.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonHelp_BDA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_BDA.ToolTipTitle = "Справка";
        }

        private void buttonHelp_BDA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
