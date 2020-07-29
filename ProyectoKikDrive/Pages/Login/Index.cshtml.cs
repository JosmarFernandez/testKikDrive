using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KikDriveController;
using KikDriveServices;
using System.Collections.Generic;

namespace ProyectoKikDrive.Pages.Login
{
    public class IndexModel : PageModel
    {
        private readonly KikDriveServices.AppBDContext _context;

        public IndexModel(KikDriveServices.AppBDContext context)
        {
            _context = context;
        }

        public IList<KikDriveController.Login> Logins { get; set; }

        public async Task OnGetAsync()
        {
            Logins = await _context.Logins.ToListAsync();
        }
    }
}
