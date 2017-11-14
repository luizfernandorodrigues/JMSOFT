using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public class PreencheCombobox
    {
        public string descricao { get; set; }
        public string valor { get; set; }

        /// <summary>
        /// Função para preencher as combobox com os nome dos filtros para os campos da pesquisa, e ja setand valores nas mesma.
        /// </summary>
        /// <param name="comboBox"></param>
        /// <returns></returns>
        public static ComboBox filtroPesquisa(ComboBox comboBox)
        {
            List<PreencheCombobox> list = new List<PreencheCombobox>();
            list.Add(new PreencheCombobox { descricao = "Iniciado Por", valor = "1" });
            list.Add(new PreencheCombobox { descricao = "Igual", valor = "2" });
            list.Add(new PreencheCombobox { descricao = "Terminado Por", valor = "3" });
            list.Add(new PreencheCombobox { descricao = "Maior Igual", valor = "4" });
            list.Add(new PreencheCombobox { descricao = "Menor Igual", valor = "5" });
            list.Add(new PreencheCombobox { descricao = "Contem", valor = "6" });
            list.Add(new PreencheCombobox { descricao = "Esta Contido", valor = "7" });
            list.Add(new PreencheCombobox { descricao = "Diferente", valor = "8" });
            list.Add(new PreencheCombobox { descricao = "Não Contem", valor = "9" });
            list.Add(new PreencheCombobox { descricao = "Não Esta Contido", valor = "10" });
            return comboBox;
        }
    }
}
