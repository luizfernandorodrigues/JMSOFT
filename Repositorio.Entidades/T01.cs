using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Repositorio.Entidades
{
   public class T01 : AbstractModel
    {
        private string t01_001_c;
        private string t01_002_c;
        private string t01_003_c;

        
        [Column(TypeName ="nvarchar")]
        [Required(ErrorMessage ="Código é Obrigatório!")]
        [Display(Name ="Código")]
        [StringLength(20)]
        public string T01_001_c { get => t01_001_c; set => t01_001_c = value; }

        [Column(TypeName = "nvarchar")]
        [Required(ErrorMessage ="Descrição é obrigatoria!")]
        [Display(Name ="Descrição")]
        [StringLength(50)]
        public string T01_002_c { get => t01_002_c; set => t01_002_c = value; }

        [Column(TypeName = "text")]
        [Required(ErrorMessage ="A Sql é obrigatória")]
        [Display(Name ="Consulta SQL")]
        public string T01_003_c { get => t01_003_c; set => t01_003_c = value; }

        public ICollection<T02> T02 { get; set; }
    }
}
