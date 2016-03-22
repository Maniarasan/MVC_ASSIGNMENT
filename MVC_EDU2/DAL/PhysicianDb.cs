using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_EDU2.Contracts;

namespace MVC_EDU2.DAL
{
    public class PhysicianDb:IPhysicianDb
    {

        HospitalEntities hospitalentities = new HospitalEntities();

        public IEnumerable<Physician> GetAllPhysicians()
        {
            return (hospitalentities.Physicians);
        }
    }
}