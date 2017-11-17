using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio.DAO.Repositorios.Base;
using Repositorio.Entidades;
using System.Windows.Forms;

namespace Repositorio.DAO.Repositorios
{
    public class RepositorioUsuario : Repositorio<Usuario>
    {
        /// <summary>
        /// Função que insere um usuario no banco de dados, recebe o objeto e persiste no banco
        /// </summary>
        /// <param name="usuario"></param>
        public void adicionar(Usuario usuario)
        {
            using (var user = new RepositorioUsuario())
            {
                user.Adicionar(usuario);
                user.SalvarTodos();
            }

        }
        /// <summary>
        /// Função para alterar um usuario no banco de dados, recebe o objeto e persiste no banco de dados
        /// </summary>
        /// <param name="usuario"></param>
        public void editar(Usuario usuario)
        {

        }
        /// <summary>
        /// função para excluir um usuario no banco de dados, recebe o objeto e efetiva a exclusão no banco de dados
        /// </summary>
        /// <param name="usuario"></param>
        public void excluir(Usuario usuario)
        {

        }

        public List<Usuario> pesquisaPorLogin(string login)
        {
            List<Usuario> user = new List<Usuario>();
            using (var repositorioUsuario = new RepositorioUsuario())
            {
                user = repositorioUsuario.Get(u => u.Login.Equals(login)).ToList<Usuario>();
                return user;
            }

           
        }
    }
}
