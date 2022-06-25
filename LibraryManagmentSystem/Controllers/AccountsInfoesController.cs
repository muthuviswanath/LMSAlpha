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
    public class AccountsInfoesController : Controller
    {
        private readonly LibraryManagementContext _context;

        public AccountsInfoesController(LibraryManagementContext context)
        {
            _context = context;
        }

        // GET: AccountsInfoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Accounts.ToListAsync());
        }

        // GET: AccountsInfoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accountsInfo = await _context.Accounts
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (accountsInfo == null)
            {
                return NotFound();
            }

            return View(accountsInfo);
        }

        // GET: AccountsInfoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AccountsInfoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserId,UserName,Password,Role")] AccountsInfo accountsInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(accountsInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(accountsInfo);
        }

        // GET: AccountsInfoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accountsInfo = await _context.Accounts.FindAsync(id);
            if (accountsInfo == null)
            {
                return NotFound();
            }
            return View(accountsInfo);
        }

        // POST: AccountsInfoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UserId,UserName,Password,Role")] AccountsInfo accountsInfo)
        {
            if (id != accountsInfo.UserId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(accountsInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AccountsInfoExists(accountsInfo.UserId))
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
            return View(accountsInfo);
        }

        // GET: AccountsInfoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accountsInfo = await _context.Accounts
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (accountsInfo == null)
            {
                return NotFound();
            }

            return View(accountsInfo);
        }

        // POST: AccountsInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var accountsInfo = await _context.Accounts.FindAsync(id);
            _context.Accounts.Remove(accountsInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AccountsInfoExists(int id)
        {
            return _context.Accounts.Any(e => e.UserId == id);
        }
    }
}
