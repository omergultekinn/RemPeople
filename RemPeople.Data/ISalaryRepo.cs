using RemPeople.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RemPeople.Data
{
    /// <summary>
    /// çalışanların maaş bilgileri
    /// </summary>
    public interface ISalaryRepo
    {
        /// <summary>
        /// çalışan idsine göre çalışanı getirir
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Employee GetEmployeeById(int id);

        /// <summary>
        /// bütün çalışan listesini getirir
        /// </summary>
        /// <returns></returns>
        List<Employee> GetEmployees();
    }
}
