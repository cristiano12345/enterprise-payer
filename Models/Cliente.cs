using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoanPayer.domain
{
    public class Cliente : Auditoria
    {      
        [Key]
        public long Id { get; set; }

        [ForeignKey("Usuario")]
        public long UsuarioId { get; set; }   

        [Required(ErrorMessage="Razão Social obrigatório")]
        [MaxLength(100, ErrorMessage="Razão Social inválida")]
        [MinLength(5, ErrorMessage="Razão Social inválida")]
        public string RazaoSocial { get; set; }

        [Required(ErrorMessage="Nome Fantasia obrigatório")]
        [MaxLength(100, ErrorMessage="Nome Fantasia inválido")]
        [MinLength(5, ErrorMessage="Nome Fantasia inválido")]
        public string NomeFantasia { get; set; }

        [Required(ErrorMessage="Cnpj obrigatório")]
        [MaxLength(14, ErrorMessage="Cnpj inválido")]
        [MinLength(14, ErrorMessage="Cnpj inválido")]
        public string Cnpj { get; set; }

        [Required(ErrorMessage="Endereço obrigatório")]    
        public Endereco Endereco { get; set; }

        [Required(ErrorMessage="Contato obrigatório")]    
        public Contato Contato { get; set; }

    }
}
