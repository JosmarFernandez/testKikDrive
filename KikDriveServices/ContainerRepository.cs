using KikDriveController;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KikDriveServices
{
    public class ContainerRepository: SQLRepository<SupervisorA>, IContainerRepository
    {
        public ContainerRepository(AppBDContext context) : base(context) { }    
        public IEnumerable<Login> GetLogin()
        {
            return context.Set<Login>().AsEnumerable();
        }
       
        }
    
    }

