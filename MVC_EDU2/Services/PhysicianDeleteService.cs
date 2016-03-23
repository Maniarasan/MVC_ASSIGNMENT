using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_EDU2.DAL;
namespace MVC_EDU2.Services
{
    public class PhysicianDeleteService
    {
        PhysicianDelete pd = new PhysicianDelete();

        public void DeletePhysician(int id)
        {
            pd.PhysicianRemove(id);
        }

    }
}