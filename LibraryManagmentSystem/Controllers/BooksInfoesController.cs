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
    public class BooksInfoesController : Controller
    {
        private readonly LibraryManagementContext _context;

        public BooksInfoesController(LibraryManagementContext context)
        {
            _context = context;
        }

        // GET: BooksInfoes
        public async Task<IActionResult> Index()
        {
            var libraryManagementContext = _context.Books.Include(b => b.AuthorInfo).Include(b => b.PublisherInfo);
            return View(await libraryManagementContext.ToListAsync());
        }

        // GET: BooksInfoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booksInfo = await _context.Books
                .Include(b => b.AuthorInfo)
                .Include(b => b.PublisherInfo)
                .FirstOrDefaultAsync(m => m.BookId == id);
            if (booksInfo == null)
            {
                return NotFound();
            }

            return View(booksInfo);
        }

        // GET: BooksInfoes/Create
        public IActionResult Create()
        {
            ViewData["AuthorId"] = new SelectList(_context.Authors, "AuthorId", "AuthorId");
            ViewData["PublisherId"] = new SelectList(_context.Publishers, "PublisherId", "PublisherId");
            return View();
        }

        // POST: BooksInfoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BookId,BookTitle,NoOfCopies,AuthorId,PublisherId,Category,ImageURl,IssuedBooks,IsAvailable")] BooksInfo booksInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(booksInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AuthorId"] = new SelectList(_context.Authors, "AuthorId", "AuthorId", booksInfo.AuthorId);
            ViewData["PublisherId"] = new SelectList(_context.Publishers, "PublisherId", "PublisherId", booksInfo.PublisherId);
            return View(booksInfo);
        }

        // GET: BooksInfoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booksInfo = await _context.Books.FindAsync(id);
            if (booksInfo == null)
            {
                return NotFound();
            }
            ViewData["AuthorId"] = new SelectList(_context.Authors, "AuthorId", "AuthorId", booksInfo.AuthorId);
            ViewData["PublisherId"] = new SelectList(_context.Publishers, "PublisherId", "PublisherId", booksInfo.PublisherId);
            return View(booksInfo);
        }

        // POST: BooksInfoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BookId,BookTitle,NoOfCopies,AuthorId,PublisherId,Category,ImageURl,IssuedBooks,IsAvailable")] BooksInfo booksInfo)
        {
            if (id != booksInfo.BookId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(booksInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BooksInfoExists(booksInfo.BookId))
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
            ViewData["AuthorId"] = new SelectList(_context.Authors, "AuthorId", "AuthorId", booksInfo.AuthorId);
            ViewData["PublisherId"] = new SelectList(_context.Publishers, "PublisherId", "PublisherId", booksInfo.PublisherId);
            return View(booksInfo);
        }

        // GET: BooksInfoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booksInfo = await _context.Books
                .Include(b => b.AuthorInfo)
                .Include(b => b.PublisherInfo)
                .FirstOrDefaultAsync(m => m.BookId == id);
            if (booksInfo == null)
            {
                return NotFound();
            }

            return View(booksInfo);
        }

        // POST: BooksInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var booksInfo = await _context.Books.FindAsync(id);
            _context.Books.Remove(booksInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BooksInfoExists(int id)
        {
            return _context.Books.Any(e => e.BookId == id);
        }
    }
}
