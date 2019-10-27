using D_Blood.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace D_Blood.ViewModels
{
    public class RegisterDonorViewModel
    {
        public RegisterDonor RegisterDonor { get; set; }
        public IEnumerable<RegisterDonor> RegisterDonors { get; set; }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        public string Occupation { get; set; }
        [Required]
        public DateTime Dob { get; set; }
        public string Sex { get; set; }
        //[Required]
        //public string PO { get; set; }
        public long? Phone { get; set; }
        public string State { get; set; }
        [Required]
        public string LGA { get; set; }
        [Display(Name = "Nearest Reputed Person")]
        public string RepPerson { get; set; }
        [Required]
        [Display(Name = "Blood Group")]
        public string BloodGroup { get; set; }
        [Required]
        [Display(Name = "Last Donated")]
        public DateTime LastDonated { get; set; }

        public RegisterDonorViewModel()
        {
            Id = 0;
        }

        public RegisterDonorViewModel(RegisterDonor donor)
        {
            Id = donor.Id;
            Name = donor.Name;
            Address = donor.Address;
            Occupation = donor.Occupation;
            Dob = donor.Dob;
            Sex = donor.Sex;
            //PO = donor.PO;
            State = donor.State;
            LGA = donor.LGA;
            Phone = donor.Phone;
            RepPerson = donor.RepPerson;
            BloodGroup = donor.BloodGroup;
            LastDonated = donor.LastDonated;
        }
    }
}