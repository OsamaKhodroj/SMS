using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skynet.ERP.Domains
{
    public enum OpStatus
    {
        None = 0,
        Added = 1,
        Exists = 2,
        Error = 3,
        Sucess = 4
    }
}
