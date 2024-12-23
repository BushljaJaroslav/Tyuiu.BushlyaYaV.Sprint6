﻿
using Tyuiu.BushlyaYaV.Sprint6.Task3.V13.Lib;

namespace Tyuiu.BushlyaYaV.Sprint6.Task3.V13.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[5, 5] { { -7, 34, -2, 25, 5 },
                                            { -16, -12, 30, -3, 17 },
                                            { 3, -15, 12, 5, -5 },
                                            { 17, 22, -3, 32, -11 },
                                            { 9, 28, 1, -9, -2 } };
            int[,] res = ds.Calculate(matrix);
            int[,] wait = { { -7, -15, -2, 25, 5 },
                            { -16, -12, 30, -3, 17 },
                            { 3, 22, 12, 5, -5 },
                            { 17, 28, -3, 32, -11 },
                            { 9, 34, 1, -9, -2 } }; ;

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
