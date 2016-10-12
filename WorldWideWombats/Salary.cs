using System;

namespace WorldWideWombats
{
    /// <summary>
    /// Salary: holds the monthly salary info
    /// </summary>
    [Serializable]
    public class Salary : Employee
    {
        public double MonthlySalary { get; set; }

        public Salary()
        {

        }
    }

   

   
}