using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace MVC_EDU2.DAL
{
    public class SpecialityFetch
    {
        HospitalEntities db = new HospitalEntities();

        public IEnumerable<Speciality> GetSpecialitiesList()
        {
            return db.Specialities.ToList<Speciality>();
        }
    }
}