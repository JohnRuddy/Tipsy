using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tipsy.CalculatorProviders;

namespace Tipsy
{
    public class Calculator
    {
        public float people { get; set; }
        public float bill { get; set; }
        public ITipCalculator TipCalculator { get; set; }
        public float Tip { get; set; }

        public Calculator(float ppl, float b, Tipsy.Enums.TipType type, float tip)
        {
            people = ppl;
            bill = b;

            if (type == Enums.TipType.AmountExact)
            {
                TipCalculator = new AmountExactCalculator(bill, people, tip);
            }
            else if (type == Enums.TipType.PercentageExact)
            {
                TipCalculator = new PercentExactCalculator(bill, people, tip);
            }
            else if (type == Enums.TipType.PercentageRoundUp)
            {
                TipCalculator = new PercentRoundupCalculator(bill, people, tip);
            }
            Tip = TipCalculator.CalculateTip();
        }

        public string PrintTip()
        {
            try
            {
                return string.Format("{0:#.00}", Convert.ToDecimal("" + this.Tip));
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
    }
 
}
