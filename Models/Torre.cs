using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LoanPayer.domain
{
    public class Torre : Auditoria
    {
        [Key]
        public long Id { get; set; }

        [ForeignKey("Empreendimento")]
        public long IdEmpreendimento { get; set; }

        [Required(ErrorMessage="Nome Torre obrigatória")]
        [MaxLength(500, ErrorMessage="Nome Torre inválido")]
        [MinLength(5, ErrorMessage="Nome Torre inválido")]   
        public string NomeTorre { get; set; }
    }
}
