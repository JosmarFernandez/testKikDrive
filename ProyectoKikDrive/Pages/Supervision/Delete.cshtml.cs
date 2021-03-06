﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KikDriveController;
using KikDriveServices;

namespace ProyectoKikDrive.Pages.Supervision
{
    public class DeleteModel : PageModel
    {
        private readonly KikDriveServices.AppBDContext _context;

        public DeleteModel(KikDriveServices.AppBDContext context)
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
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Supervision = await _context.Supervisions.FindAsync(id);

            if (Supervision != null)
            {
                _context.Supervisions.Remove(Supervision);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
