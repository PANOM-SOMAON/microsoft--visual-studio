using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gym1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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
