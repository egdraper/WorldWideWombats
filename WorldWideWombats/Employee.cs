using System;
using System.CodeDom;
using System.Collections.Generic;

namespace WorldWideWombats
{
    [Serializable]
    public abstract class Employee
    {
        public uint EmpID { get; set; }   
        public EType EmpType { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool ApprovedForTruition { get; set; }
        public Dictionary<string, Course> Courses { get; set; } 
    }

    [Serializable]
    public class Course
    {
        public string Name { get; set; }
        public int Cost { get; set; }
        public int Credits { get; set; }
        public bool CurrentlyEnrolled { get; set; } 
    }

}
