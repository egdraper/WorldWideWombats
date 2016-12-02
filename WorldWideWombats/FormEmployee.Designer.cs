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
            this.btnOpenExistin = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlCourses = new System.Windows.Forms.Panel();
            this.lblCourseError = new System.Windows.Forms.Label();
            this.cboxCurrenltyEnroled = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tboxCourseCredits = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.tboxCourseCost = new System.Windows.Forms.TextBox();
            this.tboxCourse = new System.Windows.Forms.TextBox();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lboxCourseList = new System.Windows.Forms.ListBox();
            this.lblPayTypeVar = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblIdVar = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblLastNameVar = new System.Windows.Forms.Label();
            this.lblFirstNameVar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDisplayFirstName = new System.Windows.Forms.Label();
            this.cboxApproved = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tboxSearch = new System.Windows.Forms.TextBox();
            this.lblSearchChriteria = new System.Windows.Forms.Label();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.tboxEmployeeId = new System.Windows.Forms.TextBox();
            this.pnlHourly.SuspendLayout();
            this.pnlSalary.SuspendLayout();
            this.pnlSales.SuspendLayout();
            this.pnlContractor.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlCourses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tboxCourseCredits)).BeginInit();
            this.SuspendLayout();
            // 
            // tboxFirstName
            // 
            this.tboxFirstName.Location = new System.Drawing.Point(213, 136);
            this.tboxFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tboxFirstName.Name = "tboxFirstName";
            this.tboxFirstName.Size = new System.Drawing.Size(216, 22);
            this.tboxFirstName.TabIndex = 1;
            // 
            // tboxLastName
            // 
            this.tboxLastName.Location = new System.Drawing.Point(213, 176);
            this.tboxLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tboxLastName.Name = "tboxLastName";
            this.tboxLastName.Size = new System.Drawing.Size(216, 22);
            this.tboxLastName.TabIndex = 2;
            // 
            // tboxHourlyRate
            // 
            this.tboxHourlyRate.Location = new System.Drawing.Point(125, 21);
            this.tboxHourlyRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tboxHourlyRate.Name = "tboxHourlyRate";
            this.tboxHourlyRate.Size = new System.Drawing.Size(216, 22);
            this.tboxHourlyRate.TabIndex = 3;
            this.tboxHourlyRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkForLetters);
            // 
            // tboxHoursWorked
            // 
            this.tboxHoursWorked.Location = new System.Drawing.Point(125, 61);
            this.tboxHoursWorked.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tboxHoursWorked.Name = "tboxHoursWorked";
            this.tboxHoursWorked.Size = new System.Drawing.Size(216, 22);
            this.tboxHoursWorked.TabIndex = 4;
            this.tboxHoursWorked.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkForLetters);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(101, 139);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(76, 17);
            this.lblFirstName.TabIndex = 7;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(101, 179);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(76, 17);
            this.lblLastName.TabIndex = 8;
            this.lblLastName.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hourly Rate";
            // 
            // EmployeeType
            // 
            this.EmployeeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EmployeeType.FormattingEnabled = true;
            this.EmployeeType.Location = new System.Drawing.Point(213, 55);
            this.EmployeeType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmployeeType.Name = "EmployeeType";
            this.EmployeeType.Size = new System.Drawing.Size(216, 24);
            this.EmployeeType.TabIndex = 10;
            this.EmployeeType.SelectedIndexChanged += new System.EventHandler(this.EmployeeType_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Hours Worked";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(101, 58);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(68, 17);
            this.lblType.TabIndex = 13;
            this.lblType.Text = "Pay Type";
            // 
            // pnlHourly
            // 
            this.pnlHourly.Controls.Add(this.tboxHourlyRate);
            this.pnlHourly.Controls.Add(this.tboxHoursWorked);
            this.pnlHourly.Controls.Add(this.label5);
            this.pnlHourly.Controls.Add(this.label4);
            this.pnlHourly.Location = new System.Drawing.Point(87, 200);
            this.pnlHourly.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlHourly.Name = "pnlHourly";
            this.pnlHourly.Size = new System.Drawing.Size(372, 91);
            this.pnlHourly.TabIndex = 14;
            this.pnlHourly.Visible = false;
            // 
            // pnlSalary
            // 
            this.pnlSalary.Controls.Add(this.tboxMonthlySalary);
            this.pnlSalary.Controls.Add(this.label8);
            this.pnlSalary.Location = new System.Drawing.Point(87, 203);
            this.pnlSalary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlSalary.Name = "pnlSalary";
            this.pnlSalary.Size = new System.Drawing.Size(372, 62);
            this.pnlSalary.TabIndex = 15;
            this.pnlSalary.Visible = false;
            // 
            // tboxMonthlySalary
            // 
            this.tboxMonthlySalary.Location = new System.Drawing.Point(125, 19);
            this.tboxMonthlySalary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tboxMonthlySalary.Name = "tboxMonthlySalary";
            this.tboxMonthlySalary.Size = new System.Drawing.Size(216, 22);
            this.tboxMonthlySalary.TabIndex = 3;
            this.tboxMonthlySalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkForLetters);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Monthly Salary";
            // 
            // pnlSales
            // 
            this.pnlSales.Controls.Add(this.tboxCommission);
            this.pnlSales.Controls.Add(this.tboxGrossSalary);
            this.pnlSales.Controls.Add(this.lblGrossSales);
            this.pnlSales.Controls.Add(this.lblCommission);
            this.pnlSales.Location = new System.Drawing.Point(87, 248);
            this.pnlSales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlSales.Name = "pnlSales";
            this.pnlSales.Size = new System.Drawing.Size(372, 95);
            this.pnlSales.TabIndex = 16;
            this.pnlSales.Visible = false;
            // 
            // tboxCommission
            // 
            this.tboxCommission.Location = new System.Drawing.Point(125, 12);
            this.tboxCommission.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tboxCommission.Name = "tboxCommission";
            this.tboxCommission.Size = new System.Drawing.Size(216, 22);
            this.tboxCommission.TabIndex = 3;
            this.tboxCommission.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkForLetters);
            // 
            // tboxGrossSalary
            // 
            this.tboxGrossSalary.Location = new System.Drawing.Point(125, 51);
            this.tboxGrossSalary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tboxGrossSalary.Name = "tboxGrossSalary";
            this.tboxGrossSalary.Size = new System.Drawing.Size(216, 22);
            this.tboxGrossSalary.TabIndex = 4;
            this.tboxGrossSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkForLetters);
            // 
            // lblGrossSales
            // 
            this.lblGrossSales.AutoSize = true;
            this.lblGrossSales.Location = new System.Drawing.Point(14, 54);
            this.lblGrossSales.Name = "lblGrossSales";
            this.lblGrossSales.Size = new System.Drawing.Size(81, 17);
            this.lblGrossSales.TabIndex = 11;
            this.lblGrossSales.Text = "GrossSales";
            // 
            // lblCommission
            // 
            this.lblCommission.AutoSize = true;
            this.lblCommission.Location = new System.Drawing.Point(14, 14);
            this.lblCommission.Name = "lblCommission";
            this.lblCommission.Size = new System.Drawing.Size(83, 17);
            this.lblCommission.TabIndex = 9;
            this.lblCommission.Text = "Commission";
            // 
            // pnlContractor
            // 
            this.pnlContractor.Controls.Add(this.tboxContractWage);
            this.pnlContractor.Controls.Add(this.lblContractWage);
            this.pnlContractor.Location = new System.Drawing.Point(87, 200);
            this.pnlContractor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlContractor.Name = "pnlContractor";
            this.pnlContractor.Size = new System.Drawing.Size(372, 62);
            this.pnlContractor.TabIndex = 16;
            this.pnlContractor.Visible = false;
            // 
            // tboxContractWage
            // 
            this.tboxContractWage.Location = new System.Drawing.Point(125, 21);
            this.tboxContractWage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tboxContractWage.Name = "tboxContractWage";
            this.tboxContractWage.Size = new System.Drawing.Size(216, 22);
            this.tboxContractWage.TabIndex = 3;
            this.tboxContractWage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkForLetters);
            // 
            // lblContractWage
            // 
            this.lblContractWage.AutoSize = true;
            this.lblContractWage.Location = new System.Drawing.Point(14, 23);
            this.lblContractWage.Name = "lblContractWage";
            this.lblContractWage.Size = new System.Drawing.Size(102, 17);
            this.lblContractWage.TabIndex = 9;
            this.lblContractWage.Text = "Contract Wage";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(310, 415);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(119, 34);
            this.btnSubmit.TabIndex = 17;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(44, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(150, 17);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "Enter A new Employee";
            // 
            // lboxEmployees
            // 
            this.lboxEmployees.FormattingEnabled = true;
            this.lboxEmployees.ItemHeight = 16;
            this.lboxEmployees.Location = new System.Drawing.Point(501, 55);
            this.lboxEmployees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lboxEmployees.Name = "lboxEmployees";
            this.lboxEmployees.Size = new System.Drawing.Size(289, 324);
            this.lboxEmployees.TabIndex = 19;
            this.lboxEmployees.SelectedIndexChanged += new System.EventHandler(this.lboxEmployees_SelectedIndexChanged);
            // 
            // lblEmployeeListTitle
            // 
            this.lblEmployeeListTitle.AutoSize = true;
            this.lblEmployeeListTitle.Location = new System.Drawing.Point(500, 37);
            this.lblEmployeeListTitle.Name = "lblEmployeeListTitle";
            this.lblEmployeeListTitle.Size = new System.Drawing.Size(70, 17);
            this.lblEmployeeListTitle.TabIndex = 20;
            this.lblEmployeeListTitle.Text = "Employee";
            // 
            // btnTestData
            // 
            this.btnTestData.Location = new System.Drawing.Point(501, 405);
            this.btnTestData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTestData.Name = "btnTestData";
            this.btnTestData.Size = new System.Drawing.Size(127, 46);
            this.btnTestData.TabIndex = 21;
            this.btnTestData.Text = "Test Data";
            this.btnTestData.UseVisualStyleBackColor = true;
            this.btnTestData.Click += new System.EventHandler(this.btnTestData_Click);
            // 
            // lblTestPassFail
            // 
            this.lblTestPassFail.AutoSize = true;
            this.lblTestPassFail.Location = new System.Drawing.Point(500, 453);
            this.lblTestPassFail.Name = "lblTestPassFail";
            this.lblTestPassFail.Size = new System.Drawing.Size(54, 17);
            this.lblTestPassFail.TabIndex = 22;
            this.lblTestPassFail.Text = "label13";
            this.lblTestPassFail.Visible = false;
            // 
            // btnOpenExistin
            // 
            this.btnOpenExistin.Location = new System.Drawing.Point(812, 58);
            this.btnOpenExistin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpenExistin.Name = "btnOpenExistin";
            this.btnOpenExistin.Size = new System.Drawing.Size(119, 34);
            this.btnOpenExistin.TabIndex = 23;
            this.btnOpenExistin.Text = "Open Existing";
            this.btnOpenExistin.UseVisualStyleBackColor = true;
            this.btnOpenExistin.Click += new System.EventHandler(this.btnOpenExistin_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(812, 95);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(119, 34);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(660, 405);
            this.btnShowAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(131, 46);
            this.btnShowAll.TabIndex = 30;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(84, 424);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(218, 17);
            this.lblError.TabIndex = 12;
            this.lblError.Text = "Something is wrong with the Input";
            this.lblError.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(22, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1017, 572);
            this.tabControl1.TabIndex = 31;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pnlSales);
            this.tabPage1.Controls.Add(this.lboxEmployees);
            this.tabPage1.Controls.Add(this.lblError);
            this.tabPage1.Controls.Add(this.tboxEmployeeId);
            this.tabPage1.Controls.Add(this.btnShowAll);
            this.tabPage1.Controls.Add(this.tboxFirstName);
            this.tabPage1.Controls.Add(this.tboxLastName);
            this.tabPage1.Controls.Add(this.lblEmployeeId);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.lblFirstName);
            this.tabPage1.Controls.Add(this.btnOpenExistin);
            this.tabPage1.Controls.Add(this.lblLastName);
            this.tabPage1.Controls.Add(this.lblTestPassFail);
            this.tabPage1.Controls.Add(this.EmployeeType);
            this.tabPage1.Controls.Add(this.btnTestData);
            this.tabPage1.Controls.Add(this.lblType);
            this.tabPage1.Controls.Add(this.lblEmployeeListTitle);
            this.tabPage1.Controls.Add(this.pnlSalary);
            this.tabPage1.Controls.Add(this.pnlContractor);
            this.tabPage1.Controls.Add(this.lblTitle);
            this.tabPage1.Controls.Add(this.btnSubmit);
            this.tabPage1.Controls.Add(this.pnlHourly);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1009, 543);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Employees";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.btnSearch);
            this.tabPage2.Controls.Add(this.lblSearch);
            this.tabPage2.Controls.Add(this.tboxSearch);
            this.tabPage2.Controls.Add(this.lblSearchChriteria);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1009, 543);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Information";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlCourses);
            this.panel1.Controls.Add(this.lblPayTypeVar);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lblIdVar);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblLastNameVar);
            this.panel1.Controls.Add(this.lblFirstNameVar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblDisplayFirstName);
            this.panel1.Controls.Add(this.cboxApproved);
            this.panel1.Location = new System.Drawing.Point(47, 102);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(949, 319);
            this.panel1.TabIndex = 32;
            // 
            // pnlCourses
            // 
            this.pnlCourses.Controls.Add(this.lblCourseError);
            this.pnlCourses.Controls.Add(this.cboxCurrenltyEnroled);
            this.pnlCourses.Controls.Add(this.label16);
            this.pnlCourses.Controls.Add(this.tboxCourseCredits);
            this.pnlCourses.Controls.Add(this.label15);
            this.pnlCourses.Controls.Add(this.tboxCourseCost);
            this.pnlCourses.Controls.Add(this.tboxCourse);
            this.pnlCourses.Controls.Add(this.btnAddCourse);
            this.pnlCourses.Controls.Add(this.label14);
            this.pnlCourses.Controls.Add(this.label13);
            this.pnlCourses.Controls.Add(this.lboxCourseList);
            this.pnlCourses.Enabled = false;
            this.pnlCourses.Location = new System.Drawing.Point(355, 51);
            this.pnlCourses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlCourses.Name = "pnlCourses";
            this.pnlCourses.Size = new System.Drawing.Size(578, 255);
            this.pnlCourses.TabIndex = 52;
            // 
            // lblCourseError
            // 
            this.lblCourseError.AutoSize = true;
            this.lblCourseError.ForeColor = System.Drawing.Color.Red;
            this.lblCourseError.Location = new System.Drawing.Point(19, 183);
            this.lblCourseError.Name = "lblCourseError";
            this.lblCourseError.Size = new System.Drawing.Size(218, 17);
            this.lblCourseError.TabIndex = 52;
            this.lblCourseError.Text = "Something is wrong with your info";
            this.lblCourseError.Visible = false;
            // 
            // cboxCurrenltyEnroled
            // 
            this.cboxCurrenltyEnroled.AutoSize = true;
            this.cboxCurrenltyEnroled.Location = new System.Drawing.Point(87, 119);
            this.cboxCurrenltyEnroled.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxCurrenltyEnroled.Name = "cboxCurrenltyEnroled";
            this.cboxCurrenltyEnroled.Size = new System.Drawing.Size(140, 21);
            this.cboxCurrenltyEnroled.TabIndex = 51;
            this.cboxCurrenltyEnroled.Text = "Currently Enroled";
            this.cboxCurrenltyEnroled.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(259, 4);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 17);
            this.label16.TabIndex = 50;
            this.label16.Text = "Course";
            // 
            // tboxCourseCredits
            // 
            this.tboxCourseCredits.Location = new System.Drawing.Point(87, 86);
            this.tboxCourseCredits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tboxCourseCredits.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.tboxCourseCredits.Name = "tboxCourseCredits";
            this.tboxCourseCredits.Size = new System.Drawing.Size(148, 22);
            this.tboxCourseCredits.TabIndex = 49;
            this.tboxCourseCredits.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 86);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 17);
            this.label15.TabIndex = 47;
            this.label15.Text = "Credits";
            // 
            // tboxCourseCost
            // 
            this.tboxCourseCost.Location = new System.Drawing.Point(87, 52);
            this.tboxCourseCost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tboxCourseCost.Name = "tboxCourseCost";
            this.tboxCourseCost.Size = new System.Drawing.Size(148, 22);
            this.tboxCourseCost.TabIndex = 46;
            // 
            // tboxCourse
            // 
            this.tboxCourse.Location = new System.Drawing.Point(87, 22);
            this.tboxCourse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tboxCourse.Name = "tboxCourse";
            this.tboxCourse.Size = new System.Drawing.Size(148, 22);
            this.tboxCourse.TabIndex = 45;
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(116, 202);
            this.btnAddCourse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(119, 31);
            this.btnAddCourse.TabIndex = 33;
            this.btnAddCourse.Text = "Add Course";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 17);
            this.label14.TabIndex = 44;
            this.label14.Text = "Cost";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 17);
            this.label13.TabIndex = 43;
            this.label13.Text = "Course";
            // 
            // lboxCourseList
            // 
            this.lboxCourseList.FormattingEnabled = true;
            this.lboxCourseList.ItemHeight = 16;
            this.lboxCourseList.Location = new System.Drawing.Point(262, 22);
            this.lboxCourseList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lboxCourseList.Name = "lboxCourseList";
            this.lboxCourseList.Size = new System.Drawing.Size(294, 212);
            this.lboxCourseList.TabIndex = 42;
            this.lboxCourseList.SelectedIndexChanged += new System.EventHandler(this.lboxCourseList_SelectedIndexChanged);
            // 
            // lblPayTypeVar
            // 
            this.lblPayTypeVar.AutoSize = true;
            this.lblPayTypeVar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayTypeVar.Location = new System.Drawing.Point(190, 171);
            this.lblPayTypeVar.Name = "lblPayTypeVar";
            this.lblPayTypeVar.Size = new System.Drawing.Size(120, 29);
            this.lblPayTypeVar.TabIndex = 39;
            this.lblPayTypeVar.Text = "Pay Type:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(36, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 29);
            this.label9.TabIndex = 38;
            this.label9.Text = "Pay Type:";
            // 
            // lblIdVar
            // 
            this.lblIdVar.AutoSize = true;
            this.lblIdVar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdVar.Location = new System.Drawing.Point(90, 14);
            this.lblIdVar.Name = "lblIdVar";
            this.lblIdVar.Size = new System.Drawing.Size(42, 29);
            this.lblIdVar.TabIndex = 37;
            this.lblIdVar.Text = "ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 29);
            this.label6.TabIndex = 36;
            this.label6.Text = "ID:";
            // 
            // lblLastNameVar
            // 
            this.lblLastNameVar.AutoSize = true;
            this.lblLastNameVar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastNameVar.Location = new System.Drawing.Point(190, 126);
            this.lblLastNameVar.Name = "lblLastNameVar";
            this.lblLastNameVar.Size = new System.Drawing.Size(143, 29);
            this.lblLastNameVar.TabIndex = 35;
            this.lblLastNameVar.Text = "First Name: ";
            // 
            // lblFirstNameVar
            // 
            this.lblFirstNameVar.AutoSize = true;
            this.lblFirstNameVar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstNameVar.Location = new System.Drawing.Point(190, 83);
            this.lblFirstNameVar.Name = "lblFirstNameVar";
            this.lblFirstNameVar.Size = new System.Drawing.Size(143, 29);
            this.lblFirstNameVar.TabIndex = 34;
            this.lblFirstNameVar.Text = "First Name: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 29);
            this.label1.TabIndex = 33;
            this.label1.Text = "Last Name:";
            // 
            // lblDisplayFirstName
            // 
            this.lblDisplayFirstName.AutoSize = true;
            this.lblDisplayFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayFirstName.Location = new System.Drawing.Point(36, 83);
            this.lblDisplayFirstName.Name = "lblDisplayFirstName";
            this.lblDisplayFirstName.Size = new System.Drawing.Size(143, 29);
            this.lblDisplayFirstName.TabIndex = 32;
            this.lblDisplayFirstName.Text = "First Name: ";
            // 
            // cboxApproved
            // 
            this.cboxApproved.AutoSize = true;
            this.cboxApproved.Enabled = false;
            this.cboxApproved.Location = new System.Drawing.Point(377, 19);
            this.cboxApproved.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxApproved.Name = "cboxApproved";
            this.cboxApproved.Size = new System.Drawing.Size(271, 21);
            this.cboxApproved.TabIndex = 31;
            this.cboxApproved.Text = "Approved for Education Rembursment";
            this.cboxApproved.UseVisualStyleBackColor = true;
            this.cboxApproved.CheckedChanged += new System.EventHandler(this.cboxApproved_CheckedChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(260, 51);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(119, 31);
            this.btnSearch.TabIndex = 30;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(16, 12);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(53, 17);
            this.lblSearch.TabIndex = 30;
            this.lblSearch.Text = "Search";
            // 
            // tboxSearch
            // 
            this.tboxSearch.Location = new System.Drawing.Point(67, 62);
            this.tboxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tboxSearch.Name = "tboxSearch";
            this.tboxSearch.Size = new System.Drawing.Size(169, 22);
            this.tboxSearch.TabIndex = 25;
            // 
            // lblSearchChriteria
            // 
            this.lblSearchChriteria.AutoSize = true;
            this.lblSearchChriteria.Location = new System.Drawing.Point(63, 43);
            this.lblSearchChriteria.Name = "lblSearchChriteria";
            this.lblSearchChriteria.Size = new System.Drawing.Size(174, 17);
            this.lblSearchChriteria.TabIndex = 27;
            this.lblSearchChriteria.Text = "Employee Id or Last Name";
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.Location = new System.Drawing.Point(101, 98);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(85, 17);
            this.lblEmployeeId.TabIndex = 6;
            this.lblEmployeeId.Text = "Employee Id";
            // 
            // tboxEmployeeId
            // 
            this.tboxEmployeeId.Enabled = false;
            this.tboxEmployeeId.Location = new System.Drawing.Point(213, 95);
            this.tboxEmployeeId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tboxEmployeeId.Name = "tboxEmployeeId";
            this.tboxEmployeeId.Size = new System.Drawing.Size(216, 22);
            this.tboxEmployeeId.TabIndex = 0;
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 596);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlCourses.ResumeLayout(false);
            this.pnlCourses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tboxCourseCredits)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button btnOpenExistin;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox tboxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearchChriteria;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox lboxCourseList;
        private System.Windows.Forms.Label lblPayTypeVar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblIdVar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblLastNameVar;
        private System.Windows.Forms.Label lblFirstNameVar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDisplayFirstName;
        private System.Windows.Forms.CheckBox cboxApproved;
        private System.Windows.Forms.NumericUpDown tboxCourseCredits;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tboxCourseCost;
        private System.Windows.Forms.TextBox tboxCourse;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Panel pnlCourses;
        private System.Windows.Forms.CheckBox cboxCurrenltyEnroled;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblCourseError;
        private System.Windows.Forms.TextBox tboxEmployeeId;
        private System.Windows.Forms.Label lblEmployeeId;
    }
}

