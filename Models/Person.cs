using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace AttributesRequired.Models
{
    public class Person
    {
        [DisplayName("First Name:")]
        [Required]
        public string First { get; set; }
        [DisplayName("Last Name:")]
        [Required]
        public string Last { get; set; }
        [DisplayName("Age:")]
        [Range(0,120)]
        public string Age { get; set; }
    }
}