﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.DAO.Contexto
{
    public class BDContexto : DbContext
    {
        public BDContexto()
            
            : base("JMSOFT") { }


    }
}