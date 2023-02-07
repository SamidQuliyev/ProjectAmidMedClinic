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
    public class ExpensesController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly AppDbContext _db;

        public ExpensesController(AppDbContext db, UserManager<AppUser> userManager)
        {
            _userManager = userManager;
            _db = db;
        }
        public IActionResult Index()
        {
            List<Expenses> expenses = _db.Expenses.ToList();
            return View(expenses);


        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Expenses expenses)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
     
            expenses.Date = DateTime.UtcNow.AddHours(4);
            AppUser appUser = await _userManager.FindByNameAsync(User.Identity.Name);
            expenses.ByWho = appUser.FullName;
            Kassa kassa = await _db.Kassa.FirstOrDefaultAsync();
            kassa.Balance -= expenses.Quantity;
            await _db.Expenses.AddAsync(expenses);
            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }

    }
}
