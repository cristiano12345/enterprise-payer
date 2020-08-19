using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LoanPayer.domain
{
    public class ContaBancaria : Auditoria
    {
        [Key]
        public long Id { get; set; }

        [ForeignKey("ClienteBeneficiario")]
        public long IdClienteBeneficiario { get; set; }

        [ForeignKey("TipoConta")]
        public long IdTipoConta { get; set; }

        [Required(ErrorMessage="Nome Banco obrigatório")]
        [MaxLength(50, ErrorMessage="Nome Banco inválido")]
        [MinLength(5, ErrorMessage="Nome Banco inválido")]
        public string NomeBanco { get; set; }

        [Required(ErrorMessage="Número obrigatório")]
        [MaxLength(50, ErrorMessage="Número inválido")]
        [MinLength(5, ErrorMessage="Número inválido")]
        public string NumBanco { get; set; } 
       
        [Required(ErrorMessage="Número agencia")]
        [MaxLength(50, ErrorMessage="Número agencia")]
        [MinLength(5, ErrorMessage="Número agencia")]
        public string NumAgencia { get; set; }

        [Required(ErrorMessage="Número conta")]
        [MaxLength(50, ErrorMessage="Número conta")]
        [MinLength(5, ErrorMessage="Número conta")]
        public string NumConta { get; set; }
       
        public bool Recebe { get; set; }


    }
}
