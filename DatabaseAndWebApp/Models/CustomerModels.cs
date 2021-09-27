using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DatabaseAndWebApp.Dal;
using System.ComponentModel.DataAnnotations;

namespace DatabaseAndWebApp.Models
{
    public class CustomerModels
    {
    }

    public class CustomerModel
    {
        public int CustomerId { get; set; }
        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }
        [Display(Name = "Country")]
        [Required]
        public string Country { get; set; }
        [Display(Name = "Email")]
        [Required]
        public string Email { get; set; }
    }

    public class AllCustomersModel
    {
        public List<CustomerModel> Customers { get; set; }
    }
}