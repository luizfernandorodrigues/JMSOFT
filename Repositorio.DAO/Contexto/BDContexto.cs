using Repositorio.Entidades;
using System;
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

        public DbSet<A22> A22 { get; set; }
        public DbSet<A23> A23 { get; set; }
        public DbSet<A24> A24 { get; set; }
        public DbSet<A25> A25 { get; set; }


    }
}
