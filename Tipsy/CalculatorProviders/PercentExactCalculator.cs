using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tipsy.CalculatorProviders
{
    class PercentExactCalculator : ITipCalculator
    {
        private float bill;
        private float people;
        private float tip;

        public PercentExactCalculator(float bill, float people)
        {
            // TODO: Complete member initialization
            this.bill = bill;
            this.people = people;
        }

        public PercentExactCalculator(float bill, float people, float tip)
        {
            // TODO: Complete member initialization
            this.bill = bill;
            this.people = people;
            this.tip = tip;
        }

        public float CalculateTip()
        {
            var billpercentage = (tip / 100) * bill;

            return (bill + billpercentage) / people;
        }

    }
}
