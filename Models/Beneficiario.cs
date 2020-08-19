using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LoanPayer.domain
{
    public class Beneficiario : Auditoria
    {
        [Key]
        public long Id { get; set; }   

        [ForeignKey("Usuario")]
        public long UsuarioId { get; set; }         

        [Required(ErrorMessage="Nome obrigatório")]
        [MaxLength(100, ErrorMessage="Nome não pode ser maior que 100 caracteres")]
        [MinLength(10, ErrorMessage="Nome não pode ser menor que 100 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage="Nome obrigatório")]
        [MaxLength(11, ErrorMessage="CPF inválido")]
        [MinLength(11, ErrorMessage="CPF inválido")]
        public string Cpf { get; set; }

        [Required(ErrorMessage="Endereço obrigatório")]        
        public Endereco Endereco { get; set; }

        [Required(ErrorMessage="Contato obrigatório")]       
        public Contato Contato { get; set; }
    }
}
