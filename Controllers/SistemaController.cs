using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspStudio.Controllers
{
    public class SistemaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}