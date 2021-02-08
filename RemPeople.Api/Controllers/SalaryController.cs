using Microsoft.AspNetCore.Mvc;
using RemPeople.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RemPeople.Api.Controllers
{
    /// <summary>
    /// Bir şirket farklı tipteki çalışanlarına ait maaş bordrolarını; 
    /// TC kimlik numarası, ad, soyad ve maaş bilgisiyle görüntülemek ve dışarıya servis olarak açmak içib oluşturulmuştur
    /// </summary>
    public class SalaryController : ApiBaseController
    {
        private readonly ISalaryCalculator _salaryCalculator;
        public SalaryController(ISalaryCalculator salaryCalculator)
        {
            _salaryCalculator = salaryCalculator;
        }

        /// <summary>
        /// ilgili personel idsine göre vordro görüntüler
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        [ApiVersion(v1)]
        [HttpGet("GetSalaryById")]
        public IActionResult Get(int Id)
        {
            return Ok(_salaryCalculator.GetCalculatedSalary(Id));
        }

        /// <summary>
        /// ilgili personel idsine göre vordro görüntüler
        /// normalde versiyonlanacak bir metot değil ama versiyonlamanın görünmesi için eklendi.
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        [ApiVersion(v1_1)]
        [HttpGet("GetAllEmployees")]
        public IActionResult GetAllEmployees()
        {
            return Ok(_salaryCalculator.GetCalculatedSalaries());
        }
    }
}
