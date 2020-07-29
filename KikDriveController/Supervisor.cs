using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KikDriveController
{
    public class SupervisorA : BaseEntity
    {
        
        [DisplayName("Nombre:")]
        [Required(ErrorMessage = "El Nombre es Requerido")]
        public string Nombre { get; set; }
        [DisplayName("Apellido Paterno:")]
        [Required(ErrorMessage = "El Apellido Paterno es Requerido")]
        public string Apellido_Paterno { get; set; }
        [DisplayName("Apellido Materno:")]
        [Required(ErrorMessage = "El Apellido Materno es Requerido")]
        public string Apellido_Materno { get; set; }
        [DisplayName("Usuario:")]
        [Required(ErrorMessage = "El Usuario es Requerido")]
        public string Usuario { get; set; }
        [DisplayName("Contraseña:")]
        [Required(ErrorMessage = "El Contraseña es Requerido")]
        public string Contraseña { get; set; }
        [DisplayName("Telefono:")]
        [Required(ErrorMessage = "El Telefono es Requerido")]
        public string Telefono { get; set; }
      
        public Login Login { get; set; }

        public Supervision Supervision { get; set; }

        



    }
}
