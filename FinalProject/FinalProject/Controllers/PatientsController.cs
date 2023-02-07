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
    public class PatientsController : Controller
    {

        private readonly AppDbContext _db;

        public PatientsController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Patients> patients = _db.Patients.ToList();
            return View(patients);


        }
        public async Task<IActionResult> CreateAsync()
        {
            ViewBag.Doctors = await _db.Doctors.ToListAsync();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( Patients patients, int[] docIds)
        {
            patients.Date = DateTime.UtcNow.AddHours(4);
            ViewBag.Doctors = await _db.Doctors.ToListAsync();
            if (!ModelState.IsValid)
            {
                return View();
            }
            List<DoctorsPatients> doctorsPatients = new List<DoctorsPatients>();

            if (docIds == null)
            {
                ModelState.AddModelError("FullName", "Hekim secin");
                return View();
            }
            bool isExist = await _db.Patients.AnyAsync(s => s.Name == patients.Name);
            if (isExist)
            {
                ModelState.AddModelError("Name", "This Patients is already exist");
                return View();
            }
            //doctorsPatients.DoctorsId = docIds?.ToArray();
            await _db.Patients.AddAsync(patients);
            await _db.SaveChangesAsync();
            patients.PatientNumber = "Patient" + (1001 + patients.Id);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Detail(int? id)
        {
            ViewBag.Doctors = await _db.Doctors.Where(x => x.Id == id).ToListAsync();
            if (id == null)
            {
                return NotFound();
            }

            Patients dbPatients = await _db.Patients.FirstOrDefaultAsync(s => s.Id == id);
            if (dbPatients == null)
            {
                return BadRequest();
            }

            return View(dbPatients);
        }
        public async Task<IActionResult> Update(int? id)
        {
            ViewBag.Doctors = await _db.Doctors.ToListAsync();
            if (id == null)
            {
                return NotFound();
            }

            Patients dbPatients = await _db.Patients.FirstOrDefaultAsync(s => s.Id == id);
            if (dbPatients == null)
            {
                return Ok();
            }

            return View(dbPatients);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Patients patients)
        {
            patients.Date = DateTime.UtcNow.AddHours(4);
            ViewBag.Doctors = await _db.Doctors.ToListAsync();
            if (id == null)
            {
                return NotFound();
            }

            Patients dbPatients = await _db.Patients.FirstOrDefaultAsync(s => s.Id == id);
            if (dbPatients == null)
            {
                return Ok();
            }
            bool isExist = await _db.Patients.AnyAsync(s => s.Name == patients.Name && s.Id != id);
            if (isExist)
            {
                ModelState.AddModelError("Name", "This Patients is already exist");
                return View();
            }
            dbPatients.Name = patients.Name;

            dbPatients.Doctors = patients.Doctors;

            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Activation(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Patients dbPatients = await _db.Patients.FirstOrDefaultAsync(s => s.Id == id);
            if (dbPatients == null)
            {
                return Ok();
            }
            if (dbPatients.IsDeactive)
            {
                dbPatients.IsDeactive = false;
            }
            else
            {
                dbPatients.IsDeactive = true;
            }
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}

