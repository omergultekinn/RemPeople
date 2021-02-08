using RemPeople.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace RemPeople.Business
{
    /// <summary>
    /// fazla mesai ücreti hesaplamaları
    /// </summary>
    public interface IOvertimeCalculator
    {
        /// <summary>
        /// fazla mesai saati * fazla mesai saat ücreti hesaplar
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        decimal GetOvertimeWage(EmployeeOvertime employeeOvertime);
    }
}
