using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.event_.tarde.Domains
{
    [Table(nameof(PresencaEventoDomain))]
    public class PresencaEventoDomain
    {
        [Key]
        public Guid IdPresencaEvento { get; set; } = Guid.NewGuid();

        [Column(TypeName = "BIT")]
        [Required(ErrorMessage = "Situação obrigatória!")]
        public bool Situacao { get; set; }

        //ref.tabela Usuario
        [Required(ErrorMessage ="Usuário é obrigatório!")]
        public Guid IdUsuario { get; set; }

        [ForeignKey(nameof(IdUsuario))]
        public UsuarioDomain? Usuario { get; set; }

        //ref. tabela Evento
        [Required(ErrorMessage ="Evento obrigatório")]
        public Guid IdEvento { get; set; }

        [ForeignKey(nameof(IdEvento))]
        public EventoDomain? Evento { get; set; }
    }
}
