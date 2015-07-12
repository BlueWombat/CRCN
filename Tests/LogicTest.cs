using System;
using System.Collections.Generic;
using System.Diagnostics;
using CashRegisterChallengeNet;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class LogicTest
    {
        [Test]
        public void can_calculate_returns_for_total_156_97_and_paid_200()
        {
            const decimal total = 156.97m, paid = 200;
            decimal returns;
            var denominationsToReturn = Logic.CalculateReturns(total, paid, out returns);
            Debug.WriteLine("Total: {0}", total);
            Debug.WriteLine("Paid: {0}", paid);
            Debug.WriteLine("Return: {0}", returns);
            foreach (var denomination in denominationsToReturn)
            {
                Debug.WriteLine("\tReturn {0} {1} ({2})", denomination.Value, denomination.Key, denomination.Key.GetDecimalValue());
            }

            Assert.AreEqual(43.03, returns);
            Assert.AreEqual(new Dictionary<EnumsAndConstants.Denominations, int>
            {
                {
                    EnumsAndConstants.Denominations.TWENTY, 
                    2
                },
                {
                    EnumsAndConstants.Denominations.TWO, 
                    1
                },
                {
                    EnumsAndConstants.Denominations.ONE, 
                    1
                },
                {
                    EnumsAndConstants.Denominations.PENNY, 
                    3
                }
            }, denominationsToReturn);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void throws_exception_when_less_is_paid_than_total()
        {
            const decimal total = 232, paid = 200;
            decimal returns;
            var denominationsToReturn = Logic.CalculateReturns(total, paid, out returns);
        }
    }
}
