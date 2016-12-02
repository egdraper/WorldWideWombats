using System.Collections.Generic;

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

            try
            {
                //check Contract
                var contract = new Salary()
                {
                    EmpType = EType.CONTRACT,
                    FirstName = "Roger",
                    LastName = "Chriation",
                    MonthlySalary = 2250,
                    ApprovedForTruition = true,
                    Courses = new Dictionary<string, Course>()
                    {
                        {
                            "Transmission Studies",
                            new Course()
                            {
                                Cost = 2100,
                                Credits = 3,
                                CurrentlyEnrolled = false,
                                Name = "Transmission Studies",
                                Id = 83923
                            }
                        },
                        {
                            "College Algabra",
                            new Course()
                            {
                                Cost = 2500,
                                Credits = 4,
                                CurrentlyEnrolled = false,
                                Name = "College Algabra",
                                Id = 83923
                            }
                        },{
                            "Dog Studies",
                            new Course()
                            {
                                Cost = 2200,
                                Credits = 3,
                                CurrentlyEnrolled = true,
                                Name = "Dog Studies",
                                Id = 83923
                            }
                        },
                    }

                };

                //check Hourly
                var hourly = new Hourly()
                { 
                    EmpType = EType.HOURLY,
                    FirstName = "Billy",
                    LastName = "McNilloy",
                    HourlyRate = 25,
                    HoursWorked = 25,
                    ApprovedForTruition = true,
                    Courses = new Dictionary<string, Course>()
                    {
                        {
                            "Life Adventures",
                            new Course()
                            {
                                Cost = 2132,
                                Credits = 3,
                                CurrentlyEnrolled = false,
                                Name = "Life Adventures",
                                Id = 83923
                            }
                        },
                        {
                            "Calculus 2",
                            new Course()
                            {
                                Cost = 3500,
                                Credits = 6,
                                CurrentlyEnrolled = true,
                                Name = "Calculus 2",
                                Id = 83923
                            }
                        },{
                            "Dog Studies",
                            new Course()
                            {
                                Cost = 2200,
                                Credits = 3,
                                CurrentlyEnrolled = true,
                                Name = "Dog Studies",
                                Id = 83923
                            }
                        },
                    }
                };

                //Check Salary
                var salary = new Salary()
                {
                    EmpType = EType.SALARY,
                    FirstName = "Frank",
                    LastName = "Allision",
                    MonthlySalary = 2250,
                    ApprovedForTruition = true,
                    Courses = new Dictionary<string, Course>()

                };

                //Check Sales
                var sales = new Sales()
                {
                    EmpType = EType.SALES,
                    FirstName = "Robertson",
                    LastName = "Blander",
                    MonthlySalary = 226,
                    Commission = 123,
                    GrossSales = 12,
                    ApprovedForTruition = false,
                };
                var contract2 = new Contract()
                {
                    EmpType = EType.CONTRACT,
                    FirstName = "Allen",
                    LastName = "Rickman",
                    ContractWage = 253,
                    ApprovedForTruition = false,   
                                     
                };

                //check Hourly
                var hourly2 = new Hourly()
                {
                    EmpType = EType.HOURLY,
                    FirstName = "Frankum",
                    LastName = "Johnson",
                    HourlyRate = 212,
                    HoursWorked = 23,
                    ApprovedForTruition = true,
                    Courses = new Dictionary<string, Course>()
                    {
                        {
                            "Life Adventures",
                            new Course()
                            {
                                Cost = 2132,
                                Credits = 3,
                                CurrentlyEnrolled = false,
                                Name = "Life Adventures",
                                Id = 83923
                            }
                        },{
                            "Dog Studies",
                            new Course()
                            {
                                Cost = 2200,
                                Credits = 3,
                                CurrentlyEnrolled = true,
                                Name = "Dog Studies",
                                Id = 83923
                            }
                        },
                    }

                };

                //Check Salary
                var salary2 = new Salary()
                {
                    EmpType = EType.SALARY,
                    FirstName = "Brandon",
                    LastName = "McDermit",
                    MonthlySalary = 234,
                    ApprovedForTruition = true,
                    Courses = new Dictionary<string, Course>()
                    {
                        {
                            "Spamming Tech",
                            new Course()
                            {
                                Cost = 2132,
                                Credits = 3,
                                CurrentlyEnrolled = false,
                                Name = "Spamming tech",
                                Id = 83923
                            }
                        },{
                            "Dog Studies",
                            new Course()
                            {
                                Cost = 2200,
                                Credits = 3,
                                CurrentlyEnrolled = false,
                                Name = "Dog Studies",
                                Id = 83923
                            }
                        },
                    }
                };

                //Check Sales
                var sales2 = new Sales()
                {
                    EmpType = EType.SALES,
                    FirstName = "Flanders",
                    LastName = "Michealson",
                    MonthlySalary = 226,
                    Commission = 123,
                    GrossSales = 12,
                    ApprovedForTruition = false
                };
                var contract3 = new Contract()
                {
                    EmpType = EType.CONTRACT,
                    FirstName = "Loyd",
                    LastName = "Smith",
                    ContractWage = 24,
                    ApprovedForTruition = false
                };

                //check Hourly
                var hourly3 = new Hourly()
                {
                    EmpType = EType.HOURLY,
                    FirstName = "Lyle",
                    LastName = "Merrit",
                    HourlyRate = 10,
                    HoursWorked = 12,
                    ApprovedForTruition = false,
                    
                };

                //Check Salary
                var salary3 = new Salary()
                {
                    EmpType = EType.SALARY,
                    FirstName = "Martha",
                    LastName = "Jorgenson",
                    MonthlySalary = 225,
                    ApprovedForTruition = true,
                    Courses = new Dictionary<string, Course>()
                    {
                        {
                            "Dancing",
                            new Course()
                            {
                                Cost = 1200,
                                Credits = 2,
                                CurrentlyEnrolled = false,
                                Name = "Dancing",
                                Id = 83923
                            }
                        },{
                            "Dog Studies",
                            new Course()
                            {
                                Cost = 2200,
                                Credits = 3,
                                CurrentlyEnrolled = false,
                                Name = "Dog Studies",
                                Id = 83923
                            }
                        },
                    }

                };

                //Check Sales
                var sales3 = new Sales()
                {
                    EmpType = EType.SALES,
                    FirstName = "Heather",
                    LastName = "Jakes",
                    MonthlySalary = 226,
                    Commission = 123,
                    GrossSales = 12,
                    ApprovedForTruition = false,
                };

                businessRules = BusinessRules.Instantiate;
                businessRules.Add(salary);
                businessRules.Add(hourly);
                businessRules.Add(contract);
                businessRules.Add(sales);
                businessRules.Add(salary2);
                businessRules.Add(hourly2);
                businessRules.Add(contract2);
                businessRules.Add(sales2);
                businessRules.Add(salary3);
                businessRules.Add(hourly3);
                businessRules.Add(contract3);
                businessRules.Add(sales3);
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
