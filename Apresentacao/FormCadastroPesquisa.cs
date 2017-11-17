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
    public partial class FormCadastroPesquisa : Apresentacao.FormBase
    {
        public FormCadastroPesquisa()
        {
            InitializeComponent();
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            novo();
        }

        private void novo()
        {
            Utils.habilitaCamposNovos(this);
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {

        }

        private void inserir()
        {
            //instancia os objetos na memória
            T01 t01 = new T01();
            T02 t02 = new T02();
            RepositorioT01 repositorioT01 = new RepositorioT01();
            RepositorioT02 repositorioT02 = new RepositorioT02();

            //preenche as propriedades do objeto T01
            t01.T01_001_c = textBoxCodigo.Text;
            t01.T01_002_c = textBoxDescricao.Text;
            t01.T01_003_c = textBoxSQL.Text;
            t01.Ukey = System.Guid.NewGuid();
            t01.Timestamp = DateTime.Now;
            t01.User_note = Utils.usuarioLogado;

            //preenche as propriedades do objeto T02
            t02.T01_ukey = t01.Ukey;
            t02.User_note = Utils.usuarioLogado;

            
            




        }
    }
}
