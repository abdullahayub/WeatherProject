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
    public partial class Loginform : Form
    {
        torqueform tf = new torqueform();
         landingpage lp = new landingpage();
         string cs = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ajwa\Desktop\torqueeee\Weather.mdf;Integrated Security=True";

        public Loginform()
        {
            InitializeComponent();
        }
        private void Loginform_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do You Really Want To Close?","Warning!" , MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                e.Cancel = false;
                tf.Show();
            }
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {

            SqlConnection myConnection = default(SqlConnection);
            myConnection = new SqlConnection(cs);

            SqlCommand myCommand = default(SqlCommand);
            string sql = "SELECT Name,Email,Password FROM adduser WHERE username = @user AND Password = @Password";
            myCommand = new SqlCommand(sql, myConnection);
            SqlParameter uName = new SqlParameter("@user", SqlDbType.VarChar);
            SqlParameter uPassword = new SqlParameter("@Password", SqlDbType.VarChar);
            uName.Value = textBox1.Text;
            uPassword.Value = l_password.Text;
            myCommand.Parameters.Add(uName);
            myCommand.Parameters.Add(uPassword);
            myCommand.Connection.Open();

            SqlDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);
            try{
           if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Field should not be Empty");
            }
            
            else if (l_password.Text == "")
            {
                errorProvider1.SetError(textBox1, "Field should not be Empty"); 
            }
          
           else  if (myReader.Read() == true)
                {
                    string op = "";

                    op = op + myReader.GetValue(0);
                    op = char.ToUpper(op[0]) + op.Substring(1);
                    this.Hide();
                    lp.setlabel(op);
                    lp.Show();
                    MessageBox.Show("Successfully Logged in as " + op + "!!");
                }


                else
                {
                   
                    MessageBox.Show("Login Failed...Try again !", "Login Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBox1.Clear();
                    l_password.Clear();
                    textBox1.Focus();

                }
                if (myConnection.State == ConnectionState.Open)
                {
                    myConnection.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_bcktohomebtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
            //tf.Show();

        }

        private void l_email_TextChanged(object sender, EventArgs e)
        {

            if (textBox1.Text=="")
            {
               errorProvider1.SetError(textBox1, "Field should not be Empty");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void l_password_Click(object sender, EventArgs e)
        {

        }

        private void l_password_MouseClick(object sender, MouseEventArgs e)
        {

            if (textBox1.Text=="")
            {
                errorProvider1.SetError(textBox1, "Field should not be Empty");
            }

        }

        private void l_password_TextChanged(object sender, EventArgs e)
        {
            if (l_password.Text=="")
            {
                errorProvider1.SetError(l_password, "Field should not be Empty");
            }

            else
            {
                errorProvider1.Clear();
            }
        }

        private void Loginform_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
