using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace torque
{
    public partial class Admin : Form
    {
        string cs = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ajwa\Desktop\torqueeee\Weather.mdf;Integrated Security=True";
        int count = 0;
        int found = 0, found2 = 0, found3 = 0, found4 = 0, found5 = 0, found6 = 0, found7 = 0;
        
        public Admin()
        {
            InitializeComponent();
        }
     
        private void btnUpdate_Click(object sender, EventArgs e)
        {
           

        }

        private void cmbWeather_SelectedIndexChanged(object sender, EventArgs e)
        {

            string sunnyImg = "C:\\Users\\ajwa\\Desktop\\torqueeee\\img\\sunny.png";
            string rainImg = "C:\\Users\\ajwa\\Desktop\\torqueeee\\img\\rain.png";
            string coldImg = "C:\\Users\\ajwa\\Desktop\\torqueeee\\img\\cold.png";
            string overcastImg = "C:\\Users\\ajwa\\Desktop\\torqueeee\\img\\overcast.png";

            if (cmbWeather.SelectedItem.ToString() == "Sunny")
            {

                pictureBox1.ImageLocation = sunnyImg;
            }
            else if (cmbWeather.SelectedItem.ToString() == "Rain")
            {

                pictureBox1.ImageLocation = rainImg;
            }
            else if (cmbWeather.SelectedItem.ToString() == "Cold")
            {

                pictureBox1.ImageLocation = coldImg;
            }
            else if (cmbWeather.SelectedItem.ToString() == "Overcast")
            {

                pictureBox1.ImageLocation = overcastImg;
            }

        }

        private void cmbDay_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbDay.SelectedItem == "Saturday")
            {
                found++;
                if (found == 1)
                {
                }
                else
                {
                    MessageBox.Show("Can Select Only Once");
                }
            }
            else if (cmbDay.SelectedItem == "Sunday")
            {

                found2++;
                if (found2 == 1)
                {
                }
                else
                {
                    MessageBox.Show("Can Select Only Once");

                }
            }
            else if (cmbDay.SelectedItem == "Monday")
            {
                found3++;
                if (found3 == 1)
                {
                }
                else
                {
                    MessageBox.Show("Can Select Only Once");
                }
            }
            else if (cmbDay.SelectedItem == "Tuesday")
            {
                found4++;
                if (found4 == 1)
                {
                }
                else
                {
                    MessageBox.Show("Can Select Only Once");
                }
            }
            else if (cmbDay.SelectedItem == "Wednesday")
            {
                found5++;
                if (found5 == 1)
                {
                }
                else
                {
                    MessageBox.Show("Can Select Only Once");
                }
            }
            else if (cmbDay.SelectedItem == "Thursday")
            {
                found6++;
                if (found6 == 1)
                {
                }
                else
                {
                    MessageBox.Show("Can Select Only Once");
                }
            }
            else if (cmbDay.SelectedItem == "Friday")
            {

                found7++;
                if (found7 == 1)
                {
                }
                else
                {
                    MessageBox.Show("Can Select Only Once");
                }
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
            SqlConnection conn = new SqlConnection(cs);
            conn.Open();
            SqlCommand obj = conn.CreateCommand();
            SqlCommand obj1 = conn.CreateCommand();
            obj.CommandType = System.Data.CommandType.Text;
            obj1.CommandType = System.Data.CommandType.Text;
            string day = "", weather = "";
            string minTemp, maxTemp, Temp, city = "";
            DateTime iDate;
            string date;
            
                if (txtCity.Text == "")
                {
                    MessageBox.Show("Field should not be Empty");
                }
                else if (cmbDay.Text == "")
                {
                    MessageBox.Show("Field should not be Empty");
                }
                else if (cmbWeather.Text == "")
                {
                    MessageBox.Show("Field should not be Empty");
                }

                else
                {
                    count++;
                    iDate = dateTimePicker1.Value;
                    date = iDate.ToString("dd/MM/yyyy");
                    city = txtCity.Text;
                    day = cmbDay.SelectedItem.ToString();
                    weather = cmbWeather.SelectedItem.ToString();
                    maxTemp = nupMaxTemp.Value.ToString();
                    minTemp = nupMiniTemp.Value.ToString();
                    Temp = nupTemp.Value.ToString();
                    obj.CommandText = "INSERT INTO dataSet(City,Day,Weather,MiniTemp,MaxTemp,Temperature)VALUES('" + city + "','" + day + "','" + weather + "','" + minTemp + "','" + maxTemp + "','" + Temp + "')";
                    obj1.CommandText = "INSERT INTO History(Date,City,Day,Weather,MiniTemp,MaxTemp,Temperature)VALUES('" + date + "','" + city + "','" + day + "','" + weather + "','" + minTemp + "','" + maxTemp + "','" + Temp + "')";

                    obj.ExecuteNonQuery();
                    obj1.ExecuteNonQuery();
                    MessageBox.Show("Registration is successfull!");
                    label7.Text = "Entry Remaining :" + (7 - count).ToString();
                    if (count == 7)
                    {
                        landingpage obj4 = new landingpage();
                        obj4.Show();
                        this.Hide();
                    }
                    else if (count == 1 || count == 5)
                    {
                        MessageBox.Show("Must Do 7 day Entry-->7 days");
                    }
                }
                cmbDay.ResetText();
                cmbWeather.ResetText();
                nupMiniTemp.ResetText();
                nupMaxTemp.ResetText();
                nupTemp.ResetText();
          
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            

        }


    }
}
