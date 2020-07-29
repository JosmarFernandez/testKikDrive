using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KikDriveController
{
    public class Vehiculo : BaseEntity
    {
        [DisplayName("Placa:")]
        [Required(ErrorMessage = "La Placa es Requerido")]
        public char Placa { get; set; }
        [DisplayName("Marca:")]
        [Required(ErrorMessage = "La Marca es Requerido")]
        public string Marca { get; set; }
        [DisplayName("Modelo:")]
        [Required(ErrorMessage = "El Modelo es Requerido")]
        public int Modelo { get; set; }
        [DisplayName("Dimenciones:")]
        [Required(ErrorMessage = "Las Dimenciones son Requeridas")]
        public string Dimensiones { get; set; }
        [DisplayName("Capacidad de Pasajeros:")]
        [Required(ErrorMessage = "La Capacidad de Pasajeros es Requerido")]
        public int Capacidad { get; set; }

        public Conductor Conductor { get; set; }
        
    }
}
