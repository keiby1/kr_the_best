using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace курсовая_МИМПРО
{
    public partial class Form1 : Form
    {
        private int D;      //ограничение веса
        private int[] w;    //веса
        private int[] c;    //цены

        public Form1()
        {
            InitializeComponent();  //инициализация
            w = new int[10];        //выделение памяти
            c = new int[10];
            D = 1000;               //значение по умолчанию
        }

        //чтение данных из файла
        private void считатьДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
            dataGridView1.Rows[0].Cells[0].Value = "d";
            dataGridView1.Rows.Add();
            dataGridView1.Rows[1].Cells[0].Value = "q";
            Read();     //чтение
            Out();      //вывод в таблицу
        }

        //очистка таблицы
        private void очиститьДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            Out();
        }

        //рассчеты
        private void рассчитатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int d = knapsack1(w, c, D); //вычисление и вывод на экран
            MessageBox.Show("Максимальная стоимость: " + d.ToString(), "Решение найдено!");
            Out();
        }

        //чтение из файла
        public void Read()
        {
            StreamReader sw = new StreamReader("in.txt");//создание потока чтения
            for (int i = 0; i < 10; i++)
            {
                w[i] = Convert.ToInt32(sw.ReadLine());  //запись в массивы по очереди
                c[i] = Convert.ToInt32(sw.ReadLine());
            }
            sw.Close();                                 //закрытие потока чтения
        }

        public void Out() //вывод данных в таблицу
        {
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    dataGridView1.Rows[0].Cells[i + 1].Value = w[i];
                    dataGridView1.Rows[1].Cells[i + 1].Value = c[i];
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        //решение задачи о рюкзаке
        int knapsack1(int[] wts, int[] cost, int W)
        {
            int n = wts.Length;
            int[] dp = new int[W + 1];
            dp[0] = 0;
            for (int w = 1; w <= W; w++)
            {
                dp[w] = dp[w - 1];
                for (int i = 0; i < n; i++)
                {
                    if (wts[i] <= w)
                    {
                        int t1 = dp[w];
                        int t2 = dp[w - wts[i]] + cost[i];
                        dp[w] = Math.Max(t1, t2 );
                    }
                }
            }
            return dp[W];
        }
       
        //указание Д
        private void указатьDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();  //форма для ввода ограничения
            f.ShowDialog();         //отображение формы
            D = f.D;                //получаем D  
            toolStripMenuItem2.Text = D.ToString(); // выводим Д
        }
    }
}
