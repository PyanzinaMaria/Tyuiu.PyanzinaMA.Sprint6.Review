using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PyanzinaMA.Sprint6.TaskReview.V30.Lib;

namespace Tyuiu.PyanzinaMA.Sprint6.TaskReview.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();

            int[,] array = new int[,] { { 64, 223, 13, 14, 5 },
                                        { 62, 74, 8, 9, 0 },
                                        { 18, 32, 5, -7, -9 },
                                        { 13, 21, 1, -24, -15 },
                                        { 6, 17, -8, -39, -16 },
                                        { 1, 3, -15, -71, -19 }};
            int c = 4;
            int k = 0;
            int l = 4;

            double res = ds.GetMatrix(array, c, k, l);
            double wait = -8.0;
            Assert.AreEqual(wait, res);
        }
    }
}
