using System;
using System.Collections.Generic;
using System.Text;

namespace PO_DAL
{
   public class IVendors
    {
       int VendorId { get; set; }
         string VendorName { get; set; }
         string EmailId { get; set; }
         string Address { get; set; }
         string Status { get; set; }
         DateTime? Registered { get; set; }
    }
}
