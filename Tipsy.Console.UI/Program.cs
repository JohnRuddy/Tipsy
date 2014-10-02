using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tipsy;
using Tipsy.Enums;

namespace Tipsy.Console.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("People : ");
            var people = float.Parse(System.Console.ReadLine());
            
            System.Console.Write("Bill : ");
            var bill = float.Parse(System.Console.ReadLine());

            System.Console.Write("Tip : ");
            var tipAmount = float.Parse(System.Console.ReadLine()); 

            System.Console.Write("Type (P)ercentage or (A)mount : ");
            var type = System.Console.ReadLine();

            var tiptype = type.Equals("p") ? Enums.TipType.PercentageRoundUp : Enums.TipType.PercentageExact;
            var calcB = new Calculator(people, bill, tiptype, tipAmount);
            
            System.Console.WriteLine("Bill Per Person: \t {0}", calcB.PrintTip());
            System.Console.ReadKey();
        }
    }
}
