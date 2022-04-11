using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float T1 = float.Parse(textBox1.Text);
            float T2 = float.Parse(textBox2.Text);
            float T =T1 + T2;
            if (T <= 100 && T >= 80) { MessageBox.Show("เกรดของคุณคือ A"); }
            else if (T <= 79 && T >= 70) { MessageBox.Show("เกรดของคุณคือ B"); }
            else if (T <= 69 && T >= 60) { MessageBox.Show("เกรดของคุณคือ C"); }
            else if (T <= 59 && T >= 50) { MessageBox.Show("เกรดของคุณคือ D"); }
            else if (T <= 49 && T > 0) { MessageBox.Show("เกรดของคุณคือ F"); }
            else { MessageBox.Show("เกรด N"); }

        }
    }
}
