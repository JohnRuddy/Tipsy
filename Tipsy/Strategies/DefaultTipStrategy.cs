// ***********************************************************************
// Assembly         : Tipsy
// Author           : john
// Created          : 09-19-2014
//
// Last Modified By : john
// Last Modified On : 09-19-2014
// ***********************************************************************
// <copyright file="DefaultRoundingStrategy.cs" company="">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tipsy.Strategies;

/// <summary>
/// The Tipsy namespace.
/// </summary>
namespace Tipsy.Strategies
{

    /// <summary>
    /// Class DefaultRoundingStrategy.
    /// </summary>
    public class DefaultTipStrategy : ITipDivisionStrategy
    {
        private float tip;

        public DefaultTipStrategy()
        {
            // TODO: Complete member initialization
        }
        public string CalculateTip(float amount, float numPeople)
        {
            return string.Format("{0:#.00}", Convert.ToDecimal("" + amount / numPeople));
        }
    }

    /// <summary>
    /// Class UpwardsRoundingStrategy.
    /// </summary>
}
