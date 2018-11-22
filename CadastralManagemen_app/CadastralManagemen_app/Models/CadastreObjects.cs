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
        [Display(Name = "Адресс")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Объязотелно выпонить это поля", AllowEmptyStrings = false)]
        [Display(Name = "Тип кадастра")]
        public string TypeCadastre { get; set; }
        [Display(Name = "Registration date")]
        public DateTime RegistrationDate { get; set; }
        [Display(Name = "Описание")]
        public string Comment { get; set; }
        [Required(ErrorMessage = "Объязотелно выпонить это поля", AllowEmptyStrings = false)]
        [Display(Name = "Стоимость")]
        public decimal Price { get; set; }

        public int Iduser { get; set; }
        public virtual User user { get; set; }

    }
}