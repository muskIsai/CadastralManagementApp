using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CadastralManagemen_app.Models
{
    public class User //Medelo do usuario principal
    {
        public int Iduser { get; set; }
        [Display(Name = "Full name")]
        public string FullName { get; set; }

        [Display(Name = "E-mail")]
        [EmailAddress]
        public string Email { get; set; }
        public string NumberPhone { get; set; }
        public string Address { get; set; }

    }
}