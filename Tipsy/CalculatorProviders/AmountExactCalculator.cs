using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tipsy.CalculatorProviders
{
    class AmountExactCalculator : ITipCalculator
    {
        private float bill;
        private float people;
        private float tip;

        public AmountExactCalculator(float bill, float people)
        {
            // TODO: Complete member initialization
            this.bill = bill;
            this.people = people;
        }

        public AmountExactCalculator(float bill, float people, float tip)
        {
            // TODO: Complete member initialization
            this.bill = bill;
            this.people = people;
            this.tip = tip;
        }

        public float CalculateTip()
        {
            tip = (bill + tip) / people;
            return tip;
        }
    }
}
