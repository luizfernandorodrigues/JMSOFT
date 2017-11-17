using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repositorio.DAO.Repositorios;
using Repositorio.Entidades;


namespace Apresentacao
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            validaUser(textBoxUsuario.Text);

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void validaUser(string login)
        {
            List<Usuario> user = new List<Usuario>();
            RepositorioUsuario repUser = new RepositorioUsuario();

            user = repUser.pesquisaPorLogin(login);

            if (user.Count == 0)
            {
                MessageBox.Show("Usuário não encontrado", Utils.TITULO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                Utils.usuarioLogado = user[0].Ukey;
            }
        }
    }
}
