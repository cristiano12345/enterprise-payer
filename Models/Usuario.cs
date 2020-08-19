using System;
using System.ComponentModel.DataAnnotations;

namespace LoanPayer.domain
{
    public class Usuario
    {
        [Key]
        public long Id { get; set; } 

        [Required(ErrorMessage="Login obrigatório")]
        [MaxLength(20, ErrorMessage="Login inválido")]
        [MinLength(5, ErrorMessage="Login inválido")]   
        public string Login { get; set; }  

        [Required(ErrorMessage="Senha obrigatória")]
        [MaxLength(20, ErrorMessage="Senha inválida")]
        [MinLength(5, ErrorMessage="Senha inválida")]   
        public string Password { get; set; }            

      
        [MaxLength(20, ErrorMessage="Perfil inválido")]       
        public string Perfil { get; set; }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}