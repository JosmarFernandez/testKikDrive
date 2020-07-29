using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KikDriveController
{
    public class Paradas : BaseEntity
    {
        [DisplayName("Incidentes:")]
        [Required (ErrorMessage ="Es necesario")]
        public int Incidentes { get; set; }
        [DisplayName("Tipo de Incidente:")]
        [Required(ErrorMessage = "Es necesario")]
        public string Tipo_incidente { get; set; }
        [DisplayName("Fecha de Parada:")]
        [Required(ErrorMessage = "Es necesario")]
        public string Fecha { get; set; }
        [DisplayName("Hora de Parada:")]
        [Required(ErrorMessage = "Es necesario")]
        public int Hora { get; set; }
        [DisplayName("Ruta Tomada:")]
        [Required(ErrorMessage = "Es necesario")]


        [ForeignKey("Rutas")]
        public int RutasId { get; set; }
        public Rutas Rutas { get; set; }


    }
}
