using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BratsunDA.Sprint6.Task3.V8.Lib;

namespace Tyuiu.BratsunDA.Sprint6.Task3.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[,] mtrx = new int[5, 5] { { -9, -4, 17, -1, -20},
                                          { -19, 18, -4, 2, 14},
                                          { -12, 16, -2, 7, 18},
                                          { -16, 15, 4, -12, -13},
                                          { -15, -4, -16, 1, -14} };

            var res = ds.Calculate(mtrx);
            int[,] wait = new int[5, 5] { { -9, -4, 17, -1, -20},
                                          { -19, 18, -4, 2, 14},
                                          { -12, 16, -2, 7, 18},
                                          { 0, 15, 0, 0, -13},
                                          { -15, -4, -16, 1, -14} }; ;
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
