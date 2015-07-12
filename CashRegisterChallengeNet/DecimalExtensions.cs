using System.Globalization;

namespace CashRegisterChallengeNet
{
    public static class DecimalExtensions
    {
        public static string PrettyPrint(this decimal input)
        {
            return input.ToString("#,##0.00", new CultureInfo("en-US"));
        }
    }
}
