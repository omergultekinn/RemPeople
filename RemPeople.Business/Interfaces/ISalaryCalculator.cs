using RemPeople.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RemPeople.Business
{
    /// <summary>
    /// maaş işlemleri arayüzü
    /// </summary>
    public interface ISalaryCalculator
    {
        /// <summary>
        /// Çalışana göre bordro bilgisini getirir
        /// </summary>
        ClientResponseModel GetCalculatedSalary(int id);

        /// <summary>
        /// Bütün çalışanların bordorlarını getirir
        /// </summary>
        List<ClientResponseModel> GetCalculatedSalaries();
    }
}
