using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CashRegisterChallengeNet
{
    public static class EnumsAndConstants
    {
        public enum Denominations
        {
            ONE_HUNDRED = 10000,
            FIFTY = 5000,
            TWENTY = 2000,
            TEN = 1000,
            FIVE = 500,
            TWO = 200,
            ONE = 100,
            HALF_DOLLAR = 050,
            QUARTER = 025,
            DIME = 010,
            NICKEL = 005,
            PENNY = 001
        }

        public static decimal GetDecimalValue(this Denominations denomination)
        {
            return (decimal)denomination / 100m;
        }

        public static IEnumerable<Denominations> GetAllPossibleDenominations()
        {
            return Enum.GetValues(typeof(Denominations)).Cast<Denominations>();
        }
    }
}
