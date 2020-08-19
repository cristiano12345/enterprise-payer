using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LoanPayer.domain
{
    public class FormaPagamento : Auditoria
    {
        [Key]
        public long Id { get; set; }
        
        [Required(ErrorMessage="Descrição obrigatória")]
        [MaxLength(500, ErrorMessage="Descrição inválida")]
        [MinLength(5, ErrorMessage="Descrição inválida")]    
        public string Descricao { get; set; }
    }
}
