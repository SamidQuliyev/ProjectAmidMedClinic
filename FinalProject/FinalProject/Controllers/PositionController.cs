using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmidmedClinic.Controllers
{
    public class PositionController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {  
            
            return View();

        }
    }
}
