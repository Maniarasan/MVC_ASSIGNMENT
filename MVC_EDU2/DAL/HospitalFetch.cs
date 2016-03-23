using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_EDU2.DAL
{
    public class HospitalFetch
    {
        HospitalEntities db = new HospitalEntities();

      public  IEnumerable<Hospital> FetchAllHospitalNames()
        {
         return db.Hospitals.ToList<Hospital>();
        }



    }
}