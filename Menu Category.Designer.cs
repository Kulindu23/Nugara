
namespace Nugara
{
    partial class frmMenuCategoryid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuCategoryid));
            this.lblCut = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNugara = new System.Windows.Forms.Label();
            this.lblmenucategory = new System.Windows.Forms.Label();
            this.cmbmenucategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMenuCategoryID = new System.Windows.Forms.Label();
            this.cmbItemID = new System.Windows.Forms.ComboBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblItemID = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridViewMenuCategoryName = new System.Windows.Forms.DataGridView();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.timerDateTime = new System.Windows.Forms.Timer(this.components);
            this.cmbItemName = new System.Windows.Forms.ComboBox();
            this.cmbMenuCategoryName = new System.Windows.Forms.ComboBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTipBack = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenuCategoryName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCut
            // 
            this.lblCut.AutoSize = true;
            this.lblCut.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCut.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCut.Location = new System.Drawing.Point(1098, 20);
            this.lblCut.Name = "lblCut";
            this.lblCut.Size = new System.Drawing.Size(31, 29);
            this.lblCut.TabIndex = 16;
            this.lblCut.Text = "X";
            this.lblCut.Click += new System.EventHandler(this.lblCut_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(135, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 18);
            this.label2.TabIndex = 42;
            this.label2.Text = "Restaurant Management System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 18);
            this.label1.TabIndex = 41;
            this.label1.Text = "411, Andiambalama Rd, Kimbulapitiya";
            // 
            // lblNugara
            // 
            this.lblNugara.AutoSize = true;
            this.lblNugara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNugara.Location = new System.Drawing.Point(134, 37);
            this.lblNugara.Name = "lblNugara";
            this.lblNugara.Size = new System.Drawing.Size(172, 20);
            this.lblNugara.TabIndex = 40;
            this.lblNugara.Text = "Nugara Restaurant.";
            // 
            // lblmenucategory
            // 
            this.lblmenucategory.AutoSize = true;
            this.lblmenucategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmenucategory.Location = new System.Drawing.Point(74, 173);
            this.lblmenucategory.Name = "lblmenucategory";
            this.lblmenucategory.Size = new System.Drawing.Size(221, 32);
            this.lblmenucategory.TabIndex = 49;
            this.lblmenucategory.Text = "Menu Category";
            // 
            // cmbmenucategory
            // 
            this.cmbmenucategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbmenucategory.FormattingEnabled = true;
            this.cmbmenucategory.Items.AddRange(new object[] {
            "MC001",
            "MC002",
            "MC003",
            "MC004",
            "MC005",
            "MC006",
            "MC007",
            "MC008",
            "MC009",
            "MC010",
            "MC011",
            "MC012",
            "MC013",
            "MC014",
            "MC015"});
            this.cmbmenucategory.Location = new System.Drawing.Point(350, 256);
            this.cmbmenucategory.Name = "cmbmenucategory";
            this.cmbmenucategory.Size = new System.Drawing.Size(166, 30);
            this.cmbmenucategory.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 20);
            this.label3.TabIndex = 52;
            this.label3.Text = "Menu Category Name\r\n";
            // 
            // lblMenuCategoryID
            // 
            this.lblMenuCategoryID.AutoSize = true;
            this.lblMenuCategoryID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuCategoryID.Location = new System.Drawing.Point(76, 261);
            this.lblMenuCategoryID.Name = "lblMenuCategoryID";
            this.lblMenuCategoryID.Size = new System.Drawing.Size(144, 20);
            this.lblMenuCategoryID.TabIndex = 51;
            this.lblMenuCategoryID.Text = "Menu Category ID";
            // 
            // cmbItemID
            // 
            this.cmbItemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbItemID.FormattingEnabled = true;
            this.cmbItemID.Items.AddRange(new object[] {
            "M001",
            "M002",
            "M003",
            "M004",
            "M005",
            "M006",
            "M007",
            "M008",
            "M009",
            "M010",
            "M011",
            "M012",
            "M013",
            "M014",
            "M015",
            "M016",
            "M017",
            "M018",
            "M019",
            "M020",
            "M021",
            "M022",
            "M023",
            "M024",
            "M025",
            "M026",
            "M027",
            "M028",
            "M029",
            "M030"});
            this.cmbItemID.Location = new System.Drawing.Point(885, 251);
            this.cmbItemID.Name = "cmbItemID";
            this.cmbItemID.Size = new System.Drawing.Size(166, 30);
            this.cmbItemID.TabIndex = 57;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.Location = new System.Drawing.Point(611, 351);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(90, 20);
            this.lblItemName.TabIndex = 56;
            this.lblItemName.Text = "Item Name";
            this.lblItemName.Click += new System.EventHandler(this.lblItemName_Click);
            // 
            // lblItemID
            // 
            this.lblItemID.AutoSize = true;
            this.lblItemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemID.Location = new System.Drawing.Point(611, 256);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(63, 20);
            this.lblItemID.TabIndex = 55;
            this.lblItemID.Text = "Item ID";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClear.Location = new System.Drawing.Point(837, 462);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 47);
            this.btnClear.TabIndex = 64;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Location = new System.Drawing.Point(600, 462);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 47);
            this.btnDelete.TabIndex = 63;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdate.Location = new System.Drawing.Point(350, 462);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 47);
            this.btnUpdate.TabIndex = 62;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.Location = new System.Drawing.Point(117, 462);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 47);
            this.btnAdd.TabIndex = 61;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridViewMenuCategoryName
            // 
            this.dataGridViewMenuCategoryName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMenuCategoryName.Location = new System.Drawing.Point(259, 532);
            this.dataGridViewMenuCategoryName.Name = "dataGridViewMenuCategoryName";
            this.dataGridViewMenuCategoryName.RowHeadersWidth = 51;
            this.dataGridViewMenuCategoryName.RowTemplate.Height = 24;
            this.dataGridViewMenuCategoryName.Size = new System.Drawing.Size(624, 193);
            this.dataGridViewMenuCategoryName.TabIndex = 65;
            this.dataGridViewMenuCategoryName.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMenuCategoryName_CellContentClick);
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Location = new System.Drawing.Point(717, 47);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(0, 17);
            this.lblDateTime.TabIndex = 67;
            // 
            // timerDateTime
            // 
            this.timerDateTime.Enabled = true;
            this.timerDateTime.Interval = 1000;
            this.timerDateTime.Tick += new System.EventHandler(this.timerDateTime_Tick);
            // 
            // cmbItemName
            // 
            this.cmbItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbItemName.FormattingEnabled = true;
            this.cmbItemName.Items.AddRange(new object[] {
            "Egg Fride Rice",
            "Chiken Fride Rice",
            "Mix Fride Rice",
            "Chopsuey Rice",
            "Spicy Seafood Rice",
            "Vegitable Rice",
            "Egg Rice",
            "Fish Rice",
            "Chiken Rice",
            "Egg Koththu",
            "Chiken Koththu",
            "Fish Koththu",
            "Masala Koththu",
            "Dolphin Koththu",
            "Cheese Koththu",
            "String Hoppers",
            "Plane Hoppers",
            "Egg Hoppers",
            "Egg Rolls",
            "Fish Rolls",
            "Egg Bun",
            "Sosage Bun",
            "Fish Bun",
            "Pestries",
            "Samosa",
            "Egg Biriyani",
            "Chiken Biriyani",
            "",
            "Pork Koththu",
            "Kochchi Koththu"});
            this.cmbItemName.Location = new System.Drawing.Point(885, 341);
            this.cmbItemName.Name = "cmbItemName";
            this.cmbItemName.Size = new System.Drawing.Size(166, 30);
            this.cmbItemName.TabIndex = 68;
            // 
            // cmbMenuCategoryName
            // 
            this.cmbMenuCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMenuCategoryName.FormattingEnabled = true;
            this.cmbMenuCategoryName.Items.AddRange(new object[] {
            "Fride Rice",
            "Rice & Curry",
            "Koththu",
            "String Hoppers",
            "Hoppers",
            "Shorties",
            "Biriyani",
            "Nasiguran",
            "Pasta",
            "Noodles",
            "Soup",
            "Juices",
            "Appetizers",
            "Desert",
            "Side Dishes"});
            this.cmbMenuCategoryName.Location = new System.Drawing.Point(350, 346);
            this.cmbMenuCategoryName.Name = "cmbMenuCategoryName";
            this.cmbMenuCategoryName.Size = new System.Drawing.Size(166, 30);
            this.cmbMenuCategoryName.TabIndex = 69;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.Location = new System.Drawing.Point(30, 746);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(63, 49);
            this.btnLogOut.TabIndex = 50;
            this.toolTipBack.SetToolTip(this.btnLogOut, "Back");
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // frmMenuCategoryid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1148, 807);
            this.Controls.Add(this.cmbMenuCategoryName);
            this.Controls.Add(this.cmbItemName);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.dataGridViewMenuCategoryName);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbItemID);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.lblItemID);
            this.Controls.Add(this.cmbmenucategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMenuCategoryID);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lblmenucategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNugara);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenuCategoryid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Category";
            this.Load += new System.EventHandler(this.frmMenuCategoryid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenuCategoryName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNugara;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblmenucategory;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.ComboBox cmbmenucategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMenuCategoryID;
        private System.Windows.Forms.ComboBox cmbItemID;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblItemID;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridViewMenuCategoryName;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Timer timerDateTime;
        private System.Windows.Forms.ComboBox cmbItemName;
        private System.Windows.Forms.ComboBox cmbMenuCategoryName;
        private System.Windows.Forms.ToolTip toolTipBack;
    }
}