using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataKar.Data;
using DataKar.Models;
using static DataKar.Helper;

namespace DataKar.Controllers
{
    public class KaryawanController : Controller
    {
        private readonly AppDbContext _context;

        public KaryawanController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Karyawan
        public async Task<IActionResult> Index()
        {
            return View(await _context.Karyawans.ToListAsync());
        }
 
        // GET: Transaction/TambahEdit(Insert)
        // GET: Transaction/TambahEdit/5(Update)
        [NoDirectAccess]
        public async Task<IActionResult> TambahEdit(int id = 0)
        {
            if (id == 0)
                return View(new Karyawan());
            else
            {
                var karyawan = await _context.Karyawans.FindAsync(id);
                if (karyawan == null)
                {
                    return NotFound();
                }
                return View(karyawan);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TambahEdit(int id, [Bind("ID,Nama,Alamat,Telepon,TLahir")] Karyawan karyawan)
        {
            if (ModelState.IsValid)
            {
                //Insert
                if (id == 0)
                {
         
                    _context.Add(karyawan);
                    await _context.SaveChangesAsync();

                }
                //Update
                else
                {
                    try
                    {
                        _context.Update(karyawan);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!KaryawanExists(karyawan.ID))
                        { return NotFound(); }
                        else
                        { throw; }
                    }
                }
                return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "_ViewAll", _context.Karyawans.ToList()) });
            }
            return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "TambahEdit", karyawan) });
        }


        // POST: Karyawan/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var karyawan = await _context.Karyawans.FindAsync(id);
            _context.Karyawans.Remove(karyawan);
            await _context.SaveChangesAsync();
            return Json(new { html = Helper.RenderRazorViewToString(this, "_ViewAll", _context.Karyawans.ToList()) });
        }

        private bool KaryawanExists(int id)
        {
            return _context.Karyawans.Any(e => e.ID == id);
        }
    }
}
