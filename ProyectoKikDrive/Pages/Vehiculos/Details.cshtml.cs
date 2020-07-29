using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KikDriveController;
using KikDriveServices;

namespace ProyectoKikDrive.Pages.Vehiculos
{
    public class DetailsModel : PageModel
    {
        private readonly KikDriveServices.AppBDContext _context;

        public DetailsModel(KikDriveServices.AppBDContext context)
        {
            _context = context;
        }

        public Vehiculo Vehiculo { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Vehiculo = await _context.Vehiculos.FirstOrDefaultAsync(m => m.Id == id);

            if (Vehiculo == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
