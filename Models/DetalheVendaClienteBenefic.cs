using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LoanPayer.domain
{
    public class DetalheVendaClienteBenefic : Auditoria
    {
        [Key]
        public long Id { get; set; }

        [ForeignKey("DetalheVenda")]
        public long IdDetalheVenda { get; set; }

        [ForeignKey("ClienteBeneficiario")]
        public long IdClienteBeneficiario { get; set; }

        [ForeignKey("StatusPagamento")]
        public long IdStatusPagamento { get; set; }

        [Required(ErrorMessage="Valor comissão obrigatório")]
        [Range(1, 999999, ErrorMessage="Código de barras inválido")]        
        public decimal VlComissao { get; set; }

        public DateTime DtPagamento { get; set; }

        [Required(ErrorMessage="Comprovante obrigatório")]
        [MaxLength(100, ErrorMessage="Comprovante inválido")]
        [MinLength(10, ErrorMessage="Comprovante inválido")]
        public string Comprovante { get; set; }

        public bool LiberaComissao { get; set; }
    }
}
