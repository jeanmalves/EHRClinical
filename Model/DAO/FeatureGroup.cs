//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model.DAO
{
    using System;
    using System.Collections.Generic;
    
    public partial class FeatureGroup
    {
        public int Id { get; set; }
        public int FeatureID { get; set; }
        public int RoleGroupID { get; set; }
    
        public virtual Feature Feature { get; set; }
        public virtual RolesGroup RolesGroup { get; set; }
    }
}
