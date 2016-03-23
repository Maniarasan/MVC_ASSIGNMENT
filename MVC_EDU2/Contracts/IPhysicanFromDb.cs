using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_EDU2.Contracts
{
    interface IPhysicanFromDb
    {
        Physician FindPhysician(int id);
    }
}
