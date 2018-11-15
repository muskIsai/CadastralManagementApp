using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CadastralManagemen_app.Models
{
    public class CadastreObjects
    {
        public int IdCadastreObjects { get; set; }
        public string Address { get; set; }
        [Display(Name = "Type Cadastre")]
        public string TypeCadastre { get; set; }
        [Display(Name = "Registration date")]
        public DateTime RegistrationDate { get; set; }
    }
}