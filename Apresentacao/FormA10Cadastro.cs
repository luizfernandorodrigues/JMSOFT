using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Repositorio.Entidades;

namespace Apresentacao
{
    public partial class FormA10Cadastro : Apresentacao.FormBase
    {
        public FormA10Cadastro()
        {
            InitializeComponent();
        }
        //função botão novo
        private void buttonNovo_Click(object sender, EventArgs e)
        {

        }

        //função gravar
        private void gravar()
        {
            //declaro objeto
            A10 a10 = new A10();

            a10.A10_001_c = textBoxCodigo.Text;
            a10.A10_002_c = textBoxFantasia.Text;
            a10.A10_003_c = textBoxRazaoSocial.Text;
            a10.A10_004_c = textBoxLogradouro.Text;
            a10.A10_005_c = textBoxNumero.Text;
            a10.A10_006_c = textBoxBairro.Text;
            a10.A10_007_c = textBoxComplemento.Text;
            a10.A10_009_c = maskedTextBoxFone.Text;
            a10.A10_010_c = maskedTextBoxFax.Text;
            a10.A10_011_c = maskedTextBoxCelular.Text;
            a10.A10_012_c = textBoxEmail.Text;
            a10.A10_013_c = textBoxSite.Text;
            a10.A10_014_d = Convert.ToDateTime(maskedTextBoxDataInicio.Text);
        }

        private void FormA10Cadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
