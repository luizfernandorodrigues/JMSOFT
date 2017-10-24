using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Repositorio.Entidades
{
    public class A22
    {
        #region propriedades

        private Guid ukey;
        private string a22_001_c;
        private string a22_002_c;
        private string a22_003_c;
        private DateTime timestamp;

        [Key]
        public Guid Ukey { get => ukey; set => ukey = value; }

        [Column(TypeName = "nvarchar")]
        [Required(ErrorMessage = "Digite o nome do país!!")]
        [Display(Name = "Nome")]
        [StringLength(100, MinimumLength = 1)]
        public string A22_001_c { get => a22_001_c; set => a22_001_c = value; }

        [Column(TypeName = "nvarchar")]
        [Required(ErrorMessage = "Digite o código do país")]
        [Display(Name = "Código")]
        [StringLength(4, MinimumLength = 4, ErrorMessage = "Código deve ter no minimo 4 caracteres e no maximo 4 caracteres!")]
        public string A22_002_c { get => a22_002_c; set => a22_002_c = value; }

        [Column(TypeName = "nvarchar")]
        [Display(Name = "Observações")]
        [StringLength(400)]
        public string A22_003_c { get => a22_003_c; set => a22_003_c = value; }

        [Column(TypeName = "DateTime")]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime Timestamp { get => timestamp; set => timestamp = value; }

        public ICollection<A23> A23 { get; set; }

        #endregion propriedades

    }
}
