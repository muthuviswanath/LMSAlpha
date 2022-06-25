using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LibraryManagmentSystem.Models;

namespace LibraryManagmentSystem.Controllers
{
    public class PublisherInfoesController : Controller
    {
        private readonly LibraryManagementContext _context;

        public PublisherInfoesController(LibraryManagementContext context)
        {
            _context = context;
        }

        // GET: PublisherInfoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Publishers.ToListAsync());
        }

        // GET: PublisherInfoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var publisherInfo = await _context.Publishers
                .FirstOrDefaultAsync(m => m.PublisherId == id);
            if (publisherInfo == null)
            {
                return NotFound();
            }

            return View(publisherInfo);
        }

        // GET: PublisherInfoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PublisherInfoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PublisherId,PublisherName")] PublisherInfo publisherInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(publisherInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(publisherInfo);
        }

        // GET: PublisherInfoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var publisherInfo = await _context.Publishers.FindAsync(id);
            if (publisherInfo == null)
            {
                return NotFound();
            }
            return View(publisherInfo);
        }

        // POST: PublisherInfoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PublisherId,PublisherName")] PublisherInfo publisherInfo)
        {
            if (id != publisherInfo.PublisherId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(publisherInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PublisherInfoExists(publisherInfo.PublisherId))
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
            return View(publisherInfo);
        }

        // GET: PublisherInfoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var publisherInfo = await _context.Publishers
                .FirstOrDefaultAsync(m => m.PublisherId == id);
            if (publisherInfo == null)
            {
                return NotFound();
            }

            return View(publisherInfo);
        }

        // POST: PublisherInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var publisherInfo = await _context.Publishers.FindAsync(id);
            _context.Publishers.Remove(publisherInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PublisherInfoExists(int id)
        {
            return _context.Publishers.Any(e => e.PublisherId == id);
        }
    }
}
