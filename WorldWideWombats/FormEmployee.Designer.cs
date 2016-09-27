namespace WorldWideWombats
{
    partial class FormEmployee
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
            this.tboxFirstName = new System.Windows.Forms.TextBox();
            this.tboxLastName = new System.Windows.Forms.TextBox();
            this.tboxHourlyRate = new System.Windows.Forms.TextBox();
            this.tboxHoursWorked = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EmployeeType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.pnlHourly = new System.Windows.Forms.Panel();
            this.pnlSalary = new System.Windows.Forms.Panel();
            this.tboxMonthlySalary = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlSales = new System.Windows.Forms.Panel();
            this.tboxCommission = new System.Windows.Forms.TextBox();
            this.tboxGrossSalary = new System.Windows.Forms.TextBox();
            this.lblGrossSales = new System.Windows.Forms.Label();
            this.lblCommission = new System.Windows.Forms.Label();
            this.pnlContractor = new System.Windows.Forms.Panel();
            this.tboxContractWage = new System.Windows.Forms.TextBox();
            this.lblContractWage = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lboxEmployees = new System.Windows.Forms.ListBox();
            this.lblEmployeeListTitle = new System.Windows.Forms.Label();
            this.btnTestData = new System.Windows.Forms.Button();
            this.lblTestPassFail = new System.Windows.Forms.Label();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.tboxEmployeeId = new System.Windows.Forms.TextBox();
            this.pnlHourly.SuspendLayout();
            this.pnlSalary.SuspendLayout();
            this.pnlSales.SuspendLayout();
            this.pnlContractor.SuspendLayout();
            this.SuspendLayout();
            // 
            // tboxFirstName
            // 
            this.tboxFirstName.Location = new System.Drawing.Point(229, 130);
            this.tboxFirstName.Name = "tboxFirstName";
            this.tboxFirstName.Size = new System.Drawing.Size(242, 26);
            this.tboxFirstName.TabIndex = 1;
            // 
            // tboxLastName
            // 
            this.tboxLastName.Location = new System.Drawing.Point(229, 184);
            this.tboxLastName.Name = "tboxLastName";
            this.tboxLastName.Size = new System.Drawing.Size(242, 26);
            this.tboxLastName.TabIndex = 2;
            // 
            // tboxHourlyRate
            // 
            this.tboxHourlyRate.Location = new System.Drawing.Point(141, 26);
            this.tboxHourlyRate.Name = "tboxHourlyRate";
            this.tboxHourlyRate.Size = new System.Drawing.Size(242, 26);
            this.tboxHourlyRate.TabIndex = 3;
            this.tboxHourlyRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkForLetters);
            // 
            // tboxHoursWorked
            // 
            this.tboxHoursWorked.Location = new System.Drawing.Point(141, 85);
            this.tboxHoursWorked.Name = "tboxHoursWorked";
            this.tboxHoursWorked.Size = new System.Drawing.Size(242, 26);
            this.tboxHoursWorked.TabIndex = 4;
            this.tboxHoursWorked.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkForLetters);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(103, 130);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(86, 20);
            this.lblFirstName.TabIndex = 7;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(103, 187);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(86, 20);
            this.lblLastName.TabIndex = 8;
            this.lblLastName.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hourly Rate";
            // 
            // EmployeeType
            // 
            this.EmployeeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EmployeeType.FormattingEnabled = true;
            this.EmployeeType.Location = new System.Drawing.Point(229, 75);
            this.EmployeeType.Name = "EmployeeType";
            this.EmployeeType.Size = new System.Drawing.Size(242, 28);
            this.EmployeeType.TabIndex = 10;
            this.EmployeeType.SelectedIndexChanged += new System.EventHandler(this.EmployeeType_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Hours Worked";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(103, 78);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(73, 20);
            this.lblType.TabIndex = 13;
            this.lblType.Text = "Pay Type";
            // 
            // pnlHourly
            // 
            this.pnlHourly.Controls.Add(this.tboxHourlyRate);
            this.pnlHourly.Controls.Add(this.tboxHoursWorked);
            this.pnlHourly.Controls.Add(this.label5);
            this.pnlHourly.Controls.Add(this.label4);
            this.pnlHourly.Location = new System.Drawing.Point(88, 298);
            this.pnlHourly.Name = "pnlHourly";
            this.pnlHourly.Size = new System.Drawing.Size(418, 145);
            this.pnlHourly.TabIndex = 14;
            this.pnlHourly.Visible = false;
            // 
            // pnlSalary
            // 
            this.pnlSalary.Controls.Add(this.tboxMonthlySalary);
            this.pnlSalary.Controls.Add(this.label8);
            this.pnlSalary.Location = new System.Drawing.Point(88, 302);
            this.pnlSalary.Name = "pnlSalary";
            this.pnlSalary.Size = new System.Drawing.Size(418, 78);
            this.pnlSalary.TabIndex = 15;
            this.pnlSalary.Visible = false;
            // 
            // tboxMonthlySalary
            // 
            this.tboxMonthlySalary.Location = new System.Drawing.Point(141, 26);
            this.tboxMonthlySalary.Name = "tboxMonthlySalary";
            this.tboxMonthlySalary.Size = new System.Drawing.Size(242, 26);
            this.tboxMonthlySalary.TabIndex = 3;
            this.tboxMonthlySalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkForLetters);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Monthly Salary";
            // 
            // pnlSales
            // 
            this.pnlSales.Controls.Add(this.tboxCommission);
            this.pnlSales.Controls.Add(this.tboxGrossSalary);
            this.pnlSales.Controls.Add(this.lblGrossSales);
            this.pnlSales.Controls.Add(this.lblCommission);
            this.pnlSales.Location = new System.Drawing.Point(88, 358);
            this.pnlSales.Name = "pnlSales";
            this.pnlSales.Size = new System.Drawing.Size(418, 145);
            this.pnlSales.TabIndex = 16;
            this.pnlSales.Visible = false;
            // 
            // tboxCommission
            // 
            this.tboxCommission.Location = new System.Drawing.Point(141, 26);
            this.tboxCommission.Name = "tboxCommission";
            this.tboxCommission.Size = new System.Drawing.Size(242, 26);
            this.tboxCommission.TabIndex = 3;
            this.tboxCommission.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkForLetters);
            // 
            // tboxGrossSalary
            // 
            this.tboxGrossSalary.Location = new System.Drawing.Point(141, 88);
            this.tboxGrossSalary.Name = "tboxGrossSalary";
            this.tboxGrossSalary.Size = new System.Drawing.Size(242, 26);
            this.tboxGrossSalary.TabIndex = 4;
            this.tboxGrossSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkForLetters);
            // 
            // lblGrossSales
            // 
            this.lblGrossSales.AutoSize = true;
            this.lblGrossSales.Location = new System.Drawing.Point(16, 91);
            this.lblGrossSales.Name = "lblGrossSales";
            this.lblGrossSales.Size = new System.Drawing.Size(92, 20);
            this.lblGrossSales.TabIndex = 11;
            this.lblGrossSales.Text = "GrossSales";
            // 
            // lblCommission
            // 
            this.lblCommission.AutoSize = true;
            this.lblCommission.Location = new System.Drawing.Point(16, 29);
            this.lblCommission.Name = "lblCommission";
            this.lblCommission.Size = new System.Drawing.Size(95, 20);
            this.lblCommission.TabIndex = 9;
            this.lblCommission.Text = "Commission";
            // 
            // pnlContractor
            // 
            this.pnlContractor.Controls.Add(this.tboxContractWage);
            this.pnlContractor.Controls.Add(this.lblContractWage);
            this.pnlContractor.Location = new System.Drawing.Point(88, 298);
            this.pnlContractor.Name = "pnlContractor";
            this.pnlContractor.Size = new System.Drawing.Size(418, 78);
            this.pnlContractor.TabIndex = 16;
            this.pnlContractor.Visible = false;
            // 
            // tboxContractWage
            // 
            this.tboxContractWage.Location = new System.Drawing.Point(141, 26);
            this.tboxContractWage.Name = "tboxContractWage";
            this.tboxContractWage.Size = new System.Drawing.Size(242, 26);
            this.tboxContractWage.TabIndex = 3;
            this.tboxContractWage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkForLetters);
            // 
            // lblContractWage
            // 
            this.lblContractWage.AutoSize = true;
            this.lblContractWage.Location = new System.Drawing.Point(16, 29);
            this.lblContractWage.Name = "lblContractWage";
            this.lblContractWage.Size = new System.Drawing.Size(116, 20);
            this.lblContractWage.TabIndex = 9;
            this.lblContractWage.Text = "Contract Wage";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(339, 525);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(134, 42);
            this.btnSubmit.TabIndex = 17;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(39, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(170, 20);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "Enter A new Employee";
            // 
            // lboxEmployees
            // 
            this.lboxEmployees.FormattingEnabled = true;
            this.lboxEmployees.ItemHeight = 20;
            this.lboxEmployees.Location = new System.Drawing.Point(628, 88);
            this.lboxEmployees.Name = "lboxEmployees";
            this.lboxEmployees.Size = new System.Drawing.Size(206, 404);
            this.lboxEmployees.TabIndex = 19;
            // 
            // lblEmployeeListTitle
            // 
            this.lblEmployeeListTitle.AutoSize = true;
            this.lblEmployeeListTitle.Location = new System.Drawing.Point(626, 65);
            this.lblEmployeeListTitle.Name = "lblEmployeeListTitle";
            this.lblEmployeeListTitle.Size = new System.Drawing.Size(79, 20);
            this.lblEmployeeListTitle.TabIndex = 20;
            this.lblEmployeeListTitle.Text = "Employee";
            // 
            // btnTestData
            // 
            this.btnTestData.Location = new System.Drawing.Point(628, 525);
            this.btnTestData.Name = "btnTestData";
            this.btnTestData.Size = new System.Drawing.Size(172, 58);
            this.btnTestData.TabIndex = 21;
            this.btnTestData.Text = "Test Data";
            this.btnTestData.UseVisualStyleBackColor = true;
            this.btnTestData.Click += new System.EventHandler(this.btnTestData_Click);
            // 
            // lblTestPassFail
            // 
            this.lblTestPassFail.AutoSize = true;
            this.lblTestPassFail.Location = new System.Drawing.Point(626, 585);
            this.lblTestPassFail.Name = "lblTestPassFail";
            this.lblTestPassFail.Size = new System.Drawing.Size(60, 20);
            this.lblTestPassFail.TabIndex = 22;
            this.lblTestPassFail.Text = "label13";
            this.lblTestPassFail.Visible = false;
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.Location = new System.Drawing.Point(103, 235);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(97, 20);
            this.lblEmployeeId.TabIndex = 6;
            this.lblEmployeeId.Text = "Employee Id";
            // 
            // tboxEmployeeId
            // 
            this.tboxEmployeeId.Enabled = false;
            this.tboxEmployeeId.Location = new System.Drawing.Point(229, 234);
            this.tboxEmployeeId.Name = "tboxEmployeeId";
            this.tboxEmployeeId.Size = new System.Drawing.Size(242, 26);
            this.tboxEmployeeId.TabIndex = 0;
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 628);
            this.Controls.Add(this.lblTestPassFail);
            this.Controls.Add(this.btnTestData);
            this.Controls.Add(this.lblEmployeeListTitle);
            this.Controls.Add(this.lboxEmployees);
            this.Controls.Add(this.pnlSales);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.pnlContractor);
            this.Controls.Add(this.pnlSalary);
            this.Controls.Add(this.pnlHourly);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.EmployeeType);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblEmployeeId);
            this.Controls.Add(this.tboxLastName);
            this.Controls.Add(this.tboxFirstName);
            this.Controls.Add(this.tboxEmployeeId);
            this.Name = "FormEmployee";
            this.Text = "Employee Directory";
            this.pnlHourly.ResumeLayout(false);
            this.pnlHourly.PerformLayout();
            this.pnlSalary.ResumeLayout(false);
            this.pnlSalary.PerformLayout();
            this.pnlSales.ResumeLayout(false);
            this.pnlSales.PerformLayout();
            this.pnlContractor.ResumeLayout(false);
            this.pnlContractor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tboxFirstName;
        private System.Windows.Forms.TextBox tboxLastName;
        private System.Windows.Forms.TextBox tboxHourlyRate;
        private System.Windows.Forms.TextBox tboxHoursWorked;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox EmployeeType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Panel pnlHourly;
        private System.Windows.Forms.Panel pnlSalary;
        private System.Windows.Forms.TextBox tboxMonthlySalary;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnlSales;
        private System.Windows.Forms.TextBox tboxCommission;
        private System.Windows.Forms.TextBox tboxGrossSalary;
        private System.Windows.Forms.Label lblGrossSales;
        private System.Windows.Forms.Label lblCommission;
        private System.Windows.Forms.Panel pnlContractor;
        private System.Windows.Forms.TextBox tboxContractWage;
        private System.Windows.Forms.Label lblContractWage;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListBox lboxEmployees;
        private System.Windows.Forms.Label lblEmployeeListTitle;
        private System.Windows.Forms.Button btnTestData;
        private System.Windows.Forms.Label lblTestPassFail;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.TextBox tboxEmployeeId;
    }
}

