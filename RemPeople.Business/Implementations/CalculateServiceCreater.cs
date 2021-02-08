using RemPeople.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RemPeople.Business.Implementations
{
    ///<inheritdoc cref="ICalculateServiceCreater"/>
    public class CalculateServiceCreater : ICalculateServiceCreater
    {
        private ICalculatorService _calculatorServiceForPlus;
        private ICalculatorService _calculatorService;
        private IOvertimeCalculator _overtimeCalculator;

        /// <summary>
        /// maaş tipine göre kullanılacak arayüzü bulur
        /// </summary>
        /// <param name="salaryType"></param>
        /// <returns></returns>
        public ICalculatorService GetCalculatorService(SalaryType salaryType)
        {
            switch (salaryType)
            {
                case SalaryType.Fixed:
                    _calculatorService = new FixedCalculator();
                    break;
                case SalaryType.Daily:
                    _calculatorService = new DailyCalculator();
                    break;
                case SalaryType.FixedPlusOvertime:
                    _overtimeCalculator = new OvertimeCalculator();
                    _calculatorServiceForPlus = new FixedCalculator();
                    _calculatorService = new SalaryPlusOvertimeCalculator(_overtimeCalculator, _calculatorServiceForPlus);
                    break;
                case SalaryType.DailyPlusOvertime:
                    _overtimeCalculator = new OvertimeCalculator();
                    _calculatorServiceForPlus = new DailyCalculator();
                    _calculatorService = new SalaryPlusOvertimeCalculator(_overtimeCalculator, _calculatorServiceForPlus);
                    break;
                default:
                    throw new NotImplementedException();
            }
            return _calculatorService;
        }
    }
}
