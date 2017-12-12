using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Repositorio.Entidades
{
    public class A10 : AbstractModel
    {
        private string a10_001_c;
        private string a10_002_c;
        private string a10_003_c;
        private string a10_004_c;
        private string a10_005_c;
        private string a10_006_c;
        private string a10_007_c;
        private string a10_009_c;
        private string a10_010_c;
        private string a10_011_c;
        private string a10_012_c;
        private string a10_013_c;
        private DateTime a10_014_d;
        private string a10_015_c;
        private string a10_016_c;
        private string a10_017_c;
        private Decimal a10_018_n;
        private Decimal a10_019_n;
        private Decimal a10_020_n;
        private Decimal a10_021_n;
        private string a10_022_c;
        private string a10_023_c;
        private string a10_024_c;
        private Decimal a10_025_n;
        private byte[] a10_026_c;
        private Decimal a10_027_n;
        private Decimal a10_028_n;
        private Decimal a10_029_n;
        private Decimal a10_031_n;
        private Decimal a10_032_n;
        private string a10_038_c;
        private Decimal a10_039_n;
        private Guid a25_ukey;
        private A25 a25;

        [DataType("nvarchar")]
        [Required(ErrorMessage = "Código é Obrigatório!")]
        [Display(Name = "Código")]
        [StringLength(20)]
        public string A10_001_c { get => a10_001_c; set => a10_001_c = value; }

        [DataType("nvarchar")]
        [Required(ErrorMessage = "Fantasia é obrigatório")]
        [Display(Name = "Fantasia")]
        [StringLength(80)]
        public string A10_002_c { get => a10_002_c; set => a10_002_c = value; }

        [DataType("nvarchar")]
        [Required(ErrorMessage = "Razão Social é Obrigatório!")]
        [Display(Name = "Razão Social")]
        [StringLength(80)]
        public string A10_003_c { get => a10_003_c; set => a10_003_c = value; }

        [DataType("nvarchar")]
        [Required(ErrorMessage = "Endereço é Obrigatório!")]
        [Display(Name = "Endereço")]
        [StringLength(40)]
        public string A10_004_c { get => a10_004_c; set => a10_004_c = value; }

        [DataType("nvarchar")]
        [Required(ErrorMessage = "Numero do Endereço é Obrigatório!")]
        [Display(Name = "Numero do Endereço")]
        [StringLength(10)]
        public string A10_005_c { get => a10_005_c; set => a10_005_c = value; }

        [DataType("nvarchar")]
        [Required(ErrorMessage = "Bairro é Obrigatório!")]
        [Display(Name = "Bairro")]
        [StringLength(50)]
        public string A10_006_c { get => a10_006_c; set => a10_006_c = value; }

        [DataType("nvarchar")]
        [Display(Name = "Complemento")]
        [StringLength(60)]
        public string A10_007_c { get => a10_007_c; set => a10_007_c = value; }

        [DataType("nvarchar")]
        [Required(ErrorMessage = "Telefone é Obrigatório!")]
        [Display(Name = "Telefone")]
        [StringLength(20)]
        public string A10_009_c { get => a10_009_c; set => a10_009_c = value; }

        [DataType("nvarchar")]
        [Display(Name = "Fax")]
        [StringLength(20)]
        public string A10_010_c { get => a10_010_c; set => a10_010_c = value; }

        [DataType("nvarchar")]
        [Display(Name = "Celular")]
        [StringLength(20)]
        public string A10_011_c { get => a10_011_c; set => a10_011_c = value; }

        [DataType("nvarchar")]
        [Display(Name = "E-mail")]
        [StringLength(80)]
        public string A10_012_c { get => a10_012_c; set => a10_012_c = value; }

        [DataType("nvarchar")]
        [Display(Name = "Site")]
        [StringLength(20)]
        public string A10_013_c { get => a10_013_c; set => a10_013_c = value; }

        [DataType("DateTime")]
        [Required(ErrorMessage = "Data de Inicio é Obrigatório!")]
        [Display(Name = "Data de Inicio")]
        public DateTime A10_014_d { get => a10_014_d; set => a10_014_d = value; }

        [DataType("nvarchar")]
        [Required(ErrorMessage = "CNAE é Obrigatório!")]
        [Display(Name = "CNAE")]
        [StringLength(20)]
        public string A10_015_c { get => a10_015_c; set => a10_015_c = value; }

        [DataType("nvarchar")]
        [Required(ErrorMessage = "Cnpj/Cpf é Obrigatório!")]
        [Display(Name = "Cnpj/Cpf")]
        [StringLength(20)]
        public string A10_016_c { get => a10_016_c; set => a10_016_c = value; }

        [DataType("nvarchar")]
        [Required(ErrorMessage = "Inscrição/Rg é Obrigatório!")]
        [Display(Name = "Inscrição/Rg")]
        [StringLength(20)]
        public string A10_017_c { get => a10_017_c; set => a10_017_c = value; }

        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "Status de emissão de nfe é Obrigatório!")]
        [Display(Name = "Status nfe")]
        public decimal A10_018_n { get => a10_018_n; set => a10_018_n = value; }

        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "Percentual de INSS é Obrigatório!")]
        [Display(Name = "Porcentagem de INSS")]
        public decimal A10_019_n { get => a10_019_n; set => a10_019_n = value; }

        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "Base Maxima INSS é Obrigatório!")]
        [Display(Name = "Base Maxima INSS")]
        public decimal A10_020_n { get => a10_020_n; set => a10_020_n = value; }

        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "Porcentagem de SEST é Obrigatório!")]
        [Display(Name = "Porcentagem SEST")]
        public decimal A10_021_n { get => a10_021_n; set => a10_021_n = value; }

        [DataType("nvarchar")]
        [Required(ErrorMessage = "Pasta nfe é Obrigatório!")]
        [Display(Name = "Pasta nfe")]
        [StringLength(100)]
        public string A10_022_c { get => a10_022_c; set => a10_022_c = value; }

        [DataType("nvarchar")]
        [Display(Name = "Contador")]
        [StringLength(50)]
        public string A10_023_c { get => a10_023_c; set => a10_023_c = value; }

        [DataType("nvarchar")]
        [Display(Name = "Telefone Contador")]
        [StringLength(20)]
        public string A10_024_c { get => a10_024_c; set => a10_024_c = value; }

        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "Situação nfe é Obrigatório!")]
        [Display(Name = "situação nfe")]
        public decimal A10_025_n { get => a10_025_n; set => a10_025_n = value; }

        [Column(TypeName ="image")]
        [Required(ErrorMessage = "Logo é Obrigatório!")]
        [Display(Name = "Logo")]
        public byte[] A10_026_c { get => a10_026_c; set => a10_026_c = value; }

        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "Fecha caixa é Obrigatório!")]
        [Display(Name = "Fecha caixa")]
        public decimal A10_027_n { get => a10_027_n; set => a10_027_n = value; }

        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "gera nfe automatico é Obrigatório!")]
        [Display(Name = "Gera Nfe automatico")]
        public decimal A10_028_n { get => a10_028_n; set => a10_028_n = value; }

        [DataType(DataType.Currency)]
        [Display(Name = "Numero sequencial de pedido")]
        public decimal A10_029_n { get => a10_029_n; set => a10_029_n = value; }

        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "Regime da empresa é Obrigatório!")]
        [Display(Name = "Regime da empresa")]
        public decimal A10_031_n { get => a10_031_n; set => a10_031_n = value; }

        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "Aliquota csosn é Obrigatório!")]
        [Display(Name = "Aliquota csosn")]
        public decimal A10_032_n { get => a10_032_n; set => a10_032_n = value; }

        [DataType("nvarchar")]
        [Display(Name = "RNTRC")]
        [StringLength(20)]
        public string A10_038_c { get => a10_038_c; set => a10_038_c = value; }

        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "Porcentagem de juros é Obrigatório!")]
        [Display(Name = "Porcentagem de juros")]
        public decimal A10_039_n { get => a10_039_n; set => a10_039_n = value; }

        [ForeignKey("A25")]
        public Guid A25_ukey { get => a25_ukey; set => a25_ukey = value; }
        public A25 A25 { get => a25; set => a25 = value; }
    }
}
