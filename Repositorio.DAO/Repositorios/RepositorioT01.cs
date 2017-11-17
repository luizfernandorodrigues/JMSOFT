using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio.Entidades;
using Repositorio.DAO.Repositorios.Base;

namespace Repositorio.DAO.Repositorios
{
   public class RepositorioT01 : Repositorio<T01>
    {
        /// <summary>
        /// Função para inserir a capa do cadastro de pesquisas, recebe o objeto T01 como parametro carregado.
        /// </summary>
        /// <param name="t01"></param>
        public void adicionar(T01 t01)
        {
            using (var cadastroPesquisa = new RepositorioT01())
            {
                //using (DbContextTransaction tran = cadastroPesquisa.)
                cadastroPesquisa.Adicionar(t01);
                cadastroPesquisa.SalvarTodos();
            }
        }
    }
}
