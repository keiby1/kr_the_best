using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace курсовая_МИМПРО
{
    public partial class Form1 : Form
    {
        private int D;
        public Form1()
        {
            InitializeComponent();
            D = 0;
        }

        private void считатьДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
            dataGridView1.Rows[0].Cells[0].Value = "d";
            dataGridView1.Rows[0].Cells[1].Value = 20;
            dataGridView1.Rows[0].Cells[2].Value = 40;
            dataGridView1.Rows[0].Cells[3].Value = 50;
            dataGridView1.Rows[0].Cells[4].Value = 10;
            dataGridView1.Rows[0].Cells[5].Value = 30;
            dataGridView1.Rows[0].Cells[6].Value = 70;
            dataGridView1.Rows[0].Cells[7].Value = 10;
            dataGridView1.Rows[0].Cells[8].Value = 60;
            dataGridView1.Rows[0].Cells[9].Value = 50;
            dataGridView1.Rows[0].Cells[10].Value = 40;

            dataGridView1.Rows.Add();
            dataGridView1.Rows[1].Cells[0].Value = "q";
            dataGridView1.Rows[1].Cells[1].Value = 5;
            dataGridView1.Rows[1].Cells[2].Value = 6;
            dataGridView1.Rows[1].Cells[3].Value = 8;
            dataGridView1.Rows[1].Cells[4].Value = 2;
            dataGridView1.Rows[1].Cells[5].Value = 4;
            dataGridView1.Rows[1].Cells[6].Value = 7;
            dataGridView1.Rows[1].Cells[7].Value = 3;
            dataGridView1.Rows[1].Cells[8].Value = 5;
            dataGridView1.Rows[1].Cells[9].Value = 1;
            dataGridView1.Rows[1].Cells[10].Value = 6;

            

        }

        private void очиститьДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void рассчитатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
   
        }

        private void указатьDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
            D = f.D;//спиздить из того д новое д
            toolStripMenuItem2.Text = D.ToString();
        }
    }
}
