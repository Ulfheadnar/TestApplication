using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JobTestProject.Models
{
    //! Class wich represents the model of "Acuaintance" with validation. Has 6 properties;
    public class MyAcuaintance
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please give the name")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please give the surname")]
        [Display(Name = "Surname")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Please give the email adress")]
        [EmailAddress(ErrorMessage = "Please give the email adress")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Please give the phone number")]
        [Phone(ErrorMessage = "Please give only number")]
        [Display(Name = "Phone")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please give the description")]
        [Display(Name = "Description")]
        public string Description { get; set; }
    }
}