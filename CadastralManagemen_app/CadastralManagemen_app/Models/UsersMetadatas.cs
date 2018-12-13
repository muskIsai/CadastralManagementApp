using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CadastralManagemen_app.Models
{
    [MetadataType(typeof(UsersMetadatas))]
    public partial class Users
    {

    }

    public class UsersMetadatas
    {

        // [Display(Name = "ID")]
        [Key]
        public int IDusers { get; set; }
        [Required(ErrorMessage = "Нельзя пропустить поля фио")]
        [StringLength(15, ErrorMessage = "фио не может быть меньше 15 слов")]
        [Display(Name = "ФИО")]
        public string fullname { get; set; }
        [StringLength(12, ErrorMessage = "Должен быть только 12 число. Пример: +79601932498")]
        [Display(Name = "Телефон")]
        [Phone]
        public string phoneNumber { get; set; }
        [Required(ErrorMessage = "Нельзя пропустить поля Адресса")]
        [StringLength(15, ErrorMessage = "Адресс не может быть меньше 100 слов.")]
        [Display(Name = "Адресс")]
        public string address { get; set; }
        [Required(ErrorMessage = "Нельзя пропустить поля Адресса")]
        [Display(Name = "Почта")]
        [EmailAddress]
        public string email { get; set; }
        [Required(ErrorMessage = "Нельзя пропустить поля Адресса")]
        [Display(Name = "Логин")]
        [DataType(DataType.Password)]
        public string login { get; set; }
        [StringLength(5, ErrorMessage = "Пароль должен быть 5 слов.")]
        [Display(Name = "Пароль")]
        public string password { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AdiminTB> AdiminTB { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CadastreObjectsTB> CadastreObjectsTB { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Client> Client { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Engineer> Engineer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequestTB> RequestTB { get; set; }
    }
}