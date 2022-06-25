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
    public class AuthorInfoesController : Controller
    {
        private readonly LibraryManagementContext _context;

        public AuthorInfoesController(LibraryManagementContext context)
        {
            _context = context;
        }

        // GET: AuthorInfoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Authors.ToListAsync());
        }

        // GET: AuthorInfoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var authorInfo = await _context.Authors
                .FirstOrDefaultAsync(m => m.AuthorId == id);
            if (authorInfo == null)
            {
                return NotFound();
            }

            return View(authorInfo);
        }

        // GET: AuthorInfoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AuthorInfoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AuthorId,AuthorName")] AuthorInfo authorInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(authorInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(authorInfo);
        }

        // GET: AuthorInfoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var authorInfo = await _context.Authors.FindAsync(id);
            if (authorInfo == null)
            {
                return NotFound();
            }
            return View(authorInfo);
        }

        // POST: AuthorInfoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AuthorId,AuthorName")] AuthorInfo authorInfo)
        {
            if (id != authorInfo.AuthorId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(authorInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AuthorInfoExists(authorInfo.AuthorId))
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
            return View(authorInfo);
        }

        // GET: AuthorInfoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var authorInfo = await _context.Authors
                .FirstOrDefaultAsync(m => m.AuthorId == id);
            if (authorInfo == null)
            {
                return NotFound();
            }

            return View(authorInfo);
        }

        // POST: AuthorInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var authorInfo = await _context.Authors.FindAsync(id);
            _context.Authors.Remove(authorInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AuthorInfoExists(int id)
        {
            return _context.Authors.Any(e => e.AuthorId == id);
        }
    }
}
