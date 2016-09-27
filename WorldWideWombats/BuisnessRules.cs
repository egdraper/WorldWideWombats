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

        private SortedDictionary<uint, Employee> employees;
        private static BusinessRules instance;
        public static uint NextEmployeeId = START_EMP_ID;

        private BusinessRules()
        {
            employees = new SortedDictionary<uint, Employee>();
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
                employees.Add(employee.EmpID, employee);
                NextEmployeeId++;
            }


        }

        /// <summary>
        /// Returns and array of Employees 
        /// </summary>
        /// <returns></returns>
        public SortedDictionary<uint, Employee> GetAll()
        {
            return employees;
        }

        public Employee GetEmployee(uint employeeId)
        {
            var emp = employees[employeeId];
            return emp;
        }

        public void Clear()
        {
            this.employees.Clear();
        }

    }
}

