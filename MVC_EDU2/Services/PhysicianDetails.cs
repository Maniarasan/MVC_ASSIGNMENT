using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_EDU2.DAL;

namespace MVC_EDU2.Services
{
    public class PhysicianDetails
    {

        private HospitalEntities hospitalentities = new HospitalEntities();
        
        public IEnumerable<Physician> GetAllPhysicianDetails()
        {
            PhysicianDb physiciandb = new PhysicianDb();
            return (physiciandb.GetAllPhysicians());
        }
    }
}