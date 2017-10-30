using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Repositorio.Entidades
{
    public class Usuario
    {
        #region propriedades
        private Guid ukey;
        private int a10_046_n;
        private int a10_055_n;
        private int adm;
        private string email;
        private DateTime horario;
        private string nome;
        private string porta;
        private string senha;
        private string senhaEmail;
        private string servidorEmail;
        private int ssl;
        private DateTime timestamp;
        private bool usr_001_n;
        private bool usr_002_n;
        private bool usr_003_n;
        private bool usr_004_n;
        private bool usr_005_n;
        private bool usr_006_n;
        private bool usr_007_n;
        private bool usr_008_n;
        private bool usr_009_n;
        private bool usr_010_n;
        private bool usr_011_n;
        private string login;
        private string usuarioEmail;
        #endregion

        #region geters e seters
        [Key]
        public Guid Ukey { get => ukey; set => ukey = value; }

        [DataType("numeric(1,0)")]
        [Display(Name = "Impressao DOS na venda!")]
        public int A10_046_n { get => a10_046_n; set => a10_046_n = value; }

        [DataType("numeric(1,0)")]
        [Display(Name = "Impress~´ao térmica na venda rapida")]
        public int A10_055_n { get => a10_055_n; set => a10_055_n = value; }

        [DataType("numeric(1,0)")]
        [Display(Name = "Se é Administrador")]
        public int Adm { get => adm; set => adm = value; }

        [Column(TypeName = "nvarchar")]
        [Display(Name = "E-mail do usuário")]
        [StringLength(80)]
        public string Email { get => email; set => email = value; }

        [Column(TypeName = "DateTime")]
        [Display(Name = "Horario")]
        public DateTime Horario { get => horario; set => horario = value; }

        [Column(TypeName = "nvarchar")]
        [Display(Name = "Nome do usuário")]
        [Required(ErrorMessage = "Nome do usuário é obrigatório!")]
        [StringLength(80, MinimumLength = 1, ErrorMessage = "Tamanho máximo é de 80 caracteres!")]
        public string Nome { get => nome; set => nome = value; }

        [Column(TypeName = "nvarchar")]
        [Display(Name = "Porta do Servidor SMTP!")]
        [StringLength(10, MinimumLength = 1, ErrorMessage = "Tamanho máximo é de 10 caracteres!")]
        public string Porta { get => porta; set => porta = value; }

        [Column(TypeName = "nvarchar")]
        [Display(Name = "Senha do usuário!")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Tamanho máximo é de 100 caracteres!")]
        public string Senha { get => senha; set => senha = value; }

        [Column(TypeName = "nvarchar")]
        [Display(Name = "Senha e-mail!")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Tamanho máximo é de 100 caracteres!")]
        public string SenhaEmail { get => senhaEmail; set => senhaEmail = value; }

        [Column(TypeName = "nvarchar")]
        [Display(Name = "Servidor de e-mail!")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Tamanho máximo é de 100 caracteres!")]
        public string ServidorEmail { get => servidorEmail; set => servidorEmail = value; }

        [DataType("numeric(1,0)")]
        [Display(Name = "Ssl")]
        public int Ssl { get => ssl; set => ssl = value; }

        [Column(TypeName = "DateTime")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime Timestamp { get => timestamp; set => timestamp = value; }

        [DataType("numerci(1,0)")]
        [Display(Name = "Se tem acesso movimento de estoque")]
        public bool Usr_001_n { get => usr_001_n; set => usr_001_n = value; }

        [DataType("numerci(1,0)")]
        [Display(Name = "Se tem acesso ao caixa")]
        public bool Usr_002_n { get => usr_002_n; set => usr_002_n = value; }

        [DataType("numerci(1,0)")]
        [Display(Name = "Se tem acesso a relatorios")]
        public bool Usr_003_n { get => usr_003_n; set => usr_003_n = value; }

        [DataType("numerci(1,0)")]
        [Display(Name = "Se tem acesso manutenção")]
        public bool Usr_004_n { get => usr_004_n; set => usr_004_n = value; }

        [DataType("numerci(1,0)")]
        [Display(Name = "Se tem acesso cadastros")]
        public bool Usr_005_n { get => usr_005_n; set => usr_005_n = value; }

        [DataType("numerci(1,0)")]
        [Display(Name = "Baixa receber")]
        public bool Usr_006_n { get => usr_006_n; set => usr_006_n = value; }

        [DataType("numerci(1,0)")]
        [Display(Name = "Se tem acesso cancela baixa")]
        public bool Usr_007_n { get => usr_007_n; set => usr_007_n = value; }

        [DataType("numerci(1,0)")]
        [Display(Name = "Se tem acesso baixa pagar")]
        public bool Usr_008_n { get => usr_008_n; set => usr_008_n = value; }

        [DataType("numerci(1,0)")]
        [Display(Name = "Se tem acesso cancela baixa pagar")]
        public bool Usr_009_n { get => usr_009_n; set => usr_009_n = value; }

        [DataType("numerci(1,0)")]
        [Display(Name = "Se marcado pede senha")]
        public bool Usr_010_n { get => usr_010_n; set => usr_010_n = value; }

        [DataType("numerci(1,0)")]
        [Display(Name = "Se tem acesso exclui cte")]
        public bool Usr_011_n { get => usr_011_n; set => usr_011_n = value; }

        [Column(TypeName = "nvarchar")]
        [Display(Name = "Login")]
        [Required(ErrorMessage = "O login do usuário é obrigatório!")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Tamanho máximo é de 50 caracteres!")]
        public string Login { get => login; set => login = value; }

        [Column(TypeName = "nvarchar")]
        [Display(Name = "Usuário do e-mail!")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Tamanho máximo é de 50 caracteres!")]
        public string UsuarioEmail { get => usuarioEmail; set => usuarioEmail = value; }
        #endregion
    }
}
