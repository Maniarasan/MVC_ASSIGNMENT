using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_EDU2.DAL;
namespace MVC_EDU2.Services
{
    public class PhysicianDetailsUpdate
    {
        PhysicianUpdate physicianupdate = new PhysicianUpdate();

        public void UpdatePhysician(Physician physician)
        {
            physicianupdate.UpdatePhysicianDetails(physician);
        }

    }
}