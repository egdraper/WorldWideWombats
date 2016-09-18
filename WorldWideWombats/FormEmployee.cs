﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WorldWideWombats
{
    /// <summary>
    /// FormEmplee: is the form that creates new employees
    /// </summary>
    public partial class FormEmployee : Form
    {
        //this stores the employees in memory.
        private List<Employee> employees = new List<Employee>();
        public FormEmployee()
        {
            InitializeComponent();
            EmployeeType.DataSource = Enum.GetNames(typeof(EType));
          
        }

        /// <summary>
        /// Checks for letters or symbols and only allows approved items in.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkForLetters(object sender, KeyPressEventArgs e)
        {
            //Code Referenced from http://stackoverflow.com/questions/463299/how-do-i-make-a-textbox-that-only-accepts-numbers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            //to here
        }
        
        /// <summary>
        /// Changes which form fields are available for a given type
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmployeeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var type = GetEmployeeType();           
            clearPanels();

            //Swithces the form type
            switch (type)
            {
                case EType.SALARY:
                    pnlSalary.Visible = true;
                    break;
                case EType.SALES:
                    pnlSales.Visible = true;
                    pnlSalary.Visible = true;                 
                    break;
                case EType.HOURLY:
                    pnlHourly.Visible = true;
                    break;
                case EType.CONTRACT:
                    pnlContractor.Visible = true;
                    break;
                default:
                    break;
            }
         
        }

        /// <summary>
        /// resets the panel visiblity to false, so the olds panels wont linger
        /// </summary>
        private void clearPanels()
        {
            pnlSales.Visible = false;
            pnlSalary.Visible = false;
            pnlContractor.Visible = false;
            pnlHourly.Visible = false;
        }

        /// <summary>
        /// After submit has been pressed, the text boxes need to be cleared
        /// </summary>
        private void clearAllBoxes()
        {
            tboxHoursWorked.Text = string.Empty;
            tboxCommission.Text = string.Empty;
            tboxContractWage.Text = string.Empty;
            tboxEmployeeId.Text = string.Empty;
            tboxFirstName.Text = string.Empty;
            tboxLastName.Text = string.Empty;
            tboxHourlyRate.Text = string.Empty;
            tboxMonthlySalary.Text = string.Empty;
            tboxGrossSalary.Text = string.Empty;
         }

        /// <summary>
        /// Gets the type from employee from the employee dropdown list
        /// </summary>
        /// <returns></returns>
        private EType GetEmployeeType()
        {
            EType type;
            Enum.TryParse<EType>(EmployeeType.SelectedValue.ToString(), out type);
            return type;
        }

        //Submits the info to the database  (aka: list in memory)
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var type = GetEmployeeType();
            Employee employee = null;

            //creates and instance for the type chosen
            switch (type)
            {
                case EType.SALARY:
                    employee = new Salary()
                    {
                        EmpID = tboxEmployeeId.Text,
                        EmpType = type,
                        FirstName = tboxFirstName.Text,
                        LastName = tboxLastName.Text,
                        MonthlySalary = Convert.ToDouble(tboxMonthlySalary.Text)
                        
                    };
                    
                    break;
                case EType.SALES:
                    employee = new Sales()
                    {
                        EmpID = tboxEmployeeId.Text,
                        EmpType = type,
                        FirstName = tboxFirstName.Text,
                        LastName = tboxLastName.Text,
                        MonthlySalary = Convert.ToDouble(tboxMonthlySalary.Text),
                        GrossSales = Convert.ToDouble(tboxGrossSalary.Text),
                        Commission = Convert.ToDouble(tboxCommission.Text)                
                    };
                    break;
                case EType.HOURLY:
                    employee = new Hourly()
                    {
                        EmpID = tboxEmployeeId.Text,
                        EmpType = type,
                        FirstName = tboxFirstName.Text,
                        LastName = tboxLastName.Text,
                        HourlyRate = Convert.ToDouble(tboxHourlyRate.Text),
                        HoursWorked = Convert.ToDouble(tboxHoursWorked.Text)
                    };

                    break;
                case EType.CONTRACT:
                    employee = new Contract()
                    {
                        EmpID = tboxEmployeeId.Text,
                        EmpType = type,
                        FirstName = tboxFirstName.Text,
                        LastName = tboxLastName.Text,
                        ContractWage = Convert.ToDouble(tboxContractWage.Text)
                    };
                    break;
                default:
                    break;
            }
            
            //adds employee to memory
            employees.Add(employee);
            clearAllBoxes();

            //lists emplyees that have been entered.
            lboxEmployees.Items.Add(employee.FirstName + " " + employee.LastName + "; " + type.ToString());
        }

        private void btnTestData_Click(object sender, EventArgs e)
        {
            lblTestPassFail.Visible = true;
            var testEmployees = Test.ClassInstantationTest();
            if (testEmployees != null)
            {
                foreach(Employee emp in testEmployees)
                {
                    lboxEmployees.Items.Add(emp.FirstName + " " + emp.LastName + "; " + emp.EmpType.ToString());
                }  
                lblTestPassFail.ForeColor = System.Drawing.Color.Green;
                lblTestPassFail.Text = "Test Passed";
            }
            else
            {
                lblTestPassFail.ForeColor = System.Drawing.Color.Red;
                lblTestPassFail.Text = "Test Failed";
            }
        }
    }
}