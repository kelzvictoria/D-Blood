using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace D_Blood.Models
{
    public class RegisterDonor
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        public string Occupation { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Dob { get; set; }
        public string Sex { get; set; }
        //[Required]
        //public string PO { get; set; }
        public long? Phone { get; set; }
        public string State { get; set; }
        [Required]
        public string LGA { get; set; }
        [Display(Name="Nearest Reputed Person")]
        public string RepPerson { get; set; }
        [Required]
        [Display(Name="Blood Group")]
        public string BloodGroup { get; set; }
        [Required]
        [Display(Name="Last Donated")]
        [DataType(DataType.Date)]
        public DateTime LastDonated { get; set; }

    }
}