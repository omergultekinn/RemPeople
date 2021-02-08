using RemPeople.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RemPeople.Business
{
    /// <summary>
    /// Kullanılacak ICalculatorService instance'ını hazırlar
    /// </summary>
    public interface ICalculateServiceCreater
    {
        /// <summary>
        /// maaş tipine göre kullanılacak arayüzü bulur
        /// </summary>
        /// <param name="salaryType"></param>
        /// <returns></returns>
        ICalculatorService GetCalculatorService(SalaryType salaryType);
    }
}
