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
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\StudentDB.mdf;Integrated Security=True");
        stuStaffDataContext stu = new stuStaffDataContext();   
        public Form1()
        {
            InitializeComponent();
            panel1.Visible = false;
            panel2.Visible = false;

        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            StuTable sttbl = new StuTable();
            sttbl.StuId=txtstuid.Text;
            sttbl.StuName = txtstuname.Text;

            stu.StuTables.InsertOnSubmit(sttbl);
            stu.SubmitChanges();

            MessageBox.Show("Data is Entered !");

        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            //List<StuTable> stbl = stu.StuTables.ToList();
            //dataGridView1.DataSource = stbl;

            var st = from s in stu.StuTables select s;
            dataGridView1.DataSource = st;
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           // panel1.Visible = true;
        }

        private void btnseachh_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                panel2.Visible=true;
                SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\StudentDB.mdf;Integrated Security=True");
                try
                {
                    sc.Open();
                    var searchid = txtSearch.Text;
                    SqlCommand cmd = new SqlCommand("SELECT * FROM StuTable WHERE StuId=@id", sc);
                    cmd.Parameters.AddWithValue("@id", searchid);
                    SqlDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        txtupid.Text = rd.GetValue(0).ToString();
                        txtupname.Text=rd.GetValue(1).ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error : "+ex.Message);
                }
                finally
                {
                    sc.Close();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string Search_id = txtSearch.Text;
           // string newid = txtupid.Text;
            string newname = txtupname.Text;

            SqlConnection up = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\StudentDB.mdf;Integrated Security=True");
            try
            {
                up.Open();
                SqlCommand cmd = new SqlCommand("UPDATE StuTable SET StuName=@name WHERE StuId=@id",up);
                cmd.Parameters.AddWithValue("@id", Search_id);
                cmd.Parameters.AddWithValue("@name", newname);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
            finally 
            { 
                up.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*SqlConnection del = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\StudentDB.mdf;Integrated Security=True");
            try
            {
                del.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM StuTable WHERE StuId=@id", del);
                cmd.Parameters.AddWithValue("@id", txtdelid.Text);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully!");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                del.Close();    
            }*/
        }
    }
}
