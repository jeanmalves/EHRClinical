using Model.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EHRWebApplication.Models
{
    public class DoctorViewModel
    {

        public int Id { get; set; }
        [Required(ErrorMessage = "Campo obrigatório.")]
        [Display(Name = "Nome")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [Display(Name = "Sobrenome")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [Display(Name = "Data de nascimento")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? Birth { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [Display(Name = "Sexo")]
        public short Sex { get; set; }

        public Dictionary<short, string> SexList
        {
            get { return SexDictionary.SexList; }
            set { }
        }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [Display(Name = "CRM nº")]
        public int MedicId { get; set; }
        public UserViewModel User { get; set; }
    }

    public class DoctorDetailsViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Nome")]
        public string FirstName { get; set; }

        [Display(Name = "Sobrenome")]
        public string LastName { get; set; }

        [Display(Name = "Data de nascimento")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? Birth { get; set; }

        [Display(Name = "Sexo")]
        public string Sex { get; set; }

        [Display(Name = "CRM nº")]
        public string CRMNumber { get; set; }

        public User User { get; set; }
    }

    public class DoctorEditViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo obrigatório.")]
        [Display(Name = "Nome")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [Display(Name = "Sobrenome")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [Display(Name = "Data de nascimento")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? Birth { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [Display(Name = "Sexo")]
        public short Sex { get; set; }

        public Dictionary<short, string> SexList
        {
            get { return SexDictionary.SexList; }
            set { }
        }

        public int MedicId { get; set; }

        public UserEditViewModel User { get; set; }
    }
}