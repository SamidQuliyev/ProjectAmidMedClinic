using AmidmedClinic.Models;
using AmidmedClinic.DAL;
using AmidmedClinic.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmidmedClinic.Controllers
{
    [Authorize]
    public class IncomesController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly AppDbContext _db;

        public IncomesController(AppDbContext db, UserManager<AppUser> userManager)
        {
            _userManager = userManager;
            _db = db;
        }
        public IActionResult Index()
        {
            List<Incomes> incomes = _db.Incomes.ToList();
            return View(incomes);


        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Incomes incomes)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            incomes.Date = DateTime.UtcNow.AddHours(4);
            AppUser appUser = await _userManager.FindByNameAsync(User.Identity.Name);
            incomes.ByWho = appUser.FullName;
            Kassa kassa = await _db.Kassa.FirstOrDefaultAsync();
            kassa.Balance += incomes.Quantity;
            //kassa.LastModified = appUser.FullName;
            await _db.Incomes.AddAsync(incomes);
            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
 
    }
}
