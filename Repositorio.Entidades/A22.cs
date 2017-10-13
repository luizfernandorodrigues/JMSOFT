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
        [Key]
        public Guid ukey { get; set; }

        [Display(Name = "Nome")]
        [Column(TypeName = "nvarchar")]
        [Required(ErrorMessage = "Campo Nome do País é Obrigatorio!")]
        [MaxLength(60), MinLength(2)]
        public string a22_001_c { get; set; }

        [Display(Name = "Código")]
        [Column(TypeName = "nvarchar")]
        [Required(ErrorMessage = "Campo Código do País é Obrigatorio!")]
        [MaxLength(10), MinLength(2)]
        public string a22_002_c { get; set; }

        [Display(Name = "Observações")]
        [Column(TypeName = "nvarchar")]
        [MaxLength(400)]
        public string a22_003_c { get; set; }


        public DateTime timestamp { get; set; }

        public A22()
        {
            this.ukey = GeraGuid.geraUkey();

        }



    }
}
