using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CadastralManagemen_app.Models;
using System.Data.Entity;

namespace CadastralManagemen_app.Controllers
{
    public class CadastreObjectsController : Controller
    {
        //Instancia d objecto da BD (CadastralManagBD1Entities) = possibilitará a comunicação emtre (models) com a BD da App
        private CadastralManagBD1Entities db = new CadastralManagBD1Entities();


        // GET: CadastreObjects
        public ActionResult Index()
        {
            var cadastreobject = db.CadastreObjectsTB.Include(m => m.Users).Include(m => m.RequestTB).ToList();
            return View(cadastreobject);
            //xtou a retormar uma lista ".ToList()" d tds os cadastros d objecto ".CadastreObjectsTB" disponivel 
            //no contexto db
            //Include(). = Usando esse metdo, xtamos informando ao EF q para alem d carregarmos a tabela (CadastreObjectsTB)
            //quremos obter os seus relaciomentos com a tabela User e RequestTB, nesse caso xtou a mostrar cadastro d  
            //objectos e seus respetivos Usuarios (Users) e Pedidos (RequestTB)
            
        }
    }
}