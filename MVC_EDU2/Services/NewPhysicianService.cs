using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_EDU2.DAL;

namespace MVC_EDU2.Services
{
    public class NewPhysicianService
    {
        
        
        NewPhysician newphysician =new NewPhysician();
        public void AddPhysician(Physician physician)
        {
            newphysician.AddNewPhysician(physician);
        }
       

        }
}