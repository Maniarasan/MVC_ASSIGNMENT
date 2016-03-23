using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_EDU2.DAL
{
    public class PhysicianDelete
    {
        HospitalEntities db = new HospitalEntities();
        public void PhysicianRemove(int id)
        {
            Physician physician = db.Physicians.Find(id);
            db.Physicians.Remove(physician);
            db.SaveChanges();
        }
    }
}