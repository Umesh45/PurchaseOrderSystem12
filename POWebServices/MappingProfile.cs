using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PO_DAL.Models;


namespace POWebServices
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Vendors, Models.Vendors>();
            CreateMap<Models.Vendors, Vendors>();
        }
    }
}
