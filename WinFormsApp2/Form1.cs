using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }
        int i, N;
        private void txtBoxN_TextChanged(object sender, EventArgs e)
        { // установка размера матрицы и DataGridView
            
           
        }
        // обработка матрицы
        private void btnStart_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridViewIn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            datGrdViewRes.Visible = false;
            MatrMake mt = new MatrMake(N);
            mt.GridToMatrix(datGrdViewIn);
            mt.DelStr();
            datGrdViewRes.Visible = true;
            mt.MatrixToGrid(datGrdViewRes);

            
        }

        private void datGrdViewIn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            N = Int32.Parse(textBox1.Text);

            DataTable matr = new DataTable("matr");
            DataColumn[] cols = new DataColumn[N];
            for (i = 0; i < N; i++)
            {
                cols[i] = new DataColumn(i.ToString());
                matr.Columns.Add(cols[i]);
            }
            for (i = 0; i < N; i++)
            {
                DataRow newRow;
                newRow = matr.NewRow();
                matr.Rows.Add(newRow);
            }
            datGrdViewIn.DataSource = matr;
            for (i = 0; i < N; i++)
                datGrdViewIn.Columns[i].Width = 50;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}