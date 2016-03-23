using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_EDU2.DAL;
using MVC_EDU2.Contracts;

namespace MVC_EDU2.Services
{
    public class NewPhysicianService:IPhysicianStore
    {


        NewPhysician newphysician;

     public   NewPhysicianService()
        {
            newphysician = new NewPhysician();
        }

        public void AddPhysician(Physician physician)
        {
            newphysician.AddNewPhysician(physician);
        }
       

        }
}