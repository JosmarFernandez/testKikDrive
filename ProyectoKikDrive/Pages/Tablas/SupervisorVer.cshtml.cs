using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KikDriveController;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using KikDriveServices;


namespace ProyectoKikDrive.Pages.Tablas
{
    public class SupervisorVerModel : PageModel
    {
        private readonly IRepository<SupervisorA> repository;
        public IEnumerable<SupervisorA> Supervisors { get; private set; }
        public SupervisorVerModel(IRepository<SupervisorA> repository)
        {
            this.repository = repository;
        }
        public IActionResult OnGet()
        {
            try
            {
                Supervisors = repository.GetAll();
                return Page();
            }
            catch (Exception)
            {
                return RedirectToPage($"/NotFount");
            }
        }
    }
}
