using System;
using System.Collections.Generic;
using System.Text;

namespace RemPeople.Model
{
    /// <summary>
    /// api response model
    /// </summary>
    public class ClientResponseModel
    {
        /// <summary>
        /// tc kimlik no
        /// </summary>
        public string IdentityNumber { get; set; }
        /// <summary>
        /// adı
        /// </summary>
        public string Firstname { get; set; }
        /// <summary>
        /// soyadı
        /// </summary>
        public string Lastname { get; set; }
        /// <summary>
        /// bordro
        /// </summary>
        public decimal Salary { get; set; }
    }
}
