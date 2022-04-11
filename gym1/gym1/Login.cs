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
    public partial class Login : Form 
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Loginbt_Click(object sender, EventArgs e)
        {
            if(UidTb.Text == "" || PassTb.Text == "")
            {
                MessageBox.Show("กรุณาใส่ข้อมูล");
            }
            else if(UidTb.Text == "Admin" && PassTb.Text == "Admin")
            {
                MainForm mainform = new MainForm();
                mainform.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(" Id or Password ไม่ถูกต้อง");
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
