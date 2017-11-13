using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public static class Utils
    {
        public const string TITULO = "JMSoft";
        public static string VERSAO = "Versão 1.1.1";
        public const string BOTAO_NOVO = "Adicionar Registro!";
        public const string BOTAO_EDITAR = "Editar Registro!";
        public const string BOTAO_EXCLUIR = "Excluir Registro!";
        public const string BOTAO_DESFAZER = "Desfazer Alterações!";
        public const string BOTAO_SAIR = "Sair da Tela!";
        public const string BOTAO_PRIMEIRO = "Primeiro Registro!";
        public const string BOTAO_ULTIMO = "Ultimo Registro!";
        public const string BOTAO_ANTERIOR = "Registro Anterior!";
        public const string BOTAO_PROXIMO = "Próximo Registro!";
        public const string BOTAO_RELATORIO = "Abrir Relatórios!";
        public const string BOTAO_PESQUISA = "Abrir Pesquisa!";
        public const string BOTAO_SALVAR = "Gravar Registro!";
        public const string MENSAGEM_SUCESSO = "Registro Gravado com Sucesso!";
        public const string MENSAGEM_ERRO = "Não Foi Possivel Gravar o Registro!\n Causa: ";


        public enum Flags
        {
            Novo = 1,
            Editar = 2,
            Excluir = 3
        };
        /// <summary>
        /// Função para habilitar o botão novo do form, quando chamada a função habilita
        /// os campos e desabilita os botões desnecessarios para o estado de inclusão
        /// </summary>
        /// <param name="ctrl"></param>
        public static void HabilitaCamposNovo(Control ctrl)
        {
            foreach (Control c in ctrl.Controls)
            {
                if (c is NumericUpDown)
                {
                    c.Enabled = true;
                }
                else if (c is CheckBox)
                {
                    c.Enabled = true;
                }
                else if (c is DateTimePicker)
                {
                    c.Enabled = true;
                }
                else if (c is TextBox)
                {
                    c.Enabled = true;
                }
                else if (c is RadioButton)
                {
                    c.Enabled = true;
                }
                else if (c is ComboBox)
                {
                    c.Enabled = true;
                }
                else if (c is MaskedTextBox)
                {
                    c.Enabled = true;
                }
                else if (c is Button)
                {
                    c.Enabled = true;
                }
                if (c.HasChildren)
                {
                    HabilitaCamposNovo(c);
                }
            }
            desabilitaBotoesNovo(ctrl);
        }

        /// <summary>
        /// Função para desabilitar os botões quando o form entra em estado de inclusão
        /// </summary>
        /// <param name="ctr"></param>
        public static void desabilitaBotoesNovo(Control ctr)
        {
            foreach(Control c in ctr.Controls)
            {
                if (c is Button && c.Name.Equals("buttonExcluir"))
                {
                    c.Enabled = false;
                }
                else if (c is Button && c.Name.Equals("buttonSair"))
                {
                    c.Enabled = false;
                }
                else if (c is Button && c.Name.Equals("buttonPesquisa"))
                {
                    c.Enabled = false;
                }
                else if (c is Button && c.Name.Equals("buttonProximo"))
                {
                    c.Enabled = false;
                }
                else if (c is Button && c.Name.Equals("buttonUltimo"))
                {
                    c.Enabled = false;
                }
                else if (c is Button && c.Name.Equals("buttonAnterior"))
                {
                    c.Enabled = false;
                }
                else if (c is Button && c.Name.Equals("buttonPrimeiro"))
                {
                    c.Enabled = false;
                }
                else if (c is Button && c.Name.Equals("buttonNovo"))
                {
                    c.Enabled = false;
                }
                else if (c is Button && c.Name.Equals("buttonEditar"))
                {
                    c.Enabled = false;
                }
                else if (c is Button && c.Name.Equals("buttonRelatorio"))
                {
                    c.Enabled = false;
                }
                if (c.HasChildren)
                {
                    desabilitaBotoesNovo(c);
                }
            }
        }
    }


}
