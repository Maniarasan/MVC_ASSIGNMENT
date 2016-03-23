using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_EDU2.Contracts
{
    interface IphysicianRemoveFromDb
    {
        void DeletePhysician(int id);
    }
}
