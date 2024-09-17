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
    public partial class Form2 : Form
    {
       // SqlConnection upload = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\StudentDB.mdf;Integrated Security = True");
        public Form2()
        {
            InitializeComponent();
        }

        private void btnupload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Image";
            ofd.Filter = "JPG file|*.jpg|JPEG file|*.jpeg|PNG file|*.png|All Files|*.*";
            ofd.InitialDirectory = @"C:\Users\hp\Pictures\Food";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(ofd.FileName);
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
