using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KikDriveController
{
    public class Login : BaseEntity
    {
        [DisplayName("Usuario:")]
        [Required(ErrorMessage = "El Usuario es Requerido")]
        public string Usuario { get; set; }
        [DisplayName("Contraseña:")]
        [Required(ErrorMessage = "La Contraseña es Requerido")]
        [MinLength(6, ErrorMessage = "Agregue o Quite Elementos")]
        public string Contraseña { get; set; }

        [ForeignKey("SupervisorA")]
        public int SupervisorId { get; set; }
        public SupervisorA SupervisorA { get; set; }       
    } 

}
