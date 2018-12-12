using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CadastralManagemen_app.Models
{
    [MetadataType(typeof(EngineerMetadatas))]
    public partial class Engineer
    {

    }

    public class EngineerMetadatas
    {
        public int IDengineer { get; set; }
        [Display(Name = "Одобрить")]
        public string acept { get; set; }
        [Display(Name = "Отклoнить")]
        public string refuse { get; set; }
        [Display(Name = "Пользователь")]
        public int IDusers { get; set; }

        public virtual Users Users { get; set; }
    }
}