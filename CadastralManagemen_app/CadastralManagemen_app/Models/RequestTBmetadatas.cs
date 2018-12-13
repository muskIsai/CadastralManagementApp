using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CadastralManagemen_app.Models
{
    [MetadataType(typeof(RequestTBmetadatas))]
    public partial class RequestTB
    {

    }

    public class RequestTBmetadatas
    {
       // [Display(Name = "ID")]
        [Key]
        public int IDrequest { get; set; }
        [Required]
        [Display(Name = "Дата запроса")]
        public System.DateTime requestDate { get; set; }
        [Required]
        [Display(Name = "Статус запроса")]
        public string status { get; set; }
        [Required]
        [Display(Name = "Пользователь")]
        public int IDusers { get; set; }
        [Required(ErrorMessage = "Нельзя пропустить это поля")]
        [Display(Name = "Объект")]
        public int IDcadastreObjects { get; set; }

        public virtual CadastreObjectsTB CadastreObjectsTB { get; set; }
        public virtual Users Users { get; set; }
    }
}