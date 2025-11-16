using DairyEntry.Data;
using DairyEntry.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace DairyEntry.Controllers
{
    public class DiaryEntriesController : Controller
    {
        private readonly ApplicationDbContext _db;

        public DiaryEntriesController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<DiaryEntry> objDiaryEntryList = _db.DiaryEntrys.ToList();
            return View(objDiaryEntryList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(DiaryEntry entry)
        {
            if (entry != null && entry.Title.Length < 3)
            {
                // Server side validation - 
                ModelState.AddModelError("Title", "Title too short");
            }
            if (ModelState.IsValid)
            {
                // If valid - add to database
                _db.DiaryEntrys.Add(entry); // Adds the new diary entry to the database table DiaryEntrys
                _db.SaveChanges(); // Save changes to the database
                return RedirectToAction("Index");
            }

            return View(entry);

        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                // send to 404 page
                return NotFound();
            }

            DiaryEntry diaryEntry = _db.DiaryEntrys.Find(id);
            if (diaryEntry == null)
            {
                return NotFound();
            }

            return View(diaryEntry);
        }

        [HttpPost]
        public IActionResult Edit(DiaryEntry entry)
        {
            if (entry != null && entry.Title.Length < 3)
            {
                // Server side validation - 
                ModelState.AddModelError("Title", "Title too short");
            }
            if (ModelState.IsValid)
            {
                // If valid - add to database
                _db.DiaryEntrys.Update(entry); // Updates the new diary entry to the database table DiaryEntrys
                _db.SaveChanges(); // Save changes to the database
                return RedirectToAction("Index");
            }

            return View(entry);

        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                // send to 404 page
                return NotFound();
            }

            DiaryEntry diaryEntry = _db.DiaryEntrys.Find(id);
            if (diaryEntry == null)
            {
                return NotFound();
            }

            return View(diaryEntry);
        }

        [HttpPost]
        public IActionResult Delete(DiaryEntry entry)
        {
            // If valid - add to database
            _db.DiaryEntrys.Remove(entry); // Removes the new diary entry to the database table DiaryEntrys
            _db.SaveChanges(); // Save changes to the database
            return RedirectToAction("Index");
        }

    }
}
