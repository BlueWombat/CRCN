using System;
using System.Collections.Generic;
using System.Linq;

namespace CashRegisterChallengeNet
{
    public sealed class Logic
    {
        public static Dictionary<EnumsAndConstants.Denominations, int> CalculateReturns(decimal total, decimal paid, out decimal returns)
        {
            if (total > paid)
                throw new ArgumentException("You can't pay less than the total of your purchase");

            var denominationsToReturn = new Dictionary<EnumsAndConstants.Denominations, int>();
            returns = 0.00m;
            var subTotal = paid - total;

            var possibleDenominations = EnumsAndConstants.GetAllPossibleDenominations().OrderByDescending(d => d);

            foreach (var possibleDenomination in possibleDenominations)
            {
                var decimalValue = possibleDenomination.GetDecimalValue();
                while (subTotal >= decimalValue)
                {
                    returns += decimalValue;
                    subTotal -= decimalValue;
                    if (denominationsToReturn.ContainsKey(possibleDenomination))
                    {
                        denominationsToReturn[possibleDenomination]++;
                    }
                    else
                    {
                        denominationsToReturn.Add(possibleDenomination, 1);
                    }
                }
            }

            return denominationsToReturn;
        }
    }
}
