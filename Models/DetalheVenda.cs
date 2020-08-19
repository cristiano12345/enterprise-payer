using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoanPayer.domain
{
    public class DetalheVenda : Auditoria
    {
        [Key]
        public long Id { get; set; }

        [ForeignKey("Venda")]
        public long IdVenda { get; set; }

        [ForeignKey("Recebimento")]
        public long IdRecebimento { get; set; }

        [ForeignKey("FormaPagamento")]
        public long IdFormaPagamento { get; set; }

        [Required(ErrorMessage="Número parcela")]
        [Range(1, 100, ErrorMessage="Número parcela inválida")]        
        public int Parcela { get; set; }

        [Required(ErrorMessage="Valor parcela")]
        [Range(1, 100, ErrorMessage="Valor parcela inválida")] 
        public decimal ValorParcela { get; set; }       

        [Required(ErrorMessage="Código de barras obrigatório")]
        [MaxLength(50, ErrorMessage="Código de barras inválido")]
        [MinLength(5, ErrorMessage="Código de barras inválido")]
        public string CodBarras { get; set; }

        [Required(ErrorMessage="Banco obrigatório")]
        [MaxLength(50, ErrorMessage="Banco inválido")]
        [MinLength(2, ErrorMessage="Banco inválido")]
        public string Banco { get; set; }

        [Required(ErrorMessage="Agencia obrigatório")]
        [MaxLength(50, ErrorMessage="Agencia inválida")]
        [MinLength(2, ErrorMessage="Agencia inválida")]
        public string Agencia { get; set; }

        [Required(ErrorMessage="Conta obrigatória")]
        [MaxLength(50, ErrorMessage="Conta inválida")]
        [MinLength(2, ErrorMessage="Conta inválida")]
        public string Conta { get; set; }
       
        [MaxLength(50, ErrorMessage="Conta inválida")]        
        public string NumCheque { get; set; }

        public DateTime? DtVencimento { get; set; }        

        public bool LiberaComissao { get; set; }
    }
}
