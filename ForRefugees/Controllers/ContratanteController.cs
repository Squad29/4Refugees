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
    public class ContratanteController : Controller
    {
        private readonly AppDbContext _context;

        public ContratanteController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Contratante
        public async Task<IActionResult> Index()
        {
            return View(await _context.Contratante.ToListAsync());
        }

        // GET: Contratante/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contratante = await _context.Contratante
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contratante == null)
            {
                return NotFound();
            }

            return View(contratante);
        }

        // GET: Contratante/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Contratante/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Cpf,Cnpj,Seguimento,ValorHora,Senha,Email,Telefone,Bio,Endereco,Bairro,Cidade,Estado")] Contratante contratante)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contratante);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Refugiado");
            }
            return View(contratante);
        }

        // GET: Contratante/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contratante = await _context.Contratante.FindAsync(id);
            if (contratante == null)
            {
                return NotFound();
            }
            return View(contratante);
        }

        // POST: Contratante/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Cpf,Cnpj,Seguimento,ValorHora,Senha,Email,Telefone,Bio,Endereco,Bairro,Cidade,Estado")] Contratante contratante)
        {
            if (id != contratante.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contratante);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContratanteExists(contratante.Id))
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
            return View(contratante);
        }

        // GET: Contratante/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contratante = await _context.Contratante
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contratante == null)
            {
                return NotFound();
            }

            return View(contratante);
        }

        // POST: Contratante/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contratante = await _context.Contratante.FindAsync(id);
            _context.Contratante.Remove(contratante);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContratanteExists(int id)
        {
            return _context.Contratante.Any(e => e.Id == id);
        }
    }
}
