using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BratsunDA.Sprint6.Task7.V12.Lib;
using System.IO;

namespace Tyuiu.BratsunDA.Sprint6.Task7.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutFileTask7V12.csv";
            int[,] wait = new int[,] { {17,17,-7,-19,-4,6,4,-17,6,0 },
                                       { -13,-13,-7,-15,-12,-1,15,18,11,0 },
                                        { 9,-12,-9,8,-12,20,10,-6,18,0 },
                                        { -15,-19,19,16,-15,-19,8,-2,11,0 },
                                        { -14,-9,-19,20,-3,8,-10,4,2,0 },
                                        { -18,-4,-14,20,-20,17,-18,-19,-9,0 },
                                        { 17,14,1,-18,0,2,-3,-9,1,0 },
                                        { -14,-10,-15,19,12,-18,6,15,-17,0 },
                                        { 19,18,14,5,8,4,-13,10,5,0 },
                                        { -7,3,12,7,-1,-13,-6,3,-17,0 } };
            int[,] res = ds.GetMatrix(path);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
