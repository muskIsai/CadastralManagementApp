using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CadastralManagemen_app.Models
{
    [MetadataType(typeof(CadastreObjectsTBmetadatas))]
    public partial class CadastreObjectsTB
    {

    }

    public class CadastreObjectsTBmetadatas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CadastreObjectsTBmetadatas()
        {
            this.RequestTB = new HashSet<RequestTB>();
        }


        // [Display(Name = "ID")]
        [Key]
        public int IDcadastreObjects { get; set; }
        [Display(Name = "Cтоимость")]
        public decimal price { get; set; }
        [Required(ErrorMessage = "Объязотелно выпонить это поля", AllowEmptyStrings = false)]
        [Display(Name = "Тип кадастра")]
        public string typeCadastre { get; set; }
        [Display(Name = "Дата доставка на учет")]
        public System.DateTime registrationDate { get; set; }
        [Required(ErrorMessage = "Объязотелно выпонять это поля", AllowEmptyStrings = false)]
        [Display(Name = "Коментарый")]
        public string comment { get; set; }
        [Display(Name = "Пользователь")]
        public int IDusers { get; set; }
        [Display(Name = "Заявка")]
        public int IDreques { get; set; }

        public virtual Users Users { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequestTB> RequestTB { get; set; }
    }
}