using System;

namespace WorldWideWombats
{
    [Serializable]
    public abstract class Employee
    {
        public uint EmpID { get; set; }   
        public EType EmpType { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
