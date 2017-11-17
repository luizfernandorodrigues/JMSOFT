using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio.DAO.Repositorios.Base;
using Repositorio.Entidades;

namespace Repositorio.DAO.Repositorios
{
   public class RepositorioT02 : Repositorio<T02>
    {
        /// <summary>
        /// Função para inserir os campos de pesquisa no banco de dados, recebe o objeto carregado e envia para o banco de dados
        /// </summary>
        /// <param name="t02"></param>
        public void inserir(T02 t02)
        {
            using(var camposPesquisa = new RepositorioT02())
            {
                camposPesquisa.Adicionar(t02);
                camposPesquisa.SalvarTodos();
            }
        }

    }
}
