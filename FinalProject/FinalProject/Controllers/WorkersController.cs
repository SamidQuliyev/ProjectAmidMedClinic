using AmidmedClinic.Helpers;
using AmidmedClinic.DAL;
using AmidmedClinic.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AmidmedClinic.Controllers
{
    [Authorize]
    public class WorkersController : Controller
    {


        private readonly AppDbContext _db;
        private readonly IWebHostEnvironment _env;
        public WorkersController(AppDbContext db, IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index()
        {
            List<Workers> workers = _db.Workers.Include(x => x.Positions).ToList();
            return View(workers);
        }
        public async Task<IActionResult> Detail(int? id)
        {
            ViewBag.Positions = await _db.Positions.ToListAsync();
            if (id == null)
            {
                return NotFound();
            }

            Workers dbDoctor = await _db.Workers.FirstOrDefaultAsync(s => s.Id == id);
            if (dbDoctor == null)
            {
                return BadRequest();
            }

            return View(dbDoctor);
        }

        public async Task<IActionResult> Create()
        {
            ViewBag.Positions = await _db.Positions.ToListAsync();



            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Workers Workers, int? posId)
        {
            ViewBag.Positions = await _db.Positions.ToListAsync();
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (posId == null)
            {
                ModelState.AddModelError("FullName", "Positions");
                return View();
            }
            Positions Positions = await _db.Positions.FirstOrDefaultAsync(x => x.Id == posId);
            if (Positions == null)
            {
                ModelState.AddModelError("FullName", "Positions");
                return View();
            }
            if (Workers.Photo == null)
            {
                ModelState.AddModelError("Photo", "Zəhmət olmasa şəkil qoyun");
                return View();
            }
            if (!Workers.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Zəhmət olmasa şəkil seçin");
                return View();
            }
            if (Workers.Photo.OlderOneMb())
            {
                ModelState.AddModelError("Photo", "Şəklin ölçüsü maksimum 3 mb ola bilər");
                return View();
            }
            string path = Path.Combine(_env.WebRootPath, "images", "workers");
            Workers.Image = await Workers.Photo.SaveFileAsync(path);

            Workers.PositionsId = (int)posId;

            await _db.Workers.AddAsync(Workers);
            await _db.SaveChangesAsync();



            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Update(int? id)

        {
            ViewBag.Positions = await _db.Positions.ToListAsync();
            if (id == null)
            {
                return NotFound();
            }

            Workers dbWorkers = await _db.Workers.FirstOrDefaultAsync(s => s.Id == id);
            if (dbWorkers == null)
            {
                return Ok();
            }

            return View(dbWorkers);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Update(int? id, Workers Workers, int? posId)
        {
            ViewBag.Positions = await _db.Positions.ToListAsync();
            if (id == null)
            {
                return NotFound();
            }

            Workers dbWorkers = await _db.Workers.FirstOrDefaultAsync(s => s.Id == id);
            if (dbWorkers == null)
            {
                return BadRequest();
            }
            if (!ModelState.IsValid)
            {
                return View(dbWorkers);
            }
            if (posId == null)
            {
                ModelState.AddModelError("FullName", "Positions");
                return View();
            }
            Positions Positions = await _db.Positions.FirstOrDefaultAsync(x => x.Id == posId);
            if (Positions == null)
            {
                ModelState.AddModelError("FullName", "Positions");
                return View();
            }
            if (Workers.Photo != null)
            {
                if (!Workers.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Zəhmət olmasa şəkil seçin");
                    return View(dbWorkers);
                }
                if (Workers.Photo.OlderOneMb())
                {
                    ModelState.AddModelError("Photo", "Şəklin ölçüsü maksimum 3 mb ola bilər");
                    return View(dbWorkers);
                }
                string path = Path.Combine(_env.WebRootPath, "images", "workers");

                if (System.IO.File.Exists(Path.Combine(path, dbWorkers.Image)))
                {
                    System.IO.File.Delete(Path.Combine(path, dbWorkers.Image));
                }
                dbWorkers.Image = await Workers.Photo.SaveFileAsync(path);
            }

            dbWorkers.FullName = Workers.FullName;
            dbWorkers.Salary = Workers.Salary;
            dbWorkers.Address = Workers.Address;
            dbWorkers.Contact = Workers.Contact;





            dbWorkers.PositionsId = (int)posId;
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");

        }
        public async Task<IActionResult> Activation(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Workers dbWorkers = await _db.Workers.FirstOrDefaultAsync(s => s.Id == id);
            if (dbWorkers == null)
            {
                return Ok();
            }
            if (dbWorkers.IsDeactive)
            {
                dbWorkers.IsDeactive = false;
            }
            else
            {
                dbWorkers.IsDeactive = true;
            }
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
            
