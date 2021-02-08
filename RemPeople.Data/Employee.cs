using RemPeople.Model;

namespace RemPeople.Data
{
    /// <summary>
    /// Çalışan bilgileri
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// çalışana ait id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// çalışan tc kimlik numarası
        /// </summary>
        public string IdentityNumber { get; set; }

        /// <summary>
        /// çalışan adı
        /// </summary>
        public string Firstname { get; set; }

        /// <summary>
        /// çalışan soyadı
        /// </summary>
        public string Lastname { get; set; }

        /// <summary>
        /// çalışan maaş tipi
        /// </summary>
        public SalaryType SalaryType { get; set; }

        /// <summary>
        /// sabit ücret çalışıyorsa ücret bilgisini içeren obje
        /// </summary>
        public EmployeeFixedSalary EmployeeFixedSalary { get; set; }

        /// <summary>
        /// günlük çalışıyorsa günlük ücret bilgilerini içerir
        /// </summary>
        public EmployeeDayWage EmployeeDayWage { get; set; }

        /// <summary>
        /// mesai ücreti alıyorsa saatlik mesai ücreti bilgilerini içerir
        /// </summary>
        public EmployeeOvertime EmployeeOvertime { get; set; }
    }
}
