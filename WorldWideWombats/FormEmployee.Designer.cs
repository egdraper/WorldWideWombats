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
            this.btnOpenExistin = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlHourly.SuspendLayout();
            this.pnlSalary.SuspendLayout();
            this.pnlSales.SuspendLayout();
            this.pnlContractor.SuspendLayout();
            this.SuspendLayout();
            // 
            // tboxFirstName
            // 
            this.tboxFirstName.Location = new System.Drawing.Point(153, 84);
            this.tboxFirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tboxFirstName.Name = "tboxFirstName";
            this.tboxFirstName.Size = new System.Drawing.Size(163, 20);
            this.tboxFirstName.TabIndex = 1;
            // 
            // tboxLastName
            // 
            this.tboxLastName.Location = new System.Drawing.Point(153, 120);
            this.tboxLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tboxLastName.Name = "tboxLastName";
            this.tboxLastName.Size = new System.Drawing.Size(163, 20);
            this.tboxLastName.TabIndex = 2;
            // 
            // tboxHourlyRate
            // 
            this.tboxHourlyRate.Location = new System.Drawing.Point(94, 17);
            this.tboxHourlyRate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tboxHourlyRate.Name = "tboxHourlyRate";
            this.tboxHourlyRate.Size = new System.Drawing.Size(163, 20);
            this.tboxHourlyRate.TabIndex = 3;
            this.tboxHourlyRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkForLetters);
            // 
            // tboxHoursWorked
            // 
            this.tboxHoursWorked.Location = new System.Drawing.Point(94, 55);
            this.tboxHoursWorked.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tboxHoursWorked.Name = "tboxHoursWorked";
            this.tboxHoursWorked.Size = new System.Drawing.Size(163, 20);
            this.tboxHoursWorked.TabIndex = 4;
            this.tboxHoursWorked.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkForLetters);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(69, 84);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 7;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(69, 122);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 8;
            this.lblLastName.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hourly Rate";
            // 
            // EmployeeType
            // 
            this.EmployeeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EmployeeType.FormattingEnabled = true;
            this.EmployeeType.Location = new System.Drawing.Point(153, 49);
            this.EmployeeType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EmployeeType.Name = "EmployeeType";
            this.EmployeeType.Size = new System.Drawing.Size(163, 21);
            this.EmployeeType.TabIndex = 10;
            this.EmployeeType.SelectedIndexChanged += new System.EventHandler(this.EmployeeType_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 59);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Hours Worked";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(69, 51);
            this.lblType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(52, 13);
            this.lblType.TabIndex = 13;
            this.lblType.Text = "Pay Type";
            // 
            // pnlHourly
            // 
            this.pnlHourly.Controls.Add(this.tboxHourlyRate);
            this.pnlHourly.Controls.Add(this.tboxHoursWorked);
            this.pnlHourly.Controls.Add(this.label5);
            this.pnlHourly.Controls.Add(this.label4);
            this.pnlHourly.Location = new System.Drawing.Point(59, 194);
            this.pnlHourly.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlHourly.Name = "pnlHourly";
            this.pnlHourly.Size = new System.Drawing.Size(279, 94);
            this.pnlHourly.TabIndex = 14;
            this.pnlHourly.Visible = false;
            // 
            // pnlSalary
            // 
            this.pnlSalary.Controls.Add(this.tboxMonthlySalary);
            this.pnlSalary.Controls.Add(this.label8);
            this.pnlSalary.Location = new System.Drawing.Point(59, 196);
            this.pnlSalary.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlSalary.Name = "pnlSalary";
            this.pnlSalary.Size = new System.Drawing.Size(279, 51);
            this.pnlSalary.TabIndex = 15;
            this.pnlSalary.Visible = false;
            // 
            // tboxMonthlySalary
            // 
            this.tboxMonthlySalary.Location = new System.Drawing.Point(94, 17);
            this.tboxMonthlySalary.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tboxMonthlySalary.Name = "tboxMonthlySalary";
            this.tboxMonthlySalary.Size = new System.Drawing.Size(163, 20);
            this.tboxMonthlySalary.TabIndex = 3;
            this.tboxMonthlySalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkForLetters);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 19);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Monthly Salary";
            // 
            // pnlSales
            // 
            this.pnlSales.Controls.Add(this.tboxCommission);
            this.pnlSales.Controls.Add(this.tboxGrossSalary);
            this.pnlSales.Controls.Add(this.lblGrossSales);
            this.pnlSales.Controls.Add(this.lblCommission);
            this.pnlSales.Location = new System.Drawing.Point(59, 233);
            this.pnlSales.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlSales.Name = "pnlSales";
            this.pnlSales.Size = new System.Drawing.Size(279, 94);
            this.pnlSales.TabIndex = 16;
            this.pnlSales.Visible = false;
            // 
            // tboxCommission
            // 
            this.tboxCommission.Location = new System.Drawing.Point(94, 17);
            this.tboxCommission.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tboxCommission.Name = "tboxCommission";
            this.tboxCommission.Size = new System.Drawing.Size(163, 20);
            this.tboxCommission.TabIndex = 3;
            this.tboxCommission.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkForLetters);
            // 
            // tboxGrossSalary
            // 
            this.tboxGrossSalary.Location = new System.Drawing.Point(94, 57);
            this.tboxGrossSalary.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tboxGrossSalary.Name = "tboxGrossSalary";
            this.tboxGrossSalary.Size = new System.Drawing.Size(163, 20);
            this.tboxGrossSalary.TabIndex = 4;
            this.tboxGrossSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkForLetters);
            // 
            // lblGrossSales
            // 
            this.lblGrossSales.AutoSize = true;
            this.lblGrossSales.Location = new System.Drawing.Point(11, 59);
            this.lblGrossSales.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGrossSales.Name = "lblGrossSales";
            this.lblGrossSales.Size = new System.Drawing.Size(60, 13);
            this.lblGrossSales.TabIndex = 11;
            this.lblGrossSales.Text = "GrossSales";
            // 
            // lblCommission
            // 
            this.lblCommission.AutoSize = true;
            this.lblCommission.Location = new System.Drawing.Point(11, 19);
            this.lblCommission.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCommission.Name = "lblCommission";
            this.lblCommission.Size = new System.Drawing.Size(62, 13);
            this.lblCommission.TabIndex = 9;
            this.lblCommission.Text = "Commission";
            // 
            // pnlContractor
            // 
            this.pnlContractor.Controls.Add(this.tboxContractWage);
            this.pnlContractor.Controls.Add(this.lblContractWage);
            this.pnlContractor.Location = new System.Drawing.Point(59, 194);
            this.pnlContractor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlContractor.Name = "pnlContractor";
            this.pnlContractor.Size = new System.Drawing.Size(279, 51);
            this.pnlContractor.TabIndex = 16;
            this.pnlContractor.Visible = false;
            // 
            // tboxContractWage
            // 
            this.tboxContractWage.Location = new System.Drawing.Point(94, 17);
            this.tboxContractWage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tboxContractWage.Name = "tboxContractWage";
            this.tboxContractWage.Size = new System.Drawing.Size(163, 20);
            this.tboxContractWage.TabIndex = 3;
            this.tboxContractWage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkForLetters);
            // 
            // lblContractWage
            // 
            this.lblContractWage.AutoSize = true;
            this.lblContractWage.Location = new System.Drawing.Point(11, 19);
            this.lblContractWage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContractWage.Name = "lblContractWage";
            this.lblContractWage.Size = new System.Drawing.Size(79, 13);
            this.lblContractWage.TabIndex = 9;
            this.lblContractWage.Text = "Contract Wage";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(226, 341);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(89, 27);
            this.btnSubmit.TabIndex = 17;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(26, 19);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(114, 13);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "Enter A new Employee";
            // 
            // lboxEmployees
            // 
            this.lboxEmployees.FormattingEnabled = true;
            this.lboxEmployees.Location = new System.Drawing.Point(419, 57);
            this.lboxEmployees.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lboxEmployees.Name = "lboxEmployees";
            this.lboxEmployees.Size = new System.Drawing.Size(139, 264);
            this.lboxEmployees.TabIndex = 19;
            // 
            // lblEmployeeListTitle
            // 
            this.lblEmployeeListTitle.AutoSize = true;
            this.lblEmployeeListTitle.Location = new System.Drawing.Point(417, 42);
            this.lblEmployeeListTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeeListTitle.Name = "lblEmployeeListTitle";
            this.lblEmployeeListTitle.Size = new System.Drawing.Size(53, 13);
            this.lblEmployeeListTitle.TabIndex = 20;
            this.lblEmployeeListTitle.Text = "Employee";
            // 
            // btnTestData
            // 
            this.btnTestData.Location = new System.Drawing.Point(419, 341);
            this.btnTestData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTestData.Name = "btnTestData";
            this.btnTestData.Size = new System.Drawing.Size(115, 38);
            this.btnTestData.TabIndex = 21;
            this.btnTestData.Text = "Test Data";
            this.btnTestData.UseVisualStyleBackColor = true;
            this.btnTestData.Click += new System.EventHandler(this.btnTestData_Click);
            // 
            // lblTestPassFail
            // 
            this.lblTestPassFail.AutoSize = true;
            this.lblTestPassFail.Location = new System.Drawing.Point(417, 380);
            this.lblTestPassFail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTestPassFail.Name = "lblTestPassFail";
            this.lblTestPassFail.Size = new System.Drawing.Size(41, 13);
            this.lblTestPassFail.TabIndex = 22;
            this.lblTestPassFail.Text = "label13";
            this.lblTestPassFail.Visible = false;
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.Location = new System.Drawing.Point(69, 153);
            this.lblEmployeeId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(65, 13);
            this.lblEmployeeId.TabIndex = 6;
            this.lblEmployeeId.Text = "Employee Id";
            // 
            // tboxEmployeeId
            // 
            this.tboxEmployeeId.Enabled = false;
            this.tboxEmployeeId.Location = new System.Drawing.Point(153, 152);
            this.tboxEmployeeId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tboxEmployeeId.Name = "tboxEmployeeId";
            this.tboxEmployeeId.Size = new System.Drawing.Size(163, 20);
            this.tboxEmployeeId.TabIndex = 0;
            // 
            // btnOpenExistin
            // 
            this.btnOpenExistin.Location = new System.Drawing.Point(562, 57);
            this.btnOpenExistin.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenExistin.Name = "btnOpenExistin";
            this.btnOpenExistin.Size = new System.Drawing.Size(89, 27);
            this.btnOpenExistin.TabIndex = 23;
            this.btnOpenExistin.Text = "Open Existing";
            this.btnOpenExistin.UseVisualStyleBackColor = true;
            this.btnOpenExistin.Click += new System.EventHandler(this.btnOpenExistin_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(562, 88);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 27);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 408);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpenExistin);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button btnOpenExistin;
        private System.Windows.Forms.Button btnSave;
    }
}

