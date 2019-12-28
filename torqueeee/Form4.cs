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
    public partial class Form4 : Form
    {
        string cs = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ajwa\Desktop\torqueeee\Weather.mdf;Integrated Security=True";
        string sunnyImg = "C:\\Users\\ajwa\\Desktop\\torqueeee\\img\\sunny.png";
        string rainImg = "C:\\Users\\ajwa\\Desktop\\torqueeee\\img\\rain.png";
        string coldImg = "C:\\Users\\ajwa\\Desktop\\torqueeee\\img\\cold.png";
        string overcastImg = "C:\\Users\\ajwa\\Desktop\\torqueeee\\img\\overcast.png";
        public static int update = 0;

        public Form4()
        {
            InitializeComponent();
        }

        public void CurrentDisplay(string a,string b,string c,string d)
        {
            lblmaxTemp.Text = a;
            lblminTemp.Text = b;
            lblTemp.Text = c;
            lblWeather.Text = d;
            if(d=="Sunny")
            {
                picBIcon.ImageLocation = sunnyImg;
            }
            else if(d=="Rain")
            {
                picBIcon.ImageLocation = rainImg;
            }
             else if(d=="Overcast")
            {
                picBIcon.ImageLocation = overcastImg;
            }
             else if(d=="Cold")
            {
                picBIcon.ImageLocation = coldImg;
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
           }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblSat_Click(object sender, EventArgs e)
        {
           

            SqlConnection conn = new SqlConnection(cs);
            conn.Open();
            SqlCommand scmd = conn.CreateCommand();
            scmd.CommandType = System.Data.CommandType.Text;

            scmd.CommandText = "SELECT * FROM dataSet WHERE Day='Saturday'";
            SqlDataReader reader = scmd.ExecuteReader();
            try
            {

                while (reader.Read())
                {
                    string day = reader["Day"].ToString();
                    string miniTemp = reader["MiniTemp"].ToString();
                    string maxTemp = reader["MaxTemp"].ToString();
                    string temp = reader["Temperature"].ToString();
                    string we = reader["Weather"].ToString();
                    
                    if(day=="Saturday")
                    {
                        Console.WriteLine("Saturday");
                        lbldate.Text = day;
                       CurrentDisplay(maxTemp, miniTemp, temp, we);
                    }
                }

                reader.Close();

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

        private void button1_Click(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString("hh:mm");
            label1.Text = time;



            string str = System.DateTime.Now.DayOfWeek.ToString();
            lbldate.Text = str;
            if (str == "Saturday")
            {
                DateTime dt = DateTime.Now;
                label2.Text = dt.ToString("dd/MM");
                DateTime dt1 = DateTime.Now.AddDays(1);
                label3.Text = dt1.ToString("dd/MM");
                DateTime dt2 = DateTime.Now.AddDays(2);
                label4.Text = dt2.ToString("dd/MM");
                DateTime dt3 = DateTime.Now.AddDays(3);
                label5.Text = dt3.ToString("dd/MM");
                DateTime dt4 = DateTime.Now.AddDays(4);
                label6.Text = dt4.ToString("dd/MM");
                DateTime dt5 = DateTime.Now.AddDays(5);
                label7.Text = dt5.ToString("dd/MM");
                DateTime dt6 = DateTime.Now.AddDays(6);
                label8.Text = dt6.ToString("dd/MM");

            }
            else if (str == "Sunday")
            {
                DateTime dt = DateTime.Now;
                label3.Text = dt.ToString("dd/MM");
                DateTime dt1 = DateTime.Now.AddDays(1);
                label4.Text = dt1.ToString("dd/MM");
                DateTime dt2 = DateTime.Now.AddDays(2);
                label5.Text = dt2.ToString("dd/MM");
                DateTime dt3 = DateTime.Now.AddDays(3);
                label6.Text = dt3.ToString("dd/MM");
                DateTime dt4 = DateTime.Now.AddDays(4);
                label7.Text = dt4.ToString("dd/MM");
                DateTime dt5 = DateTime.Now.AddDays(5);
                label8.Text = dt5.ToString("dd/MM");
                DateTime dt6 = DateTime.Now.AddDays(6);
                label2.Text = dt6.ToString("dd/MM");

            }

            else if (str == "Monday")
            {
                DateTime dt = DateTime.Now;
                label4.Text = dt.ToString("dd/MM");
                DateTime dt1 = DateTime.Now.AddDays(1);
                label5.Text = dt1.ToString("dd/MM");
                DateTime dt2 = DateTime.Now.AddDays(2);
                label6.Text = dt2.ToString("dd/MM");
                DateTime dt3 = DateTime.Now.AddDays(3);
                label7.Text = dt3.ToString("dd/MM");
                DateTime dt4 = DateTime.Now.AddDays(4);
                label8.Text = dt4.ToString("dd/MM");
                DateTime dt5 = DateTime.Now.AddDays(5);
                label2.Text = dt5.ToString("dd/MM");
                DateTime dt6 = DateTime.Now.AddDays(6);
                label3.Text = dt6.ToString("dd/MM");


            }
            else if (str == "Tuesday")
            {
                DateTime dt = DateTime.Now;
                label5.Text = dt.ToString("dd/MM");
                DateTime dt1 = DateTime.Now.AddDays(1);
                label6.Text = dt1.ToString("dd/MM");
                DateTime dt2 = DateTime.Now.AddDays(2);
                label7.Text = dt2.ToString("dd/MM");
                DateTime dt3 = DateTime.Now.AddDays(3);
                label8.Text = dt3.ToString("dd/MM");
                DateTime dt4 = DateTime.Now.AddDays(4);
                label2.Text = dt4.ToString("dd/MM");
                DateTime dt5 = DateTime.Now.AddDays(5);
                label3.Text = dt5.ToString("dd/MM");
                DateTime dt6 = DateTime.Now.AddDays(6);
                label4.Text = dt6.ToString("dd/MM");


            }
            else if (str == "Wednesday")
            {
                DateTime dt = DateTime.Now;
                label6.Text = dt.ToString("dd/MM");
                DateTime dt1 = DateTime.Now.AddDays(1);
                label7.Text = dt1.ToString("dd/MM");
                DateTime dt2 = DateTime.Now.AddDays(2);
                label8.Text = dt2.ToString("dd/MM");
                DateTime dt3 = DateTime.Now.AddDays(3);
                label2.Text = dt3.ToString("dd/MM");
                DateTime dt4 = DateTime.Now.AddDays(4);
                label3.Text = dt4.ToString("dd/MM");
                DateTime dt5 = DateTime.Now.AddDays(5);
                label4.Text = dt5.ToString("dd/MM");
                DateTime dt6 = DateTime.Now.AddDays(6);
                label5.Text = dt6.ToString("dd/MM");

            }
            else if (str == "Thursday")
            {
                DateTime dt = DateTime.Now;
                label7.Text = dt.ToString("dd/MM");
                DateTime dt1 = DateTime.Now.AddDays(1);
                label8.Text = dt1.ToString("dd/MM");
                DateTime dt2 = DateTime.Now.AddDays(2);
                label2.Text = dt2.ToString("dd/MM");
                DateTime dt3 = DateTime.Now.AddDays(3);
                label3.Text = dt3.ToString("dd/MM");
                DateTime dt4 = DateTime.Now.AddDays(4);
                label4.Text = dt4.ToString("dd/MM");
                DateTime dt5 = DateTime.Now.AddDays(5);
                label5.Text = dt5.ToString("dd/MM");
                DateTime dt6 = DateTime.Now.AddDays(6);
                label6.Text = dt6.ToString("dd/MM");


            }
            else if (str == "Friday")
            {
                DateTime dt = DateTime.Now;
                label8.Text = dt.ToString("dd/MM");
                DateTime dt1 = DateTime.Now.AddDays(1);
                label2.Text = dt1.ToString("dd/MM");
                DateTime dt2 = DateTime.Now.AddDays(2);
                label3.Text = dt2.ToString("dd/MM");
                DateTime dt3 = DateTime.Now.AddDays(3);
                label4.Text = dt3.ToString("dd/MM");
                DateTime dt4 = DateTime.Now.AddDays(4);
                label5.Text = dt4.ToString("dd/MM");
                DateTime dt5 = DateTime.Now.AddDays(5);
                label6.Text = dt5.ToString("dd/MM");
                DateTime dt6 = DateTime.Now.AddDays(6);
                label7.Text = dt6.ToString("dd/MM");


            }

       
            SqlConnection conn = new SqlConnection(cs);
            conn.Open();
            SqlCommand scmd = conn.CreateCommand();
            scmd.CommandType = System.Data.CommandType.Text;

            scmd.CommandText = "SELECT * FROM dataSet";
            SqlDataReader reader = scmd.ExecuteReader();
            try
            {

                while (reader.Read())
                {
                    string city = reader["City"].ToString();
                    string day = reader["Day"].ToString();
                    string miniTemp = reader["MiniTemp"].ToString();
                    string maxTemp = reader["MaxTemp"].ToString();
                    string temp = reader["Temperature"].ToString();
                    string we = reader["Weather"].ToString();
                    lblCity.Text = city;
                    if (day == "Saturday")
                    {
                        label22.Text = maxTemp;
                        label9.Text = miniTemp;
                        if (str == "Saturday")
                        {
                            CurrentDisplay(maxTemp, miniTemp, temp, we);
                        }
                        if(we=="Sunny")
                        {
                            pictureBox1.ImageLocation = sunnyImg;
                        }
                        else if(we=="Rain")
                        {
                            pictureBox1.ImageLocation = rainImg;
                        }
                        else if (we == "Overcast")
                        {
                            pictureBox1.ImageLocation = overcastImg;
                        }
                        else if (we == "Cold")
                        {
                            pictureBox1.ImageLocation = coldImg;
                        }
                    }
                    else if (day == "Sunday")
                    {
                        label10.Text = maxTemp;
                        label11.Text = miniTemp;
                        if (str == "Sunday")
                        {
                            CurrentDisplay(maxTemp, miniTemp, temp, we);
                        }
                        if (we == "Sunny")
                        {
                            pictureBox2.ImageLocation = sunnyImg;
                        }
                        else if (we == "Rain")
                        {
                            pictureBox2.ImageLocation = rainImg;
                        }
                        else if (we == "Overcast")
                        {
                            pictureBox2.ImageLocation = overcastImg;
                        }
                        else if (we == "Cold")
                        {
                            pictureBox2.ImageLocation = coldImg;
                        }
                    }
                    else if (day == "Monday")
                    {
                        label12.Text = maxTemp;
                        label13.Text = miniTemp;
                        if (str == "Monday")
                        {
                            CurrentDisplay(maxTemp, miniTemp, temp, we);
                        }
                        if (we == "Sunny")
                        {
                            pictureBox3.ImageLocation = sunnyImg;
                        }
                        else if (we == "Rain")
                        {
                            pictureBox3.ImageLocation = rainImg;
                        }
                        else if (we == "Overcast")
                        {
                            pictureBox3.ImageLocation = overcastImg;
                        }
                        else if (we == "Cold")
                        {
                            pictureBox3.ImageLocation = coldImg;
                        }
                    }
                    else if (day == "Tuesday")
                    {

                        label14.Text = maxTemp;
                        label15.Text = miniTemp;
                        if (str == "Tuesday")
                        {
                            CurrentDisplay(maxTemp, miniTemp, temp, we);
                        }
                        if (we == "Sunny")
                        {
                            pictureBox4.ImageLocation = sunnyImg;
                        }
                        else if (we == "Rain")
                        {
                            pictureBox4.ImageLocation = rainImg;
                        }
                        else if (we == "Overcast")
                        {
                            pictureBox4.ImageLocation = overcastImg;
                        }
                        else if (we == "Cold")
                        {
                            pictureBox4.ImageLocation = coldImg;
                        }
                    }
                    else if (day == "Wednesday")
                    {
                        label16.Text = maxTemp;
                        label17.Text = miniTemp;
                        if (str == "Wednesday")
                        {
                            CurrentDisplay(maxTemp, miniTemp, temp, we);
                        }
                        if (we == "Sunny")
                        {
                            pictureBox5.ImageLocation = sunnyImg;
                        }
                        else if (we == "Rain")
                        {
                            pictureBox5.ImageLocation = rainImg;
                        }
                        else if (we == "Overcast")
                        {
                            pictureBox5.ImageLocation = overcastImg;
                        }
                        else if (we == "Cold")
                        {
                            pictureBox5.ImageLocation = coldImg;
                        }
                    }
                    else if (day == "Thursday")
                    {
                        label18.Text = maxTemp;
                        label19.Text = miniTemp;
                        if (str == "Thursday")
                        {
                            CurrentDisplay(maxTemp, miniTemp, temp, we);
                        }
                        if (we == "Sunny")
                        {
                            pictureBox6.ImageLocation = sunnyImg;
                        }
                        else if (we == "Rain")
                        {
                            pictureBox6.ImageLocation = rainImg;
                        }
                        else if (we == "Overcast")
                        {
                            pictureBox6.ImageLocation = overcastImg;
                        }
                        else if (we == "Cold")
                        {
                            pictureBox6.ImageLocation = coldImg;
                        }
                    }
                    else if (day == "Friday")
                    {
                        label20.Text = maxTemp;
                        label21.Text = miniTemp;
                        if (str == "Friday")
                        {
                            CurrentDisplay(maxTemp, miniTemp, temp, we);
                        }
                        if (we == "Sunny")
                        {
                            pictureBox7.ImageLocation = sunnyImg;
                        }
                        else if (we == "Rain")
                        {
                            pictureBox7.ImageLocation = rainImg;
                        }
                        else if (we == "Overcast")
                        {
                            pictureBox7.ImageLocation = overcastImg;
                        }
                        else if (we == "Cold")
                        {
                            pictureBox7.ImageLocation = coldImg;
                        }
                    }

                }


                reader.Close();

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

        private void lblSun_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(cs);
            conn.Open();
            SqlCommand scmd = conn.CreateCommand();
            scmd.CommandType = System.Data.CommandType.Text;

            scmd.CommandText = "SELECT * FROM dataSet WHERE Day='Sunday'";
            SqlDataReader reader = scmd.ExecuteReader();
            try
            {

                while (reader.Read())
                {
                    string day = reader["Day"].ToString();
                    string miniTemp = reader["MiniTemp"].ToString();
                    string maxTemp = reader["MaxTemp"].ToString();
                    string temp = reader["Temperature"].ToString();
                    string we = reader["Weather"].ToString();

                    if (day == "Sunday")
                    {
                        lbldate.Text = day;
                        CurrentDisplay(maxTemp, miniTemp, temp, we);
                    }
                }

                reader.Close();

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

        private void lblMon_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(cs);
            conn.Open();
            SqlCommand scmd = conn.CreateCommand();
            scmd.CommandType = System.Data.CommandType.Text;

            scmd.CommandText = "SELECT * FROM dataSet WHERE Day='Monday'";
            SqlDataReader reader = scmd.ExecuteReader();
            try
            {

                while (reader.Read())
                {
                    string day = reader["Day"].ToString();
                    string miniTemp = reader["MiniTemp"].ToString();
                    string maxTemp = reader["MaxTemp"].ToString();
                    string temp = reader["Temperature"].ToString();
                    string we = reader["Weather"].ToString();

                    if (day == "Monday")
                    {
                        lbldate.Text = day;
                        CurrentDisplay(maxTemp, miniTemp, temp, we);
                    }
                }

                reader.Close();

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

        private void lblTue_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(cs);
            conn.Open();
            SqlCommand scmd = conn.CreateCommand();
            scmd.CommandType = System.Data.CommandType.Text;

            scmd.CommandText = "SELECT * FROM dataSet WHERE Day='Tuesday'";
            SqlDataReader reader = scmd.ExecuteReader();
            try
            {

                while (reader.Read())
                {
                    string day = reader["Day"].ToString();
                    string miniTemp = reader["MiniTemp"].ToString();
                    string maxTemp = reader["MaxTemp"].ToString();
                    string temp = reader["Temperature"].ToString();
                    string we = reader["Weather"].ToString();

                    if (day == "Tuesday")
                    {
                        lbldate.Text = day;
                        CurrentDisplay(maxTemp, miniTemp, temp, we);
                    }
                }

                reader.Close();

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

        private void lblWed_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(cs);
            conn.Open();
            SqlCommand scmd = conn.CreateCommand();
            scmd.CommandType = System.Data.CommandType.Text;

            scmd.CommandText = "SELECT * FROM dataSet WHERE Day='Wednesday'";
            SqlDataReader reader = scmd.ExecuteReader();
            try
            {

                while (reader.Read())
                {
                    string day = reader["Day"].ToString();
                    string miniTemp = reader["MiniTemp"].ToString();
                    string maxTemp = reader["MaxTemp"].ToString();
                    string temp = reader["Temperature"].ToString();
                    string we = reader["Weather"].ToString();

                    if (day == "Wednesday")
                    {
                        lbldate.Text = day;
                        CurrentDisplay(maxTemp, miniTemp, temp, we);
                    }
                }

                reader.Close();

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

        private void lblThurs_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(cs);
            conn.Open();
            SqlCommand scmd = conn.CreateCommand();
            scmd.CommandType = System.Data.CommandType.Text;

            scmd.CommandText = "SELECT * FROM dataSet WHERE Day='Thursday'";
            SqlDataReader reader = scmd.ExecuteReader();
            try
            {

                while (reader.Read())
                {
                    string day = reader["Day"].ToString();
                    string miniTemp = reader["MiniTemp"].ToString();
                    string maxTemp = reader["MaxTemp"].ToString();
                    string temp = reader["Temperature"].ToString();
                    string we = reader["Weather"].ToString();

                    if (day == "Thursday")
                    {
                        lbldate.Text = day;
                        CurrentDisplay(maxTemp, miniTemp, temp, we);
                    }
                }

                reader.Close();

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

        private void lblFri_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(cs);
            conn.Open();
            SqlCommand scmd = conn.CreateCommand();
            scmd.CommandType = System.Data.CommandType.Text;

            scmd.CommandText = "SELECT * FROM dataSet WHERE Day='Friday'";
            SqlDataReader reader = scmd.ExecuteReader();
            try
            {

                while (reader.Read())
                {
                    string day = reader["Day"].ToString();
                    string miniTemp = reader["MiniTemp"].ToString();
                    string maxTemp = reader["MaxTemp"].ToString();
                    string temp = reader["Temperature"].ToString();
                    string we = reader["Weather"].ToString();

                    if (day == "Friday")
                    {
                        lbldate.Text = day;
                        CurrentDisplay(maxTemp, miniTemp, temp, we);
                    }
                }

                reader.Close();

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

        private void btUpdate_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(cs);
            conn.Open();
            try
            {
                SqlCommand obj = conn.CreateCommand();
                obj.CommandType = System.Data.CommandType.Text;
                obj.CommandText = "DELETE FROM dataSet";
                obj.ExecuteNonQuery();
                //MessageBox.Show("Successfully Deleted!");
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

        private void button2_Click(object sender, EventArgs e)
        {
            landingpage ln = new landingpage();
            ln.Show();
            this.Hide();
        }
    }
}
