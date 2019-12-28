using System;
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
    public partial class signupform : Form
    {
        private int _tickss;
        torqueform tff=new torqueform();
        string connectionstring = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ajwa\Desktop\torqueeee\Weather.mdf;Integrated Security=True";
      //  string connectionstring = @"Data Source = DESKTOP-O1TFQGA\SQLEXPRESS; Initial Catalog = Torque;Integrated Security=True";
        public signupform()
        {
            InitializeComponent();
            goTologin.Hide();
            
        }

        public static bool hasSpecialChar(string input)
        {
            string specialChar = @"\|!#$%&/()=?»«@£§€{}.;'<>_,";
            foreach (var item in specialChar)
            {
                if (input.Contains(item))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool hasUpperCaseLetter(string input)
        {
            foreach (char c in input)
            {
                if (char.IsUpper(c))
                {
                    return true;
                }

            }
            return false;
        }


        public static bool hasLowerCaseLetter(string input)
        {
            foreach (char c in input)
            {
                if (char.IsLower(c))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool hasDecimalDigit(string input)
        {
            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }

        private void Signupbtn_Click(object sender, EventArgs e)
        {

            string name = s_name.Text;
            string user = s_username.Text;
            string email = s_email.Text;
            string pass = s_password.Text;
            string ph = s_phone.Text;
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            SqlCommand obj = conn.CreateCommand();
            obj.CommandType = System.Data.CommandType.Text;

            int phlen;
            int cniclen;
            int passlen;
            phlen = ph.Length;
            passlen = pass.Length;
           

            if (passlen < 6)
            {
                MessageBox.Show("Password must be atleast 6 characters");
            }

            else if (!hasUpperCaseLetter(pass) == true)
            {
                MessageBox.Show("password must contain 1 special character,1 UPPERCASE character,1 LOWER CASE character,1 NUMERIC DIGIT");
            }
            else if (!hasLowerCaseLetter(pass) == true)
            {
                MessageBox.Show("password must contain 1 special character,1 UPPERCASE character,1 LOWER CASE character,1 NUMERIC DIGIT");
            }
            else if (!hasDecimalDigit(pass) == true)
            {
                MessageBox.Show("password must contain 1 special character,1 UPPERCASE character,1 LOWER CASE character,1 NUMERIC DIGIT");
            }
            else if (!hasSpecialChar(pass) == true)
            {
                MessageBox.Show("password must contain 1 special character,1 UPPERCASE character,1 LOWER CASE character,1 NUMERIC DIGIT");
            }
          
            else if (s_password.Text != s_confirmpassword.Text)
            {
                MessageBox.Show("Password do not match");
            }

            else if (phlen != 11)
            {
               MessageBox.Show("Invalid Phone Fomate(####1234567)");
            }
            else if (hasUpperCaseLetter(ph) == true)
            {
                MessageBox.Show("Invalid Phone Fomate(####1234567)");
            }
            else if (hasLowerCaseLetter(ph) == true)
            {

                MessageBox.Show("Invalid Phone Fomate(####1234567)");
            }
            else if (hasSpecialChar(ph) == true)
            {
                MessageBox.Show("Invalid Phone Fomate(####1234567)");
            }

         
            else
            {

                obj.CommandText = "INSERT INTO adduser(Name,username,Email,Password,Phone_number)VALUES('" + name + "','" + user+ "','" +email + "','" + pass+ "','" +ph + "')";
                obj.ExecuteNonQuery();
                MessageBox.Show("Registration is successfull!");
                torqueform trq = new torqueform();
                trq.Show();
                this.Hide();
            }

        }
        void clear()
        {
            s_name.Text = s_username.Text = s_email.Text = s_password.Text = s_phone.Text= s_confirmpassword.Text = "";
        }
        private void Signupform_Load(object sender, EventArgs e)
        {

        }

        private void Reg_bcktohomebtn_Click(object sender, EventArgs e)
        {
            this.Close();
            //tff.Show();
        }

        private void Signupform_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do You Really Want To Close?", "Warning!", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                e.Cancel = false;
                tff.Show();
            }
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Reg_gotologinbtn_Click(object sender, EventArgs e)
        {
            Loginform obj1 = new Loginform();
            this.Hide();
            obj1.Show();

        }

        private void S_gtlbtntimer_Tick(object sender, EventArgs e)
        {   
                
            
            _tickss++;

            op.Text = "Getting things ready "+_tickss.ToString();
            if (_tickss == 1)
                goTologin.Show();
            if(_tickss==2)
                goTologin.Hide();
            if(_tickss==3)
                goTologin.Show();
            if (_tickss == 4)
                goTologin.Hide();
            if (_tickss==5)
            {
                op.Text = "Done";
                s_gtlbtntimer.Stop();
                goTologin.Show();
            }
        }

        private void s_name_TextChanged(object sender, EventArgs e)
        {
            if (s_name.Text == "")
            {

                errorProvider1.SetError(s_name, "Field should not be Empty");
            }
            else
            {
                errorProvider1.Clear();
            }

        }

        private void goTologin_Click(object sender, EventArgs e)
        {

            Loginform lff = new Loginform();
            this.Hide();
            lff.Show();

        }

        private void s_username_TextChanged(object sender, EventArgs e)
        {
            if (s_username.Text== "")
            {
               
                errorProvider1.SetError(s_username, "Field should not be Empty");
            }
            else
            {
                errorProvider1.Clear();
            }

        }

        private void s_email_TextChanged(object sender, EventArgs e)
        {
            if (s_email.Text == "")
            {
                errorProvider1.SetError(s_email, "Field should not be Empty");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void s_password_TextChanged(object sender, EventArgs e)
        {
            if (s_password.Text == "")
            {
                errorProvider1.SetError(s_password, "Field should not be Empty");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void s_confirmpassword_TextChanged(object sender, EventArgs e)
        {
            if (s_confirmpassword.Text == "")
            {
                errorProvider1.SetError(s_confirmpassword, "Field should not be Empty");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void s_phone_TextChanged(object sender, EventArgs e)
        {
            if (s_phone.Text== "")
            {
                errorProvider1.SetError(s_phone, "Field should not be Empty");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
