using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_EDU2.Contracts;
namespace MVC_EDU2.DAL
{
    public class NewPhysician:IPhysicianStore
    {
        HospitalEntities hospitalentities = new HospitalEntities();
        public void AddNewPhysician(Physician physician)
        {
          
                hospitalentities.Physicians.Add(physician);
                hospitalentities.SaveChanges();
             
        }

 
    }
}