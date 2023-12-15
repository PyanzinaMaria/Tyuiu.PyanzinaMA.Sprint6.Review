using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.PyanzinaMA.Sprint6.TaskReview.V30.Lib
{
    public class DataService
    {
        public double GetMatrix(int[,] array, int c, int k, int l)
        {
            double res = 0;
            for (int i = k; i <= l; i++)
            {
                res += array[c, i];
            }
            


            return res;

        }

    }
}