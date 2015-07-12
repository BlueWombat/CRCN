using System;
using System.Diagnostics;
using System.Linq;
using CashRegisterChallengeNet;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class EnumTests
    {
        [Test]
        public void can_get_correct_decimal_value_from_ONE_HUNDRED_enum()
        {
            const EnumsAndConstants.Denominations currency = EnumsAndConstants.Denominations.ONE_HUNDRED;

            Assert.AreEqual(100m, currency.GetDecimalValue());
        }

        [Test]
        public void can_get_correct_decimal_value_from_FIFTY_enum()
        {
            const EnumsAndConstants.Denominations currency = EnumsAndConstants.Denominations.FIFTY;

            Assert.AreEqual(50m, currency.GetDecimalValue());
        }

        [Test]
        public void can_get_correct_decimal_value_from_TWENTY_enum()
        {
            const EnumsAndConstants.Denominations currency = EnumsAndConstants.Denominations.TWENTY;

            Assert.AreEqual(20m, currency.GetDecimalValue());
        }

        [Test]
        public void can_get_correct_decimal_value_from_TEN_enum()
        {
            const EnumsAndConstants.Denominations currency = EnumsAndConstants.Denominations.TEN;

            Assert.AreEqual(10m, currency.GetDecimalValue());
        }

        [Test]
        public void can_get_correct_decimal_value_from_FIVE_enum()
        {
            const EnumsAndConstants.Denominations currency = EnumsAndConstants.Denominations.FIVE;

            Assert.AreEqual(5m, currency.GetDecimalValue());
        }

        [Test]
        public void can_get_correct_decimal_value_from_TWO_enum()
        {
            const EnumsAndConstants.Denominations currency = EnumsAndConstants.Denominations.TWO;

            Assert.AreEqual(2m, currency.GetDecimalValue());
        }

        [Test]
        public void can_get_correct_decimal_value_from_ONE_enum()
        {
            const EnumsAndConstants.Denominations currency = EnumsAndConstants.Denominations.ONE;

            Assert.AreEqual(1m, currency.GetDecimalValue());
        }

        [Test]
        public void can_get_correct_decimal_value_from_HALF_DOLLAR_enum()
        {
            const EnumsAndConstants.Denominations currency = EnumsAndConstants.Denominations.HALF_DOLLAR;

            Assert.AreEqual(0.50m, currency.GetDecimalValue());
        }

        [Test]
        public void can_get_correct_decimal_value_from_QUARTER_enum()
        {
            const EnumsAndConstants.Denominations currency = EnumsAndConstants.Denominations.QUARTER;

            Assert.AreEqual(0.25m, currency.GetDecimalValue());
        }

        [Test]
        public void can_get_correct_decimal_value_from_DIME_enum()
        {
            const EnumsAndConstants.Denominations currency = EnumsAndConstants.Denominations.DIME;

            Assert.AreEqual(0.10m, currency.GetDecimalValue());
        }

        [Test]
        public void can_get_correct_decimal_value_from_NICKEL_enum()
        {
            const EnumsAndConstants.Denominations currency = EnumsAndConstants.Denominations.NICKEL;

            Assert.AreEqual(0.05m, currency.GetDecimalValue());
        }

        [Test]
        public void can_get_correct_decimal_value_from_PENNY_enum()
        {
            const EnumsAndConstants.Denominations currency = EnumsAndConstants.Denominations.PENNY;

            Assert.AreEqual(0.01m, currency.GetDecimalValue());
        }

        [Test]
        public void can_get_all_possible_denominations()
        {
            var billsAndCoins = EnumsAndConstants.GetAllPossibleDenominations();
            foreach (var billAndCoin in billsAndCoins)
            {
                Debug.WriteLine(billAndCoin);
            }
        }
    }
}
