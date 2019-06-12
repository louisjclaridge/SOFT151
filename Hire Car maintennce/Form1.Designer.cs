namespace Hire_Car_maintennce
{
    partial class Form1
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
            this.lstCompanies = new System.Windows.Forms.ListBox();
            this.lstCars = new System.Windows.Forms.ListBox();
            this.btnSaveCar = new System.Windows.Forms.Button();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.btnAddComp = new System.Windows.Forms.Button();
            this.btnSaveComp = new System.Windows.Forms.Button();
            this.lblSelectedCar = new System.Windows.Forms.Label();
            this.txtSearchComp = new System.Windows.Forms.TextBox();
            this.txtSearchCar = new System.Windows.Forms.TextBox();
            this.txtLastService = new System.Windows.Forms.TextBox();
            this.lblLastService = new System.Windows.Forms.Label();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.lblComments = new System.Windows.Forms.Label();
            this.txtFuelType = new System.Windows.Forms.TextBox();
            this.lblFuelType = new System.Windows.Forms.Label();
            this.txtMakeAndModel = new System.Windows.Forms.TextBox();
            this.lblCarMakeAndModel = new System.Windows.Forms.Label();
            this.txtRegistration = new System.Windows.Forms.TextBox();
            this.lblRegistration = new System.Windows.Forms.Label();
            this.txtCarID = new System.Windows.Forms.TextBox();
            this.lblCarID = new System.Windows.Forms.Label();
            this.btnDeleteCar = new System.Windows.Forms.Button();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtCompID = new System.Windows.Forms.TextBox();
            this.lblCompID = new System.Windows.Forms.Label();
            this.btnClearCar = new System.Windows.Forms.Button();
            this.btnClearComp = new System.Windows.Forms.Button();
            this.lblSelectedComp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstCompanies
            // 
            this.lstCompanies.FormattingEnabled = true;
            this.lstCompanies.ItemHeight = 16;
            this.lstCompanies.Location = new System.Drawing.Point(16, 58);
            this.lstCompanies.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstCompanies.Name = "lstCompanies";
            this.lstCompanies.Size = new System.Drawing.Size(731, 260);
            this.lstCompanies.TabIndex = 1;
            this.lstCompanies.SelectedIndexChanged += new System.EventHandler(this.lstCompanies_SelectedIndexChanged);
            // 
            // lstCars
            // 
            this.lstCars.FormattingEnabled = true;
            this.lstCars.ItemHeight = 16;
            this.lstCars.Location = new System.Drawing.Point(16, 414);
            this.lstCars.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstCars.Name = "lstCars";
            this.lstCars.Size = new System.Drawing.Size(731, 260);
            this.lstCars.TabIndex = 2;
            this.lstCars.SelectedIndexChanged += new System.EventHandler(this.lstCars_SelectedIndexChanged);
            // 
            // btnSaveCar
            // 
            this.btnSaveCar.Location = new System.Drawing.Point(1011, 564);
            this.btnSaveCar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveCar.Name = "btnSaveCar";
            this.btnSaveCar.Size = new System.Drawing.Size(207, 38);
            this.btnSaveCar.TabIndex = 16;
            this.btnSaveCar.Text = "Save";
            this.btnSaveCar.UseVisualStyleBackColor = true;
            this.btnSaveCar.Click += new System.EventHandler(this.btnSaveCar_Click);
            // 
            // btnAddCar
            // 
            this.btnAddCar.Location = new System.Drawing.Point(784, 564);
            this.btnAddCar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(207, 38);
            this.btnAddCar.TabIndex = 17;
            this.btnAddCar.Text = "Add";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // btnAddComp
            // 
            this.btnAddComp.Location = new System.Drawing.Point(1011, 236);
            this.btnAddComp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddComp.Name = "btnAddComp";
            this.btnAddComp.Size = new System.Drawing.Size(207, 38);
            this.btnAddComp.TabIndex = 19;
            this.btnAddComp.Text = "Add";
            this.btnAddComp.Click += new System.EventHandler(this.btnAddComp_Click_1);
            // 
            // btnSaveComp
            // 
            this.btnSaveComp.Location = new System.Drawing.Point(784, 236);
            this.btnSaveComp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveComp.Name = "btnSaveComp";
            this.btnSaveComp.Size = new System.Drawing.Size(207, 38);
            this.btnSaveComp.TabIndex = 18;
            this.btnSaveComp.Text = "Save";
            this.btnSaveComp.UseVisualStyleBackColor = true;
            this.btnSaveComp.Click += new System.EventHandler(this.btnSaveComp_Click);
            // 
            // lblSelectedCar
            // 
            this.lblSelectedCar.AutoSize = true;
            this.lblSelectedCar.Location = new System.Drawing.Point(1057, 434);
            this.lblSelectedCar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectedCar.Name = "lblSelectedCar";
            this.lblSelectedCar.Size = new System.Drawing.Size(0, 17);
            this.lblSelectedCar.TabIndex = 21;
            // 
            // txtSearchComp
            // 
            this.txtSearchComp.Location = new System.Drawing.Point(16, 15);
            this.txtSearchComp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearchComp.Name = "txtSearchComp";
            this.txtSearchComp.Size = new System.Drawing.Size(624, 22);
            this.txtSearchComp.TabIndex = 23;
            this.txtSearchComp.TextChanged += new System.EventHandler(this.txtSearchComp_TextChanged);
            // 
            // txtSearchCar
            // 
            this.txtSearchCar.Location = new System.Drawing.Point(16, 382);
            this.txtSearchCar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearchCar.Name = "txtSearchCar";
            this.txtSearchCar.Size = new System.Drawing.Size(624, 22);
            this.txtSearchCar.TabIndex = 24;
            this.txtSearchCar.TextChanged += new System.EventHandler(this.txtSearchCar_TextChanged);
            // 
            // txtLastService
            // 
            this.txtLastService.Location = new System.Drawing.Point(913, 501);
            this.txtLastService.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLastService.Name = "txtLastService";
            this.txtLastService.Size = new System.Drawing.Size(211, 22);
            this.txtLastService.TabIndex = 40;
            // 
            // lblLastService
            // 
            this.lblLastService.AutoSize = true;
            this.lblLastService.Location = new System.Drawing.Point(819, 501);
            this.lblLastService.Name = "lblLastService";
            this.lblLastService.Size = new System.Drawing.Size(86, 17);
            this.lblLastService.TabIndex = 39;
            this.lblLastService.Text = "Last Service";
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(913, 529);
            this.txtComments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(211, 22);
            this.txtComments.TabIndex = 38;
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Location = new System.Drawing.Point(831, 529);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(74, 17);
            this.lblComments.TabIndex = 37;
            this.lblComments.Text = "Comments";
            // 
            // txtFuelType
            // 
            this.txtFuelType.Location = new System.Drawing.Point(913, 473);
            this.txtFuelType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFuelType.Name = "txtFuelType";
            this.txtFuelType.Size = new System.Drawing.Size(211, 22);
            this.txtFuelType.TabIndex = 36;
            // 
            // lblFuelType
            // 
            this.lblFuelType.AutoSize = true;
            this.lblFuelType.Location = new System.Drawing.Point(839, 473);
            this.lblFuelType.Name = "lblFuelType";
            this.lblFuelType.Size = new System.Drawing.Size(67, 17);
            this.lblFuelType.TabIndex = 35;
            this.lblFuelType.Text = "FuelType";
            // 
            // txtMakeAndModel
            // 
            this.txtMakeAndModel.Location = new System.Drawing.Point(913, 417);
            this.txtMakeAndModel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMakeAndModel.Name = "txtMakeAndModel";
            this.txtMakeAndModel.Size = new System.Drawing.Size(211, 22);
            this.txtMakeAndModel.TabIndex = 34;
            // 
            // lblCarMakeAndModel
            // 
            this.lblCarMakeAndModel.AutoSize = true;
            this.lblCarMakeAndModel.Location = new System.Drawing.Point(795, 417);
            this.lblCarMakeAndModel.Name = "lblCarMakeAndModel";
            this.lblCarMakeAndModel.Size = new System.Drawing.Size(112, 17);
            this.lblCarMakeAndModel.TabIndex = 33;
            this.lblCarMakeAndModel.Text = "Make and Model";
            // 
            // txtRegistration
            // 
            this.txtRegistration.Location = new System.Drawing.Point(913, 446);
            this.txtRegistration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRegistration.Name = "txtRegistration";
            this.txtRegistration.Size = new System.Drawing.Size(211, 22);
            this.txtRegistration.TabIndex = 32;
            // 
            // lblRegistration
            // 
            this.lblRegistration.AutoSize = true;
            this.lblRegistration.Location = new System.Drawing.Point(821, 446);
            this.lblRegistration.Name = "lblRegistration";
            this.lblRegistration.Size = new System.Drawing.Size(84, 17);
            this.lblRegistration.TabIndex = 31;
            this.lblRegistration.Text = "Registration";
            // 
            // txtCarID
            // 
            this.txtCarID.Location = new System.Drawing.Point(913, 389);
            this.txtCarID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCarID.Name = "txtCarID";
            this.txtCarID.Size = new System.Drawing.Size(211, 22);
            this.txtCarID.TabIndex = 30;
            // 
            // lblCarID
            // 
            this.lblCarID.AutoSize = true;
            this.lblCarID.Location = new System.Drawing.Point(859, 389);
            this.lblCarID.Name = "lblCarID";
            this.lblCarID.Size = new System.Drawing.Size(47, 17);
            this.lblCarID.TabIndex = 29;
            this.lblCarID.Text = "Car ID";
            // 
            // btnDeleteCar
            // 
            this.btnDeleteCar.Location = new System.Drawing.Point(784, 623);
            this.btnDeleteCar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteCar.Name = "btnDeleteCar";
            this.btnDeleteCar.Size = new System.Drawing.Size(207, 38);
            this.btnDeleteCar.TabIndex = 41;
            this.btnDeleteCar.Text = "Delete";
            this.btnDeleteCar.UseVisualStyleBackColor = true;
            this.btnDeleteCar.Click += new System.EventHandler(this.btnDeleteCar_Click);
            // 
            // txtPostcode
            // 
            this.txtPostcode.Location = new System.Drawing.Point(967, 183);
            this.txtPostcode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(211, 22);
            this.txtPostcode.TabIndex = 50;
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Location = new System.Drawing.Point(893, 183);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(67, 17);
            this.lblPostcode.TabIndex = 49;
            this.lblPostcode.Text = "Postcode";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(967, 129);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(211, 22);
            this.txtName.TabIndex = 48;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(911, 132);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 47;
            this.lblName.Text = "Name";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(967, 156);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(211, 22);
            this.txtAddress.TabIndex = 46;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(901, 160);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(60, 17);
            this.lblAddress.TabIndex = 45;
            this.lblAddress.Text = "Address";
            // 
            // txtCompID
            // 
            this.txtCompID.Location = new System.Drawing.Point(967, 100);
            this.txtCompID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCompID.Name = "txtCompID";
            this.txtCompID.Size = new System.Drawing.Size(211, 22);
            this.txtCompID.TabIndex = 44;
            // 
            // lblCompID
            // 
            this.lblCompID.AutoSize = true;
            this.lblCompID.Location = new System.Drawing.Point(871, 103);
            this.lblCompID.Name = "lblCompID";
            this.lblCompID.Size = new System.Drawing.Size(84, 17);
            this.lblCompID.TabIndex = 43;
            this.lblCompID.Text = "Company ID";
            // 
            // btnClearCar
            // 
            this.btnClearCar.Location = new System.Drawing.Point(1011, 623);
            this.btnClearCar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearCar.Name = "btnClearCar";
            this.btnClearCar.Size = new System.Drawing.Size(207, 38);
            this.btnClearCar.TabIndex = 53;
            this.btnClearCar.Text = "Clear";
            this.btnClearCar.Click += new System.EventHandler(this.btnClearCar_Click);
            // 
            // btnClearComp
            // 
            this.btnClearComp.Location = new System.Drawing.Point(904, 281);
            this.btnClearComp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearComp.Name = "btnClearComp";
            this.btnClearComp.Size = new System.Drawing.Size(207, 38);
            this.btnClearComp.TabIndex = 54;
            this.btnClearComp.Text = "Clear";
            this.btnClearComp.Click += new System.EventHandler(this.btnClearComp_Click);
            // 
            // lblSelectedComp
            // 
            this.lblSelectedComp.AutoSize = true;
            this.lblSelectedComp.Location = new System.Drawing.Point(701, 11);
            this.lblSelectedComp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectedComp.Name = "lblSelectedComp";
            this.lblSelectedComp.Size = new System.Drawing.Size(0, 17);
            this.lblSelectedComp.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 706);
            this.Controls.Add(this.btnClearComp);
            this.Controls.Add(this.btnClearCar);
            this.Controls.Add(this.txtPostcode);
            this.Controls.Add(this.lblPostcode);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtCompID);
            this.Controls.Add(this.lblCompID);
            this.Controls.Add(this.btnDeleteCar);
            this.Controls.Add(this.txtLastService);
            this.Controls.Add(this.lblLastService);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.lblComments);
            this.Controls.Add(this.txtFuelType);
            this.Controls.Add(this.lblFuelType);
            this.Controls.Add(this.txtMakeAndModel);
            this.Controls.Add(this.lblCarMakeAndModel);
            this.Controls.Add(this.txtRegistration);
            this.Controls.Add(this.lblRegistration);
            this.Controls.Add(this.txtCarID);
            this.Controls.Add(this.lblCarID);
            this.Controls.Add(this.txtSearchCar);
            this.Controls.Add(this.txtSearchComp);
            this.Controls.Add(this.lblSelectedCar);
            this.Controls.Add(this.btnAddComp);
            this.Controls.Add(this.btnSaveComp);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.btnSaveCar);
            this.Controls.Add(this.lblSelectedComp);
            this.Controls.Add(this.lstCars);
            this.Controls.Add(this.lstCompanies);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstCompanies;
        private System.Windows.Forms.ListBox lstCars;
        private System.Windows.Forms.Button btnSaveCar;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Button btnAddComp;
        private System.Windows.Forms.Button btnSaveComp;
        private System.Windows.Forms.Label lblSelectedCar;
        private System.Windows.Forms.TextBox txtSearchComp;
        private System.Windows.Forms.TextBox txtSearchCar;
        private System.Windows.Forms.TextBox txtLastService;
        private System.Windows.Forms.Label lblLastService;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.TextBox txtFuelType;
        private System.Windows.Forms.Label lblFuelType;
        private System.Windows.Forms.TextBox txtMakeAndModel;
        private System.Windows.Forms.Label lblCarMakeAndModel;
        private System.Windows.Forms.TextBox txtRegistration;
        private System.Windows.Forms.Label lblRegistration;
        private System.Windows.Forms.TextBox txtCarID;
        private System.Windows.Forms.Label lblCarID;
        private System.Windows.Forms.Button btnDeleteCar;
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtCompID;
        private System.Windows.Forms.Label lblCompID;
        private System.Windows.Forms.Button btnClearCar;
        private System.Windows.Forms.Button btnClearComp;
        private System.Windows.Forms.Label lblSelectedComp;
    }
}

