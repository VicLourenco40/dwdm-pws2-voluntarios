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
    public class DeleteModel : PageModel
    {
        private readonly dwdm_pws2_voluntarios.Data.dwdm_pws2_voluntariosContext _context;

        public DeleteModel(dwdm_pws2_voluntarios.Data.dwdm_pws2_voluntariosContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Voluntario Voluntario { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var voluntario = await _context.Voluntario.FirstOrDefaultAsync(m => m.Id == id);

            if (voluntario == null)
            {
                return NotFound();
            }
            else
            {
                Voluntario = voluntario;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var voluntario = await _context.Voluntario.FindAsync(id);
            if (voluntario != null)
            {
                Voluntario = voluntario;
                _context.Voluntario.Remove(Voluntario);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
