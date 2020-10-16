using System;
using System.Collections.Generic;
using PO_DAL;
using PO_DAL.Models;

namespace PO_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------VENDOR SYSTEM--------------------");

//            //Add Vendor to Database
//             // AddVendorToDB();

//            //Get Vendor List
//           // GetVendorList();

//            //Add User to Database
//            //  AddUserToDB();

//            //Modify Vendor's details
//           //  modifyVendor();


//        }
//        public static void AddVendorToDB()
//        {

//            //  AddVendor addVendors = new AddVendor();

//            PORepo poObj = new PORepo();
//            var venObj = new Vendors();
//            venObj.VendorId = 1003;
//            venObj.VendorName = "Amrita Pvt ltd";
//            venObj.EmailId = "amrita.vend@amc.com";
//            venObj.Address = "D1/105 Amrita Complex,Mumbai MH 456123";
//            venObj.Status = "Active";
//            venObj.Registered = DateTime.Now;


//            bool status = poObj.AddVendor(venObj);
//            if (status)
//            {
//                Console.WriteLine("Vendor Added successfully");
//            }
//            else
//            {
//                Console.WriteLine("Not Added ...Try Again ");
//            }
//        }

//        //public static void AddUserToDB()
//        //{

//        //    PORepo pOObj = new PORepo();
//        //    Console.Write("Enter the UserID : ");
//        //    string userId = Console.ReadLine();
//        //    Console.Write("Enter the Password : ");
//        //    string pwd = Console.ReadLine();
//        //    bool result = pOObj.AddUser(userId, pwd);

//        //    if (result)
//        //    {
//        //        Console.WriteLine("User Added successfully");
//        //    }
//        //    else
//        //    {
//        //        Console.WriteLine("Try again..!!!");

//        //    }
//        //}

//        public static void modifyVendor()

//        {
//             PORepo poobj = new PORepo();
//           // ModifyVendor modifyVendor = new ModifyVendor();
//            Vendors venobj = new Vendors();
//            Console.WriteLine("--Update Vendors Details--"); Console.WriteLine();
//            Console.Write("Enter Vendor ID: "); int vendID =Int32.Parse(Console.ReadLine());

//            Console.Write("Enter Vendor new Name: "); string vendName = Console.ReadLine();

//            bool res = poobj.modifyVendor(vendID, vendName);
//            if (res)
//            {
//                Console.WriteLine("Vendor's Details Updated successfully");
//                //Console.WriteLine("Updated Vendor's Name is ",venobj.VendorName);
//            }
//            else
//            {
//                Console.WriteLine("Some error occured.Try Again..!!");
//            }
//        }

//        public static void GetVendorList()
//        {
//             PORepo poObj = new PORepo();
//           // GetVendorList getVendorList = new GetVendorList();
//            List<Vendors> vendorList = poObj.GetAllVendors();
//            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------");
//            Console.WriteLine("{0,-15}{1,-30}{2,-30}{3,-45}{4,-10}{5}","VendorId","VendorName","EmailId","Address","Status","Registered");
//            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------------");

//            foreach (var vendor in vendorList)
//            {
//                Console.WriteLine("{0,-15}{1,-30}{2,-30}{3,-45}{4,-10}{5}",vendor.VendorId,vendor.VendorName,vendor.EmailId,vendor.Address,vendor.Status,vendor.Registered);
//            }
//            Console.WriteLine();
        }
    }
}
