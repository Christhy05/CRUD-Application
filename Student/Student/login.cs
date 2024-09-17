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
    public partial class login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\StudentDB.mdf;Integrated Security=True");
        stuStaffDataContext ss = new stuStaffDataContext();
        public login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

            LoginTable lotable = new LoginTable();  
            Form1 frm1 = new Form1();
            Form2 frm2 = new Form2();   

            var user = ss.LoginTables.Where(u=>u.UserName==(txtusername.Text) && u.Password==(txtpassword.Text)).FirstOrDefault();
            if(user!=null)
            {
                if (user.Role == "Student")
                {
                    frm2.Show();
                    this.Hide();
                }
                else
                {
                    frm1.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Must fill the field !");
            }
        }

        private void btnsing_Click(object sender, EventArgs e)
        {
            SignIn sign = new SignIn();
            sign.Show();
            this.Hide();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
