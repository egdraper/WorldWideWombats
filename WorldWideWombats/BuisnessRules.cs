namespace WorldWideWombats
{
    /// <summary>
    /// Contains the entered user information.
    /// </summary>
    public class BusinessRules
    {
        //Constants
        const int MAX_EMPLOYEES = 10;
        const int START_INDEX = 0;
        //public
        private Employee[] employees = new Employee[MAX_EMPLOYEES];

        //private
        private static BusinessRules instance;
        private static int index;

        private BusinessRules() { }

        /// <summary>
        /// Lazy loads the class (singlton)
        /// </summary>
        public static BusinessRules Instantiate
        {
            get
            {
                if (instance == null)
                {
                    index = START_INDEX;
                    instance = new BusinessRules();
                }
                return instance;
            }
        }

        /// <summary>
        /// Adds new employee to the list of employees
        /// </summary>
        /// <param name="employee"></param>
        public void add(Employee employee)
        {
            employees[index] = employee;
            index++;
        }

        /// <summary>
        /// Returns and array of Employees 
        /// </summary>
        /// <returns></returns>
        public Employee[] get()
        {
            return employees;
        }
    }
}

