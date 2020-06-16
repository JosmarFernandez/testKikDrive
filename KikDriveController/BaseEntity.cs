using System;

namespace KikDriveController
{
    public class BaseEntity :IEntity
    {
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
    }
}
