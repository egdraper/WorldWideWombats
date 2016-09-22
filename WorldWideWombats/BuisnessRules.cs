namespace WorldWideWombats
{
    /// <summary>
    /// Contains the entered user information.
    /// </summary>
    public class BusinessRules
    {
        
    
        private DArray employees;
        private static BusinessRules instance;
        private static int index;

        private BusinessRules() {
            employees = DArray.Instantiate();
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
        public void add(Employee employee)
        {
            employees.AddValue(employee);
            index++;
        }

        /// <summary>
        /// Returns and array of Employees 
        /// </summary>
        /// <returns></returns>
        public Employee[] get()
        {
            var a = employees.GetEnumerator();
            return null;
        }

        public Employee getNext()
        {
            var emp = employees.GetValue();
            employees.MoveNext();
            return emp;
        }
       
    }
}

