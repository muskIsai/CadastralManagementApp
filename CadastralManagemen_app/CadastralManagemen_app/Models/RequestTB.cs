//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CadastralManagemen_app.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class RequestTB
    {
        public int IDrequest { get; set; }
        public System.DateTime requestDate { get; set; }
        public string status { get; set; }
        public int IDusers { get; set; }
        public int IDcadastreObjects { get; set; }
    
        public virtual CadastreObjectsTB CadastreObjectsTB { get; set; }
        public virtual Users Users { get; set; }
    }
}