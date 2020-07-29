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

namespace ProyectoKikDrive.Pages.Supervision
{
    public class EditModel : PageModel
    {
        private readonly KikDriveServices.AppBDContext _context;

        public EditModel(KikDriveServices.AppBDContext context)
        {
            _context = context;
        }

        [BindProperty]
        public KikDriveController.Supervision Supervision { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Supervision = await _context.Supervisions
                .Include(s => s.SupervisorA).FirstOrDefaultAsync(m => m.Id == id);

            if (Supervision == null)
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

            _context.Attach(Supervision).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SupervisionExists(Supervision.Id))
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

        private bool SupervisionExists(int id)
        {
            return _context.Supervisions.Any(e => e.Id == id);
        }
    }
}
