using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_EDU2.Contracts
{
    public interface IPhysicianStore
    {
        void AddNewPhysician(Physician physician);
    }
}