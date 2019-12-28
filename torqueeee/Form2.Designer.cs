namespace torque
{
    partial class signupform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signupform));
            this.s_name = new System.Windows.Forms.TextBox();
            this.s_email = new System.Windows.Forms.TextBox();
            this.s_password = new System.Windows.Forms.TextBox();
            this.s_phone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.signupbtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.s_username = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.s_confirmpassword = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.op = new System.Windows.Forms.Label();
            this.s_gtlbtntimer = new System.Windows.Forms.Timer(this.components);
            this.reg_bcktohomebtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.goTologin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // s_name
            // 
            this.s_name.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.s_name.Location = new System.Drawing.Point(302, 102);
            this.s_name.Name = "s_name";
            this.s_name.Size = new System.Drawing.Size(216, 20);
            this.s_name.TabIndex = 0;
            this.s_name.TextChanged += new System.EventHandler(this.s_name_TextChanged);
            // 
            // s_email
            // 
            this.s_email.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.s_email.Location = new System.Drawing.Point(302, 276);
            this.s_email.Name = "s_email";
            this.s_email.Size = new System.Drawing.Size(216, 20);
            this.s_email.TabIndex = 1;
            this.s_email.TextChanged += new System.EventHandler(this.s_email_TextChanged);
            // 
            // s_password
            // 
            this.s_password.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.s_password.Location = new System.Drawing.Point(302, 349);
            this.s_password.MaxLength = 20;
            this.s_password.Name = "s_password";
            this.s_password.PasswordChar = '*';
            this.s_password.Size = new System.Drawing.Size(216, 20);
            this.s_password.TabIndex = 2;
            this.s_password.TextChanged += new System.EventHandler(this.s_password_TextChanged);
            // 
            // s_phone
            // 
            this.s_phone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.s_phone.Location = new System.Drawing.Point(302, 480);
            this.s_phone.Name = "s_phone";
            this.s_phone.Size = new System.Drawing.Size(216, 20);
            this.s_phone.TabIndex = 3;
            this.s_phone.TextChanged += new System.EventHandler(this.s_phone_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(0, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(0, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(0, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(0, 467);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Phone #";
            // 
            // signupbtn
            // 
            this.signupbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.signupbtn.BackColor = System.Drawing.Color.Transparent;
            this.signupbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.signupbtn.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupbtn.ForeColor = System.Drawing.SystemColors.MenuText;
            this.signupbtn.Image = global::torque.Properties.Resources.blackoutline;
            this.signupbtn.Location = new System.Drawing.Point(313, 567);
            this.signupbtn.Name = "signupbtn";
            this.signupbtn.Size = new System.Drawing.Size(194, 81);
            this.signupbtn.TabIndex = 8;
            this.signupbtn.Text = "SIGN UP";
            this.signupbtn.UseVisualStyleBackColor = false;
            this.signupbtn.Click += new System.EventHandler(this.Signupbtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(524, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(524, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(0, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Username";
            // 
            // s_username
            // 
            this.s_username.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.s_username.Location = new System.Drawing.Point(302, 186);
            this.s_username.Name = "s_username";
            this.s_username.Size = new System.Drawing.Size(216, 20);
            this.s_username.TabIndex = 0;
            this.s_username.TextChanged += new System.EventHandler(this.s_username_TextChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(0, 400);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(205, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "Confirm Password";
            // 
            // s_confirmpassword
            // 
            this.s_confirmpassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.s_confirmpassword.Location = new System.Drawing.Point(302, 413);
            this.s_confirmpassword.MaxLength = 20;
            this.s_confirmpassword.Name = "s_confirmpassword";
            this.s_confirmpassword.PasswordChar = '*';
            this.s_confirmpassword.Size = new System.Drawing.Size(216, 20);
            this.s_confirmpassword.TabIndex = 2;
            this.s_confirmpassword.TextChanged += new System.EventHandler(this.s_confirmpassword_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(524, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "*";
            // 
            // op
            // 
            this.op.AutoSize = true;
            this.op.BackColor = System.Drawing.Color.Transparent;
            this.op.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op.ForeColor = System.Drawing.SystemColors.Window;
            this.op.Location = new System.Drawing.Point(557, 625);
            this.op.Name = "op";
            this.op.Size = new System.Drawing.Size(0, 19);
            this.op.TabIndex = 11;
            // 
            // s_gtlbtntimer
            // 
            this.s_gtlbtntimer.Interval = 1000;
            this.s_gtlbtntimer.Tick += new System.EventHandler(this.S_gtlbtntimer_Tick);
            // 
            // reg_bcktohomebtn
            // 
            this.reg_bcktohomebtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.reg_bcktohomebtn.BackColor = System.Drawing.Color.Transparent;
            this.reg_bcktohomebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reg_bcktohomebtn.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_bcktohomebtn.ForeColor = System.Drawing.Color.Black;
            this.reg_bcktohomebtn.Image = ((System.Drawing.Image)(resources.GetObject("reg_bcktohomebtn.Image")));
            this.reg_bcktohomebtn.Location = new System.Drawing.Point(527, 567);
            this.reg_bcktohomebtn.Name = "reg_bcktohomebtn";
            this.reg_bcktohomebtn.Size = new System.Drawing.Size(182, 77);
            this.reg_bcktohomebtn.TabIndex = 9;
            this.reg_bcktohomebtn.Text = "Back";
            this.reg_bcktohomebtn.UseVisualStyleBackColor = false;
            this.reg_bcktohomebtn.Click += new System.EventHandler(this.Reg_bcktohomebtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // goTologin
            // 
            this.goTologin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.goTologin.BackColor = System.Drawing.Color.Transparent;
            this.goTologin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.goTologin.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goTologin.ForeColor = System.Drawing.SystemColors.Window;
            this.goTologin.Image = ((System.Drawing.Image)(resources.GetObject("goTologin.Image")));
            this.goTologin.Location = new System.Drawing.Point(750, 467);
            this.goTologin.Name = "goTologin";
            this.goTologin.Size = new System.Drawing.Size(182, 81);
            this.goTologin.TabIndex = 12;
            this.goTologin.Text = "Go to Login";
            this.goTologin.UseVisualStyleBackColor = false;
            this.goTologin.Click += new System.EventHandler(this.goTologin_Click);
            // 
            // signupform
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::torque.Properties.Resources.YTQhnGkV9mvG4RO9Y6umiwPdGeaHLWuCaK5HKqjJztJy2yLcblVFZZLD0H1PWUf2tgiiwDnF4Nd2kuDyfVMTgsy_WwUmiLGw_8OWmvkjyfucx_eZtHoJXag4WFwv83COOsvXdFW6AqBe;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(991, 660);
            this.Controls.Add(this.goTologin);
            this.Controls.Add(this.op);
            this.Controls.Add(this.reg_bcktohomebtn);
            this.Controls.Add(this.signupbtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.s_phone);
            this.Controls.Add(this.s_confirmpassword);
            this.Controls.Add(this.s_password);
            this.Controls.Add(this.s_email);
            this.Controls.Add(this.s_username);
            this.Controls.Add(this.s_name);
            this.Name = "signupform";
            this.Text = "Sign Up";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Signupform_FormClosing);
            this.Load += new System.EventHandler(this.Signupform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox s_name;
        private System.Windows.Forms.TextBox s_email;
        private System.Windows.Forms.TextBox s_password;
        private System.Windows.Forms.TextBox s_phone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button signupbtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox s_username;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox s_confirmpassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label op;
        private System.Windows.Forms.Timer s_gtlbtntimer;
        private System.Windows.Forms.Button reg_bcktohomebtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button goTologin;
    }
}