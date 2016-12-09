using System;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;

namespace WorldWideWombats
{
    /// <summary>
    /// FormEmplee: is the form that creates new employees
    /// </summary>
    public partial class FormEmployee : Form
    {
        //this stores the employees in memory.
        private BusinessRules businessRules;
        private Employee SelectedEmployee;

        public FormEmployee()
        {
            InitializeComponent();
            EmployeeType.DataSource = Enum.GetNames(typeof(EType));
            this.businessRules = BusinessRules.Instantiate;
            this.UpdateEmployeeId();
            
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
            tboxEmployeeId.Text = BusinessRules.NextEmployeeId.ToString();
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

            lblError.Visible = false;
            if (!businessRules.CheckName(tboxFirstName.Text))
            {
                lblError.Visible = true;
                return;
            }

            if (!businessRules.CheckName(tboxLastName.Text))
            {
                lblError.Visible = true;
                return;
            }

            var type = GetEmployeeType();
            Employee employee = null;
            
            try
            {
                //creates and instance for the type chosen
                switch (type)
                {
                    case EType.SALARY:
                        employee = new Salary()
                        {
                            EmpType = type,
                            FirstName = tboxFirstName.Text,
                            LastName = tboxLastName.Text,
                            MonthlySalary = Convert.ToDouble(tboxMonthlySalary.Text)
                        };
                        if (!businessRules.CheckHoursAndWages(tboxMonthlySalary.Text))
                        {
                            lblError.Visible = true;
                            return;
                        }

                        break;
                    case EType.SALES:
                        employee = new Sales()
                        {
                            EmpType = type,
                            FirstName = tboxFirstName.Text,
                            LastName = tboxLastName.Text,
                            MonthlySalary = Convert.ToDouble(tboxMonthlySalary.Text),
                            GrossSales = Convert.ToDouble(tboxGrossSalary.Text),
                            Commission = Convert.ToDouble(tboxCommission.Text)
                        };

                        if (!businessRules.CheckHoursAndWages(tboxMonthlySalary.Text))
                        {
                            lblError.Visible = true;
                            return;
                        }
                        if (!businessRules.CheckHoursAndWages(tboxGrossSalary.Text))
                        {
                            lblError.Visible = true;
                            return;
                        }
                        if (!businessRules.CheckHoursAndWages(tboxCommission.Text))
                        {
                            lblError.Visible = true;
                            return;
                        }
                        break;
                    case EType.HOURLY:
                        employee = new Hourly()
                        {
                            EmpType = type,
                            FirstName = tboxFirstName.Text,
                            LastName = tboxLastName.Text,
                            HourlyRate = Convert.ToDouble(tboxHourlyRate.Text),
                            HoursWorked = Convert.ToDouble(tboxHoursWorked.Text)
                        };
                        if (!businessRules.CheckHoursAndWages(tboxHourlyRate.Text))
                        {
                            lblError.Visible = true;
                            return;
                        }
                        if (!businessRules.CheckHoursAndWages(tboxHoursWorked.Text))
                        {
                            lblError.Visible = true;
                            return;
                        }
                        break;
                    case EType.CONTRACT:
                        employee = new Contract()
                        {
                            EmpType = type,
                            FirstName = tboxFirstName.Text,
                            LastName = tboxLastName.Text,
                            ContractWage = Convert.ToDouble(tboxContractWage.Text)
                        };
                        if (!businessRules.CheckHoursAndWages(tboxContractWage.Text))
                        {
                            lblError.Visible = true;
                            return;
                        }
                        break;
                    default:
                        break;
                }

                this.businessRules.Add(employee);
                clearAllBoxes();

                //lists emplyees that have been entered.
                lboxEmployees.Items.Add(employee.EmpID + ":  " + employee.FirstName + " " + employee.LastName + " --- " + type);

            }
            catch
            {
                MessageBox.Show("Not all field have entered values. Please enter a value for every field");
            }

            //adds employee to memory using the lazy loaded Singleton
        }

        /// <summary>
        /// Tests the BusinessRules class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTestData_Click(object sender, EventArgs e)
        {
            lboxEmployees.Items.Clear();
            lblTestPassFail.Visible = true;
            BusinessRules testEmployees = Test.ClassInstantationTest();
            if (testEmployees != null)
            {
                foreach (var emp in testEmployees.GetAll())
                {
                    var employee = emp.Value;
                    if (emp.Value != null)
                        lboxEmployees.Items.Add(employee.EmpID + ":  " + employee.FirstName + " " + employee.LastName + " --- " + employee.EmpType);
                }

                lblTestPassFail.ForeColor = System.Drawing.Color.Green;
                lblTestPassFail.Text = "Test Passed";
            }
            else
            {
                lblTestPassFail.ForeColor = System.Drawing.Color.Red;
                lblTestPassFail.Text = "Test Failed";
            }

            UpdateEmployeeId();
        }

        private void UpdateEmployeeId()
        {
            this.tboxEmployeeId.Text = BusinessRules.NextEmployeeId.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            businessRules.Save();
        }

        /// <summary>
        /// opens and existing name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenExistin_Click(object sender, EventArgs e)
        {
            businessRules.Open();
            lboxEmployees.Items.Clear();
            lboxEmployees.Refresh();
            foreach (var emp in businessRules.GetAll())
            {
                var employee = emp.Value;
                if (emp.Value != null)
                    lboxEmployees.Items.Add(employee.EmpID + ":  " + employee.FirstName + " " + employee.LastName + " --- " + employee.EmpType);
            }
        }

        /// <summary>
        /// shows all the users
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            lboxEmployees.Items.Clear();
            foreach (var emp in businessRules.GetAll())
            {
                var employee = emp.Value;
                if (emp.Value != null)
                    lboxEmployees.Items.Add(employee.EmpID + ":  " + employee.FirstName + " " + employee.LastName + " --- " + employee.EmpType);
            }
        }
       
        /// <summary>
        /// This box tell if the employee has been approved for tuition assistance. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboxApproved_CheckedChanged(object sender, EventArgs e)
        {

            if(SelectedEmployee.EmpType == EType.CONTRACT)
            {
                lblNotEligable.Visible = true;
                cboxApproved.Checked = false;
                return;
            }


            if (cboxApproved.Checked == true)
            {
                SelectedEmployee.ApprovedForTruition = true;
                pnlCourses.Enabled = true;
            }                
            else
                pnlCourses.Enabled = false;
        }

        /// <summary>
        /// searches for an employee by the last name or ID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            ResetCourseApproval();
            var searchedEmployee = businessRules.Search(tboxSearch.Text);
            this.SelectedEmployee = searchedEmployee;
            this.clearCourseBoxes(true);
            if (searchedEmployee != null)
            { 
                cboxApproved.Enabled = true;
                lblIdVar.Text = searchedEmployee.EmpID.ToString();
                lblFirstNameVar.Text = searchedEmployee.FirstName;
                lblLastNameVar.Text = searchedEmployee.LastName;
                lblPayTypeVar.Text = searchedEmployee.EmpType.ToString();
                cboxApproved.Checked = searchedEmployee.ApprovedForTruition;

                if (searchedEmployee.Courses != null)
                {
                    foreach (var courses in searchedEmployee.Courses)
                    {
                        lboxCourseList.Items.Add(courses.Value.Name);
                    }
                }

                pnlCourses.Enabled = searchedEmployee.ApprovedForTruition;
                
            }
            else
            {
                cboxApproved.Enabled = false;
                pnlCourses.Enabled = false;
            }
        }

        /// <summary>
        /// Add a couse to the current employee
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            lblCourseError.Visible = false;
            var insertResults = this.businessRules.AddCourse(
                tboxCourse.Text,
                tboxCourseCost.Text,
                tboxCourseCredits.Text,
                dtpStartDate.Value,
                dtpEndDate.Value,
                this.SelectedEmployee);

            if(insertResults == false)
            {
                lblCourseError.Visible = true;
                return;
            }

            lboxCourseList.Items.Add(tboxCourse.Text);
            clearCourseBoxes(false);
        }

        /// <summary>
        /// Clears the text box after the course has bee entered.
        /// </summary>
        /// <param name="clearCourseList"></param>
        private void clearCourseBoxes(bool clearCourseList)
        {
            if (clearCourseList)
            {
                lboxCourseList.Items.Clear();
            }

            tboxCourse.Text = string.Empty;
            tboxCourseCost.Text = string.Empty;
            tboxCourseCredits.Value = 0;
            tboxCourseDescription.Text = string.Empty;
            dtpEndDate.Value = DateTime.Now;
            dtpStartDate.Value = DateTime.Now;
            
        }

        private void lboxEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboxEmployees.SelectedItem != null)
            {
                // Get the currently selected item in the ListBox.
                string curItem = lboxEmployees.SelectedItem.ToString();
                // Get the currently selected item in the ListBox.
                tabControl1.SelectedIndex = 1;
                tboxSearch.Text = curItem.Substring(0, curItem.IndexOf(':'));
                btnSearch.PerformClick();
                FileIO.currentIndex = SelectedEmployee.EmpID;
            }   
        }

        /// <summary>
        /// Selects the course for the user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lboxCourseList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.SelectedEmployee.Courses.Count != 0)
            {
                ResetCourseApproval();
               
                var course = SelectedEmployee.Courses[lboxCourseList.SelectedItem.ToString()];

                lblCostSelection.Text = "$" + course.Cost.ToString();
                lblCoursSelection.Text = course.Name;
                lblCreditSelection.Text = course.Credits.ToString();
                lblCourseStartDisp.Text = course.StartDate.ToShortDateString();
                lblCourseEndDisp.Text = course.EndDate.ToShortDateString();

                if (course.Grade != null)
                {
                    cboxGradSelection.Text = course.Grade;
                    cboxGradSelection.Enabled = false;
                }
                   

                if (course.Approved)
                {
                    lblDateApproved.Text = course.ApprovedDate.ToString();
                    lblDateApproved.Visible = true;
                    lblDateApprovedLabel.Visible = true;;
                    lblApproveLabel.Visible = false;
                    btnApprove.Visible = false;
                    btnApprove.Enabled = false;
                }
                else
                {
                    lblApproveLabel.Visible = true;
                    btnApprove.Visible = true;
                    btnApprove.Enabled = false;
                    cboxGradSelection.Enabled = true;
                }

            }
            else
            {
                ResetCourseApproval();
            }
             
        }

        /// <summary>
        /// Resests the all the course approval info.
        /// </summary>
        private void ResetCourseApproval()
        {
            lblCostSelection.Text = "Not Enrolled";
            lblCoursSelection.Text = "Not Enrolled";
            lblCreditSelection.Text = "Not Enrolled";
            cboxGradSelection.Text = "Not Enrolled";
            lblCourseStartDisp.Text = "Not Enrolled";
            lblCourseEndDisp.Text = "Not Enrolled";
            lblGradeInsificient.Visible = false;
            lblDateApproved.Visible = false;
            lblDateApprovedLabel.Visible = false;
            lblApproveLabel.Visible = true;
            btnApprove.Visible = true;
            btnApprove.Enabled = false;
            cboxGradSelection.SelectedIndex = -1;
            lblNotEligable.Visible = false;
            cboxGradSelection.Enabled = false;
        }

        /// <summary>
        /// Scrolls between the users
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            ResetCourseApproval();

            var previous = businessRules.getPrevious();
            if (previous == 999999)
                btnBack.Enabled = false;
            else
            {
                tboxSearch.Text = previous.ToString();
                btnSearch.PerformClick();
            }
            if (businessRules.checkNext())
            {
                btnFoward.Enabled = true;
            }

        }

        /// <summary>
        /// Moves to the next employees.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFoward_Click(object sender, EventArgs e)
        {

            ResetCourseApproval();

            var next = businessRules.getNext();
            if (next == 999999)
                btnFoward.Enabled = false;
            else
            {
                tboxSearch.Text = next.ToString();
                btnSearch.PerformClick();
            }

            if (businessRules.checkPrev())
            {
                btnBack.Enabled = true;
            }
        }


        /// <summary>
        /// Approves the employee for tuition Rembursment.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnApprove_Click(object sender, EventArgs e)
        {
            var course = SelectedEmployee.Courses[lboxCourseList.SelectedItem.ToString()];
            course.Approved = true;
            course.ApprovedDate = DateTime.Now;
            course.Grade = cboxGradSelection.Text;

            ResetCourseApproval();
        }
        
        /// <summary>
        /// Selects the Grad when getting approval
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboxGradSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblGradeInsificient.Visible = false;

            if(SelectedEmployee.EmpType == EType.SALARY)
            {
                if (cboxGradSelection.SelectedIndex > 2)
                {
                    lblGradeInsificient.Visible = true;
                    btnApprove.Enabled = false;
                    return;
                }
            }

            if (SelectedEmployee.EmpType == EType.SALES)
            {
                if (cboxGradSelection.SelectedIndex > 5)
                {
                    lblGradeInsificient.Visible = true;
                    btnApprove.Enabled = false;
                    return;
                }
            }

            if (SelectedEmployee.EmpType == EType.HOURLY)
            {
                if (cboxGradSelection.SelectedIndex > 4)
                {
                    lblGradeInsificient.Visible = true;
                    btnApprove.Enabled = false;
                    return;
                }
                
            }
            btnApprove.Enabled = true;
        }
    }
}
