using PO_DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PO_DAL
{
   public interface IPORepo
    {
        List<Vendors> GetAllVendors();

        bool modifyVendor(int vendId, string vendName);
        bool AddVendor(Vendors vendObj);
       // bool AddUser(string userId, string pwd);
        bool deleteVendor(int vendorId);
        Vendors vendorById(int vendId);
    }
}
