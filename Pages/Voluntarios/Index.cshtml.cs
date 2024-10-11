using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
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

        public async Task OnGetAsync()
        {
            Voluntario = await _context.Voluntario.ToListAsync();
        }
    }
}
