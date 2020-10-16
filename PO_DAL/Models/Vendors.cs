using System;
using System.Collections.Generic;

namespace PO_DAL.Models
{
    public partial class Vendors
    {
        public int VendorId { get; set; }
        public string VendorName { get; set; }
        public string EmailId { get; set; }
        public string Address { get; set; }
        public string Status { get; set; }
        public DateTime? Registered { get; set; }
    }
}
