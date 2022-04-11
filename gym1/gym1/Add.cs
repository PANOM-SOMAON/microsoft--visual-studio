using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace gym1
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

       
        SqlConnection Conn = new SqlConnection(@"Data Source=DESKTOP-G1D1LLT\SQLEXPRESS;Initial Catalog=GymDb;Integrated Security=True");
        private void Add_Load(object sender, EventArgs e)
        {

        }

        private void savetb_Click(object sender, EventArgs e)
        {
            if (Nametb.Text == "" || Lasttb.Text == "" || Agetb.Text == "" || Phonetb.Text == "")
            {
                MessageBox.Show("กรุณาใส่ข้อมูลให้ครบ");
            }
            else
            {
                try
                {
                    Conn.Open();
                    string query = "INSERT INTO MemberTb2 (MName,MLast,MAge,MGen,MPhone,MTime) VALUES ('" + Nametb.Text + "','" + Lasttb.Text + "','" + Agetb.Text + "','" + Gendercb.SelectedItem.ToString() + "','" + Phonetb.Text + "','" + Timecb.SelectedItem.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(query,Conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("เพิ่มสมาชิกสำเร็จ");
                    Conn.Close();
                    Nametb.Text = "";
                    Agetb.Text = "";
                    Lasttb.Text = "";
                    Phonetb.Text = "";
                    Gendercb.Text = "";
                    Timecb.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
            
        }

        private void Resettb_Click(object sender, EventArgs e)
        {
            Nametb.Text = "";
            Agetb.Text = "";
            Lasttb.Text = "";
            Phonetb.Text = "";
            Gendercb.Text = "";
            Timecb.Text = "";
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

        private void Logoutbt_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
