﻿using System.Collections.Generic;

namespace WorldWideWombats
{
    /// <summary>
    /// Tests that all the employee objects
    /// </summary>
    public class Test
    {
        /// <summary>
        /// Test that all the employee objects instantiate
        /// </summary>
        /// <returns></returns>
       public static BusinessRules ClassInstantationTest()
        {
            BusinessRules businessRules;

            var employees = new List<Employee>();
            try
            {
                //check Contract
                var contract = new Contract()
                {
                    EmpID = "TestId1",
                    EmpType = EType.CONTRACT,
                    FirstName = "c_First",
                    LastName = "c_Last",
                    ContractWage = 25
                };
                
                //check Hourly
                var hourly = new Hourly()
                {
                    EmpID = "TestId2",
                    EmpType = EType.HOURLY,
                    FirstName = "h_First",
                    LastName = "h_Last",
                    HourlyRate = 25,
                    HoursWorked = 25
                };

                //Check Salary
                var salary = new Salary()
                {
                    EmpID = "TestId2",
                    EmpType = EType.SALARY,
                    FirstName = "sa_First",
                    LastName = "sa_Last",
                    MonthlySalary = 225,
                };

                //Check Sales
                var sales = new Sales()
                {
                    EmpID = "TestId4",
                    EmpType = EType.SALES,
                    FirstName = "s_First",
                    LastName = "s_Last",
                    MonthlySalary = 226,
                    Commission = 123,
                    GrossSales = 12,
                };


                businessRules = BusinessRules.Instantiate;
                businessRules.add(salary);
                businessRules.add(hourly);
                businessRules.add(contract);
                businessRules.add(sales);
            }
            catch
            {
                //if there are any runtime errors the catch will return null
                return null;
            }

            //if all employees are instantiated without issue the test will return the items
            return businessRules;
        }
    }
}
