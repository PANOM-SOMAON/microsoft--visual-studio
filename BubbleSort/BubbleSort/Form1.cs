namespace BubbleSort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] data = new int[10];
        int data_size;
        private void inputButton_Click(object sender, EventArgs e)
        {
            data_size = 0;
            string output = "";
            int i;
            for (i = 0; i < data.Length; i++)
            {
                string txt = "รับค่าตัวเลขที่" + i + "\n (หากต้องการออกให้ใส่ค่า -1)";
                string input = Microsoft.VisualBasic.Interaction.InputBox( txt ,"รับค่าตัวเลขจากคีย์บอร์ด", "", 0, 0);
                int temp = int.Parse(input);
                if (temp == -1)
                {
                    break;
                }
                else
                {
                    data[i] = temp;
                }
                output += input + "";
            }
            data_size = i;
            inputtextBox.Text = output;
        }

        private void outputbutton_Click(object sender, EventArgs e)
        {
            BubbleSort();
            string output = "";
            for (int i = 0; i < data.Length; ++i)
            {
                output += data[i] +"";
            }
            outputtextBox.Text = output;
        }
        public void BubbleSort()
        {
            int i;
            int j;
            int temp;
            for(i = (data_size - 1); i >= 0; i--)
            {
                for (j = 1; j <= i; j++)
                {
                    if (data[j -1] > data[j])
                    {
                        temp = data[j-1];
                        data[j-1] = data[j];
                        data[j] = temp;
                    }
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            data_size =0;
            inputtextBox.Clear();
            outputtextBox.Clear();
        }
    }
}