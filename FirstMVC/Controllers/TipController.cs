using FirstMVC.Model;
using FirstMVC.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMVC.Controllers
{
    internal class TipController
    {
        private Tip tip= new Tip();
        private Display display= new Display();

        public TipController()
        {

            display.Input();
            tip.Amount = display.Amount;
            tip.Percent = display.Percent;
            display.Tip=tip.CalculateTip();
            display.Total = tip.CalculatorTotal();
            display.Output();
        }
    }
}
