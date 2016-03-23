using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_EDU2.DAL;
using MVC_EDU2.Contracts;



namespace MVC_EDU2.Services
{
    public class PhysicianDeleteService:IphysicianRemoveFromDb
    {
        PhysicianDelete pd;

       public PhysicianDeleteService()
        {

            pd = new PhysicianDelete();

        }


        public void DeletePhysician(int id)
        {
            pd.PhysicianRemove(id);
        }

    }
}