using Repositorio.DAO.Repositorios.Base;
using Repositorio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.DAO.Repositorios
{
   public class RepositorioA22 : Repositorio<A22>
    {

        public void adicionar(A22 a22)
        {
            using (var pais = new RepositorioA22())
            {
                pais.Adicionar(a22);
                pais.SalvarTodos();
            }

        }
    }
}
