using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KikDriveController
{
    public class Supervision: BaseEntity
    {
        [DisplayName("Paradas:")]
        [Required(ErrorMessage = "Es necesario")]
        public string Paradas { get; set; }
        [DisplayName("Ruta:")]
        [Required(ErrorMessage = "Es necesario")]
        public string Rutas { get; set; }
        [DisplayName("Vehiculo:")]
        [Required(ErrorMessage = "Es necesario")]
        public string Vehiculo { get; set; }
        [DisplayName("Conductor:")]
        [Required(ErrorMessage = "Es necesario")]
        public string Conductor { get; set; }
        
        [ForeignKey("SupervisorA")]
        public int SupervisorId { get; set; }
        public SupervisorA SupervisorA { get; set; }
       

       

    }
}
