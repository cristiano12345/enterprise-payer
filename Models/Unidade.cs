using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LoanPayer.domain
{
    public class Unidade : Auditoria
    {
        [Key]
        public long Id { get; set; }

        [ForeignKey("Torre")]
        public long IdTorre { get; set; }

        [Required(ErrorMessage="Nome Unidade obrigatório")]
        [MaxLength(500, ErrorMessage="Nome Unidade inválida")]
        [MinLength(5, ErrorMessage="Nome Unidade inválida")]   
        public string NomeUnidade { get; set; }
    }
}
