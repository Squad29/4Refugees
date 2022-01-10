using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ForRefugees.Data;
using ForRefugees.Models;

namespace ForRefugees.Controllers
{
    public class SuporteController : Controller
    {
        private readonly AppDbContext _context;

        public SuporteController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Suporte
        public async Task<IActionResult> Index()
        {
            return View(await _context.Suporte.ToListAsync());
        }

        // GET: Suporte/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var suporte = await _context.Suporte
                .FirstOrDefaultAsync(m => m.id == id);
            if (suporte == null)
            {
                return NotFound();
            }

            return View(suporte);
        }

        // GET: Suporte/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Suporte/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,mensagem,assunto,email,nome")] Suporte suporte)
        {
            if (ModelState.IsValid)
            {
                _context.Add(suporte);
                await _context.SaveChangesAsync();
                return RedirectToAction("Congrats", "Home");
            }
            return View(suporte);
        }

        // GET: Suporte/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var suporte = await _context.Suporte.FindAsync(id);
            if (suporte == null)
            {
                return NotFound();
            }
            return View(suporte);
        }

        // POST: Suporte/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,mensagem,assunto,email,nome")] Suporte suporte)
        {
            if (id != suporte.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(suporte);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SuporteExists(suporte.id))
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
            return View(suporte);
        }

        // GET: Suporte/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var suporte = await _context.Suporte
                .FirstOrDefaultAsync(m => m.id == id);
            if (suporte == null)
            {
                return NotFound();
            }

            return View(suporte);
        }

        // POST: Suporte/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var suporte = await _context.Suporte.FindAsync(id);
            _context.Suporte.Remove(suporte);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SuporteExists(int id)
        {
            return _context.Suporte.Any(e => e.id == id);
        }
    }
}
