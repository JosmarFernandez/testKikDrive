using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using KikDriveServices;
using KikDriveController;

namespace ProyectoKikDrive.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IRepository<KikDriveController.Login> repository;
        public IndexModel(IRepository<KikDriveController.Login> repository)
        {
            this.repository = repository;
        }

        public IEnumerable<KikDriveController.Login> Login { get; private set; }

        public IActionResult OnGet()
        {
            try
            {
                Login = repository.GetAll();
                return Page();
            }
            catch (Exception)
            {
                return RedirectToPage($"/NotFount");
            }
        }
    }
}
