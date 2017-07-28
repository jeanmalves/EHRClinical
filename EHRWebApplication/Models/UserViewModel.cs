using System.ComponentModel.DataAnnotations;

namespace EHRWebApplication.Models
{
    public class UserViewModel
    {
        [Required(ErrorMessage = "Campo obrigatório.")]
        [Display(Name = "Usuário")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password { get; set; }

        [Display(Name = "Organização")]
        public  string Organization { get; set; }

        public int Access { get; set; }
    }

    public class UserEditViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [Display(Name = "Usuário")]
        public string UserName { get; set; }
        
        [EmailAddress]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password { get; set; }

        [Display(Name = "Organização")]
        public string Organization { get; set; }

        public int Access { get; set; }
    }
}