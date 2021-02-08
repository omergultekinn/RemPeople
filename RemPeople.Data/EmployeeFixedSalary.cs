namespace RemPeople.Data
{
    /// <summary>
    /// Sabit ücret bilgileri
    /// </summary>
    public class EmployeeFixedSalary
    {
        /// <summary>
        /// çalışan id
        /// </summary>
        public int EmployeeId { get; set; }

        /// <summary>
        /// sabit aylık maaş
        /// </summary>
        public decimal FixedSalary { get; set; }
    }
}
