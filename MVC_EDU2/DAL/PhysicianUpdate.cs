using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_EDU2.Contracts;
using System.Data.Entity;

namespace MVC_EDU2.DAL
{
    public class PhysicianUpdate:IPhysicianUpdateDb
    {
        HospitalEntities db = new HospitalEntities();
        public void UpdatePhysicianDetails(Physician physician)
        {
            db.Entry(physician).State = EntityState.Modified;
            db.SaveChanges();
                
        }
    }
}