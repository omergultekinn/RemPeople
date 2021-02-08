using RemPeople.Data;
using RemPeople.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RemPeople.Business.Implementations
{
    public class SalaryPlusOvertimeCalculator : ICalculatorService
    {
        private readonly IOvertimeCalculator _overtimeCalculator;
        private readonly ICalculatorService _calculatorService;
        public SalaryPlusOvertimeCalculator(IOvertimeCalculator overtimeCalculator, ICalculatorService calculatorService)
        {
            _overtimeCalculator = overtimeCalculator;
            _calculatorService = calculatorService;
        }
        public decimal Calculate(Employee employee)
        {
            return _calculatorService.Calculate(employee) + _overtimeCalculator.GetOvertimeWage(employee.EmployeeOvertime);
        }
    }
}
