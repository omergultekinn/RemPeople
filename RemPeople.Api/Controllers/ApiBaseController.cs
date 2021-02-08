using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RemPeople.Api.Controllers
{
    public class ApiBaseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
