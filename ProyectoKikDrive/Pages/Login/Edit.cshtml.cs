using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KikDriveController;
using KikDriveServices;

namespace ProyectoKikDrive.Pages.Login
{
    public class EditModel : PageModel
    {
        private readonly KikDriveServices.AppBDContext _context;

        public EditModel(KikDriveServices.AppBDContext context)
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
           ViewData["SupervisorId"] = new SelectList(_context.Supervisors, "Id", "Apellido_Materno");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Login).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LoginExists(Login.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool LoginExists(int id)
        {
            return _context.Logins.Any(e => e.Id == id);
        }
    }
}
