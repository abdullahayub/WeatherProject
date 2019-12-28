namespace torque
{
    partial class torqueform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(torqueform));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.h_registerbtn = new System.Windows.Forms.Button();
            this.h_signinbtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.85655F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.14345F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.h_registerbtn, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.h_signinbtn, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-2, -1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.83721F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.16279F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 141F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(976, 700);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Brush Script MT", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(96, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 37);
            this.label1.TabIndex = 25;
            this.label1.Text = "Welcome to Weather App";
            // 
            // h_registerbtn
            // 
            this.h_registerbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.h_registerbtn.BackColor = System.Drawing.Color.Transparent;
            this.h_registerbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.h_registerbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.h_registerbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.h_registerbtn.Image = global::torque.Properties.Resources.whs;
            this.h_registerbtn.Location = new System.Drawing.Point(764, 580);
            this.h_registerbtn.Name = "h_registerbtn";
            this.h_registerbtn.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.h_registerbtn.Size = new System.Drawing.Size(209, 117);
            this.h_registerbtn.TabIndex = 22;
            this.h_registerbtn.UseVisualStyleBackColor = false;
            this.h_registerbtn.Click += new System.EventHandler(this.H_registerbtn_Click_1);
            // 
            // h_signinbtn
            // 
            this.h_signinbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.h_signinbtn.BackColor = System.Drawing.Color.Transparent;
            this.h_signinbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.h_signinbtn.Image = global::torque.Properties.Resources.white;
            this.h_signinbtn.Location = new System.Drawing.Point(3, 580);
            this.h_signinbtn.Name = "h_signinbtn";
            this.h_signinbtn.Size = new System.Drawing.Size(209, 117);
            this.h_signinbtn.TabIndex = 21;
            this.h_signinbtn.UseVisualStyleBackColor = false;
            this.h_signinbtn.Click += new System.EventHandler(this.H_signinbtn_Click_1);
            // 
            // torqueform
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundImage = global::torque.Properties.Resources._41GBgteobapIljnz18YL67Qhl6w2C3om1_44mMdk273mzogaV4DplvouQpVo5_AIxgU8J0cOM3E3mLZ6_ghgBgCMSCsF2fqYMetaIf5ZBkOKEcDy1d9ZYGuZSaxgPx8WVHZ6ZT3bxx2e;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(972, 701);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "torqueform";
            this.Text = "Torque";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Torqueform_FormClosing);
            this.Load += new System.EventHandler(this.torqueform_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button h_registerbtn;
        private System.Windows.Forms.Button h_signinbtn;
        private System.Windows.Forms.Label label1;
    }
}

