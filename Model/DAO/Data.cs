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
    
    public partial class Data
    {
        public int Id { get; set; }
        public int TemplateAttributeId { get; set; }
        public string Value { get; set; }
        public int PatientRecordId { get; set; }
    
        public virtual PatientRecord PatientRecord { get; set; }
        public virtual TemplateAttribute TemplateAttribute { get; set; }
    }
}
