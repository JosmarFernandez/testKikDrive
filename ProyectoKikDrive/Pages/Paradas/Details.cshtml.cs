﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KikDriveController;
using KikDriveServices;

namespace ProyectoKikDrive.Pages.Paradas
{
    public class DetailsModel : PageModel
    {
        private readonly KikDriveServices.AppBDContext _context;

        public DetailsModel(KikDriveServices.AppBDContext context)
        {
            _context = context;
        }

        public KikDriveController.Paradas Paradas { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Paradas = await _context.Paradas
                .Include(p => p.Rutas).FirstOrDefaultAsync(m => m.Id == id);

            if (Paradas == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
