using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Repositorio.Entidades
{
    public abstract class AbstractModel
    {
        private DateTime timestamp;
        private Guid user_note;
        private Usuario usuario;
        private Guid ukey;
        private Guid cia_ukey;
        private A10 a10;

        [Column(TypeName ="DateTime")]
        public DateTime Timestamp { get => timestamp; set => timestamp = value; }

        [ForeignKey("Usuario")]
        public Guid User_note { get => user_note; set => user_note = value; }
        public Usuario Usuario { get => usuario; set => usuario = value; }

        [Key]
        public Guid Ukey { get => ukey; set => ukey = value; }

        [ForeignKey("A10")]
        public Guid Cia_ukey { get => cia_ukey; set => cia_ukey = value; }
        public A10 A10 { get => a10; set => a10 = value; }
    }
}
