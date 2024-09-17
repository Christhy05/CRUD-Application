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

namespace Student
{
  
    public partial class SignIn : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\StudentDB.mdf;Integrated Security=True");
        stuStaffDataContext ssc = new stuStaffDataContext();
        public SignIn()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login log = new login();    
            log.Show();
            this.Hide();
        }

        private void btnsignin_Click(object sender, EventArgs e)
        {
            LoginTable lotb = new LoginTable();    
            lotb.Name = txtname.Text;
            lotb.UserName = txtuname.Text;
            lotb.Password = txtpassword.Text;
            lotb.Role = comboBox1.Text;

            ssc.LoginTables.InsertOnSubmit(lotb);
            ssc.SubmitChanges();

            MessageBox.Show("Successfully created !");
        }
    }
}
