using System;
using System.Collections.Generic;
using System.Text;

namespace RemPeople.Data
{
    /// <summary>
    /// günlük ücreti bilgileri
    /// </summary>
    public class EmployeeDayWage
    {
        /// <summary>
        /// çalışan id
        /// </summary>
        public int EmployeeId { get; set; }

        /// <summary>
        /// günlük ücret
        /// </summary>
        public decimal WagePerDay { get; set; }

        /// <summary>
        /// çalıştığı günler
        /// </summary>
        public IList<EmployeeWorkingDay> EmployeeWorkingDays { get; set; }
    }
}
