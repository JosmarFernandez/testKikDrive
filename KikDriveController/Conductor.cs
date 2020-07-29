using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KikDriveController
{
    
    public class Conductor:BaseEntity
    {
        
        [DisplayName("Nombre:")]
        [Required(ErrorMessage = "El Nombre del Conductor es Requerido")]
        public string Nombre { get; set; }
        [DisplayName("Apellido Paterno:")]
        [Required(ErrorMessage = "El Apellido Paterno del Conductor es Requerido")]
        public string Apellido_Paterno { get; set; }
        [DisplayName("Apellido Materno:")]
        [Required(ErrorMessage = "El Apellido Materno del Conductor es Requerido")]
        public string Apellifo_Materno { get; set; }
        [DisplayName("Tipo de Licencia:")]
        [Required(ErrorMessage = "El Tipo de Liciencia del Conductor es Requerido")]
        public string Tipo_liciencia { get; set; }
        [DisplayName("Vehiculo Asignado:")]
        [Required(ErrorMessage = "El Vehiculo Asignado al Conductor es Requerido")]
        public char Vehiculos { get; set; }
       
        [Required(ErrorMessage = "Vehiculo es requerido")]
        [ForeignKey("Vehiculo")]
        public int VehiculoId { get; set; }
        public Vehiculo Vehiculo { get; set; }

        

    }
}
