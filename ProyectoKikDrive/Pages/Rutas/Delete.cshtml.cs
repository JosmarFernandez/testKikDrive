using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KikDriveController;
using KikDriveServices;

namespace ProyectoKikDrive.Pages.Rutas
{
    public class DeleteModel : PageModel
    {
        private readonly KikDriveServices.AppBDContext _context;

        public DeleteModel(KikDriveServices.AppBDContext context)
        {
            _context = context;
        }

        [BindProperty]
        public KikDriveController.Rutas Rutas { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Rutas = await _context.Rutas.FirstOrDefaultAsync(m => m.Id == id);

            if (Rutas == null)
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

            Rutas = await _context.Rutas.FindAsync(id);

            if (Rutas != null)
            {
                _context.Rutas.Remove(Rutas);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
