using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace geografico.Controllers
{
    public class CoordenadasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
