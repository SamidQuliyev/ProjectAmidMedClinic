using AmidmedClinic.DAL;
using AmidmedClinic.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmidmedClinic.Controllers
{
    [Authorize]
    public class VacanciesController : Controller
    {

        private readonly AppDbContext _db;

        public VacanciesController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Vacancies> Vacancies = _db.Vacancies.ToList();
            return View(Vacancies);


        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Vacancies Vacancies)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            bool isExist = await _db.Vacancies.AnyAsync(s => s.Name == Vacancies.Name);
            if (isExist)
            {
                ModelState.AddModelError("Name", "This Vacancies is already exist");
                return View();
            }
            await _db.Vacancies.AddAsync(Vacancies);
            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Vacancies dbVacancies = await _db.Vacancies.FirstOrDefaultAsync(s => s.Id == id);
            if (dbVacancies == null)
            {
                return Ok();
            }

            return View(dbVacancies);
        }
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Vacancies dbVacancies = await _db.Vacancies.FirstOrDefaultAsync(s => s.Id == id);
            if (dbVacancies == null)
            {
                return Ok();
            }

            return View(dbVacancies);
        }
        [HttpPost]

        public async Task<IActionResult> Update(int? id, Vacancies Vacancies)
        {
            if (id == null)
            {
                return NotFound();
            }

            Vacancies dbVacancies = await _db.Vacancies.FirstOrDefaultAsync(s => s.Id == id);
            if (dbVacancies == null)
            {
                return Ok();
            }
            bool isExist = await _db.Vacancies.AnyAsync(s => s.Name == Vacancies.Name && s.Id != id);
            if (isExist)
            {
                ModelState.AddModelError("Name", "This Vacancies is already exist");
                return View();
            }
            dbVacancies.Name = Vacancies.Name;
            dbVacancies.VacantPosition = Vacancies.VacantPosition;
            dbVacancies.Requirements = Vacancies.Requirements;
            dbVacancies.Offers = Vacancies.Offers;

            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Activation(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Vacancies dbVacancies = await _db.Vacancies.FirstOrDefaultAsync(s => s.Id == id);
            if (dbVacancies == null)
            {
                return Ok();
            }
            if (dbVacancies.IsDeactive)
            {
                dbVacancies.IsDeactive = false;
            }
            else
            {
                dbVacancies.IsDeactive = true;
            }
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}

