﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_EDU2.DAL
{
    public class PhysicianFind
    {
        HospitalEntities db = new HospitalEntities();
        public Physician FindPhysician(int id)
        {
            return(db.Physicians.Find(id));
        }
    }
}