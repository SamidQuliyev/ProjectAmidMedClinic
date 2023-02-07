using AmidmedClinic.Models;
using AmidmedClinic.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace AmidmedClinic.Controllers
{[Authorize]
    public class KassaController : Controller
    {
        private readonly AppDbContext _db;
        public KassaController(AppDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            Kassa kassa= await _db.Kassa.FirstOrDefaultAsync();
            return View(kassa);
        }
    }
}
