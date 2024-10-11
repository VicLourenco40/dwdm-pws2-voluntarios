using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using dwdm_pws2_voluntarios.Data;
using dwdm_pws2_voluntarios.Models;

namespace dwdm_pws2_voluntarios.Pages.Voluntarios
{
    public class CreateModel : PageModel
    {
        private readonly dwdm_pws2_voluntarios.Data.dwdm_pws2_voluntariosContext _context;

        public CreateModel(dwdm_pws2_voluntarios.Data.dwdm_pws2_voluntariosContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Voluntario Voluntario { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Voluntario.Add(Voluntario);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
