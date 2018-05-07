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
    public partial class Form2 : Form
    {
        public int D;
        public Form2()
        {
            InitializeComponent();
            D = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            D = Convert.ToInt32(textBox1.Text);
            this.Close();
        }
    }
}
