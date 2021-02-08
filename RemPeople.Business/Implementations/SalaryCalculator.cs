using RemPeople.Data;
using RemPeople.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemPeople.Business.Implementations
{
    ///<inheritdoc cref="ISalaryCalculator"/>
    public class SalaryCalculator : ISalaryCalculator
    {
        private readonly ICalculateServiceCreater _calculator;
        private readonly ISalaryRepo _salaryRepo;
        public SalaryCalculator(ICalculateServiceCreater calculator, ISalaryRepo salaryRepo)
        {
            _calculator = calculator;
            _salaryRepo = salaryRepo;
        }

        public List<ClientResponseModel> GetCalculatedSalaries()
        {
            var employees = _salaryRepo.GetEmployees();
            var result = new List<ClientResponseModel>();
            foreach (var employeesGroup in employees.GroupBy(g => g.SalaryType))
            {
                var service = _calculator.GetCalculatorService(employeesGroup.Key);
                foreach (var employee in employeesGroup)
                {
                    var salary = service.Calculate(employee);

                    var model = new ClientResponseModel
                    {
                        IdentityNumber = employee.IdentityNumber,
                        Firstname = employee.Firstname,
                        Lastname = employee.Lastname,
                        Salary = salary
                    };
                    result.Add(model);
                }
            }
            return result;
        }

        /// <summary>
        /// Çalışana göre maaş bilgisini getirir
        /// </summary>
        public ClientResponseModel GetCalculatedSalary(int id)
        {
            var employee = _salaryRepo.GetEmployeeById(id);
            var service = _calculator.GetCalculatorService(employee.SalaryType);
            var salary = service.Calculate(employee);

            var result = new ClientResponseModel
            {
                IdentityNumber = employee.IdentityNumber,
                Firstname = employee.Firstname,
                Lastname = employee.Lastname,
                Salary = salary
            };

            return result;
        }
    }
}
