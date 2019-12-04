using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HiperAcademia.Controllers
{
  
    [Route("")]
    public class HomeController : Controller
    {
     
        [HttpGet]
        public IActionResult Index()
        {
            return View(); //Abstração do framework que simboliza que estou devolvendo um view pra tela (arquivo html)
        }

        

    }
}
