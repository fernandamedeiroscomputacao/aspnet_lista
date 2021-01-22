using System.ComponentModel.DataAnnotations;

namespace Curso_ASP.Models
{
    public class Usuario
    {
        //[Required(ErrorMessage = "O nome é obrigatório")]
        public string Nome {get; set; }   

        [StringLength(50, MinimumLength = 5, ErrorMessage = "Insira uma informação de 5 a 50 caracteres")]
        public string Observacoes {get; set; }

        [RegularExpression(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$", ErrorMessage = "Digite um Email válido")]
        public string Email {get; set; }

        [Range(18, 70, ErrorMessage = "A idade tem que estar entre 18 e 70")]      
        public int Idade {get; set; }

        [RegularExpression(@"[a-zA-Z]{5,15}", ErrorMessage = "Somente letras, e de cinco a quinze caracteres")]
       // [Required(ErrorMessage = "O login é obrigatório")]
        public string Login {get; set; }

        //[Required(ErrorMessage = "A senha é obrigatório")]
        public string Senha {get; set; }

 //       [Compare("Senha", ErrorMessage = "Senhas diferem")]
        public string ConfirmarSenha {get; set; }

    
    }
}