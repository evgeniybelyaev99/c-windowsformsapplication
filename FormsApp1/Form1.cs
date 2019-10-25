using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void creatematrix(int m,int n)
        {
            matrix.RowCount = m;
            matrix.ColumnCount = n;
            Random r = new Random();
            for (int i = 0; i < m;i++)
                for (int j = 0; j < n; j++)
                    matrix.Rows[i].Cells[j].Value = r.Next(10); 
        }
        private int max_row(int row)
        {
            int max = -1;
            for (int i=0; i < matrix.ColumnCount; i++)
            {
                if ((int)matrix.Rows[row].Cells[i].Value >= max)
                    max = (int)matrix.Rows[row].Cells[i].Value;
            }
            return max;
        }
        private int min_column(int column)
        {
            int min = 9;
            for (int i = 0; i < matrix.RowCount; i++)
            {
                if ((int)matrix.Rows[i].Cells[column].Value <= min)
                    min = (int)matrix.Rows[i].Cells[column].Value;
            }
            return min;
        }
        private double mean_row(int row)
        {
            double mean = 0;
            int count = 0;
            for (int i = 0; i < matrix.ColumnCount; i++)
            {
                mean += (int)matrix.Rows[row].Cells[i].Value;
                if ((int)matrix.Rows[row].Cells[i].Value == 0)
                {
                    count++;
                }
            }
            mean /= (matrix.ColumnCount-count);
            mean = Math.Round(mean, 1);
            return mean;
        }
        private int multi_column(int column)
        {
            int multi = 1;
            for (int i = 0; i < matrix.RowCount; i++)
            {
                
                    multi *= (int)matrix.Rows[i].Cells[column].Value;
            }
            return multi;
        }
        private void generate_matrix(object sender, EventArgs e)
        {
            try
            {
                int m = int.Parse(textBox1.Text);
                int n = int.Parse(textBox2.Text);
                if (m > 0 && n > 0 && m <= 10 && n <= 10)
                {
                    creatematrix(m, n);
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox9.Clear();
                    textBox10.Clear();
                    textBox11.Clear();
                    textBox12.Clear();
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    button5.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Количество строк и столбцов должно изменяться от 1 до 10!");
                }
            }
            catch
            {

                if (textBox1.Text == "" || textBox2.Text == "")
                {
                    MessageBox.Show("Введите количество строк и столбцов!");
                }
                else
                {
                    MessageBox.Show("Введены некорректные данные!");
                }
            }
        }
    
         private void max_in_str(object sender, EventArgs e)
        {
            try
            {
                int row = int.Parse(textBox3.Text);
                if (row >= 0 && row < (int)matrix.RowCount)
                {
                    textBox5.Text = "max= " + max_row(row);
                }
                else
                {
                    MessageBox.Show("Выбранная строка отсутствует!");
                    textBox5.Clear();
                }
            }
            catch
            {
                if (textBox3.Text == "")
                {
                    MessageBox.Show("Введите номер строки!");
                }
                else
                {
                    MessageBox.Show("Введены некорректные данные!");
                    textBox5.Clear();
                }
            }
        }
       private void min_in_column(object sender, EventArgs e)
        {
            try
            {
                int column = int.Parse(textBox4.Text);
                if (column >= 0 && column < (int)matrix.ColumnCount)
                {
                    textBox6.Text = "min= " + min_column(column);
                }
                else
                {
                    MessageBox.Show("Выбранный столбец отсутствует!");
                    textBox6.Clear();
                }
            }
            catch
            {
                if (textBox4.Text == "")
                {
                    MessageBox.Show("Введите номер столбца!");
                }
                else
                {
                    MessageBox.Show("Введены некорректные данные!");
                    textBox6.Clear();
                }
            }
        }
        private void avg_in_str(object sender, EventArgs e)
        {
            try {
                int row = int.Parse(textBox9.Text);
                if (row >= 0 && row < (int)matrix.RowCount)
                {
                    textBox11.Text = "mean= " + mean_row(row);
                }
                else
                {
                    MessageBox.Show("Выбранная строка отсутствует!");
                    textBox11.Clear();
                }
            }
            catch
            {
                if (textBox9.Text == "")
                {
                    MessageBox.Show("Введите номер строки!");
                }
                else
                {
                    MessageBox.Show("Введены некорректные данные!");
                    textBox11.Clear();
                }
            }
            
        }
        private void product_of_column_elements(object sender, EventArgs e)
        {
            try
            {
                int column = int.Parse(textBox10.Text);
                if (column >= 0 && column < (int)matrix.ColumnCount)
                {
                    textBox12.Text = "multi= " + multi_column(column);
                }
                else
                {
                    MessageBox.Show("Выбранный столбец отсутствует!");
                    textBox12.Clear();
                }
            }
            catch
            {
                if (textBox10.Text == "")
                {
                    MessageBox.Show("Введите номер столбца!");
                }
                else
                {
                    MessageBox.Show("Введены некорректные данные!");
                    textBox12.Clear();
                }
                
            }

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
