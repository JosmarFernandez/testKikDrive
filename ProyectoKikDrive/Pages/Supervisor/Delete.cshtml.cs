using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KikDriveController;
using KikDriveServices;

namespace ProyectoKikDrive.Pages.Supervisor
{
    public class DeleteModel : PageModel
    {
        private readonly KikDriveServices.AppBDContext _context;

        public DeleteModel(KikDriveServices.AppBDContext context)
        {
            _context = context;
        }

        [BindProperty]
        public SupervisorA SupervisorA { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            SupervisorA = await _context.Supervisors.FirstOrDefaultAsync(m => m.Id == id);

            if (SupervisorA == null)
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

            SupervisorA = await _context.Supervisors.FindAsync(id);

            if (SupervisorA != null)
            {
                _context.Supervisors.Remove(SupervisorA);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
