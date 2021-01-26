using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Clinica_Veterinaria_3.Data;
using Clinica_Veterinaria_3.Models;

namespace Clinica_Veterinaria_3.Pages.Acoes_Consultas
{
    public class DeleteModel : PageModel
    {
        private readonly Clinica_Veterinaria_3.Data.ConsultaContext _context;

        public DeleteModel(Clinica_Veterinaria_3.Data.ConsultaContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Consulta = await _context.Consulta.FindAsync(id);

            if (Consulta != null)
            {
                _context.Consulta.Remove(Consulta);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
