using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_EDU2.DAL;
using MVC_EDU2.Contracts;

namespace MVC_EDU2.Services
{
    public class PhysicianDetailsUpdate:IPhysicianUpdateDb
    {
        PhysicianUpdate physicianupdate ;

      public  PhysicianDetailsUpdate()

        {

            physicianupdate = new PhysicianUpdate();
        }

        public void UpdatePhysician(Physician physician)
        {
            physicianupdate.UpdatePhysicianDetails(physician);
        }

    }
}