
namespace Nugara
{
    partial class frmHome3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome3));
            this.panelHome = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnSupplierpayment = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.btnpayroll = new System.Windows.Forms.Button();
            this.btnEmpDetails = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNugara = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCut = new System.Windows.Forms.Label();
            this.toolTipEmployeeDetails = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipEmployeeAttendance = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipPayRoll = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipSupplier = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipSupplierPayment = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipMore = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipBack = new System.Windows.Forms.ToolTip(this.components);
            this.lblDateTime = new System.Windows.Forms.Label();
            this.timerDateTime = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHome
            // 
            this.panelHome.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelHome.Controls.Add(this.btnLogOut);
            this.panelHome.Controls.Add(this.btnSupplierpayment);
            this.panelHome.Controls.Add(this.btnSupplier);
            this.panelHome.Controls.Add(this.btnpayroll);
            this.panelHome.Controls.Add(this.btnEmpDetails);
            this.panelHome.Controls.Add(this.btnNext);
            this.panelHome.Controls.Add(this.pictureBox1);
            this.panelHome.Location = new System.Drawing.Point(1, 1);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(85, 795);
            this.panelHome.TabIndex = 2;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.Location = new System.Drawing.Point(12, 722);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(63, 49);
            this.btnLogOut.TabIndex = 7;
            this.toolTipBack.SetToolTip(this.btnLogOut, "Back");
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnSupplierpayment
            // 
            this.btnSupplierpayment.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSupplierpayment.Image = ((System.Drawing.Image)(resources.GetObject("btnSupplierpayment.Image")));
            this.btnSupplierpayment.Location = new System.Drawing.Point(11, 469);
            this.btnSupplierpayment.Name = "btnSupplierpayment";
            this.btnSupplierpayment.Size = new System.Drawing.Size(63, 49);
            this.btnSupplierpayment.TabIndex = 6;
            this.toolTipSupplierPayment.SetToolTip(this.btnSupplierpayment, "Supplier Payment");
            this.btnSupplierpayment.UseVisualStyleBackColor = false;
            this.btnSupplierpayment.Click += new System.EventHandler(this.btnSupplierpayment_Click);
            // 
            // btnSupplier
            // 
            this.btnSupplier.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSupplier.Image = ((System.Drawing.Image)(resources.GetObject("btnSupplier.Image")));
            this.btnSupplier.Location = new System.Drawing.Point(12, 354);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(63, 49);
            this.btnSupplier.TabIndex = 5;
            this.toolTipSupplier.SetToolTip(this.btnSupplier, "Supplier");
            this.btnSupplier.UseVisualStyleBackColor = false;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // btnpayroll
            // 
            this.btnpayroll.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnpayroll.Image = ((System.Drawing.Image)(resources.GetObject("btnpayroll.Image")));
            this.btnpayroll.Location = new System.Drawing.Point(12, 239);
            this.btnpayroll.Name = "btnpayroll";
            this.btnpayroll.Size = new System.Drawing.Size(63, 49);
            this.btnpayroll.TabIndex = 4;
            this.toolTipPayRoll.SetToolTip(this.btnpayroll, "Pay Roll");
            this.btnpayroll.UseVisualStyleBackColor = false;
            this.btnpayroll.Click += new System.EventHandler(this.btnpayroll_Click);
            // 
            // btnEmpDetails
            // 
            this.btnEmpDetails.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEmpDetails.Image = ((System.Drawing.Image)(resources.GetObject("btnEmpDetails.Image")));
            this.btnEmpDetails.Location = new System.Drawing.Point(11, 128);
            this.btnEmpDetails.Name = "btnEmpDetails";
            this.btnEmpDetails.Size = new System.Drawing.Size(63, 49);
            this.btnEmpDetails.TabIndex = 2;
            this.toolTipEmployeeDetails.SetToolTip(this.btnEmpDetails, "Employee Details");
            this.btnEmpDetails.UseVisualStyleBackColor = false;
            this.btnEmpDetails.Click += new System.EventHandler(this.btnEmpDetails_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(11, 596);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(63, 49);
            this.btnNext.TabIndex = 1;
            this.toolTipMore.SetToolTip(this.btnNext, "More");
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblNugara
            // 
            this.lblNugara.AutoSize = true;
            this.lblNugara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNugara.Location = new System.Drawing.Point(110, 13);
            this.lblNugara.Name = "lblNugara";
            this.lblNugara.Size = new System.Drawing.Size(172, 20);
            this.lblNugara.TabIndex = 3;
            this.lblNugara.Text = "Nugara Restaurant.";
            this.lblNugara.Click += new System.EventHandler(this.lblNugara_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(111, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Restaurant Management System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "411, Andiambalama Rd, Kimbulapitiya";
            // 
            // lblCut
            // 
            this.lblCut.AutoSize = true;
            this.lblCut.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCut.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCut.Location = new System.Drawing.Point(1211, 13);
            this.lblCut.Name = "lblCut";
            this.lblCut.Size = new System.Drawing.Size(31, 29);
            this.lblCut.TabIndex = 15;
            this.lblCut.Text = "X";
            this.lblCut.Click += new System.EventHandler(this.lblCut_Click);
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.Location = new System.Drawing.Point(872, 33);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(0, 18);
            this.lblDateTime.TabIndex = 16;
            // 
            // timerDateTime
            // 
            this.timerDateTime.Enabled = true;
            this.timerDateTime.Interval = 1000;
            this.timerDateTime.Tick += new System.EventHandler(this.timerDateTime_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(103, 129);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1148, 550);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // frmHome3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1263, 793);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.lblCut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNugara);
            this.Controls.Add(this.panelHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHome3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frmHome3_Load);
            this.panelHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Button btnEmpDetails;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNugara;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSupplierpayment;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.Button btnpayroll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblCut;
        private System.Windows.Forms.ToolTip toolTipBack;
        private System.Windows.Forms.ToolTip toolTipSupplierPayment;
        private System.Windows.Forms.ToolTip toolTipSupplier;
        private System.Windows.Forms.ToolTip toolTipPayRoll;
        private System.Windows.Forms.ToolTip toolTipEmployeeAttendance;
        private System.Windows.Forms.ToolTip toolTipEmployeeDetails;
        private System.Windows.Forms.ToolTip toolTipMore;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Timer timerDateTime;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}