using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KikDriveController
{
    public class Rutas: BaseEntity
    {
        [DisplayName("Nombre de la Ruta:")]
        [Required(ErrorMessage = "El Nombre de la Ruta es Requerido")]
        public string Nombre { get; set; }
        [DisplayName("Tramos de la Ruta:")]
        [Required(ErrorMessage = "Los Tramo de la Ruta es Requerido")]
        public int Tramos { get; set; }

        public Paradas Paradas { get; set; }

        
    }
}
