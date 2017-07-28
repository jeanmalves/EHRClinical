using Model.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EHRWebApplication.Models
{
    public class PatientViewModel
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

        public UserViewModel User { get; set; }
    }

    public class PatientDetailsViewModel
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

        [Display(Name = "EHR nº")]
        public string EhrNumber { get; set; }

        public User User { get; set; }
    }

    public class PatientEditViewModel
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

        public UserEditViewModel User { get; set; }
    }
}