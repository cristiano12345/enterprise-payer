using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoanPayer.domain
{
    public class Comprador : Auditoria
    {
        [Key]
        public long Id { get; set; }

        [ForeignKey("Usuario")]
        public long UsuarioId { get; set; }  

        [Required(ErrorMessage="Nome obrigatório")]
        [MaxLength(50, ErrorMessage="Nome inválido")]
        [MinLength(5, ErrorMessage="Nome inválido")]
        public string Nome { get; set; }

        [Required(ErrorMessage="CPF obrigatório")]
        [MaxLength(11, ErrorMessage="CPF inválido")]
        [MinLength(11, ErrorMessage="CPF inválido")]
        public string Cpf { get; set; }

        [Required(ErrorMessage="Contato obrigatório")]    
        public Contato Contato { get; set; }
    }
}
