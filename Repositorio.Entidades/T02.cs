using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Repositorio.Entidades
{
    public class T02 : AbstractModel
    {
        private string t02_001_c;
        private string t02_002_c;
        private int t02_003_n;
        private int t02_004_n;
        private string t02_005_c;
        private string t02_006_c;
        private string t02_007_n;
        private Guid t01_ukey;
        private T01 t01;

        [Column(TypeName = "nvarchar")]
        [Required(ErrorMessage = "Campo tabela do sistema é obrigatorio!")]
        [Display(Name = "Tabela")]
        [StringLength(15)]
        public string T02_001_c { get => t02_001_c; set => t02_001_c = value; }

        [Column(TypeName = "nvarchar")]
        [Required(ErrorMessage = "coluna campo da tabela é obrigatório!")]
        [Display(Name = "Campo Tabela")]
        [StringLength(30)]
        public string T02_002_c { get => t02_002_c; set => t02_002_c = value; }

        [DataType("numeric(2,0)")]
        [Required(ErrorMessage = "operador é obrigatório!")]
        [Display(Name = "operador")]
        public int T02_003_n { get => t02_003_n; set => t02_003_n = value; }

        [DataType("numeric(2,0)")]
        [Required(ErrorMessage = "Tipo de campo é obrigatorio!")]
        [Display(Name = "Tipo do campo")]
        public int T02_004_n { get => t02_004_n; set => t02_004_n = value; }

        [Column(TypeName = "nvarchar")]
        [Display(Name = "valor padrao")]
        [StringLength(30)]
        public string T02_005_c { get => t02_005_c; set => t02_005_c = value; }

        [Column(TypeName = "nvarchar")]
        [Required(ErrorMessage = "nome do campo para exibição é obrigatório!")]
        [Display(Name = "Campo de Exibição")]
        [StringLength(30)]
        public string T02_006_c { get => t02_006_c; set => t02_006_c = value; }

        [Column(TypeName = "nvarchar")]
        [Required(ErrorMessage = "oredem dos campos de exibição é obrigatório!")]
        [Display(Name = "ordem dos campos para exibição")]
        [StringLength(30)]
        public string T02_007_n { get => t02_007_n; set => t02_007_n = value; }

        [ForeignKey("T01")]
        public Guid T01_ukey { get => t01_ukey; set => t01_ukey = value; }
        public T01 T01 { get => t01; set => t01 = value; }
    }
}
