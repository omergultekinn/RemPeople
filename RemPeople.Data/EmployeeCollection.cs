using System;
using System.Collections.Generic;
using System.Text;

namespace RemPeople.Data
{
    /// <summary>
    /// çalışan datası
    /// </summary>
    public class EmployeeCollection
    {
        public ICollection<Employee> Employees { get; set; }
    }
}
