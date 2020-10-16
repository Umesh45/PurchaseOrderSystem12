using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PO_DAL.Models;

using System.Threading.Tasks;
using Microsoft.Azure.KeyVault;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
namespace PO_DAL
{
    public class PORepo:IPORepo
    {
        mydatabase12Context context;
        public PORepo(mydatabase12Context _context)
        {
            context = _context;
        }
        //Add user Methods
        //public bool AddUser(string userId, string pwd)
        //{
        //    bool status = false;
        //    Users userObj = new Users();
        //    userObj.UserId = userId;
        //    userObj.Password = pwd;
        //    try
        //    {
        //        context.Users.Add(userObj);
        //        context.SaveChanges();
        //        status = true;

        //    }
        //    catch (Exception)
        //    {

        //        status = false;

        //    }
        //    return status;

        //}
        //Add vendors

        public bool AddVendor(Vendors vendObj)
        {//hkjdkjldsjgkjjhgjhgdhgjkd
            bool status = false;
            try
            {
                context.Vendors.Add(vendObj);
                context.SaveChanges();
                status = true;
            }
            catch (Exception)
            {

                status = false;
            }

            return status;
        }

        //modify vendor's details
        public bool modifyVendor(int vendId, string vendName)
        {
            bool status = false;
            try
            {
                Vendors vendObj = context.Vendors.Find(vendId);
                if (vendObj != null)
                {
                    vendObj.VendorName = vendName;
                    context.SaveChanges();
                    status = true;
                }
                else
                {
                    Console.WriteLine("Entered Vendor Id Is not Found");
                    status = false;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                status = false;
            }
            return status;
        }

        //Read vendor's data
        public List<Vendors> GetAllVendors()
        {
            var vendorList = context.Vendors.ToList();

            return vendorList;
        }

        //  Remove vendor
        public bool deleteVendor(int vendorId)
        {
            Vendors venObj = null;
            bool status = false;
            try
            {
                venObj = context.Vendors.Find(vendorId);
                if (venObj != null)
                {
                    context.Vendors.Remove(venObj);
                    context.SaveChanges();
                    status = true;
                }

            }
            catch (Exception)
            {

                status = false;
            }
            return status;
        }

        public Vendors vendorById(int vendId)
        {
            Vendors venobj = new Vendors();
            try
            {
                venobj = context.Vendors.Find(vendId);
            }
            catch (Exception)
            {

                venobj = null;
            }
            return venobj;
        }

        //public Vendors vendorByName(string vendorName)
        //{
        //    Vendors venobj = new Vendors();
        //    try
        //    {
        //        venobj = context.Vendors.Find(vendorName);
        //    }
        //    catch (Exception)
        //    {

        //        venobj = null;
        //    }
        //    return venobj;
        //}

        //Getting Connection String

        //getting connection string
        public async static Task<string> KeyVault123()
        {
            const string APP_CLIENT_ID = "396146d8-df07-4d68-be75-48a101540af3";
            const string APP_CLIENT_SECRET = "WqvW13hI956_C~P6n~I15_FP.jfiW0Id4_";
            const string KEYVAULT_BASE_URI = "https://sample-vault123.vault.azure.net/";

            var kvc = new KeyVaultClient(new KeyVaultClient.AuthenticationCallback(
                async (string authority, string resource, string scope) =>
                {
                    var authContext = new AuthenticationContext(authority);
                    var credentials = new ClientCredential(APP_CLIENT_ID, APP_CLIENT_SECRET);
                    AuthenticationResult result = await authContext.AcquireTokenAsync(resource, credentials);

                    if (result == null)
                    {
                        throw new InvalidOperationException("Failed to retrieve JWT token");
                    }
                    return result.AccessToken;
                }
                ));

            var secretBundle = await kvc.GetSecretAsync(KEYVAULT_BASE_URI, "dbconstr1");
            return secretBundle.Value;


            // Console.WriteLine("Secret:" + secretBundle.Value);
            //Console.ReadKey();

        }

    }
}
