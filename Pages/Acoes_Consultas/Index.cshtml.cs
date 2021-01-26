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
    public class IndexModel : PageModel
    {
        private readonly Clinica_Veterinaria_3.Data.ConsultaContext _context;

        public IndexModel(Clinica_Veterinaria_3.Data.ConsultaContext context)
        {
            _context = context;
        }

        public IList<Consulta> Consulta { get;set; }

        public async Task OnGetAsync()
        {
            Consulta = await _context.Consulta.ToListAsync();
        }
    }
}
