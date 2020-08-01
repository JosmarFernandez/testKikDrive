using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using KikDriveServices;
using KikDriveController;
using Microsoft.AspNetCore.Http;

namespace ProyectoKikDrive.Pages
{
    public class IndexModel : PageModel
    {
        public string Msg;

        private readonly ILogger<IndexModel> _logger;
        AppBDContext AppBD;
        [BindProperty]
        public KikDriveController.Login Login { get; set; }
        public string Usuario { get; set; }
        public object BCrypt { get; private set; }
        public object Net { get; private set; }

        public IndexModel(ILogger<IndexModel> logger, AppBDContext appBD)
        {
            _logger = logger;
            AppBD = appBD;
        }

        public void OnGet()
        {
            Login = new KikDriveController.Login();
        }

        public IActionResult OnPost()
        {
            var _loggin = login(Login.Usuario, Login.Contraseña);
            if(_loggin == null)
            {
                return RedirectToPage("Eror de inicio");
            }
            else
            {
                HttpContext.Session.SetString("Nombre", _loggin.Usuario);
                return RedirectToPage("IniciarSesion", _loggin.Contraseña);
            }
        }      
        private KikDriveController.Login login(string usuario, string contraseña)
        {
            var login = AppBD.Logins.SingleOrDefault(a => a.Usuario.Equals(usuario));
            if( login != null)
            {
                if(BCrypt.Net.BCrypt.Verify(contraseña, login.Contraseña))
                {
                    return login;
                }
                return null;            
            }
        }


        public IActionResult OnGetLogout()
        {
            HttpContext.Session.Remove("Nombre");
            return RedirectToPage("Index");
        }
    }
}
