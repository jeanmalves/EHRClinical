using Model.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EHRWebApplication.Models
{
    public class PatientViewModel
    {
        [Required(ErrorMessage = "Campo obrigatório.")]
        [Display(Name = "Nome")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [Display(Name = "Sobrenome")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [Display(Name = "Data de nascimento")]
        public DateTime? Birth { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [Display(Name = "Sexo")]
        public short Sex { get; set; }

        public Dictionary<short, string> SexList
        {
            get { return SexDictionary.SexList; }
            set { }
        }
    }
}