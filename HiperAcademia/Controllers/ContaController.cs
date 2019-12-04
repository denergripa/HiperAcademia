using HiperAcademia.ViewModels.Conta;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HiperAcademia.Controllers
{
    [Route("conta")]
    public class ContaController : Controller
    {
        public static decimal _saldo;
        [HttpGet("sacar")]
        public IActionResult Sacar()
        {
            var viewModel = new SaqueViewModel();
            viewModel.Saldo = _saldo;
            return View(viewModel);
        }

        [HttpPost("sacar")]
        public IActionResult Sacar(SaqueViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                viewModel.Saldo = _saldo;
                return View(viewModel);
            }
           

            _saldo = _saldo - viewModel.Valor;
            return RedirectToAction("Sacar");
        }
    }
}
