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
            toolTipFormBase.SetToolTip(buttonPesquisa, Utils.BOTAO_pesq);
        }
    }
}
