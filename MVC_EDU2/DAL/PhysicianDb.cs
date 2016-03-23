using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace MVC_EDU2.DAL
{
    public class PhysicianDb
    {

        HospitalEntities hospitalentities = new HospitalEntities();

        public IEnumerable<Physician> GetAllPhysicians()
        {
            return (hospitalentities.Physicians);
        }
    }
}