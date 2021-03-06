﻿using System;

namespace WorldWideWombats
{
    /// <summary>
    /// Hourly: Stores the HourlyRate and HoursWorked for an hourly employee
    /// </summary>
    [Serializable]
    public class Hourly : Employee
    {
        public double HourlyRate { get; set; }
        public double HoursWorked { get; set; }

        public Hourly()
        {

        }
    }
}