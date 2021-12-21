using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CrudProjeto365.Models;

namespace CrudProjeto365.Controllers
{
    public class PassagemsController : Controller
    {
        private readonly Context _context;

        public PassagemsController(Context context)
        {
            _context = context;
        }

        // GET: Passagems
        public async Task<IActionResult> Index()
        {
            var context = _context.passagem.Include(p => p.Cliente);
            return View(await context.ToListAsync());
        }

        // GET: Passagems/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var passagem = await _context.passagem
                .Include(p => p.Cliente)
                .FirstOrDefaultAsync(m => m.Passagem_id == id);
            if (passagem == null)
            {
                return NotFound();
            }

            return View(passagem);
        }

        // GET: Passagems/Create
        public IActionResult Create()
        {
            ViewData["Cliente_id"] = new SelectList(_context.cliente, "Cliente_id", "Cliente_id");
            return View();
        }

        // POST: Passagems/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Passagem_id,Destino,Data,Horario,Poltrona,Classe,Preço,Cliente_id")] Passagem passagem)
        {
           
                _context.Add(passagem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            
            ViewData["Cliente_id"] = new SelectList(_context.cliente, "Cliente_id", "Cliente_id", passagem.Cliente_id);
            
        }

        // GET: Passagems/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var passagem = await _context.passagem.FindAsync(id);
            if (passagem == null)
            {
                return NotFound();
            }
            ViewData["Cliente_id"] = new SelectList(_context.cliente, "Cliente_id", "Cliente_id", passagem.Cliente_id);
            return View(passagem);
        }

        // POST: Passagems/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Passagem_id,Destino,Data,Horario,Poltrona,Classe,Preço,Cliente_id")] Passagem passagem)
        {
            if (id != passagem.Passagem_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(passagem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PassagemExists(passagem.Passagem_id))
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
            ViewData["Cliente_id"] = new SelectList(_context.cliente, "Cliente_id", "Cliente_id", passagem.Cliente_id);
            return View(passagem);
        }

        // GET: Passagems/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var passagem = await _context.passagem
                .Include(p => p.Cliente)
                .FirstOrDefaultAsync(m => m.Passagem_id == id);
            if (passagem == null)
            {
                return NotFound();
            }

            return View(passagem);
        }

        // POST: Passagems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var passagem = await _context.passagem.FindAsync(id);
            _context.passagem.Remove(passagem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PassagemExists(int id)
        {
            return _context.passagem.Any(e => e.Passagem_id == id);
        }
    }
}
