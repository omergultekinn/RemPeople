using System;
using System.Collections.Generic;
using System.Text;

namespace RemPeople.Data
{
    /// <summary>
    /// fazla mesai ücreti bilgileri
    /// </summary>
    public class EmployeeOvertime
    {
        /// <summary>
        /// çalışan id
        /// </summary>
        public int EmployeeId { get; set; }

        /// <summary>
        /// saatlik mesai ücreti
        /// </summary>
        public decimal PerHour { get; set; }

        /// <summary>
        /// mesai yapılan gün ve saat bilgisi
        /// </summary>
        public IList<EmployeeOvertimeWorking> EmployeeOvertimeWorkings { get; set; }
    }
}
