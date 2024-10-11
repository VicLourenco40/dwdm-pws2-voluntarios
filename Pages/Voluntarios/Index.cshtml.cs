using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using dwdm_pws2_voluntarios.Data;
using dwdm_pws2_voluntarios.Models;

namespace dwdm_pws2_voluntarios.Pages.Voluntarios
{
    public class IndexModel : PageModel
    {
        private readonly dwdm_pws2_voluntarios.Data.dwdm_pws2_voluntariosContext _context;

        public IndexModel(dwdm_pws2_voluntarios.Data.dwdm_pws2_voluntariosContext context)
        {
            _context = context;
        }

        public IList<Voluntario> Voluntario { get;set; } = default!;
        public SelectList Armazens { get;set; }
        [BindProperty(SupportsGet = true)]
        public string Armazem { get;set; }

        public async Task OnGetAsync()
        {
            IQueryable<string> armazemQuery = from f in _context.Voluntario orderby f.Armazem select f.Armazem;
            var voluntarios = from f in _context.Voluntario select f;

            if (!string.IsNullOrEmpty(Armazem)) {
                voluntarios = voluntarios.Where(g => g.Armazem == Armazem);
            }
            
            Armazens = new SelectList(await armazemQuery.Distinct().ToListAsync());
            Voluntario = await voluntarios.ToListAsync();
        }
    }
}
