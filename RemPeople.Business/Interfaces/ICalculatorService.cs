using RemPeople.Data;
using RemPeople.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RemPeople.Business
{
    /// <summary>
    /// çalışan maaş hesaplarıyla ilgilenir
    /// </summary>
    public interface ICalculatorService
    {
        /// <summary>
        /// ilgili çalışanın maaşını hesplar
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        decimal Calculate(Employee employee);
    }
}
