using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_mod3.Data
{
   public class RegistrationAddressClass
    {
        public string Country { get; set; } = default!;
        public string Region { get; set; } = default!;
        public string City { get; set; } = default!;
        public string AddressPart { get; set; } = default!;
    }
}
