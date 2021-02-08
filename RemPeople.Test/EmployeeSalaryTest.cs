using System;
using Xunit;

namespace RemPeople.Test
{
    public class EmployeeSalaryTest : IClassFixture<EmployeeSalaryFixture>
    {
        private EmployeeSalaryFixture  _employeeSalaryFixture;
        public EmployeeSalaryTest(EmployeeSalaryFixture employeeSalaryFixture)
        {
            _employeeSalaryFixture = employeeSalaryFixture;
        }

        [Theory]
        [InlineData(1, 500)]
        public void GetCalculatedSalaryTest(int actual, decimal expected)
        {
           var model =  _employeeSalaryFixture.SalaryCalculator.GetCalculatedSalary(actual);
            Assert.Equal(expected, model.Salary);
        }

        [Fact]
        public void GetCalculatedSalariesTest()
        {
            var model = _employeeSalaryFixture.SalaryCalculator.GetCalculatedSalaries();
            Assert.Equal(4, model.Count);
        }
    }
}
