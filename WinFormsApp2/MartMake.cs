using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    class MatrMake
    {
        int n_str, //количество строк
    n_col; //количество столбцов
        int[,] matrix; // обрабатываемая матрица
        int[,] newA;
        public MatrMake(int n) // конструктор
        {
            n_str = n; // на входе матрица квадратная
            n_col = n;
            matrix = new int[n, n];
            newA = new int[n_str, n_col-1];
        }
        //заполнение матрицы из DataGridView
        public void GridToMatrix(DataGridView dgv)
        {
            DataGridViewCell txtCell;
            for (int i = 0; i < n_str; i++)
            {
                for (int j = 0; j < n_col; j++)
                {
                    txtCell = dgv.Rows[i].Cells[j];
                    string s = txtCell.Value.ToString();
                    if (s == "")
                        matrix[i, j] = 0;
                    else
                        matrix[i, j] = Int32.Parse(s);
                }
            }
        }
        //вывод матрицы в DataGridView
        public void MatrixToGrid(DataGridView dgv)
        {
            //установка размеров
            int i;
            DataTable matr = new DataTable("matr");
            DataColumn[] cols = new DataColumn[n_col - 1];
            for (i = 0; i < n_col - 1; i++)
            {
                cols[i] = new DataColumn(i.ToString());
                matr.Columns.Add(cols[i]);
            }
            for (i = 0; i < n_str; i++)
            {
                DataRow newRow;
                newRow = matr.NewRow();
                matr.Rows.Add(newRow);
            }
            dgv.DataSource = matr;
            for (i = 0; i < n_col - 1; i++)
                dgv.Columns[i].Width = 50;
            // занесение значений
            DataGridViewCell txtCell;
            for (i = 0; i < n_str; i++)
            {
                for (int j = 0; j < n_col - 1; j++)
                {
                    txtCell = dgv.Rows[i].Cells[j];
                    txtCell.Value = newA[i, j].ToString();
                }
            }
        }
        // Удалить столбцы, сумма элементов которых максимальна.
        public void DelStr() //true, если результат пустая матрица
        {
            
            int sum;
            int max = 0;
            byte n = 0;
            for (byte j = 0; j < n_str; j++)
            {
                sum = 0;
                for (byte i = 0; i < n_col; i++)
                    sum += matrix[i, j];
                if (sum > max)
                    n = j;
                max = Math.Max(max, sum);
            }
            byte index = 0;
            for (byte y = 0; y < n_str; y++)
            {
                if (y == n)
                    continue;
                for (byte x = 0; x < n_col; x++)
                    newA[x, index] = matrix[x, y];
                index++;
            }

        }
    }
}