using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_EDU2.DAL;

namespace MVC_EDU2.Services
{
    public class PhysicianFindService
    {
        
        PhysicianFind pf = new PhysicianFind();


        public Physician FindAphysician(int id)
        {
            return(pf.FindPhysician(id));
        }

    }
}