using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_EDU2.Contracts;
using MVC_EDU2.DAL;
namespace MVC_EDU2.Services
{
    public class HospitalService:IHospitalDb
    {
        HospitalFetch hospitalfetcher;
     public   HospitalService()
        { 
        hospitalfetcher = new HospitalFetch();
        }

        public IEnumerable<Hospital> GetAllHospital()
        {
            return hospitalfetcher.FetchAllHospitalNames();
        }
    }
}