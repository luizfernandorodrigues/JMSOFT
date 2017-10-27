using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Repositorio.Entidades
{
    public class A25
    {
        private Guid ukey;
        private string a25_001_c;
        private string a25_002_c;
        private string a25_003_c;
        private DateTime timestamp;
        private Guid a24_ukey;
        private A24 a24;

        [Key]
        public Guid Ukey { get => ukey; set => ukey = value; }

        [Column(TypeName ="nvarchar")]
        [Display(Name ="Cep")]
        [Required(ErrorMessage ="Cep obrigatório")]
        [StringLength(8, MinimumLength =8, ErrorMessage ="Cep deve conter 8 caracteres!")]
        public string A25_001_c { get => a25_001_c; set => a25_001_c = value; }

        [Column(TypeName ="nvarchar")]
        [Display(Name ="Rua")]
        [StringLength(80, MinimumLength =1, ErrorMessage ="Campo rua deve conter no maximo 80 caracteres!")]
        public string A25_002_c { get => a25_002_c; set => a25_002_c = value; }

        [Column(TypeName ="nvarchar")]
        [Display(Name ="Bairro")]
        [StringLength(60, ErrorMessage ="Campo bairro deve contaer n maximo 60 caracteres!")]
        public string A25_003_c { get => a25_003_c; set => a25_003_c = value; }

        [Column(TypeName ="DateTime")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime Timestamp { get => timestamp; set => timestamp = value; }

        [ForeignKey("A24")]
        public Guid A24_ukey { get => a24_ukey; set => a24_ukey = value; }

        public A24 A24 { get => a24; set => a24 = value; }
    }
}
