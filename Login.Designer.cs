
namespace Nugara
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblEmployeePosition = new System.Windows.Forms.Label();
            this.lblUN = new System.Windows.Forms.Label();
            this.cmbEmpPos = new System.Windows.Forms.ComboBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.lblPw = new System.Windows.Forms.Label();
            this.toolTipUN = new System.Windows.Forms.ToolTip(this.components);
            this.txtUN = new System.Windows.Forms.TextBox();
            this.linkLabelForgetPW = new System.Windows.Forms.LinkLabel();
            this.lblCut = new System.Windows.Forms.Label();
            this.checkBoxShowPW = new System.Windows.Forms.CheckBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTipPw = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Black;
            this.lblWelcome.Location = new System.Drawing.Point(24, 42);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(526, 44);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to Nugara!                \r\n";
            // 
            // lblEmployeePosition
            // 
            this.lblEmployeePosition.AutoSize = true;
            this.lblEmployeePosition.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeePosition.Location = new System.Drawing.Point(29, 138);
            this.lblEmployeePosition.Name = "lblEmployeePosition";
            this.lblEmployeePosition.Size = new System.Drawing.Size(199, 23);
            this.lblEmployeePosition.TabIndex = 1;
            this.lblEmployeePosition.Text = "Employee Position :";
            this.lblEmployeePosition.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblUN
            // 
            this.lblUN.AutoSize = true;
            this.lblUN.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUN.Location = new System.Drawing.Point(29, 218);
            this.lblUN.Name = "lblUN";
            this.lblUN.Size = new System.Drawing.Size(122, 23);
            this.lblUN.TabIndex = 2;
            this.lblUN.Text = "Username :";
            // 
            // cmbEmpPos
            // 
            this.cmbEmpPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmpPos.FormattingEnabled = true;
            this.cmbEmpPos.IntegralHeight = false;
            this.cmbEmpPos.Items.AddRange(new object[] {
            "Admin",
            "Cashier",
            "Manager",
            "Store Manager"});
            this.cmbEmpPos.Location = new System.Drawing.Point(296, 137);
            this.cmbEmpPos.Name = "cmbEmpPos";
            this.cmbEmpPos.Size = new System.Drawing.Size(248, 33);
            this.cmbEmpPos.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogin.Location = new System.Drawing.Point(296, 411);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(248, 42);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPW
            // 
            this.txtPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPW.Location = new System.Drawing.Point(350, 301);
            this.txtPW.Multiline = true;
            this.txtPW.Name = "txtPW";
            this.txtPW.PasswordChar = '*';
            this.txtPW.Size = new System.Drawing.Size(194, 39);
            this.txtPW.TabIndex = 7;
            this.toolTipPw.SetToolTip(this.txtPW, "Please Enter Your Password");
            // 
            // lblPw
            // 
            this.lblPw.AutoSize = true;
            this.lblPw.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPw.Location = new System.Drawing.Point(28, 298);
            this.lblPw.Name = "lblPw";
            this.lblPw.Size = new System.Drawing.Size(118, 23);
            this.lblPw.TabIndex = 8;
            this.lblPw.Text = "Password :";
            this.lblPw.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtUN
            // 
            this.txtUN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUN.Location = new System.Drawing.Point(350, 218);
            this.txtUN.Multiline = true;
            this.txtUN.Name = "txtUN";
            this.txtUN.Size = new System.Drawing.Size(194, 41);
            this.txtUN.TabIndex = 9;
            this.txtUN.Text = "USER";
            this.toolTipUN.SetToolTip(this.txtUN, "Please Enter Username");
            // 
            // linkLabelForgetPW
            // 
            this.linkLabelForgetPW.AutoSize = true;
            this.linkLabelForgetPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelForgetPW.Location = new System.Drawing.Point(36, 468);
            this.linkLabelForgetPW.Name = "linkLabelForgetPW";
            this.linkLabelForgetPW.Size = new System.Drawing.Size(130, 18);
            this.linkLabelForgetPW.TabIndex = 11;
            this.linkLabelForgetPW.TabStop = true;
            this.linkLabelForgetPW.Text = "Forget Password?";
            this.linkLabelForgetPW.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelForgetPW_LinkClicked);
            // 
            // lblCut
            // 
            this.lblCut.AutoSize = true;
            this.lblCut.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCut.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCut.Location = new System.Drawing.Point(1115, 9);
            this.lblCut.Name = "lblCut";
            this.lblCut.Size = new System.Drawing.Size(31, 29);
            this.lblCut.TabIndex = 14;
            this.lblCut.Text = "X";
            this.lblCut.Click += new System.EventHandler(this.lblCut_Click);
            // 
            // checkBoxShowPW
            // 
            this.checkBoxShowPW.AutoSize = true;
            this.checkBoxShowPW.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxShowPW.Location = new System.Drawing.Point(350, 356);
            this.checkBoxShowPW.Name = "checkBoxShowPW";
            this.checkBoxShowPW.Size = new System.Drawing.Size(137, 20);
            this.checkBoxShowPW.TabIndex = 16;
            this.checkBoxShowPW.Text = "Show Password";
            this.checkBoxShowPW.UseVisualStyleBackColor = true;
            this.checkBoxShowPW.CheckedChanged += new System.EventHandler(this.checkBoxShowPW_CheckedChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(296, 218);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 41);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(296, 301);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Nugara.Properties.Resources.ppp;
            this.pictureBox1.Location = new System.Drawing.Point(573, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(591, 541);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1158, 528);
            this.Controls.Add(this.checkBoxShowPW);
            this.Controls.Add(this.lblCut);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.linkLabelForgetPW);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtUN);
            this.Controls.Add(this.lblPw);
            this.Controls.Add(this.txtPW);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.cmbEmpPos);
            this.Controls.Add(this.lblUN);
            this.Controls.Add(this.lblEmployeePosition);
            this.Controls.Add(this.lblWelcome);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblEmployeePosition;
        private System.Windows.Forms.Label lblUN;
        private System.Windows.Forms.ComboBox cmbEmpPos;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.Label lblPw;
        private System.Windows.Forms.ToolTip toolTipUN;
        private System.Windows.Forms.TextBox txtUN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabelForgetPW;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblCut;
        private System.Windows.Forms.CheckBox checkBoxShowPW;
        private System.Windows.Forms.ToolTip toolTipPw;
    }
}

