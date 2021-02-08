using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RemPeople.Api.Controllers
{
    /// <summary>
    /// Api için base controllerımız. 
    /// Genel tanımlamalar olacaksa buraya tanımlanacak ve api controllerları burayı base alacaklar
    /// </summary>
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class ApiBaseController : ControllerBase
    {
        protected const string v1 = "1.0";
        protected const string v1_1 = "1.1";
    }
}
