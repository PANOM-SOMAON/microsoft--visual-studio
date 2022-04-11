using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CirCleArea
{
    public partial class Form1 : Form
    {
        const float PI = 3.141f;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float Radius;
            float Area;

            Radius = float.Parse(textBox1.Text);
            Area = PI * (Radius * Radius);

            MessageBox.Show("พื้นที่เท่ากับ :" + Area, "ผลการคำนวณ");
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
