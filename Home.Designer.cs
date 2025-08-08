
namespace Nugara
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.panelHome = new System.Windows.Forms.Panel();
            this.lblNugara = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCut = new System.Windows.Forms.Label();
            this.toolTipMenu = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipOrder = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipPrepareMeals = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipPayment = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipBilling = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipMore = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipBack = new System.Windows.Forms.ToolTip(this.components);
            this.lblDateTime = new System.Windows.Forms.Label();
            this.timerDateTime = new System.Windows.Forms.Timer(this.components);
            this.btnbilling = new System.Windows.Forms.Button();
            this.btnpayment = new System.Windows.Forms.Button();
            this.btnother = new System.Windows.Forms.Button();
            this.btnorder = new System.Windows.Forms.Button();
            this.btnmenu = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHome
            // 
            this.panelHome.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelHome.Controls.Add(this.btnbilling);
            this.panelHome.Controls.Add(this.btnpayment);
            this.panelHome.Controls.Add(this.btnother);
            this.panelHome.Controls.Add(this.btnorder);
            this.panelHome.Controls.Add(this.btnmenu);
            this.panelHome.Controls.Add(this.btnLogOut);
            this.panelHome.Controls.Add(this.pictureBox1);
            this.panelHome.Location = new System.Drawing.Point(1, 0);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(85, 754);
            this.panelHome.TabIndex = 0;
            // 
            // lblNugara
            // 
            this.lblNugara.AutoSize = true;
            this.lblNugara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNugara.Location = new System.Drawing.Point(110, 12);
            this.lblNugara.Name = "lblNugara";
            this.lblNugara.Size = new System.Drawing.Size(172, 20);
            this.lblNugara.TabIndex = 1;
            this.lblNugara.Text = "Nugara Restaurant.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "411, Andiambalama Rd, Kimbulapitiya";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(111, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Restaurant Management System";
            // 
            // lblCut
            // 
            this.lblCut.AutoSize = true;
            this.lblCut.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCut.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCut.Location = new System.Drawing.Point(1154, 12);
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
            this.lblDateTime.Location = new System.Drawing.Point(793, 34);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(0, 18);
            this.lblDateTime.TabIndex = 16;
            // 
            // timerDateTime
            // 
            this.timerDateTime.Interval = 1000;
            this.timerDateTime.Tick += new System.EventHandler(this.timerDateTime_Tick);
            // 
            // btnbilling
            // 
            this.btnbilling.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnbilling.Image = ((System.Drawing.Image)(resources.GetObject("btnbilling.Image")));
            this.btnbilling.Location = new System.Drawing.Point(11, 478);
            this.btnbilling.Name = "btnbilling";
            this.btnbilling.Size = new System.Drawing.Size(63, 60);
            this.btnbilling.TabIndex = 8;
            this.toolTipBilling.SetToolTip(this.btnbilling, "Billing");
            this.btnbilling.UseVisualStyleBackColor = false;
            this.btnbilling.Click += new System.EventHandler(this.btnbilling_Click);
            // 
            // btnpayment
            // 
            this.btnpayment.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnpayment.Image = ((System.Drawing.Image)(resources.GetObject("btnpayment.Image")));
            this.btnpayment.Location = new System.Drawing.Point(11, 353);
            this.btnpayment.Name = "btnpayment";
            this.btnpayment.Size = new System.Drawing.Size(63, 48);
            this.btnpayment.TabIndex = 7;
            this.toolTipPayment.SetToolTip(this.btnpayment, "Payment");
            this.btnpayment.UseVisualStyleBackColor = false;
            this.btnpayment.Click += new System.EventHandler(this.btnpayment_Click);
            // 
            // btnother
            // 
            this.btnother.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnother.Image = ((System.Drawing.Image)(resources.GetObject("btnother.Image")));
            this.btnother.Location = new System.Drawing.Point(11, 598);
            this.btnother.Name = "btnother";
            this.btnother.Size = new System.Drawing.Size(63, 49);
            this.btnother.TabIndex = 6;
            this.toolTipMore.SetToolTip(this.btnother, "More");
            this.btnother.UseVisualStyleBackColor = false;
            this.btnother.Click += new System.EventHandler(this.btnother_Click);
            // 
            // btnorder
            // 
            this.btnorder.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnorder.Image = ((System.Drawing.Image)(resources.GetObject("btnorder.Image")));
            this.btnorder.Location = new System.Drawing.Point(11, 224);
            this.btnorder.Name = "btnorder";
            this.btnorder.Size = new System.Drawing.Size(63, 49);
            this.btnorder.TabIndex = 4;
            this.toolTipOrder.SetToolTip(this.btnorder, "Order");
            this.btnorder.UseVisualStyleBackColor = false;
            this.btnorder.Click += new System.EventHandler(this.btnorder_Click);
            // 
            // btnmenu
            // 
            this.btnmenu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnmenu.Image = ((System.Drawing.Image)(resources.GetObject("btnmenu.Image")));
            this.btnmenu.Location = new System.Drawing.Point(11, 109);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Size = new System.Drawing.Size(63, 49);
            this.btnmenu.TabIndex = 3;
            this.toolTipMenu.SetToolTip(this.btnmenu, "Menu Item");
            this.btnmenu.UseVisualStyleBackColor = false;
            this.btnmenu.Click += new System.EventHandler(this.btnmenu_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.Location = new System.Drawing.Point(11, 696);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(63, 49);
            this.btnLogOut.TabIndex = 1;
            this.toolTipBack.SetToolTip(this.btnLogOut, "Logout");
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(114, 97);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1075, 648);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1201, 757);
            this.Controls.Add(this.panelHome);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.lblCut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNugara);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.panelHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNugara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnbilling;
        private System.Windows.Forms.Button btnpayment;
        private System.Windows.Forms.Button btnother;
        private System.Windows.Forms.Button btnorder;
        private System.Windows.Forms.Button btnmenu;
        private System.Windows.Forms.Label lblCut;
        private System.Windows.Forms.ToolTip toolTipMenu;
        private System.Windows.Forms.ToolTip toolTipOrder;
        private System.Windows.Forms.ToolTip toolTipBilling;
        private System.Windows.Forms.ToolTip toolTipPayment;
        private System.Windows.Forms.ToolTip toolTipMore;
        private System.Windows.Forms.ToolTip toolTipPrepareMeals;
        private System.Windows.Forms.ToolTip toolTipBack;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Timer timerDateTime;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}