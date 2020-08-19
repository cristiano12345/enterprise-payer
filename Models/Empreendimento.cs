using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LoanPayer.domain
{
    public class Empreendimento : Auditoria
    {
        [Key]
        public long Id { get; set; }

        [ForeignKey("Cliente")]
        public long IdCliente { get; set; }

        [Required(ErrorMessage="Nome obrigatório")]
        [MaxLength(50, ErrorMessage="Nome inválido")]
        [MinLength(5, ErrorMessage="Nome inválido")]
        public string Nome { get; set; }

        [Required(ErrorMessage="Razão Social obrigatório")]
        [MaxLength(100, ErrorMessage="Razão Social inválida")]
        [MinLength(10, ErrorMessage="Razão Social inválida")]
        public string RazaoSocial { get; set; }

        [Required(ErrorMessage="Nome fantasia obrigatório")]
        [MaxLength(100, ErrorMessage="Nome fantasia inválido")]
        [MinLength(10, ErrorMessage="Nome fantasia inválido")]
        public string NomeFantasia { get; set; }

        [Required(ErrorMessage="Cnpj obrigatório")]
        [MaxLength(14, ErrorMessage="Cnpj inválido")]
        [MinLength(14, ErrorMessage="Cnpj inválido")]
        public string Cnpj { get; set; }

        [Required(ErrorMessage="Endereço obrigatório")]  
        public Endereco Endereco { get; set; }
    }
}
