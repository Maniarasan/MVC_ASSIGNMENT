using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_EDU2.DAL;
using MVC_EDU2.Contracts;

namespace MVC_EDU2.Services
{
    public class SpecialityService:ISpecialityDb
    {
        SpecialityFetch specialityfetch;

       public SpecialityService()
        {
            specialityfetch = new SpecialityFetch();

        }

        public IEnumerable<Speciality> GetSpecialityList()
        {
            return specialityfetch.GetSpecialitiesList();
        }





    }
}