using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace torque
{
    public partial class landingpage : Form
    {
        string cs = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ajwa\Desktop\torqueeee\Weather.mdf;Integrated Security=True";
        public landingpage()
        {
            InitializeComponent();
        }
        public void setlabel(string o)
        {
            lp_welcm_lbl.Text += "\nRespected User "+o;
        }
        private void Lp_logoutbtn_Click_1(object sender, EventArgs e)
        {
            torqueform tobj = new torqueform();
            DialogResult dr = MessageBox.Show("Do You want to continue to logout?", "Good Bye", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                this.Close();
                tobj.Show();
            }
            else if (dr == DialogResult.No)
            {
                ;
            }
         
        }

        private void lp_welcm_lbl_Click(object sender, EventArgs e)
        {

        }

        private void al_guidebtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(cs);
            conn.Open();
            try
            {
                SqlCommand obj = conn.CreateCommand();
                obj.CommandType = System.Data.CommandType.Text;
                obj.CommandText = "DELETE FROM dataSet";
                obj.ExecuteNonQuery();
               
                Admin ad = new Admin();
                ad.Show();
                this.Hide();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
           
        }

        private void al_needmchncbtn_Click(object sender, EventArgs e)
        {
            Form4 obj = new Form4();
            obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(cs);
            conn.Open();
            try
            {
                SqlCommand obj = conn.CreateCommand();
                obj.CommandType = System.Data.CommandType.Text;
                obj.CommandText = "DELETE FROM dataSet";
                obj.ExecuteNonQuery();
                MessageBox.Show("Successfully Deleted!");
               
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
          
        }
    }
}
