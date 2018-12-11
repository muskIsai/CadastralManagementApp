using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CadastralManagemen_app.Models
{
    [MetadataType(typeof(AdminTBmetadatas))]
    public partial class AdminTB
    {

    }

    public class AdminTBmetadatas
    {
        public int IDadmin { get; set; }
        [Display(Name = "User")]
        public int IDusers { get; set; }

        public virtual Users Users { get; set; }
    }
}