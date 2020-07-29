using System;

namespace KikDriveController
{
    public class BaseEntity :IEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAT { get; set; } = DateTime.Now;
        public DateTime? UpdatedAT { get; set; }
        public bool Status { get; set; } = true;
    }
}
