using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.PyanzinaMA.Sprint6.TaskReview.V30.Lib;

namespace Tyuiu.PyanzinaMA.Sprint6.TaskReview.V30
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        Random rnd = new Random();
        static int[,] mtrx;
        static int[,] matrix;
        static int rows;
        static int columns;

        private void buttonGenMatrix_PMA_Click(object sender, EventArgs e)
        {
            rows = Convert.ToInt32(textBoxRows_PMA.Text);
            columns = Convert.ToInt32(textBoxColumns_PMA.Text);

            int StartStep = Convert.ToInt32(textBoxStart_PMA.Text);
            int StopStep = Convert.ToInt32(textBoxStop_PMA.Text);

            dataGridViewOutPutMatrix_PMA.RowCount = rows;
            dataGridViewOutPutMatrix_PMA.ColumnCount = columns;

            mtrx = new int[dataGridViewOutPutMatrix_PMA.RowCount, dataGridViewOutPutMatrix_PMA.ColumnCount];
            int[] array = new int[] { };
            for (int i = 0; i < dataGridViewOutPutMatrix_PMA.RowCount; i++)
            {
                for (int j = 0; j < dataGridViewOutPutMatrix_PMA.ColumnCount; j++)
                {
                    int r = rnd.Next(StartStep, StopStep);
                    mtrx[j, i] = r;
                }
            }

            for (int r = 0; r < mtrx.GetLength(0); r++)
            {
                for (int i = 0; i < mtrx.GetLength(1); i++)
                {
                    for (int j = i + 1; j < mtrx.GetLength(1); j++)
                    {
                        if (mtrx[r, i] < mtrx[r, j])
                        {
                            int tmp = mtrx[r, i];
                            mtrx[r, i] = mtrx[r, j];
                            mtrx[r, j] = tmp;
                        }
                    }
                }
            }

            int w = mtrx.GetLength(0);
            int h = mtrx.GetLength(1);

            matrix = new int[h, w];
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    matrix[j, i] = mtrx[i, j];
                }
            }

            try
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewOutPutMatrix_PMA.Columns[i].Width = 35;
                        dataGridViewOutPutMatrix_PMA.Rows[j].Cells[i].Value = Convert.ToString(matrix[j, i]);
                    }
                }
                

                MessageBox.Show("Матрица сгенерирована", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void textBoxStart_PMA_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelStart_PMA_Click(object sender, EventArgs e)
        {

        }

        private void buttonHelp_PMA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SprintReview выполнила студентка группы ИИПб-23-1 Пьянзина Мария Алексеевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_PMA_Click(object sender, EventArgs e)
        {
            try
            {
                
                int RowNum = Convert.ToInt32(textBoxRow_PMA.Text);
                int FirstNum = Convert.ToInt32(textBoxNumStart_PMA.Text);
                int LastNum = Convert.ToInt32(textBoxNumStop_PMA.Text);
                double res = ds.GetMatrix(matrix, RowNum, FirstNum, LastNum);
                res = Math.Round((res / (LastNum - FirstNum + 1)), 3);
                textBoxResult_PMA.Text = Convert.ToString(res);

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCondition_PMA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Дан целочисленный двумерный массив N (N>1) на M (M>1) элементов, заполненный случайными числами в заданном диапазоне (от n1 до n2) по убыванию в столбцах. Найти среднее арифметическое элементов массива с номерами от K до L(нумерация начинается с нуля) включительно в заданной строке R. Произвести проверку на корректность ввода интервальных значений(n1 < n2, K < L, R и т.д.).", "Условие задачи", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
