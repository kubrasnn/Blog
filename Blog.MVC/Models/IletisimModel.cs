using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blog.MVC.Models
{
    public class IletisimModel
    {
        [EmailAddress(ErrorMessage = "E-Posta formatında giriniz")]
        [Required(ErrorMessage = "E-posta zorunludur")]
        public string From { get; set; } 

           public string To { get; set; }
           public string MessageBody { get; set; }
           public string MessageSubject { get; set; }
    }
}