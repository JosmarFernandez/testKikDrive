using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KikDriveController;
using KikDriveServices;

namespace ProyectoKikDrive.Pages.Conductor
{
    public class DeleteModel : PageModel
    {
        private readonly KikDriveServices.AppBDContext _context;

        public DeleteModel(KikDriveServices.AppBDContext context)
        {
            _context = context;
        }

        [BindProperty]
        public KikDriveController.Conductor Conductor { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Conductor = await _context.Conductors
                .Include(c => c.Vehiculo).FirstOrDefaultAsync(m => m.Id == id);

            if (Conductor == null)
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

            Conductor = await _context.Conductors.FindAsync(id);

            if (Conductor != null)
            {
                _context.Conductors.Remove(Conductor);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
