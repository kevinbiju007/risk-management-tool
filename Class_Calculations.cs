using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RiskManagementTool
{
    internal class Class_Calculations
    {
        internal sealed class TradeResults
        {
            public decimal riskAmount { get; set; }
            public decimal stopDistance { get; set; }
            public decimal positionSize { get; set; }
            public decimal positionValue { get; set; }
            public decimal targetReward { get; set; }
            public decimal RR { get; set; }          

        }
        internal static decimal RiskAmount(decimal accountBalance, decimal riskPercentage)
        // calculates risk ammount
        {
            decimal riskAmount;
            riskAmount = accountBalance * (riskPercentage / 100m);
           
            return riskAmount;
        }

        internal static decimal StopDistance(decimal entryPrice, decimal stopPrice)
        // calculates stop distance
        {
            decimal stopDistance;
            stopDistance = Math.Abs(entryPrice - stopPrice);

            return stopDistance;
        }

        internal static decimal PositionSizeUnits(decimal accountBalance, decimal riskPercentage, decimal entryPrice, decimal stopPrice)
        // calculates position size in units
        {
            decimal riskAmount;
            decimal stopDistance;
            decimal positionSizeUnits;

            riskAmount = accountBalance * (riskPercentage / 100m);
            stopDistance = Math.Abs(entryPrice - stopPrice);
            positionSizeUnits = riskAmount / stopDistance;
            positionSizeUnits = Math.Round(positionSizeUnits, 2);
            return positionSizeUnits;
        }

        internal static decimal PositionSizeCurrency(decimal accountBalance, decimal riskPercentage, decimal entryPrice, decimal stopPrice)
        // calculates position size currency value
        {
            decimal riskAmount;
            decimal stopDistance;
            decimal positionSizeUnits;
            decimal positionSizeCurrency;

            riskAmount = accountBalance * (riskPercentage / 100m);
            stopDistance = Math.Abs(entryPrice - stopPrice);
            positionSizeUnits = riskAmount / stopDistance;
            positionSizeUnits = Math.Round(positionSizeUnits, 2);
            positionSizeCurrency = positionSizeUnits * entryPrice;

            return positionSizeCurrency;
        }

        internal static decimal TargetReward(decimal accountBalance,decimal riskPercentage, decimal entryPrice,decimal targetPrice, decimal stopPrice)
            // calculates target reward
        {
            decimal riskAmount;
            decimal stopDistance;
            decimal positionSizeUnits;
            decimal targetDistance;
            decimal targetReward;

            riskAmount = accountBalance * (riskPercentage / 100m);
            stopDistance = Math.Abs(entryPrice - stopPrice);
            positionSizeUnits = riskAmount / stopDistance;
            positionSizeUnits = Math.Round(positionSizeUnits, 2);
            targetDistance = Math.Abs(targetPrice - entryPrice);
            targetReward = positionSizeUnits * targetDistance;
            return targetReward;
        }
        internal static decimal RiskReward(decimal accountBalance, decimal riskPercentage, decimal entryPrice, decimal stopPrice, decimal targtPrice)
            // calculates risk to reward 
        {
            decimal riskAmount;
            decimal stopDistance;
            decimal positionSizeUnits;
            decimal targetDistance;
            decimal targetReward;
            decimal riskReward;
            
            riskAmount = accountBalance * (riskPercentage / 100m);
            stopDistance = Math.Abs(entryPrice - stopPrice);            
            targetDistance = Math.Abs(targtPrice - entryPrice);                        
            positionSizeUnits = riskAmount / stopPrice;
            positionSizeUnits = Math.Round(positionSizeUnits, 2);
            targetReward = positionSizeUnits * targetDistance;
            riskReward = targetDistance / stopDistance;

            return riskReward;

        }

    }
    }


