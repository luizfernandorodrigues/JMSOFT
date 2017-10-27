using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repositorio.Entidades
{
    public class A23
    {
        [Key]
        private Guid ukey;
        private string a23_001_c;
        private string a23_002_c;
        private string a23_003_c;
        private string a23_004_c;
        private DateTime timestamp;
        private Guid a22_ukey;
        private A22 a22;

        [Key]
        public Guid Ukey { get => ukey; set => ukey = value; }

        [Column(TypeName = "nvarchar")]
        [Display(Name = "Sigla")]
        [Required(ErrorMessage = "Campo é obrigatório")]
        [StringLength(2, MinimumLength = 2, ErrorMessage = "Campo deve conter no maximo 2 e no mínimo 2 caracteres!")]
        public string A23_001_c { get => a23_001_c; set => a23_001_c = value; }

        [Column(TypeName = "nvarchar")]
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Campo é obrigatório")]
        [StringLength(30, MinimumLength = 1, ErrorMessage = "Campo deve conter no maximo 30 caracteres!")]
        public string A23_002_c { get => a23_002_c; set => a23_002_c = value; }

        [Column(TypeName = "nvarchar")]
        [Display(Name = "Código IBGE")]
        [StringLength(2, MinimumLength = 2, ErrorMessage = "Campp deve conter no máximo 2 e no mínimo 2 caracteres!")]
        public string A23_003_c { get => a23_003_c; set => a23_003_c = value; }

        [Column(TypeName = "nvarchar")]
        [Display(Name = "Observações")]
        [StringLength(400)]
        public string A23_004_c { get => a23_004_c; set => a23_004_c = value; }

        [Column(TypeName = "DateTime")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime Timestamp { get => timestamp; set => timestamp = value; }

        [ForeignKey("A22")]
        public Guid A22_ukey { get => a22_ukey; set => a22_ukey = value; }

        public A22 A22 { get => a22; set => a22 = value; }

        public ICollection<A24> A24 { get; set; }
    }
}
