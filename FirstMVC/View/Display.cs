using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMVC.View
{
    internal class Display
    {
        public double Amount
        {
            get; set;   
        }
        public double Percent
        {
            get;set;
        }
        public double Total
        {
            get;set;
        }
        public double Tip
        {
            get;set;
        }


        public void Input()
        {
            Console.Write("Put an amount: ");
            Amount = double.Parse(Console.ReadLine());
            Console.Write("Put a percent: ");
            Percent = double.Parse(Console.ReadLine());
        }
        public void Output() 
        {
            Console.WriteLine($"Your tip is: {Tip:C}");
            Console.WriteLine($"Your total amount is: {Total:C}");
        }
    }
}
