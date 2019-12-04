using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HiperAcademia.ViewModels.Conta
{
    public class SaqueViewModel
    {
        public decimal Saldo { get; set; }

        [Required(ErrorMessage = "O Campo Valor é Obrigatório cuzão")]
        [Range(2,500, ErrorMessage = "Você deve informar um valor entre 2 e 500 reais.")]
        public decimal Valor { get; set; }
    }
}
