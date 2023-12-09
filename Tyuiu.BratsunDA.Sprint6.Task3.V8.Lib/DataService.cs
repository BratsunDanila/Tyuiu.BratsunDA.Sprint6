using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.BratsunDA.Sprint6.Task3.V8.Lib
{
    public class DataService : ISprint6Task3V8
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int colums = matrix.Length / rows;

            for (int j = 0; j < colums; j++)
            {
                if (matrix[3, j] % 2 == 0)
                {
                    matrix[3, j] = 0;
                }
            }

            return matrix;
        }
    }
}
