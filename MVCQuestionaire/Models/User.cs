using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCQuestionaire.Models
{
    [MetadataType(typeof(UserAnnotations))]
    public partial class User
    {
    }

    public class UserAnnotations
    {
        [Required(ErrorMessage="Please enter your name"), 
        StringLength(50, ErrorMessage="Max characters for your name is 50")]
        public string Name { get; set; }

        [Required(ErrorMessage="Please enter your phone number"),
        StringLength(20, ErrorMessage = "Max characters for your phone number is 20")]
        public string Phone { get; set; }
    }
}