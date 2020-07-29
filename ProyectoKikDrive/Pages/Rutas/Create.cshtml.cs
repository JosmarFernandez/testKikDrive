using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using KikDriveController;
using KikDriveServices;

namespace ProyectoKikDrive.Pages.Rutas
{
    public class CreateModel : PageModel
    {
        private readonly KikDriveServices.AppBDContext _context;

        public CreateModel(KikDriveServices.AppBDContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public KikDriveController.Rutas Rutas { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Rutas.Add(Rutas);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
