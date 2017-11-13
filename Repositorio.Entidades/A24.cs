using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Repositorio.Entidades
{
    public class A24
    {
        private Guid ukey;
        private string a24_001_c;
        private string a24_002_c;
        private decimal a24_003_n;
        private decimal a24_007_n;
        private string a24_008_c;
        private DateTime timestamp;
        private Guid a23_ukey;
        private A23 a23;

        [Key]
        public Guid Ukey { get => ukey; set => ukey = value; }

        [Column(TypeName = "nvarchar")]
        [Required(ErrorMessage = "Nome da Cidade é Obrigatório!")]
        [Display(Name = "Nome")]
        [StringLength(80, MinimumLength = 1, ErrorMessage = "Campo nome deve conter no mínimo 1 caracter e no máximo 80 caracteres")]
        public string A24_001_c { get => a24_001_c; set => a24_001_c = value; }

        [Column(TypeName = "nvarchar")]
        [Required(ErrorMessage = "DDD da Cidade é obrigatório")]
        [Display(Name = "DDD")]
        [StringLength(3, MinimumLength = 3, ErrorMessage = "Campo DDD deve conter no mínimo 3 caracter e no máximo 3 caracteres")]
        public string A24_002_c { get => a24_002_c; set => a24_002_c = value; }

        [DataType("numeric(1,0)")]
        [Required]
        [Display(Name = "Se é Capital")]
        public decimal A24_003_n { get => a24_003_n; set => a24_003_n = value; }

        [DataType("numeric(15,6)")]
        [Display(Name = "Valor Frete")]
        public decimal A24_007_n { get => a24_007_n; set => a24_007_n = value; }

        [Column(TypeName = "nvarchar")]
        [Display(Name = "Código IBGE")]
        [Required(ErrorMessage = "Código IBGE é obrigatório!")]
        [StringLength(7, MinimumLength = 7, ErrorMessage = "Código do IBGE deve conter 7 caracteres!")]
        public string A24_008_c { get => a24_008_c; set => a24_008_c = value; }

        [Column(TypeName = "DateTime")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime Timestamp { get => timestamp; set => timestamp = value; }

        [ForeignKey("A23")]
        public Guid A23_ukey { get => a23_ukey; set => a23_ukey = value; }
        public A23 A23 { get => a23; set => a23 = value; }

        public ICollection<A25> A25 { get; set; }
    }
}
