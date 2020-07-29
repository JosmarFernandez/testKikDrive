using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KikDriveController;
using KikDriveServices;

namespace ProyectoKikDrive.Pages.Login
{
    public class DeleteModel : PageModel
    {
        private readonly KikDriveServices.AppBDContext _context;

        public DeleteModel(KikDriveServices.AppBDContext context)
        {
            _context = context;
        }

        [BindProperty]
        public KikDriveController.Login Login { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Login = await _context.Logins
                .Include(l => l.SupervisorA).FirstOrDefaultAsync(m => m.Id == id);

            if (Login == null)
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

            Login = await _context.Logins.FindAsync(id);

            if (Login != null)
            {
                _context.Logins.Remove(Login);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
