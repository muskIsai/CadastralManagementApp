using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CadastralManagemen_app.Models
{
    public class Request
    {
        public int IdRequest { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }

        public int Iduser { get; set; }
        public virtual User user { get; set; }
    }
}