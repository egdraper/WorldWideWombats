using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorldWideWombats;

namespace WorldWideWombatsTests
{
    [TestClass]
    public class BusinessRulesTest
    {
        /// <summary>
        /// This Tests both to Add and GetEmployee function of Buisness Rules Class
        /// </summary>
        [TestMethod]
        public void Add_and_GetEmployeeTest()
        {
            var businessRules = BusinessRules.Instantiate;
            businessRules.Clear();
            //check Contract
            var contract = new Contract()
            {
                EmpType = EType.CONTRACT,
                FirstName = "c_First",
                LastName = "c_Last",
                ContractWage = 25
            };

            //check Hourly
            var hourly = new Hourly()
            {
                EmpType = EType.HOURLY,
                FirstName = "h_First",
                LastName = "h_Last",
                HourlyRate = 25,
                HoursWorked = 25
            };

            //Check Salary
            var salary = new Salary()
            {
                EmpType = EType.SALARY,
                FirstName = "sa_First",
                LastName = "sa_Last",
                MonthlySalary = 225,
            };

            //Check Sales
            var sales = new Sales()
            {
                EmpType = EType.SALES,
                FirstName = "s_First",
                LastName = "s_Last",
                MonthlySalary = 226,
                Commission = 123,
                GrossSales = 12,
            };

            businessRules.Add(salary);
            businessRules.Add(hourly);
            businessRules.Add(contract);
            businessRules.Add(sales);
           
            Assert.AreEqual(businessRules.GetEmployee(0), salary);
            Assert.AreEqual(businessRules.GetEmployee(1), hourly);
            Assert.AreEqual(businessRules.GetEmployee(2), contract);
            Assert.AreEqual(businessRules.GetEmployee(3), sales);
        }

        /// <summary>
        /// Tests the GetAll function
        /// </summary>
        [TestMethod]
        public void GetAll()
        {
            var businessRules = BusinessRules.Instantiate;
            businessRules.Clear();
            //check Contract
            var contract = new Contract()
            {
                EmpType = EType.CONTRACT,
                FirstName = "c_First",
                LastName = "c_Last",
                ContractWage = 25
            };

            //check Hourly
            var hourly = new Hourly()
            {
                EmpType = EType.HOURLY,
                FirstName = "h_First",
                LastName = "h_Last",
                HourlyRate = 25,
                HoursWorked = 25
            };

            //Check Salary
            var salary = new Salary()
            {
                EmpType = EType.SALARY,
                FirstName = "sa_First",
                LastName = "sa_Last",
                MonthlySalary = 225,
            };

            //Check Sales
            var sales = new Sales()
            {
                EmpType = EType.SALES,
                FirstName = "s_First",
                LastName = "s_Last",
                MonthlySalary = 226,
                Commission = 123,
                GrossSales = 12,
            };

            businessRules.Add(salary);
            businessRules.Add(hourly);
            businessRules.Add(contract);
            businessRules.Add(sales);

            int count = businessRules.GetAll().Count;
            Assert.AreEqual<int>(count, 4);
        }

       
    }
}
