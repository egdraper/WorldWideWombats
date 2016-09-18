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
            this.tboxEmployeeId = new System.Windows.Forms.TextBox();
            this.tboxFirstName = new System.Windows.Forms.TextBox();
            this.tboxLastName = new System.Windows.Forms.TextBox();
            this.tboxHourlyRate = new System.Windows.Forms.TextBox();
            this.tboxHoursWorked = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EmployeeType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlHourly = new System.Windows.Forms.Panel();
            this.pnlSalary = new System.Windows.Forms.Panel();
            this.tboxMonthlySalary = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlSales = new System.Windows.Forms.Panel();
            this.tboxCommission = new System.Windows.Forms.TextBox();
            this.tboxGrossSalary = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlContractor = new System.Windows.Forms.Panel();
            this.tboxContractWage = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.lboxEmployees = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnTestData = new System.Windows.Forms.Button();
            this.lblTestPassFail = new System.Windows.Forms.Label();
            this.pnlHourly.SuspendLayout();
            this.pnlSalary.SuspendLayout();
            this.pnlSales.SuspendLayout();
            this.pnlContractor.SuspendLayout();
            this.SuspendLayout();
            // 
            // tboxEmployeeId
            // 
            this.tboxEmployeeId.Location = new System.Drawing.Point(229, 87);
            this.tboxEmployeeId.Name = "tboxEmployeeId";
            this.tboxEmployeeId.Size = new System.Drawing.Size(243, 26);
            this.tboxEmployeeId.TabIndex = 0;
            // 
            // tboxFirstName
            // 
            this.tboxFirstName.Location = new System.Drawing.Point(229, 195);
            this.tboxFirstName.Name = "tboxFirstName";
            this.tboxFirstName.Size = new System.Drawing.Size(243, 26);
            this.tboxFirstName.TabIndex = 1;
            // 
            // tboxLastName
            // 
            this.tboxLastName.Location = new System.Drawing.Point(229, 250);
            this.tboxLastName.Name = "tboxLastName";
            this.tboxLastName.Size = new System.Drawing.Size(243, 26);
            this.tboxLastName.TabIndex = 2;
            // 
            // tboxHourlyRate
            // 
            this.tboxHourlyRate.Location = new System.Drawing.Point(141, 26);
            this.tboxHourlyRate.Name = "tboxHourlyRate";
            this.tboxHourlyRate.Size = new System.Drawing.Size(243, 26);
            this.tboxHourlyRate.TabIndex = 3;
            this.tboxHourlyRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkForLetters);
            // 
            // tboxHoursWorked
            // 
            this.tboxHoursWorked.Location = new System.Drawing.Point(141, 85);
            this.tboxHoursWorked.Name = "tboxHoursWorked";
            this.tboxHoursWorked.Size = new System.Drawing.Size(243, 26);
            this.tboxHoursWorked.TabIndex = 4;
            this.tboxHoursWorked.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkForLetters);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Employee Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Last Name";
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
            this.EmployeeType.Location = new System.Drawing.Point(229, 140);
            this.EmployeeType.Name = "EmployeeType";
            this.EmployeeType.Size = new System.Drawing.Size(243, 28);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(104, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Pay Type";
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
            this.pnlSalary.Location = new System.Drawing.Point(88, 301);
            this.pnlSalary.Name = "pnlSalary";
            this.pnlSalary.Size = new System.Drawing.Size(418, 78);
            this.pnlSalary.TabIndex = 15;
            this.pnlSalary.Visible = false;
            // 
            // tboxMonthlySalary
            // 
            this.tboxMonthlySalary.Location = new System.Drawing.Point(141, 26);
            this.tboxMonthlySalary.Name = "tboxMonthlySalary";
            this.tboxMonthlySalary.Size = new System.Drawing.Size(243, 26);
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
            this.pnlSales.Controls.Add(this.label9);
            this.pnlSales.Controls.Add(this.label10);
            this.pnlSales.Location = new System.Drawing.Point(88, 359);
            this.pnlSales.Name = "pnlSales";
            this.pnlSales.Size = new System.Drawing.Size(418, 145);
            this.pnlSales.TabIndex = 16;
            this.pnlSales.Visible = false;
            // 
            // tboxCommission
            // 
            this.tboxCommission.Location = new System.Drawing.Point(141, 26);
            this.tboxCommission.Name = "tboxCommission";
            this.tboxCommission.Size = new System.Drawing.Size(243, 26);
            this.tboxCommission.TabIndex = 3;
            this.tboxCommission.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkForLetters);
            // 
            // tboxGrossSalary
            // 
            this.tboxGrossSalary.Location = new System.Drawing.Point(141, 88);
            this.tboxGrossSalary.Name = "tboxGrossSalary";
            this.tboxGrossSalary.Size = new System.Drawing.Size(243, 26);
            this.tboxGrossSalary.TabIndex = 4;
            this.tboxGrossSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkForLetters);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "GrossSales";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Commission";
            // 
            // pnlContractor
            // 
            this.pnlContractor.Controls.Add(this.tboxContractWage);
            this.pnlContractor.Controls.Add(this.label6);
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
            this.tboxContractWage.Size = new System.Drawing.Size(243, 26);
            this.tboxContractWage.TabIndex = 3;
            this.tboxContractWage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkForLetters);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Contract Wage";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(339, 524);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(133, 42);
            this.btnSubmit.TabIndex = 17;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(170, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "Enter A new Employee";
            // 
            // lboxEmployees
            // 
            this.lboxEmployees.FormattingEnabled = true;
            this.lboxEmployees.ItemHeight = 20;
            this.lboxEmployees.Location = new System.Drawing.Point(629, 87);
            this.lboxEmployees.Name = "lboxEmployees";
            this.lboxEmployees.Size = new System.Drawing.Size(206, 404);
            this.lboxEmployees.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(625, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "Employee";
            // 
            // btnTestData
            // 
            this.btnTestData.Location = new System.Drawing.Point(629, 524);
            this.btnTestData.Name = "btnTestData";
            this.btnTestData.Size = new System.Drawing.Size(173, 58);
            this.btnTestData.TabIndex = 21;
            this.btnTestData.Text = "Test Data";
            this.btnTestData.UseVisualStyleBackColor = true;
            this.btnTestData.Click += new System.EventHandler(this.btnTestData_Click);
            // 
            // lblTestPassFail
            // 
            this.lblTestPassFail.AutoSize = true;
            this.lblTestPassFail.Location = new System.Drawing.Point(625, 585);
            this.lblTestPassFail.Name = "lblTestPassFail";
            this.lblTestPassFail.Size = new System.Drawing.Size(60, 20);
            this.lblTestPassFail.TabIndex = 22;
            this.lblTestPassFail.Text = "label13";
            this.lblTestPassFail.Visible = false;
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 627);
            this.Controls.Add(this.lblTestPassFail);
            this.Controls.Add(this.btnTestData);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lboxEmployees);
            this.Controls.Add(this.pnlSales);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.pnlContractor);
            this.Controls.Add(this.pnlSalary);
            this.Controls.Add(this.pnlHourly);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.EmployeeType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxLastName);
            this.Controls.Add(this.tboxFirstName);
            this.Controls.Add(this.tboxEmployeeId);
            this.Name = "FormEmployee";
            this.Text = "Form1";
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

        private System.Windows.Forms.TextBox tboxEmployeeId;
        private System.Windows.Forms.TextBox tboxFirstName;
        private System.Windows.Forms.TextBox tboxLastName;
        private System.Windows.Forms.TextBox tboxHourlyRate;
        private System.Windows.Forms.TextBox tboxHoursWorked;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox EmployeeType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlHourly;
        private System.Windows.Forms.Panel pnlSalary;
        private System.Windows.Forms.TextBox tboxMonthlySalary;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnlSales;
        private System.Windows.Forms.TextBox tboxCommission;
        private System.Windows.Forms.TextBox tboxGrossSalary;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pnlContractor;
        private System.Windows.Forms.TextBox tboxContractWage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox lboxEmployees;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnTestData;
        private System.Windows.Forms.Label lblTestPassFail;
    }
}

