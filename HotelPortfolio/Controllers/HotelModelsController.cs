using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HotelPortfolio.Models;

namespace HotelPortfolio.Controllers
{
    public class HotelModelsController : Controller
    {
        private readonly HotelDBContext _context;

        public HotelModelsController(HotelDBContext context)
        {
            _context = context;
        }

        // GET: HotelModels
        public async Task<IActionResult> Index()
        {
              return _context.Hotel != null ? 
                          View(await _context.Hotel.ToListAsync()) :
                          Problem("Entity set 'HotelDBContext.Hotel'  is null.");
        }

        // GET: HotelModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Hotel == null)
            {
                return NotFound();
            }

            var hotelModel = await _context.Hotel
                .FirstOrDefaultAsync(m => m.hotelID == id);
            if (hotelModel == null)
            {
                return NotFound();
            }

            return View(hotelModel);
        }

        // GET: HotelModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HotelModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("hotelID,hotelName,hotelCategory,hotelBranch,hotelRating")] HotelModel hotelModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hotelModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hotelModel);
        }

        // GET: HotelModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Hotel == null)
            {
                return NotFound();
            }

            var hotelModel = await _context.Hotel.FindAsync(id);
            if (hotelModel == null)
            {
                return NotFound();
            }
            return View(hotelModel);
        }

        // POST: HotelModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("hotelID,hotelName,hotelCategory,hotelBranch,hotelRating")] HotelModel hotelModel)
        {
            if (id != hotelModel.hotelID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hotelModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HotelModelExists(hotelModel.hotelID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(hotelModel);
        }

        // GET: HotelModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Hotel == null)
            {
                return NotFound();
            }

            var hotelModel = await _context.Hotel
                .FirstOrDefaultAsync(m => m.hotelID == id);
            if (hotelModel == null)
            {
                return NotFound();
            }

            return View(hotelModel);
        }

        // POST: HotelModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Hotel == null)
            {
                return Problem("Entity set 'HotelDBContext.Hotel'  is null.");
            }
            var hotelModel = await _context.Hotel.FindAsync(id);
            if (hotelModel != null)
            {
                _context.Hotel.Remove(hotelModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HotelModelExists(int id)
        {
          return (_context.Hotel?.Any(e => e.hotelID == id)).GetValueOrDefault();
        }
    }
}
