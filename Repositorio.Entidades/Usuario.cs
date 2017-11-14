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
        private string email;
        private DateTime horario;
        private string nome;
        private string porta;
        private string senha;
        private string senhaEmail;
        private string servidorEmail;
        private int ssl;
        private DateTime timestamp;
        private string login;
        private string usuarioEmail;
        #endregion

        #region geters e seters
        [Key]
        public Guid Ukey { get => ukey; set => ukey = value; }

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
        [StringLength(10, ErrorMessage = "Tamanho máximo da porta SMTP é de 10 caracteres!")]
        public string Porta { get => porta; set => porta = value; }

        [Column(TypeName = "nvarchar")]
        [Display(Name = "Senha do usuário!")]
        [Required(ErrorMessage = "A senha do Usuário é Obrigatório!")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Tamanho máximo da senha é de 100 caracteres!")]
        public string Senha { get => senha; set => senha = value; }

        [Column(TypeName = "nvarchar")]
        [Display(Name = "Senha e-mail!")]
        [StringLength(100, ErrorMessage = "Tamanho máximo é de 100 caracteres!")]
        public string SenhaEmail { get => senhaEmail; set => senhaEmail = value; }

        [Column(TypeName = "nvarchar")]
        [Display(Name = "Servidor de e-mail!")]
        [StringLength(100, ErrorMessage = "Tamanho máximo do servidor de e-mail é de 100 caracteres!")]
        public string ServidorEmail { get => servidorEmail; set => servidorEmail = value; }

        [DataType("numeric(1,0)")]
        [Display(Name = "Ssl")]
        public int Ssl { get => ssl; set => ssl = value; }

        [Column(TypeName = "DateTime")]
        public DateTime Timestamp { get => timestamp; set => timestamp = value; }

        [Column(TypeName = "nvarchar")]
        [Display(Name = "Login")]
        [Required(ErrorMessage = "O login do usuário é obrigatório!")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Tamanho máximo do login é de 50 caracteres!")]
        public string Login { get => login; set => login = value; }

        [Column(TypeName = "nvarchar")]
        [Display(Name = "Usuário do e-mail!")]
        [StringLength(50, ErrorMessage = "Tamanho máximo é de 50 caracteres!")]
        public string UsuarioEmail { get => usuarioEmail; set => usuarioEmail = value; }
        #endregion

        
    }
}
