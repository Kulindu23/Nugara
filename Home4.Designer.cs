
namespace Nugara
{
    partial class frmHome4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome4));
            this.panelHome = new System.Windows.Forms.Panel();
            this.btnCookedItems = new System.Windows.Forms.Button();
            this.btnMenuCategory = new System.Windows.Forms.Button();
            this.btnGRN = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnSupplierInvoice = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNugara = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCut = new System.Windows.Forms.Label();
            this.toolTipGRN = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipSupplierInvoice = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipReport = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipBack = new System.Windows.Forms.ToolTip(this.components);
            this.lblDateTime = new System.Windows.Forms.Label();
            this.timerDateTime = new System.Windows.Forms.Timer(this.components);
            this.toolTipMenuCategory = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipCooked = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHome
            // 
            this.panelHome.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelHome.Controls.Add(this.btnCookedItems);
            this.panelHome.Controls.Add(this.btnMenuCategory);
            this.panelHome.Controls.Add(this.btnGRN);
            this.panelHome.Controls.Add(this.btnLogOut);
            this.panelHome.Controls.Add(this.btnReport);
            this.panelHome.Controls.Add(this.btnSupplierInvoice);
            this.panelHome.Controls.Add(this.pictureBox1);
            this.panelHome.Location = new System.Drawing.Point(0, 2);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(85, 749);
            this.panelHome.TabIndex = 3;
            // 
            // btnCookedItems
            // 
            this.btnCookedItems.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCookedItems.Image = ((System.Drawing.Image)(resources.GetObject("btnCookedItems.Image")));
            this.btnCookedItems.Location = new System.Drawing.Point(12, 552);
            this.btnCookedItems.Name = "btnCookedItems";
            this.btnCookedItems.Size = new System.Drawing.Size(63, 49);
            this.btnCookedItems.TabIndex = 9;
            this.toolTipCooked.SetToolTip(this.btnCookedItems, "Cooked Items");
            this.btnCookedItems.UseVisualStyleBackColor = false;
            this.btnCookedItems.Click += new System.EventHandler(this.btnCookedItems_Click);
            // 
            // btnMenuCategory
            // 
            this.btnMenuCategory.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMenuCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuCategory.Image")));
            this.btnMenuCategory.Location = new System.Drawing.Point(12, 447);
            this.btnMenuCategory.Name = "btnMenuCategory";
            this.btnMenuCategory.Size = new System.Drawing.Size(63, 49);
            this.btnMenuCategory.TabIndex = 9;
            this.toolTipBack.SetToolTip(this.btnMenuCategory, "Back");
            this.toolTipMenuCategory.SetToolTip(this.btnMenuCategory, "Menu Category");
            this.btnMenuCategory.UseVisualStyleBackColor = false;
            this.btnMenuCategory.Click += new System.EventHandler(this.btnMenuCategory_Click);
            // 
            // btnGRN
            // 
            this.btnGRN.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGRN.Image = ((System.Drawing.Image)(resources.GetObject("btnGRN.Image")));
            this.btnGRN.Location = new System.Drawing.Point(12, 127);
            this.btnGRN.Name = "btnGRN";
            this.btnGRN.Size = new System.Drawing.Size(63, 49);
            this.btnGRN.TabIndex = 8;
            this.toolTipGRN.SetToolTip(this.btnGRN, "Good Receive Note");
            this.btnGRN.UseVisualStyleBackColor = false;
            this.btnGRN.Click += new System.EventHandler(this.btnGRN_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.Location = new System.Drawing.Point(12, 652);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(63, 49);
            this.btnLogOut.TabIndex = 4;
            this.toolTipBack.SetToolTip(this.btnLogOut, "Back");
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReport.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.Image")));
            this.btnReport.Location = new System.Drawing.Point(12, 336);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(63, 49);
            this.btnReport.TabIndex = 3;
            this.toolTipReport.SetToolTip(this.btnReport, "Report");
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnSupplierInvoice
            // 
            this.btnSupplierInvoice.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSupplierInvoice.Image = ((System.Drawing.Image)(resources.GetObject("btnSupplierInvoice.Image")));
            this.btnSupplierInvoice.Location = new System.Drawing.Point(12, 230);
            this.btnSupplierInvoice.Name = "btnSupplierInvoice";
            this.btnSupplierInvoice.Size = new System.Drawing.Size(63, 49);
            this.btnSupplierInvoice.TabIndex = 2;
            this.toolTipSupplierInvoice.SetToolTip(this.btnSupplierInvoice, "Supplier Invoice");
            this.btnSupplierInvoice.UseVisualStyleBackColor = false;
            this.btnSupplierInvoice.Click += new System.EventHandler(this.btnSupplierInvoice_Click);
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
            this.lblNugara.Location = new System.Drawing.Point(113, 14);
            this.lblNugara.Name = "lblNugara";
            this.lblNugara.Size = new System.Drawing.Size(172, 20);
            this.lblNugara.TabIndex = 4;
            this.lblNugara.Text = "Nugara Restaurant.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "411, Andiambalama Rd, Kimbulapitiya";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(114, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Restaurant Management System";
            // 
            // lblCut
            // 
            this.lblCut.AutoSize = true;
            this.lblCut.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCut.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCut.Location = new System.Drawing.Point(1131, 7);
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
            this.lblDateTime.Location = new System.Drawing.Point(749, 18);
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
            this.pictureBox2.Location = new System.Drawing.Point(117, 129);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1045, 589);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // frmHome4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1174, 750);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.lblCut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNugara);
            this.Controls.Add(this.panelHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHome4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frmHome4_Load);
            this.panelHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnSupplierInvoice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNugara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnGRN;
        private System.Windows.Forms.Label lblCut;
        private System.Windows.Forms.ToolTip toolTipGRN;
        private System.Windows.Forms.ToolTip toolTipBack;
        private System.Windows.Forms.ToolTip toolTipReport;
        private System.Windows.Forms.ToolTip toolTipSupplierInvoice;
        private System.Windows.Forms.Button btnMenuCategory;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Timer timerDateTime;
        private System.Windows.Forms.ToolTip toolTipMenuCategory;
        private System.Windows.Forms.Button btnCookedItems;
        private System.Windows.Forms.ToolTip toolTipCooked;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}