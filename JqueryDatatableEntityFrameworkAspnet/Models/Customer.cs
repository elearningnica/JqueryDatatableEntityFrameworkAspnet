using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JqueryDatatableEntityFrameworkAspnet.Models
{
    public class Customer
    {
        [Key]
        [Display(Name = "Customer Key")]
        public int CustomerKey { get; set; }
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [StringLength(50)]
        [Display(Name = "Phone Number")]
        public string Phone { get; set; }
        [Display(Name = "Email Address")]
        [StringLength(50)]
        public string EmailAddress { get; set; }
    }
}