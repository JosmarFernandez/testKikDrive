using System;
using System.Collections.Generic;
using System.Text;

namespace KikDriveController
{
    public interface IEntity
    {
        public string Usuario { get; set; }
        public string Contraseña { get; set; }

    }
}
