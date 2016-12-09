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
                            "TECH2342",
                            new Course()
                            {
                                Cost = 2100,
                                Credits = 3,
                                Name = "TECH2342",
                                Id = 83923,
                                Description = "Transmission Studies",
                                StartDate = new System.DateTime(2016, 1, 3),
                                EndDate = new System.DateTime(2016, 5, 12),
                                Approved = false   
                            }
                        },
                        {
                            "GEO2453",
                            new Course()
                            {
                                Cost = 2500,
                                Credits = 4,
                                Name = "GEO2453",
                                Id = 83923,
                                Description = "Geology",
                                StartDate = new System.DateTime(2016, 1, 3),
                                EndDate = new System.DateTime(2016, 5, 12),
                                Approved = false
                            }
                        },{
                            "DOG3843",
                            new Course()
                            {
                                Cost = 2200,
                                Credits = 3,
                                Name = "DOG3843",
                                Id = 83923,
                                Description = "Dog Studies",
                                StartDate = new System.DateTime(2015, 8, 15),
                                EndDate = new System.DateTime(2015, 12, 15),
                                Approved = true,
                                ApprovedDate = new System.DateTime(2015, 12, 20),
                                Grade= "B-"
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
                            "HLT3243",
                            new Course()
                            {
                                Cost = 2132,
                                Credits = 3,
                                Name = "HLT3243",
                                Id = 83923,
                                Description = "Life Adventures",
                                StartDate = new System.DateTime(2015, 8, 15),
                                EndDate = new System.DateTime(2015, 12, 15),
                                Approved = true,
                                ApprovedDate = new System.DateTime(2015, 12, 20),
                                Grade="A"
                            }
                        },
                        {
                            "MAT2142",
                            new Course()
                            {
                                Cost = 3500,
                                Credits = 5,
                                Name = "MAT2142",
                                Id = 83923,
                                Description = "Calculus 2",
                                StartDate = new System.DateTime(2015, 8, 15),
                                EndDate = new System.DateTime(2015, 12, 15),
                                Approved = true,
                                ApprovedDate = new System.DateTime(2015, 12, 20),
                                Grade = "B"
                            }
                        },{
                            "DOG3843",
                            new Course()
                            {
                                Cost = 2200,
                                Credits = 3,
                                Name = "DOG3843",
                                Id = 83923,
                                Description = "Dog Studies",
                                StartDate = new System.DateTime(2016, 8, 15),
                                EndDate = new System.DateTime(2016, 12, 15),
                                Approved = false,
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
                            "HLT3243",
                            new Course()
                            {
                                Cost = 2132,
                                Credits = 3,
                                Name = "HLT3243",
                                Id = 83923,
                                Description = "Life Adventures",
                                StartDate = new System.DateTime(2016, 8, 15),
                                EndDate = new System.DateTime(2016, 12, 15),
                                Approved = false
                            }
                        },{
                           "DOG3843",
                            new Course()
                            {
                                Cost = 2200,
                                Credits = 3,
                                Name = "DOG3843",
                                Id = 83923,
                                Description = "Dog Studies",
                                StartDate = new System.DateTime(2016, 1, 5),
                                EndDate = new System.DateTime(2016, 5, 15),
                                Approved = true,
                                ApprovedDate = new System.DateTime(2016, 5, 28),
                                Grade = "A-"
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
                            "MAT2142",
                            new Course()
                            {
                                Cost = 3500,
                                Credits = 5,
                                Name = "MAT2142",
                                Id = 83923,
                                Description = "Calculus 2",
                                StartDate = new System.DateTime(2015, 8, 15),
                                EndDate = new System.DateTime(2015, 12, 15),
                                Approved = true,
                                ApprovedDate = new System.DateTime(2015, 12, 20),
                                Grade = "B+"
                            }
                        },{
                            "DOG3843",
                            new Course()
                            {
                                Cost = 2200,
                                Credits = 3,
                                Name = "DOG3843",
                                Id = 83923,
                                Description = "Dog Studies",
                                StartDate = new System.DateTime(2016, 1, 5),
                                EndDate = new System.DateTime(2016, 5, 15),
                                Approved = true,
                                ApprovedDate = new System.DateTime(2016, 5, 28),
                                Grade = "B-"
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
                            "GEO2453",
                            new Course()
                            {
                                Cost = 2500,
                                Credits = 4,
                                Name = "GEO2453",
                                Id = 83923,
                                Description = "Geology",
                                StartDate = new System.DateTime(2016, 1, 3),
                                EndDate = new System.DateTime(2016, 5, 12),
                                Approved = false
                            }
                        },{
                            "DOG3843",
                            new Course()
                            {
                                Cost = 2200,
                                Credits = 3,
                                Name = "DOG3843",
                                Id = 83923,
                                Description = "Dog Studies",
                                StartDate = new System.DateTime(2015, 8, 15),
                                EndDate = new System.DateTime(2015, 12, 15),
                                Approved = true,
                                ApprovedDate = new System.DateTime(2015, 12, 20)
                            }
                        }
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
