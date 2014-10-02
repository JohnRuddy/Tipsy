// ***********************************************************************
// Assembly         : Tipsy
// Author           : john
// Created          : 09-19-2014
//
// Last Modified By : john
// Last Modified On : 09-19-2014
// ***********************************************************************
// <copyright file="UpwardsRoundingStrategy.cs" company="">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using Tipsy.Strategies;

/// <summary>
/// The Tipsy namespace.
/// </summary>
namespace Tipsy.Strategies
{
    /// <summary>
    /// Class UpwardsRoundingStrategy.
    /// </summary>
    public class UpwardsTipStrategy : ITipDivisionStrategy
    {

        public string CalculateTip(float amount, float numPeople, ITipCalculatorProvider calc)
        {
            amount = calc.CalculateTotalAmount(amount);

            return string.Format("{0:#.00}", Convert.ToDecimal("" + (int)((amount / numPeople) + 1)));
        }
    }
}