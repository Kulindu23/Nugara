
namespace Nugara
{
    partial class frmHome2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome2));
            this.panelHome = new System.Windows.Forms.Panel();
            this.btnother = new System.Windows.Forms.Button();
            this.btninventory = new System.Windows.Forms.Button();
            this.btncustomer = new System.Windows.Forms.Button();
            this.btnPromotion = new System.Windows.Forms.Button();
            this.btnHall = new System.Windows.Forms.Button();
            this.btnReservation = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNugara = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCut = new System.Windows.Forms.Label();
            this.toolTipTableReservation = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipHallBooking = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipPromotion = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipCustomer = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipInventory = new System.Windows.Forms.ToolTip(this.components);
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
            this.panelHome.Controls.Add(this.btnother);
            this.panelHome.Controls.Add(this.btninventory);
            this.panelHome.Controls.Add(this.btncustomer);
            this.panelHome.Controls.Add(this.btnPromotion);
            this.panelHome.Controls.Add(this.btnHall);
            this.panelHome.Controls.Add(this.btnReservation);
            this.panelHome.Controls.Add(this.btnLogOut);
            this.panelHome.Controls.Add(this.pictureBox1);
            this.panelHome.Location = new System.Drawing.Point(0, 0);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(85, 784);
            this.panelHome.TabIndex = 1;
            // 
            // btnother
            // 
            this.btnother.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnother.Image = ((System.Drawing.Image)(resources.GetObject("btnother.Image")));
            this.btnother.Location = new System.Drawing.Point(12, 628);
            this.btnother.Name = "btnother";
            this.btnother.Size = new System.Drawing.Size(63, 49);
            this.btnother.TabIndex = 7;
            this.toolTipMore.SetToolTip(this.btnother, "More");
            this.btnother.UseVisualStyleBackColor = false;
            this.btnother.Click += new System.EventHandler(this.btnother_Click);
            // 
            // btninventory
            // 
            this.btninventory.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btninventory.Image = ((System.Drawing.Image)(resources.GetObject("btninventory.Image")));
            this.btninventory.Location = new System.Drawing.Point(11, 519);
            this.btninventory.Name = "btninventory";
            this.btninventory.Size = new System.Drawing.Size(63, 54);
            this.btninventory.TabIndex = 6;
            this.toolTipInventory.SetToolTip(this.btninventory, "Inventory");
            this.btninventory.UseVisualStyleBackColor = false;
            this.btninventory.Click += new System.EventHandler(this.btninventory_Click);
            // 
            // btncustomer
            // 
            this.btncustomer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btncustomer.Image = ((System.Drawing.Image)(resources.GetObject("btncustomer.Image")));
            this.btncustomer.Location = new System.Drawing.Point(12, 420);
            this.btncustomer.Name = "btncustomer";
            this.btncustomer.Size = new System.Drawing.Size(62, 53);
            this.btncustomer.TabIndex = 5;
            this.toolTipCustomer.SetToolTip(this.btncustomer, "Customer");
            this.btncustomer.UseVisualStyleBackColor = false;
            this.btncustomer.Click += new System.EventHandler(this.btncustomer_Click);
            // 
            // btnPromotion
            // 
            this.btnPromotion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPromotion.Image = ((System.Drawing.Image)(resources.GetObject("btnPromotion.Image")));
            this.btnPromotion.Location = new System.Drawing.Point(12, 315);
            this.btnPromotion.Name = "btnPromotion";
            this.btnPromotion.Size = new System.Drawing.Size(63, 57);
            this.btnPromotion.TabIndex = 4;
            this.toolTipPromotion.SetToolTip(this.btnPromotion, "Promotion");
            this.btnPromotion.UseVisualStyleBackColor = false;
            this.btnPromotion.Click += new System.EventHandler(this.btnPromotion_Click);
            // 
            // btnHall
            // 
            this.btnHall.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHall.Image = ((System.Drawing.Image)(resources.GetObject("btnHall.Image")));
            this.btnHall.Location = new System.Drawing.Point(11, 212);
            this.btnHall.Name = "btnHall";
            this.btnHall.Size = new System.Drawing.Size(63, 56);
            this.btnHall.TabIndex = 3;
            this.toolTipHallBooking.SetToolTip(this.btnHall, "Hall Booking");
            this.btnHall.UseVisualStyleBackColor = false;
            this.btnHall.Click += new System.EventHandler(this.btnHall_Click);
            // 
            // btnReservation
            // 
            this.btnReservation.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReservation.Image = ((System.Drawing.Image)(resources.GetObject("btnReservation.Image")));
            this.btnReservation.Location = new System.Drawing.Point(11, 117);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Size = new System.Drawing.Size(63, 49);
            this.btnReservation.TabIndex = 2;
            this.toolTipTableReservation.SetToolTip(this.btnReservation, "Table Reservation");
            this.btnReservation.UseVisualStyleBackColor = false;
            this.btnReservation.Click += new System.EventHandler(this.btnReservation_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.Location = new System.Drawing.Point(11, 723);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(63, 49);
            this.btnLogOut.TabIndex = 1;
            this.toolTipBack.SetToolTip(this.btnLogOut, "Back");
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
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
            this.lblNugara.Location = new System.Drawing.Point(104, 12);
            this.lblNugara.Name = "lblNugara";
            this.lblNugara.Size = new System.Drawing.Size(172, 20);
            this.lblNugara.TabIndex = 2;
            this.lblNugara.Text = "Nugara Restaurant.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "411, Andiambalama Rd, Kimbulapitiya";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(105, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Restaurant Management System";
            // 
            // lblCut
            // 
            this.lblCut.AutoSize = true;
            this.lblCut.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCut.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCut.Location = new System.Drawing.Point(1225, 12);
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
            this.lblDateTime.Location = new System.Drawing.Point(814, 34);
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
            this.pictureBox2.Location = new System.Drawing.Point(97, 117);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1150, 550);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // frmHome2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1268, 784);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.lblCut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNugara);
            this.Controls.Add(this.panelHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHome2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frmHome2_Load);
            this.panelHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNugara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btninventory;
        private System.Windows.Forms.Button btncustomer;
        private System.Windows.Forms.Button btnPromotion;
        private System.Windows.Forms.Button btnHall;
        private System.Windows.Forms.Button btnReservation;
        private System.Windows.Forms.Button btnother;
        private System.Windows.Forms.Label lblCut;
        private System.Windows.Forms.ToolTip toolTipMore;
        private System.Windows.Forms.ToolTip toolTipInventory;
        private System.Windows.Forms.ToolTip toolTipCustomer;
        private System.Windows.Forms.ToolTip toolTipPromotion;
        private System.Windows.Forms.ToolTip toolTipHallBooking;
        private System.Windows.Forms.ToolTip toolTipTableReservation;
        private System.Windows.Forms.ToolTip toolTipBack;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Timer timerDateTime;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}