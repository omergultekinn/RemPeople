using System;
using System.Collections.Generic;
using System.Text;

namespace RemPeople.Data
{
    /// <summary>
    /// çalışılan günler
    /// </summary>
    public class EmployeeWorkingDay
    {
        /// <summary>
        /// çalışan id
        /// </summary>
        public int EmployeeId { get; set; }

        /// <summary>
        /// çalışılan gün
        /// </summary>
        public DateTime WorkingDay { get; set; }
    }
}
