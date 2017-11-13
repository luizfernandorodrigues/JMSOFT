using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Repositorio.Entidades;
using Repositorio.DAO.Repositorios;
namespace Apresentacao
{
    public partial class FormUsuarioCadastro : Apresentacao.FormBase
    {
        private int flag = 1;

        public FormUsuarioCadastro()
        {
            InitializeComponent();
        }

        private void FormUsuarioCadastro_Load(object sender, EventArgs e)
        {

        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {

        }

        private void novo()
        {
            flag = 1;
            Usuario usuario = new Usuario();
            usuario.Email = textBoxEmail.Text;
            usuario.Login = textBoxUsuario.Text;
            usuario.Nome = textBoxNomeUsuario.Text;
            usuario.Porta = textBoxPortaSmtp.Text;
            usuario.Senha = textBoxSenha.Text;
            usuario.SenhaEmail = textBoxSenhaEmail.Text;
            usuario.ServidorEmail = textBoxServidorEmail.Text;

            if (checkBoxSsl.Checked)
            {
                usuario.Ssl = 1;
            }
            else
            {
                usuario.Ssl = 0;
            }

            usuario.Ukey = System.Guid.NewGuid();
            usuario.UsuarioEmail = textBoxUsuarioEmail.Text;
            usuario.Horario = DateTime.Now;
            usuario.Timestamp = DateTime.Now;

            using (var user = new RepositorioUsuario())
            {
                Validacao.ValidarEntidade(usuario);
                user.Adicionar(usuario);
                user.SalvarTodos();
            }

           

            //user.adicionar(usuario);


        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                try
                {
                    novo();
                    MessageBox.Show(Utils.MENSAGEM_SUCESSO, Utils.TITULO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Utils.MENSAGEM_ERRO + ex.ToString(), Utils.TITULO, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(ex.Data);
                    return;
                    
                }
            }
        }
    }
}
