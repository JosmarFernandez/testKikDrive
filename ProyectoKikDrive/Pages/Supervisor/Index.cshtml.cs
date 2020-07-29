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
    public class IndexModel : PageModel
    {
        private readonly KikDriveServices.AppBDContext _context;

        public IndexModel(KikDriveServices.AppBDContext context)
        {
            _context = context;
        }

        public IList<SupervisorA> SupervisorA { get;set; }

        public async Task OnGetAsync()
        {
            SupervisorA = await _context.Supervisors.ToListAsync();
        }
    }
}
