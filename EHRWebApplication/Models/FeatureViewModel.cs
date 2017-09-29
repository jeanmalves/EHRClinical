using Model.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EHRWebApplication.Models
{
    public class FeatureViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Funcionalidade")]
        public string Feature { get; set; }

        [Display(Name= "Descrição")]
        public string Description { get; set; }

        [Display(Name = "Criado em")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? CreatedAt { get; set; }

        [Display(Name = "EHR Template")]
        public string TemplateName { get; set; }

        public short? DisplayMenu { get; set; }

        [Display(Name = "Exibir no menu")]
        public string DisplayMenuLabel{ get; set; }

        public short Status { get; set; }

        [Display(Name = "Status")]
        public string StatusLabel { get; set; }

        public int RoleGroup { get; set; }

        [Display(Name = "Grupo de Usuário")]
        public string RoleGroupLabel { get; set; }
    }

    public class EditFeatureViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Funcionalidade")]
        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Feature { get; set; }

        [Display(Name = "Descrição")]
        public string Description { get; set; }
        
        [Display(Name = "EHR Template")]
        public string TemplateName { get; set; }

        [Display(Name = "Exibir no menu")]
        public short? DisplayMenu { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        public short Status { get; set; }

        [Display(Name = "Grupo de Usuário")]
        [Required(ErrorMessage = "Campo obrigatório.")]
        public int RoleGroup { get; set; }

        public Dictionary<int, string> Roles
        {
            get { return RolesDictionary.RoleList; }
            set { }
        }

        public Dictionary<int, string> StatusList
        {
            get { return StatusDictionary.StatusList; }
            set { }
        }

        public Dictionary<int, string> BooleanList
        {
            get { return BooleanDictionary.BooleanList; }
            set { }
        }
    }
}