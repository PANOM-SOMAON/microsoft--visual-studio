using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gym1
{
    public partial class Delete_edit : Form
    {
        public Delete_edit()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-G1D1LLT\SQLEXPRESS;Initial Catalog=GymDb;Integrated Security=True");
        private void populate()
        {
            Con.Open();
            string query = "SELECT * FROM MemberTb2";

            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            dataView.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Delete_edit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gymDbDataSet.MemberTb2' table. You can move, or remove it, as needed.
            this.memberTb2TableAdapter.Fill(this.gymDbDataSet.MemberTb2);

            populate();
        }
        int Key=0;
        private void dataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Key = Convert.ToInt32(dataView.SelectedRows[0].Cells[0].Value.ToString());
            Nametb.Text = dataView.SelectedRows[0].Cells[1].Value.ToString();
            Lasttb.Text = dataView.SelectedRows[0].Cells[2].Value.ToString();
            Agetb.Text = dataView.SelectedRows[0].Cells[3].Value.ToString();
            Gendercb.Text = dataView.SelectedRows[0].Cells[4].Value.ToString();
            Phonetb.Text = dataView.SelectedRows[0].Cells[5].Value.ToString();
            Timecb.Text = dataView.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void Resettb_Click(object sender, EventArgs e)
        {
            Nametb.Text = "";
            Lasttb.Text = "";
            Agetb.Text = "";
            Gendercb.Text = "";
            Phonetb.Text = "";
            Timecb.Text = "";
        }

        private void deletetb_Click(object sender, EventArgs e)
        {
            if(Key == 0)
            {
                MessageBox.Show("เลือกสมาชิกที่จะลบ");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from MemberTb2 where MId=" + Key + ";";
                    SqlCommand cmd = new SqlCommand(query,Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("ลบสมาชิกเรียบร้อยแล้ว");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void savetb_Click(object sender, EventArgs e)
        {
            if (Key == 0 ||Nametb.Text ==""||Lasttb.Text ==""||Agetb.Text ==""||Gendercb.Text ==""||Phonetb.Text ==""||Timecb.Text =="")
            {
                MessageBox.Show("ไม่มีข้อมูล");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update MemberTb2 set MName='" + Nametb.Text + "',MLast='" + Lasttb.Text + "',MAge='" + Agetb.Text + "',MGen='" + Gendercb.Text + "',MPhone='" + Phonetb.Text + "',MTime='" + Timecb.Text + "' where MId="+Key+";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("อัพเดทสมาชิกเรียบร้อยแล้ว");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Logoutbt_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void Addbt_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.Show();
            this.Hide();
        }

        private void Delebt_Click(object sender, EventArgs e)
        {
            Delete_edit delete = new Delete_edit();
            delete.Show();
            this.Hide();
        }

        private void Databt_Click(object sender, EventArgs e)
        {
            Data data = new Data();
            data.Show();
            this.Hide();
        }

        private void Paybt_Click(object sender, EventArgs e)
        {
            pay pay = new pay();
            pay.Show();
            this.Hide();
        }

        

        private void exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
