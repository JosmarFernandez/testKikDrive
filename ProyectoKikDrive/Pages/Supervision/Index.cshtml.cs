using System;
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
    public class IndexModel : PageModel
    {
        private readonly KikDriveServices.AppBDContext _context;

        public IndexModel(KikDriveServices.AppBDContext context)
        {
            _context = context;
        }

        public IList<KikDriveController.Supervision> Supervision { get;set; }

        public async Task OnGetAsync()
        {
            Supervision = await _context.Supervisions.Include(s => s.SupervisorA).ToListAsync();
        }
    }
}
