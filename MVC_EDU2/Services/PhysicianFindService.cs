using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_EDU2.DAL;
using MVC_EDU2.Contracts;

namespace MVC_EDU2.Services
{
    public class PhysicianFindService:IPhysicanFromDb
    {
        PhysicianFind pf;

       public PhysicianFindService()
        {

         pf = new PhysicianFind();        
        }
        
        public Physician FindAphysician(int id)
        {
            return(pf.FindPhysician(id));
        }

    }
}