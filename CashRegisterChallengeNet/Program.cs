using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CashRegisterChallengeNet
{
    class Program
    {
        static void Main()
        {
            decimal total, paid;
            AskTotalAndPaid(out total, out paid);

            decimal returns;
            var denominationsToReturn = Logic.CalculateReturns(total, paid, out returns);
            Console.WriteLine("Total: {0}", total.PrettyPrint());
            Console.WriteLine("Paid: {0}", paid.PrettyPrint());
            Console.WriteLine("Return: {0}", returns.PrettyPrint());
            foreach (var denomination in denominationsToReturn)
            {
                Console.WriteLine("\tReturn {0} {1} ({2})", denomination.Value, denomination.Key, denomination.Key.GetDecimalValue().PrettyPrint());
            }

            Console.Read();
        }

        private static void AskTotalAndPaid(out decimal total, out decimal paid)
        {
            total = AskTotal();
            paid = AskPaid();
            if (total > paid)
            {
                Console.WriteLine("You can't pay less than the total, please try again");
                AskTotalAndPaid(out total, out paid);
            }
        }

        private static decimal AskTotal()
        {
            Console.WriteLine("What's the total (format: 1,234.56)?");
            var totalText = Console.ReadLine();
            decimal total;
            if (!ConvertInputToDecimal(totalText, out total))
            {
                Console.WriteLine("Unknown format, please try again");
                return AskTotal();
            }
            else
            {
                return total;
            }
        }

        private static decimal AskPaid()
        {
            Console.WriteLine("How much is paid (format: 1,234.56)?");
            var paidText = Console.ReadLine();
            decimal paid;
            if (!ConvertInputToDecimal(paidText, out paid))
            {
                Console.WriteLine("Unknown format, please try again");
                return AskPaid();
            }
            else
            {
                return paid;
            }
        }

        private static bool ConvertInputToDecimal(string input, out decimal value)
        {
            var r = new Regex(@"^((\d{1,3},)+\d{3}|\d+)(\.\d{1,2})?$");
            if (!r.IsMatch(input))
            {
                value = -1;
                return false;
            }
            else
            {
                value = decimal.Parse(input, new CultureInfo("en-US"));
                return true;
            }
        }
    }
}
