using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
            Utils.habilitaCamposNovos(this);
        }
    }
}
