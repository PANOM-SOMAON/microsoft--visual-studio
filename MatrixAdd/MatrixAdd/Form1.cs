namespace MatrixAdd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int [,] Matrix1, Matrix2, AddMatrix;

        private void button1_Click(object sender, EventArgs e)
        {
            int RowSize = int.Parse(textBox1.Text);
            int ColSize = int.Parse(textBox2.Text);

            Matrix1 = new int[RowSize, ColSize];
            for (int i = 0; i < RowSize; ++i)
            {
                string rowTxt = "";
                for (int j = 0; j < ColSize; ++j)
                {
                    string data = Microsoft.VisualBasic.Interaction.InputBox("แถวที่" + i + " หลักที่ " +j ,"Matrix","0",0,0);
                    Matrix1[i,j] = int.Parse(data);
                    rowTxt += data +"";
                }
                listBox1.Items.Add(rowTxt);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int RowSize = int.Parse (textBox1.Text);
            int ColSize = int.Parse (textBox2.Text);

            Matrix2 = new int[RowSize, ColSize];
            for (int i = 0;i < RowSize; ++i)
            {
                string rowTxt = "";
                for (int j = 0;j < ColSize; ++j)
                {
                    string data = Microsoft.VisualBasic.Interaction.InputBox("แถวที่ " + i + " หลักที่ " + j, "Matrix2","0",0,0);
                    Matrix2[i,j] = int.Parse(data);
                    rowTxt += data + "";
                }
                listBox2.Items.Add(rowTxt);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int RowSize = int.Parse (textBox1.Text);
            int ColSize = int.Parse (textBox2.Text);

            AddMatrix = new int[RowSize, ColSize];  
            for (int i = 0; i < RowSize; ++i)
            {
                string rowTxt = "";
                for (int j = 0; j < ColSize; ++j)
                {
                    AddMatrix[i, j] = Matrix1[i, j] + Matrix2[i, j];
                    rowTxt += AddMatrix[i, j] +"";
                }
                listBox3.Items.Add(rowTxt);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
        }
    }
}