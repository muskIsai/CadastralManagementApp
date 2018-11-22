using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CadastralManagemen_app.Models
{
    public class Client
    {
        public int Idclient { get; set; }
        public int PassportNumber { get; set; }

        List<User> user { get; set; }
    }
}