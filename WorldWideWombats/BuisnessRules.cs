using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System;

namespace WorldWideWombats
{
    /// <summary>
    /// Contains the entered user information.
    /// </summary>
    public class BusinessRules
    {
        private const uint START_EMP_ID = 0;
        FileIO database;       
        private static BusinessRules instance;
        public static uint NextEmployeeId = START_EMP_ID;

        private BusinessRules()
        {
            this.database = new FileIO();
            this.database.EmployeeDB = new SortedDictionary<uint, Employee>();
        }

        /// <summary>
        /// Lazy loads the class (singlton)
        /// </summary>
        public static BusinessRules Instantiate
        {
            get
            {
                if (instance == null)
                {
                    instance = new BusinessRules();
                }
                return instance;
            }
        }

        /// <summary>
        /// Adds new employee to the list of employees
        /// </summary>
        /// <param name="employee"></param>
        public void Add(Employee employee)
        {
            if (employee == null)
            {
                MessageBox.Show("There was no Employee to add");
            }
            else
            {
                employee.EmpID = NextEmployeeId;
                database.EmployeeDB.Add(employee.EmpID, employee);
                NextEmployeeId++;
            }
        }

        /// <summary>
        /// Returns and array of Employees 
        /// </summary>
        /// <returns></returns>
        public SortedDictionary<uint, Employee> GetAll()
        {
            return database.EmployeeDB;
        }


        /// <summary>
        /// gets and employee by the ID
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        public Employee GetEmployee(uint employeeId)
        {
            var emp = database.EmployeeDB[employeeId];
            return emp;
        }

        /// <summary>
        /// clears the current database
        /// </summary>
        public void Clear()
        {
            this.database.EmployeeDB.Clear();
        }

        /// <summary>
        /// saves the file
        /// </summary>
        public void Save()
        {
            database.WriteFileDB();
        }

        /// <summary>
        /// opens the file
        /// </summary>
        public void Open()
        {
            database.ReadFileDB();
        }

        /// <summary>
        /// searches for a name either by last name or id
        /// </summary>
        /// <param name="searchItem"></param>
        /// <returns></returns>
        public Employee Search(string searchItem)
        {
            return database.EmployeeDB.FirstOrDefault(emp => emp.Value.LastName == searchItem ||
                       emp.Value.EmpID.ToString() == searchItem).Value;
        }

        /// <summary>
        /// Checks the name format
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool CheckName(string name)
        { 
            return Regex.IsMatch(name, @"^[a-zA-Z]+$");
        }


        /// <summary>
        /// checks the number format
        /// </summary>
        /// <param name="hoursOrWages"></param>
        /// <returns></returns>
        public bool CheckHoursAndWages(string hoursOrWages)
        {
            return Regex.IsMatch(hoursOrWages, @"^-?\d*\.?\d*");
        }

        /// <summary>
        /// Adds the course to the current list
        /// </summary>
        /// <param name="name"></param>
        /// <param name="cost"></param>
        /// <param name="credits"></param>
        /// <param name="currentlyEnrolled"></param>
        /// <param name="currEmployee"></param>
        /// <returns></returns>
        public bool AddCourse(string name, string cost, string credits, DateTime startDate, DateTime endDate, Employee currEmployee)
        {
            int cleanCredit;
            double cleanCost;
            if (!int.TryParse(credits, out cleanCredit))
            { 
                return false;
            }

            if (!double.TryParse(cost, out cleanCost))
            {
                return false;
            }

            if(currEmployee.Courses == null)
            {
                currEmployee.Courses = new Dictionary<string, Course>();
            }

            var course = new Course()
            {
                Cost = cleanCost,
                Credits = cleanCredit,
                Name = name,
                StartDate = startDate,
                EndDate = endDate,
            };
            
            currEmployee.Courses.Add(course.Name, course);

            return true;
        }

        /// <summary>
        /// Get Next employee when scrolling
        /// </summary>
        /// <returns></returns>
        public uint getNext()
        {
            if (FileIO.currentIndex == database.EmployeeDB.Count - 1)
                return 999999;
            else
                return database.EmployeeDB[++FileIO.currentIndex].EmpID;
        }

        /// <summary>
        /// Gets the previous employee when scrolling
        /// </summary>
        /// <returns></returns>
        public uint getPrevious()
        {
            if (FileIO.currentIndex > 0)
                return database.EmployeeDB[--FileIO.currentIndex].EmpID;
            else
                return 999999;
        }

        /// <summary>
        /// checks to see if there is a next employee
        /// </summary>
        /// <returns></returns>
        public bool checkNext()
        {
            if (FileIO.currentIndex < database.EmployeeDB.Count - 1)
                return true;
            else
                return false;
            
        }

        /// <summary>
        /// checks to see if there is a previous employee
        /// </summary>
        /// <returns></returns>
        public bool checkPrev()
        {
            if (FileIO.currentIndex > 0)
                return true;
            else
                return false;
        }

    }
}

