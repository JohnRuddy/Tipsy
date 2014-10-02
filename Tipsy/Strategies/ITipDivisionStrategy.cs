using Tipsy.Enums;

namespace Tipsy.Strategies
{
    public interface ITipDivisionStrategy
    {
        string CalculateTip(float amount, float numPeople, ITipCalculatorProvider calc);
    }
}