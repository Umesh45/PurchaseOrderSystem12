using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POWebServices.Interfaces
{
  public  interface IVendor
    {
         int VendorId { get; set; }
         string VendorName { get; set; }
         string EmailId { get; set; }
         string Address { get; set; }
         string Status { get; set; }
         DateTime? Registered { get; set; }
    }
}
