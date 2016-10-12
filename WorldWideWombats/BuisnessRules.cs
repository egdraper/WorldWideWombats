using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

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

        public Employee GetEmployee(uint employeeId)
        {
            var emp = database.EmployeeDB[employeeId];
            return emp;
        }

        public void Clear()
        {
            this.database.EmployeeDB.Clear();
        }

        public void Save()
        {
            database.WriteFileDB();
        }

        public void Open()
        {
            database.ReadFileDB();
        }

    }
}

