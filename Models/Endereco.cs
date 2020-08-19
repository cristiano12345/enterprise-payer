using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LoanPayer.domain
{
    public class Endereco
    {
        [Key]
        public long Id { get; set; }

        [Required(ErrorMessage="CEP obrigatório")]       
        public string Cep { get; set; }

        [Required(ErrorMessage="Cidade obrigatório")]
        [MaxLength(50, ErrorMessage="Cidade inválido")]
        [MinLength(5, ErrorMessage="Cidade inválido")]
        public string Cidade { get; set; }

        [Required(ErrorMessage="Bairro obrigatório")]
        [MaxLength(50, ErrorMessage="Bairro inválido")]
        [MinLength(5, ErrorMessage="Bairro inválido")]
        public string Bairro { get; set; }

        [Required(ErrorMessage="Logradouro obrigatório")]
        [MaxLength(200, ErrorMessage="Logradouro inválido")]
        [MinLength(10, ErrorMessage="Logradouro inválido")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage="Numero obrigatório")]
        [Range(1, long.MaxValue, ErrorMessage="Numero inválido")]       
        public long Numero { get; set; }
       
        [MaxLength(500, ErrorMessage="Complemento inválido")]      
        public string Complemento { get; set; }

    }
}
