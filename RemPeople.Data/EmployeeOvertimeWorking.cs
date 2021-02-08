using System;
using System.Collections.Generic;
using System.Text;

namespace RemPeople.Data
{
    /// <summary>
    /// mesai yapılan zamanları içerir
    /// </summary>
    public class EmployeeOvertimeWorking
    {
        /// <summary>
        /// çalışan id
        /// </summary>
        public int EmployeeId { get; set; }

        /// <summary>
        /// kaç saat çalıştığı
        /// </summary>
        public int WorkingHours { get; set; }

        /// <summary>
        /// mesai yaptığı gün
        /// </summary>
        public DateTime OvertimeDay { get; set; }
    }
}
