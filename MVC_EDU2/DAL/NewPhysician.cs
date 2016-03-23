using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_EDU2.DAL
{
    public class NewPhysician
    {
        HospitalEntities hospitalentities = new HospitalEntities();
        public void AddNewPhysician(Physician physician)
        {
          
                hospitalentities.Physicians.Add(physician);
                hospitalentities.SaveChanges();
             
        }

 
    }
}