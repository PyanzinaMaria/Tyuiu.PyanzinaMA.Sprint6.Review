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
            int[,] matrix = {  { 9, 8, 7 },
                               { 6, 5, 4 },
                               { 3, 2, 1 } };
            int n1 = 1;
            int n2 = 10;
            int r = 0;
            int k = 0;
            int l = 2;

            double result = ds.GetMatrix(matrix, n1, n2, r, k, l);

            Assert.AreEqual(8, result);
        }
    }
}
