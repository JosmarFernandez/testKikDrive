using KikDriveController;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace KikDriveServices
{
    public class AppBDContext : DbContext
    {
        public AppBDContext(DbContextOptions<AppBDContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Login> Logins { get; set; }      
        public DbSet<SupervisorA> Supervisors { get; set; }
        public DbSet<Vehiculo> Vehiculos { get; set; }
        public DbSet<Conductor> Conductors { get; set; }
        public DbSet<Supervision> Supervisions { get; set; }
        public DbSet<Rutas> Rutas { get; set; }
        public DbSet<Paradas> Paradas { get; set; }
        
        



    }
}
