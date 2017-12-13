using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FormBase : Form
    {
        private int flag = 1;
        public FormBase()
        {
            InitializeComponent();
        }

        private void FormBase_Load(object sender, EventArgs e)
        {
            toolTipFormBase.SetToolTip(buttonAnterior, Utils.BOTAO_ANTERIOR);
            toolTipFormBase.SetToolTip(buttonDesfazer, Utils.BOTAO_DESFAZER);
            toolTipFormBase.SetToolTip(buttonEditar, Utils.BOTAO_EDITAR);
            toolTipFormBase.SetToolTip(buttonExcluir, Utils.BOTAO_EXCLUIR);
            toolTipFormBase.SetToolTip(buttonNovo, Utils.BOTAO_NOVO);
            toolTipFormBase.SetToolTip(buttonProximo, Utils.BOTAO_PROXIMO);
            toolTipFormBase.SetToolTip(buttonSair, Utils.BOTAO_SAIR);
            toolTipFormBase.SetToolTip(buttonSalvar, Utils.BOTAO_SALVAR);
            toolTipFormBase.SetToolTip(buttonUltimo, Utils.BOTAO_ULTIMO);
            toolTipFormBase.SetToolTip(buttonPrimeiro, Utils.BOTAO_PRIMEIRO);
            toolTipFormBase.SetToolTip(buttonRelatorio, Utils.BOTAO_RELATORIO);
            toolTipFormBase.SetToolTip(buttonPesquisa, Utils.BOTAO_PESQUISA);

        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            Utils.habilitaCamposNovos(this);
            flag = 1;
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void buttonDesfazer_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                Utils.desfazerEstadoNovo(this);
            }
        }
    }
}
