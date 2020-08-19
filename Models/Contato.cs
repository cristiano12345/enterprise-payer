using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LoanPayer.domain
{
    public class Contato
    {
        [Key]
        public long Id { get; set; }

        [Required(ErrorMessage="E-mail obrigatório")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail em formato inválido.")]
        public string Email { get; set; }

        [Required(ErrorMessage="DDD obrigatório")]
        [MaxLength(2, ErrorMessage="DDD inválido")]
        [MinLength(2, ErrorMessage="DDD inválido")]
        public int Ddd { get; set; }

        [Required(ErrorMessage="Telefone obrigatório")]
        [MaxLength(9, ErrorMessage="Telefone inválido")]
        [MinLength(8, ErrorMessage="Telefone inválido")]
        public string Telefone { get; set; }
    }
}
