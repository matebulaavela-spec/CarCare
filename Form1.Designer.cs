namespace AutoCareSystem
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            lblServiceNumber = new Label();
            lblCustomerName = new Label();
            lblIDNumber = new Label();
            lblContact = new Label();
            txtServiceNumber = new TextBox();
            txtCustomerName = new TextBox();
            txtIDNumber = new TextBox();
            txtContactNumber = new TextBox();
            lblReg = new Label();
            lblMake = new Label();
            lblModel = new Label();
            lblYear = new Label();
            lblServiceType = new Label();
            lblTechnician = new Label();
            lblCost = new Label();
            txtVehicleRegistration = new TextBox();
            txtVehicleMake = new TextBox();
            txtVehicleModel = new TextBox();
            txtVehicleYear = new TextBox();
            txtServiceType = new TextBox();
            txtTechnician = new TextBox();
            txtServiceCost = new TextBox();
            lblServiceDate = new Label();
            lblNextDate = new Label();
            lblPayment = new Label();
            dtpServiceDate = new DateTimePicker();
            dtpNextServiceDate = new DateTimePicker();
            cmbPaymentStatus = new ComboBox();
            btnRegister = new Button();
            btnView = new Button();
            btnSearch = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            btnReport = new Button();
            dgvServices = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvServices).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(30, 15);
            label1.Name = "label1";
            label1.Size = new Size(490, 32);
            label1.TabIndex = 0;
            label1.Text = "VEHICLE SERVICE MANAGEMENT SYSTEM";
            // 
            // lblServiceNumber
            // 
            lblServiceNumber.AutoSize = true;
            lblServiceNumber.Location = new Point(40, 70);
            lblServiceNumber.Name = "lblServiceNumber";
            lblServiceNumber.Size = new Size(117, 20);
            lblServiceNumber.TabIndex = 1;
            lblServiceNumber.Text = "Service Number:";
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(340, 70);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(119, 20);
            lblCustomerName.TabIndex = 2;
            lblCustomerName.Text = "Customer Name:";
            // 
            // lblIDNumber
            // 
            lblIDNumber.AutoSize = true;
            lblIDNumber.Location = new Point(40, 130);
            lblIDNumber.Name = "lblIDNumber";
            lblIDNumber.Size = new Size(85, 20);
            lblIDNumber.TabIndex = 3;
            lblIDNumber.Text = "ID Number:";
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Location = new Point(340, 130);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(121, 20);
            lblContact.TabIndex = 4;
            lblContact.Text = "Contact Number:";
            // 
            // txtServiceNumber
            // 
            txtServiceNumber.Location = new Point(40, 95);
            txtServiceNumber.Name = "txtServiceNumber";
            txtServiceNumber.Size = new Size(240, 27);
            txtServiceNumber.TabIndex = 5;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(340, 95);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(240, 27);
            txtCustomerName.TabIndex = 6;
            // 
            // txtIDNumber
            // 
            txtIDNumber.Location = new Point(40, 155);
            txtIDNumber.Name = "txtIDNumber";
            txtIDNumber.Size = new Size(240, 27);
            txtIDNumber.TabIndex = 7;
            // 
            // txtContactNumber
            // 
            txtContactNumber.Location = new Point(340, 155);
            txtContactNumber.Name = "txtContactNumber";
            txtContactNumber.Size = new Size(240, 27);
            txtContactNumber.TabIndex = 8;
            // 
            // lblReg
            // 
            lblReg.AutoSize = true;
            lblReg.Location = new Point(40, 195);
            lblReg.Name = "lblReg";
            lblReg.Size = new Size(143, 20);
            lblReg.TabIndex = 9;
            lblReg.Text = "Vehicle Registration:";
            // 
            // lblMake
            // 
            lblMake.AutoSize = true;
            lblMake.Location = new Point(340, 195);
            lblMake.Name = "lblMake";
            lblMake.Size = new Size(99, 20);
            lblMake.TabIndex = 10;
            lblMake.Text = "Vehicle Make:";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(40, 255);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(106, 20);
            lblModel.TabIndex = 11;
            lblModel.Text = "Vehicle Model:";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(340, 255);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(91, 20);
            lblYear.TabIndex = 12;
            lblYear.Text = "Vehicle Year:";
            // 
            // lblServiceType
            // 
            lblServiceType.AutoSize = true;
            lblServiceType.Location = new Point(40, 315);
            lblServiceType.Name = "lblServiceType";
            lblServiceType.Size = new Size(94, 20);
            lblServiceType.TabIndex = 13;
            lblServiceType.Text = "Service Type:";
            // 
            // lblTechnician
            // 
            lblTechnician.AutoSize = true;
            lblTechnician.Location = new Point(340, 315);
            lblTechnician.Name = "lblTechnician";
            lblTechnician.Size = new Size(81, 20);
            lblTechnician.TabIndex = 14;
            lblTechnician.Text = "Technician:";
            // 
            // lblCost
            // 
            lblCost.AutoSize = true;
            lblCost.Location = new Point(40, 375);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(92, 20);
            lblCost.TabIndex = 15;
            lblCost.Text = "Service Cost:";
            // 
            // txtVehicleRegistration
            // 
            txtVehicleRegistration.Location = new Point(40, 220);
            txtVehicleRegistration.Name = "txtVehicleRegistration";
            txtVehicleRegistration.Size = new Size(240, 27);
            txtVehicleRegistration.TabIndex = 16;
            // 
            // txtVehicleMake
            // 
            txtVehicleMake.Location = new Point(340, 220);
            txtVehicleMake.Name = "txtVehicleMake";
            txtVehicleMake.Size = new Size(240, 27);
            txtVehicleMake.TabIndex = 17;
            // 
            // txtVehicleModel
            // 
            txtVehicleModel.Location = new Point(40, 280);
            txtVehicleModel.Name = "txtVehicleModel";
            txtVehicleModel.Size = new Size(240, 27);
            txtVehicleModel.TabIndex = 18;
            // 
            // txtVehicleYear
            // 
            txtVehicleYear.Location = new Point(340, 280);
            txtVehicleYear.Name = "txtVehicleYear";
            txtVehicleYear.Size = new Size(240, 27);
            txtVehicleYear.TabIndex = 19;
            // 
            // txtServiceType
            // 
            txtServiceType.Location = new Point(40, 340);
            txtServiceType.Name = "txtServiceType";
            txtServiceType.Size = new Size(240, 27);
            txtServiceType.TabIndex = 20;
            // 
            // txtTechnician
            // 
            txtTechnician.Location = new Point(340, 340);
            txtTechnician.Name = "txtTechnician";
            txtTechnician.Size = new Size(240, 27);
            txtTechnician.TabIndex = 21;
            // 
            // txtServiceCost
            // 
            txtServiceCost.Location = new Point(40, 400);
            txtServiceCost.Name = "txtServiceCost";
            txtServiceCost.Size = new Size(240, 27);
            txtServiceCost.TabIndex = 22;
            // 
            // lblServiceDate
            // 
            lblServiceDate.AutoSize = true;
            lblServiceDate.Location = new Point(340, 375);
            lblServiceDate.Name = "lblServiceDate";
            lblServiceDate.Size = new Size(95, 20);
            lblServiceDate.TabIndex = 23;
            lblServiceDate.Text = "Service Date:";
            // 
            // lblNextDate
            // 
            lblNextDate.AutoSize = true;
            lblNextDate.Location = new Point(40, 435);
            lblNextDate.Name = "lblNextDate";
            lblNextDate.Size = new Size(130, 20);
            lblNextDate.TabIndex = 24;
            lblNextDate.Text = "Next Service Date:";
            // 
            // lblPayment
            // 
            lblPayment.AutoSize = true;
            lblPayment.Location = new Point(340, 435);
            lblPayment.Name = "lblPayment";
            lblPayment.Size = new Size(112, 20);
            lblPayment.TabIndex = 25;
            lblPayment.Text = "Payment Status:";
            // 
            // dtpServiceDate
            // 
            dtpServiceDate.Location = new Point(340, 400);
            dtpServiceDate.Name = "dtpServiceDate";
            dtpServiceDate.Size = new Size(240, 27);
            dtpServiceDate.TabIndex = 26;
            // 
            // dtpNextServiceDate
            // 
            dtpNextServiceDate.Location = new Point(40, 460);
            dtpNextServiceDate.Name = "dtpNextServiceDate";
            dtpNextServiceDate.Size = new Size(240, 27);
            dtpNextServiceDate.TabIndex = 27;
            // 
            // cmbPaymentStatus
            // 
            cmbPaymentStatus.FormattingEnabled = true;
            cmbPaymentStatus.Items.AddRange(new object[] { "Paid", "Unpaid", "Partial" });
            cmbPaymentStatus.Location = new Point(340, 460);
            cmbPaymentStatus.Name = "cmbPaymentStatus";
            cmbPaymentStatus.Size = new Size(240, 28);
            cmbPaymentStatus.TabIndex = 28;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(40, 510);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(130, 30);
            btnRegister.TabIndex = 29;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnView
            // 
            btnView.Location = new Point(180, 510);
            btnView.Name = "btnView";
            btnView.Size = new Size(100, 30);
            btnView.TabIndex = 30;
            btnView.Text = "View All";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(290, 510);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(80, 30);
            btnSearch.TabIndex = 31;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(380, 510);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(80, 30);
            btnUpdate.TabIndex = 32;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(470, 510);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(80, 30);
            btnDelete.TabIndex = 33;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(40, 550);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(80, 30);
            btnClear.TabIndex = 34;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnReport
            // 
            btnReport.Location = new Point(130, 550);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(150, 30);
            btnReport.TabIndex = 35;
            btnReport.Text = "Generate Reports";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // dgvServices
            // 
            dgvServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServices.Location = new Point(40, 595);
            dgvServices.Name = "dgvServices";
            dgvServices.RowHeadersWidth = 51;
            dgvServices.Size = new Size(959, 300);
            dgvServices.TabIndex = 36;
            dgvServices.CellClick += dgvServices_CellClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 920);
            Controls.Add(dgvServices);
            Controls.Add(btnReport);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSearch);
            Controls.Add(btnView);
            Controls.Add(btnRegister);
            Controls.Add(cmbPaymentStatus);
            Controls.Add(dtpNextServiceDate);
            Controls.Add(dtpServiceDate);
            Controls.Add(lblPayment);
            Controls.Add(lblNextDate);
            Controls.Add(lblServiceDate);
            Controls.Add(txtServiceCost);
            Controls.Add(txtTechnician);
            Controls.Add(txtServiceType);
            Controls.Add(txtVehicleYear);
            Controls.Add(txtVehicleModel);
            Controls.Add(txtVehicleMake);
            Controls.Add(txtVehicleRegistration);
            Controls.Add(lblCost);
            Controls.Add(lblTechnician);
            Controls.Add(lblServiceType);
            Controls.Add(lblYear);
            Controls.Add(lblModel);
            Controls.Add(lblMake);
            Controls.Add(lblReg);
            Controls.Add(txtContactNumber);
            Controls.Add(txtIDNumber);
            Controls.Add(txtCustomerName);
            Controls.Add(txtServiceNumber);
            Controls.Add(lblContact);
            Controls.Add(lblIDNumber);
            Controls.Add(lblCustomerName);
            Controls.Add(lblServiceNumber);
            Controls.Add(label1);
            Name = "Form1";
            Text = "AutoCare Service Centre";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvServices).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblServiceNumber;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblIDNumber;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtServiceNumber;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtIDNumber;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.Label lblReg;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblServiceType;
        private System.Windows.Forms.Label lblTechnician;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox txtVehicleRegistration;
        private System.Windows.Forms.TextBox txtVehicleMake;
        private System.Windows.Forms.TextBox txtVehicleModel;
        private System.Windows.Forms.TextBox txtVehicleYear;
        private System.Windows.Forms.TextBox txtServiceType;
        private System.Windows.Forms.TextBox txtTechnician;
        private System.Windows.Forms.TextBox txtServiceCost;
        private System.Windows.Forms.Label lblServiceDate;
        private System.Windows.Forms.Label lblNextDate;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.DateTimePicker dtpServiceDate;
        private System.Windows.Forms.DateTimePicker dtpNextServiceDate;
        private System.Windows.Forms.ComboBox cmbPaymentStatus;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.DataGridView dgvServices;
    }
}