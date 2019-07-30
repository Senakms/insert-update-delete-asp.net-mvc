using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace project01.ViewModel
{
    public class recorModel
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Enter Name Surname!")]
        [Display(Name = "Name Surname")]
        [StringLength(50, ErrorMessage = "Name Surname must be at most 50 characters !")]
        public string NameSurname { get; set; }

        [Required(ErrorMessage = "Enter email!")]
        [Display(Name = "E-mail")]
        [StringLength(50, ErrorMessage = "E-mail must be at most 50 characters!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter Age!")]
        [Display(Name = "Age")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Enter GSM!")]
        [Display(Name = "GSM")]
        [StringLength(50, ErrorMessage = "Gsm must be at most 50 characters!")]
        public string Gsm { get; set; }

        [Required(ErrorMessage = "Enter Address!")]
        [Display(Name = "Address")]
        [StringLength(50, ErrorMessage = "Address must be at most 50 characters!")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Enter city!")]
        [Display(Name = "City")]
        [StringLength(50, ErrorMessage = "City must be at most 50 characters!")]
        public string City { get; set; }
    }
}