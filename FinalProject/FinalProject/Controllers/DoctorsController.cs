using AmidmedClinic.Helpers;
using AmidmedClinic;
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
    public class DoctorsController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IWebHostEnvironment _env;
        public DoctorsController(AppDbContext db, IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }

        public IActionResult Index()
        {
            List<Doctors> doctors = _db.Doctors.Include(x=>x.Branches).ToList();
            return View(doctors);

        }

        public async Task<IActionResult> Detail(int? id)
        {
            ViewBag.Branches = await _db.Branches.ToListAsync();
            if (id == null)
            {
                return NotFound();
            }

            Doctors dbDoctor = await _db.Doctors.FirstOrDefaultAsync(s => s.Id == id);
            if (dbDoctor == null)
            {
                return BadRequest();
            }

            return View(dbDoctor);
        }

        public async Task<IActionResult> Create()
        {
            ViewBag.Branches = await _db.Branches.ToListAsync();



            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( Doctors Doctors, int? branchId)
        {
            ViewBag.Branches = await _db.Branches.ToListAsync();
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (branchId == null)
            {
                ModelState.AddModelError("Name", "Branches");
                return View();
            }
            Branches Branches = await _db.Branches.FirstOrDefaultAsync(x => x.Id == branchId);
            if (Branches == null)
            {
                ModelState.AddModelError("Name", "Branches");
                return View();
            }
            if (Doctors.Photo == null)
            {
                ModelState.AddModelError("Photo", "Zəhmət olmasa şəkil qoyun");
                return View();
            }
            if (!Doctors.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Zəhmət olmasa şəkil seçin");
                return View();
            }
            if (Doctors.Photo.OlderOneMb())
            {
                ModelState.AddModelError("Photo", "Şəklin ölçüsü maksimum 3mb olmalıdır");
                return View();
            }
            string path = Path.Combine(_env.WebRootPath, "images", "doctors");
            Doctors.Image = await Doctors.Photo.SaveFileAsync(path);

            Doctors.BranchesId = (int)branchId;

            await _db.Doctors.AddAsync(Doctors);
            await _db.SaveChangesAsync();



            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Update(int? id)

        {
            ViewBag.Branches = await _db.Branches.ToListAsync();
            if (id == null)
            {
                return NotFound();
            }

            Doctors dbDoctors = await _db.Doctors.FirstOrDefaultAsync(s => s.Id == id);
            if (dbDoctors == null)
            {
                return Ok();
            }

            return View(dbDoctors);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Update(int? id, Doctors Doctors, int? branchId)
        {
            ViewBag.Branches = await _db.Branches.ToListAsync();
            if (id == null)
            {
                return NotFound();
            }

            Doctors dbDoctors = await _db.Doctors.FirstOrDefaultAsync(s => s.Id == id);
            if (dbDoctors == null)
            {
                return BadRequest();
            }
            if (!ModelState.IsValid)
            {
                return View(dbDoctors);
            }
            if (branchId == null)
            {
                ModelState.AddModelError("Name", "Branches");
                return View();
            }
            Branches Branches = await _db.Branches.FirstOrDefaultAsync(x => x.Id == branchId);
            if (Branches == null)
            {
                ModelState.AddModelError("Name", "Branches");
                return View();
            }
            if (Doctors.Photo != null)
            {
                if (!Doctors.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Zəhmət olmasa şəkil seçin");
                    return View(dbDoctors);
                }
                if (Doctors.Photo.OlderOneMb())
                {
                    ModelState.AddModelError("Photo", "Şəklin ölçüsü maksimum 3mb olmalıdır");
                    return View(dbDoctors);
                }
                string path = Path.Combine(_env.WebRootPath, "images", "doctors");

                if (System.IO.File.Exists(Path.Combine(path, dbDoctors.Image)))
                {
                    System.IO.File.Delete(Path.Combine(path, dbDoctors.Image));
                }
                dbDoctors.Image = await Doctors.Photo.SaveFileAsync(path);
            }

            dbDoctors.FullName = Doctors.FullName;
            dbDoctors.Salary = Doctors.Salary;
            dbDoctors.Address = Doctors.Address;
            dbDoctors.Contact = Doctors.Contact;
            dbDoctors.Education = Doctors.Education;


            dbDoctors.BranchesId = (int)branchId;
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");

        }
        public async Task<IActionResult> Activation(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Doctors dbDoctors = await _db.Doctors.FirstOrDefaultAsync(s => s.Id == id);
            if (dbDoctors == null)
            {
                return Ok();
            }
            if (dbDoctors.IsDeactive)
            {
                dbDoctors.IsDeactive = false;
            }
            else
            {
                dbDoctors.IsDeactive = true;
            }
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
 
}
