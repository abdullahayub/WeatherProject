using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace torque
{
    public partial class torqueform : Form
    {
        public torqueform()
        {
            InitializeComponent();
        }

        private void Torqueform_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do You Really Want To Close?","Warning!",  MessageBoxButtons.YesNo);
            if(dr==DialogResult.Yes)
            {
               
                 e.Cancel = false;
                
               
            }
            if(dr==DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void H_signinbtn_Click_1(object sender, EventArgs e)
        {
            Loginform lf = new Loginform();
            this.Hide();
            lf.Show();
        }

        private void H_registerbtn_Click_1(object sender, EventArgs e)
        {
            signupform sf = new signupform();
            sf.Show();
            this.Hide();
        }

        private void torqueform_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
