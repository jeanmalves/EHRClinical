﻿using Model.BLL;
using Model.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EHRWebApplication.Models
{
    public class AuthViewModel
    {
        [Required(ErrorMessage = "Campo obrigatório.")]
        [Display(Name = "Usuário")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        public int Role { get; set; }
        public Dictionary<int, string> Roles
        {
            get {

                var rolesDictionary = new Dictionary<int, string>();

                var roles = RoleGroupBLL.GetRolesGroup();

                foreach (var role in roles)
                {
                    if (role.Id != (int) Model.DAO.Roles.DOCTOR)
                    {
                        rolesDictionary.Add(role.Id, role.Description);
                    }
                }
                
                return rolesDictionary;
            }
            set { }
        }
    }
}