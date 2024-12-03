using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skynet.ERP.Domains
{
    public class BaseClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
//<Company>.(<Product>|<Technology>)[.<Feature>][.<Subnamespace>]
