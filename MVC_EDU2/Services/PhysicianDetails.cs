using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_EDU2.DAL;
using MVC_EDU2.Contracts;

namespace MVC_EDU2.Services
{
    public class PhysicianDetails:IPhysicianDb
    {
        PhysicianDb physiciandb;

      public  PhysicianDetails()
        {
            physiciandb = new PhysicianDb();
        }

        
        public IEnumerable<Physician> GetAllPhysicianDetails()
        {
        
            return (physiciandb.GetAllPhysicians());
        }
    }
}