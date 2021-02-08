using RemPeople.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RemPeople.Data
{
    ///<inheritdoc cref="ISalaryRepo"/>
    public class SalaryRepo : ISalaryRepo
    {
        public Employee GetEmployeeById(int id)
        {
            var employee = GetEmployeeCollection()?.Employees?.FirstOrDefault(e => e.Id == id);
            if (employee != null)
                return employee;

            throw new Exception($"Invalid employee id: {id}");
        }

        public List<Employee> GetEmployees()
        {
            return GetEmployeeCollection().Employees.ToList();
        }

        /// <summary>
        /// dummy data oluşturup bize ilgili collectionı getirir
        /// </summary>
        /// <returns></returns>
        private EmployeeCollection GetEmployeeCollection()
        {
            var employess = new List<Employee>();
            var employeeId = 1;
            //Fixed salary
            employess.Add(new Employee
            {
                Firstname = "Fixed",
                Id = employeeId,
                IdentityNumber = "11111111111",
                Lastname = "Salary",
                SalaryType = SalaryType.Fixed,
                EmployeeFixedSalary = new EmployeeFixedSalary
                {
                    EmployeeId = employeeId,
                    FixedSalary = 500
                },
            });

            employeeId = 2;
            //dailySalary
            employess.Add(new Employee
            {
                Firstname = "Daily",
                Id = employeeId,
                IdentityNumber = "11111111111",
                Lastname = "Salary",
                SalaryType = SalaryType.Daily,
                EmployeeDayWage = new EmployeeDayWage
                {
                    EmployeeId = employeeId,
                    WagePerDay = 32,
                    EmployeeWorkingDays = new List<EmployeeWorkingDay>
                    {
                        new EmployeeWorkingDay {  EmployeeId = employeeId, WorkingDay = DateTime.Today.AddDays(-1) },
                        new EmployeeWorkingDay {  EmployeeId = employeeId, WorkingDay = DateTime.Today.AddDays(-2) },
                        new EmployeeWorkingDay {  EmployeeId = employeeId, WorkingDay = DateTime.Today.AddDays(-3) },
                    }
                },
            });

            employeeId = 3;
            //dailySalaryOvertime
            employess.Add(new Employee
            {
                Firstname = "FixedPlusOvertime",
                Id = employeeId,
                IdentityNumber = "11111111111",
                Lastname = "Salary",
                SalaryType = SalaryType.FixedPlusOvertime,
                EmployeeFixedSalary = new EmployeeFixedSalary
                {
                    EmployeeId = employeeId,
                    FixedSalary = 500
                },
                EmployeeOvertime = new EmployeeOvertime { 
                    EmployeeId = employeeId,
                    PerHour = 3,
                    EmployeeOvertimeWorkings = new List<EmployeeOvertimeWorking>
                    {
                        new EmployeeOvertimeWorking { EmployeeId = employeeId, OvertimeDay = DateTime.Today.AddDays(-1), WorkingHours = 3 },
                        new EmployeeOvertimeWorking { EmployeeId = employeeId, OvertimeDay = DateTime.Today.AddDays(-3), WorkingHours = 5 },
                        new EmployeeOvertimeWorking { EmployeeId = employeeId, OvertimeDay = DateTime.Today.AddDays(-8), WorkingHours = 4 },
                    }
                },
            });

            employeeId = 4;
            //dailySalaryOvertime
            employess.Add(new Employee
            {
                Firstname = "DailyPlusOvertime",
                Id = employeeId,
                IdentityNumber = "11111111111",
                Lastname = "Salary",
                SalaryType = SalaryType.DailyPlusOvertime,
                EmployeeDayWage = new EmployeeDayWage
                {
                    EmployeeId = employeeId,
                    WagePerDay = 14,
                    EmployeeWorkingDays = new List<EmployeeWorkingDay>
                    {
                        new EmployeeWorkingDay {  EmployeeId = employeeId, WorkingDay = DateTime.Today.AddDays(-1) },
                        new EmployeeWorkingDay {  EmployeeId = employeeId, WorkingDay = DateTime.Today.AddDays(-2) },
                        new EmployeeWorkingDay {  EmployeeId = employeeId, WorkingDay = DateTime.Today.AddDays(-3) },
                    }
                },
                EmployeeOvertime = new EmployeeOvertime
                {
                    EmployeeId = employeeId,
                    PerHour = 3,
                    EmployeeOvertimeWorkings = new List<EmployeeOvertimeWorking>
                    {
                        new EmployeeOvertimeWorking { EmployeeId = employeeId, OvertimeDay = DateTime.Today.AddDays(-1), WorkingHours = 3 },
                        new EmployeeOvertimeWorking { EmployeeId = employeeId, OvertimeDay = DateTime.Today.AddDays(-3), WorkingHours = 5 },
                        new EmployeeOvertimeWorking { EmployeeId = employeeId, OvertimeDay = DateTime.Today.AddDays(-8), WorkingHours = 4 },
                    }
                }
            });
            
            return new EmployeeCollection
            {
                Employees = employess
            };
        }
    }
}
