using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoanPayer.domain
{
    public class ClienteBeneficiario : Auditoria
    {
        [Key]
        public long Id { get; set; }        

        [ForeignKey("Cliente")]
        public long IdCliente { get; set; }

        [ForeignKey("Beneficiario")]
        public long IdBeneficiario { get; set; }
        
    }
}
