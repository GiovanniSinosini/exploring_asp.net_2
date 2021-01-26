using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Clinica_Veterinaria_3.Data;
using Clinica_Veterinaria_3.Models;

namespace Clinica_Veterinaria_3.Pages.Acoes_Consultas
{
    public class CreateModel : PageModel
    {
        private readonly Clinica_Veterinaria_3.Data.ConsultaContext _context;

        public CreateModel(Clinica_Veterinaria_3.Data.ConsultaContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Consulta Consulta { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Consulta.Add(Consulta);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
