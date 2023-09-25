﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.event_.tarde.Domains
{
    [Table(nameof(ComentarioEventoDomain))]
    public class ComentarioEventoDomain
    {
        [Key]
        public Guid IdComentarioEvento { get; set; }

        [Column(TypeName = "TEXT")]
        [Required(ErrorMessage ="Descrição obrigatória")]
        public string? Descricao { get; set; }

        [Column(TypeName = "BIT")]
        [Required(ErrorMessage = "Informação sobre exibição é obrigatória")]
        public bool? Exibe { get; set; }

        //ref.tabela Usuario
        [Required(ErrorMessage = "Usuário é obrigatório!")]
        public Guid IdUsuario { get; set; }

        [ForeignKey(nameof(IdUsuario))]
        public UsuarioDomain? Usuario { get; set; }

        //ref. tabela Evento
        [Required(ErrorMessage = "Evento obrigatório")]
        public Guid IdEvento { get; set; }

        [ForeignKey(nameof(IdEvento))]
        public EventoDomain? Evento { get; set; }
    }
}
