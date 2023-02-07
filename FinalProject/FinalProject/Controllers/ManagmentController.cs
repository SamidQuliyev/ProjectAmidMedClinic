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
    public class ManagmentController : Controller
    {


        private readonly AppDbContext _db;
        private readonly IWebHostEnvironment _env;
        public ManagmentController(AppDbContext db, IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index()
        {
            List<Managment> Managment = _db.Managment.Include(x => x.Positions).ToList();
            return View(Managment);
        }
        public async Task<IActionResult> Detail(int? id)
        {
            ViewBag.Positions = await _db.Positions.ToListAsync();
            if (id == null)
            {
                return NotFound();
            }

            Managment dbDoctor = await _db.Managment.FirstOrDefaultAsync(s => s.Id == id);
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
        public async Task<IActionResult> Create(Managment Managment, int? posId)
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
            if (Managment.Photo == null)
            {
                ModelState.AddModelError("Photo", "Zəhmət olmasa şəkil qoyun");
                return View();
            }
            if (!Managment.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Zəhmət olmasa şəkil seçin");
                return View();
            }
            if (Managment.Photo.OlderOneMb())
            {
                ModelState.AddModelError("Photo", "Şəklin ölçüsü maksimum 3mb olmalıdır");
                return View();
            }
            string path = Path.Combine(_env.WebRootPath, "images", "managment");
            Managment.Image = await Managment.Photo.SaveFileAsync(path);

            Managment.PositionsId = (int)posId;

            await _db.Managment.AddAsync(Managment);
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

            Managment dbManagment = await _db.Managment.FirstOrDefaultAsync(s => s.Id == id);
            if (dbManagment == null)
            {
                return Ok();
            }

            return View(dbManagment);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Update(int? id, Managment Managment, int? posId)
        {
            ViewBag.Positions = await _db.Positions.ToListAsync();
            if (id == null)
            {
                return NotFound();
            }

            Managment dbManagment = await _db.Managment.FirstOrDefaultAsync(s => s.Id == id);
            if (dbManagment == null)
            {
                return BadRequest();
            }
            if (!ModelState.IsValid)
            {
                return View(dbManagment);
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
            if (Managment.Photo != null)
            {
                if (!Managment.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Zəhmət olmasa şəkil seçin");
                    return View(dbManagment);
                }
                if (Managment.Photo.OlderOneMb())
                {
                    ModelState.AddModelError("Photo", "Şəklin ölçüsü maksimum 3mb olmalıdır");
                    return View(dbManagment);
                }
                string path = Path.Combine(_env.WebRootPath, "images", "managment");

                if (System.IO.File.Exists(Path.Combine(path, dbManagment.Image)))
                {
                    System.IO.File.Delete(Path.Combine(path, dbManagment.Image));
                }
                dbManagment.Image = await Managment.Photo.SaveFileAsync(path);
            }

            dbManagment.FullName = Managment.FullName;

            dbManagment.PositionsId = (int)posId;
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");

        }
        public async Task<IActionResult> Activation(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Managment dbManagment = await _db.Managment.FirstOrDefaultAsync(s => s.Id == id);
            if (dbManagment == null)
            {
                return Ok();
            }
            if (dbManagment.IsDeactive)
            {
                dbManagment.IsDeactive = false;
            }
            else
            {
                dbManagment.IsDeactive = true;
            }
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
            
