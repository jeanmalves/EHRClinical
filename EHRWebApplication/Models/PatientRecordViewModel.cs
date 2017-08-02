using Model.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EHRWebApplication.Models
{
    public class PatientRecordViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Data")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? CreatedAt { get; set; }

        [Display(Name = "Procedimento")]
        public string OptName { get; set; }

        [Display(Name = "Médico")]
        public string Doctor { get; set; }

    }

    public class PatientRecordDetailsViewModel
    {
        public int Id { get; set; }

        public int PatientId { get; set; }

        [Display(Name = "Data")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? CreatedAt { get; set; }

        [Display(Name = "Procedimento")]
        public string OptName { get; set; }

        [Display(Name = "Médico")]
        public string Doctor { get; set; }

        public ICollection<Data> Data { get; set; }
    }
}