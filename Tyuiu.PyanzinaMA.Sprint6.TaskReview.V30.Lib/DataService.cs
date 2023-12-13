using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.PyanzinaMA.Sprint6.TaskReview.V30.Lib
{
    public class DataService
    {
        public double GetMatrix(int[,] array, int n1, int n2, int c, int k, int l)
        {
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);
                      
            double sum = 0;
            double count = 0;

            for (int j = k; j <= l; j++)
            {
                sum += array[c, j];
                count++;
            }
            
            double average = Math.Round((sum / count), 3);

            return average;


        }
    }
}