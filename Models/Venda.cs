using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LoanPayer.domain
{
    public class Venda : Auditoria
    {
        [Key]
        public long Id { get; set; }     

        [ForeignKey("Unidade")]
        public long IdUnidade { get; set; }

        [ForeignKey("Comprador")]
        public long IdComprador { get; set; }        

        [ForeignKey("StatusVenda ")]
        public long IdStatusVenda { get; set; }

        [Required(ErrorMessage="Nº Contrato obrigatório")]
        [MaxLength(500, ErrorMessage="Nº Contrato inválido")]
        [MinLength(5, ErrorMessage="Nº Contrato inválido")]
        public long NumContrato { get; set; }

        [Required(ErrorMessage="Valor comissão obrigatória")]
        [Range(1, 999999, ErrorMessage="Valor comissão inválido")]      
        public decimal ValorComissaoTotal { get; set; }

        [Required(ErrorMessage="Quantidade parcela(s) obrigatória")]
        [Range(1, 100, ErrorMessage="Quantidade parcela(s) inválida(s)")]    
        public int QtdParcelas { get; set; }
    }
}
