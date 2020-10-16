using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PO_DAL;
using PO_DAL.Models;
using POWebServices.Interfaces;

namespace POWebServices.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class VendorController : ControllerBase
    {
        private readonly IPORepo _repoObj;
        private readonly IMapper _mapper;



        //kjdf
        //more changes

        public VendorController(IPORepo repoObj, IMapper mapper)
        {
            _repoObj = repoObj;
            _mapper = mapper;
           // MessageSender = messageSender;
        }



        [HttpGet]
        public JsonResult getVendors()
        {
            List<Models.Vendors> vendorList_Service = new List<Models.Vendors>();
            try
            {
                List<Vendors> vendorList_DAL = _repoObj.GetAllVendors();
                if (vendorList_DAL != null)
                {
                    foreach (var DALvendor in vendorList_DAL)
                    {
                        Models.Vendors ServiceVendor = _mapper.Map<Models.Vendors>(DALvendor);
                        vendorList_Service.Add(ServiceVendor);
                    }
                }

            }
            catch (Exception)
            {

                vendorList_Service = null;
            }
            return new JsonResult(vendorList_Service);
        }

        [HttpPost]
        public JsonResult addVender(Models.Vendors serviceVendor)
        {
            bool status = false;
            try
            {
                status = _repoObj.AddVendor(_mapper.Map<Vendors>(serviceVendor));
            }
            catch (Exception)
            {

                status = false;
            }
            return new JsonResult(status);
        }

        [HttpPut]
        public JsonResult updateVendor(int vendId, string vendName)
        {
            bool status = false;
            try
            {
                status = _repoObj.modifyVendor(vendId, vendName);
            }
            catch (Exception)
            {

                status = false;
            }
            return new JsonResult(status);
        }

        [HttpDelete]
        public JsonResult removeVendor(int vendorId)
        {
            bool status = false;
            try
            {
                status = _repoObj.deleteVendor(vendorId);

            }
            catch (Exception)
            {

                status = false;
            }
            return new JsonResult(status);
        }

        // GET: api/Vendor
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Vendor/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }



        // POST: api/Vendor
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Vendor/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }

   
}
