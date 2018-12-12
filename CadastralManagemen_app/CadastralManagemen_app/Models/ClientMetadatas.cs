using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CadastralManagemen_app.Models
{
    [MetadataType(typeof(ClientMetadatas))]
    public partial class Client
    {

    }

    public class ClientMetadatas
    {
        [Display(Name = "ID")]
        public int IDclient { get; set; }
        [Required(ErrorMessage = "Нельзя пропустить это поля")]
        [StringLength(10, ErrorMessage ="Номер поспорта не может быть меньше 8 слов")]
        public string passportNumber { get; set; }
        [Display(Name = "Пользователь")]
        public int IDusers { get; set; }

        public virtual Users Users { get; set; }
    }
}