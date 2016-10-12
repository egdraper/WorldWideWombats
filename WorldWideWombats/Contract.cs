using System;

namespace WorldWideWombats
{
    /// <summary>
    /// Contract: holds the contractors wage
    /// </summary>
    [Serializable]
    public class Contract : Employee
    {
        public double ContractWage { get; set; }

        public Contract()
        {

        }
    }
}