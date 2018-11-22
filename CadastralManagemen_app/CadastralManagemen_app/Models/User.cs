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
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public bool PhoneNumberConfirmed { get; set; } //Retorna verdairo se o num for igaul
        public string Roles { get; set; }
        public string Logins { get; set; }
        public bool TwoFactorEnabled { get; set; }//Se for True igual True se 
        public string PasswordHash { get; set; }
        public int AccessFailedCount { get; set; }//Numero d tentatovasd d senha
        public bool EmailConfirmed { get; set; } //Retorna True se o a senha for igual

        List<CadastreObjects> cadastreObjects { get; set; }
        List<Client> client { get; set; }


    }
}