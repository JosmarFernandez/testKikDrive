using System;
using System.Collections.Generic;
using System.Text;

namespace KikDriveController
{
    public class User: BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }

    }
}
