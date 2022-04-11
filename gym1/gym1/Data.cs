using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace gym1
{
    public partial class Data : Form
    {
        public Data()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-G1D1LLT\SQLEXPRESS;Initial Catalog=GymDb;Integrated Security=True");
        private void populate()
        {
            Con.Open();
            string query = "SELECT * FROM MemberTb2";
            
            SqlDataAdapter sda = new SqlDataAdapter(query ,Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            dataView.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Data_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gymDbDataSet.MemberTb2' table. You can move, or remove it, as needed.
            this.memberTb2TableAdapter.Fill(this.gymDbDataSet.MemberTb2);
            populate( );
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
        private void filterByName()
        {
            Con.Open();
            string query = "select * from MemberTb2 where MName='" + SearchName.Text + "'";

            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            dataView.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Resettb_Click(object sender, EventArgs e)
        {
            populate();
        }
        private void Search_Click(object sender, EventArgs e)
        {
            filterByName();
        }
        private void exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
