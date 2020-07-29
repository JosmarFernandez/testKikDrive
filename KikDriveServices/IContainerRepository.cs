using KikDriveController;
using System;
using System.Collections.Generic;
using System.Text;

namespace KikDriveServices
{
    public interface IContainerRepository: IRepository<SupervisorA>
    {                   
        public IEnumerable<Login> GetLogin();
        
        
    }
}
