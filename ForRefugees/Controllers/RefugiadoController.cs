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
    public class RefugiadoController : Controller
    {
        private readonly AppDbContext _context;

        public RefugiadoController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Refugiado
        public async Task<IActionResult> Index()
        {
            return View(await _context.Refugiado.ToListAsync());
        }

        // GET: Refugiado/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var refugiado = await _context.Refugiado
                .FirstOrDefaultAsync(m => m.Id == id);
            if (refugiado == null)
            {
                return NotFound();
            }

            return View(refugiado);
        }

        // GET: Refugiado/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Refugiado/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Cpf,Cidade,Telefone,Estado,Profissao,Nacionalidade,Bio,DataNascimento,ValorHora,Endereco,Bairro")] Refugiado refugiado)
        {
            DateTime date1 = DateTime.Now;
            date1 = date1.AddYears(-18);
            int result = DateTime.Compare(refugiado.DataNascimento, date1);
            if (result <= 0)
            {
                if (ModelState.IsValid)
                {
                    _context.Add(refugiado);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index", "Vaga");
                }
                return View(refugiado);
            }
            return RedirectToAction("Create", "Refugiado");
        }

        // GET: Refugiado/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var refugiado = await _context.Refugiado.FindAsync(id);
            if (refugiado == null)
            {
                return NotFound();
            }
            return View(refugiado);
        }

        // POST: Refugiado/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Cpf,Cidade,Telefone,Estado,Profissao,Nacionalidade,Bio,DataNascimento,ValorHora,Endereco,Bairro")] Refugiado refugiado)
        {
            if (id != refugiado.Id)
            {
                return NotFound();
            }
            DateTime date1 = DateTime.Now;
            date1 = date1.AddYears(-18);
            int result = DateTime.Compare(refugiado.DataNascimento, date1);
            if (result <= 0)
            {
                if (ModelState.IsValid)
                {
                    try
                    {
                        _context.Update(refugiado);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!RefugiadoExists(refugiado.Id))
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
            }
            return View(refugiado);
        }

        // GET: Refugiado/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var refugiado = await _context.Refugiado
                .FirstOrDefaultAsync(m => m.Id == id);
            if (refugiado == null)
            {
                return NotFound();
            }

            return View(refugiado);
        }

        // POST: Refugiado/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var refugiado = await _context.Refugiado.FindAsync(id);
            _context.Refugiado.Remove(refugiado);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RefugiadoExists(int id)
        {
            return _context.Refugiado.Any(e => e.Id == id);
        }
    }
}
