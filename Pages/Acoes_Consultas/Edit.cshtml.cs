using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Clinica_Veterinaria_3.Data;
using Clinica_Veterinaria_3.Models;

namespace Clinica_Veterinaria_3.Pages.Acoes_Consultas
{
    public class EditModel : PageModel
    {
        private readonly Clinica_Veterinaria_3.Data.ConsultaContext _context;

        public EditModel(Clinica_Veterinaria_3.Data.ConsultaContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Consulta Consulta { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Consulta = await _context.Consulta.FirstOrDefaultAsync(m => m.Id_Consulta == id);

            if (Consulta == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Consulta).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ConsultaExists(Consulta.Id_Consulta))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ConsultaExists(int id)
        {
            return _context.Consulta.Any(e => e.Id_Consulta == id);
        }
    }
}
