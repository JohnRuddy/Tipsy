using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tipsy.CalculatorProviders
{
    class PercentRoundupCalculator : ITipCalculator
    {

        private float bill;
        private float people;
        private float tip;

        public PercentRoundupCalculator(float bill, float people)
        {
            // TODO: Complete member initialization
            this.bill = bill;
            this.people = people;
        }

        public PercentRoundupCalculator(float bill, float people, float tip)
        {
            // TODO: Complete member initialization
            this.bill = bill;
            this.people = people;
            this.tip = tip;
        }

        public float CalculateTip()
        {
            var billpercentage = (tip / 100) * bill;

            var tipAmount = (bill + billpercentage) / people;

            var tipNearestWholeInt = float.Parse("" + (int)tipAmount);
            if (tipAmount > tipNearestWholeInt)
                return tipNearestWholeInt + 1;
            else
                return tipNearestWholeInt;
            
        }

    }
}
