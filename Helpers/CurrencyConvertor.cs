using NUnit.Framework;
using System;
using System.Globalization;

namespace ForthDemo_v1.Helpers
{
    public class CurrencyConvertor
    {
        private NumberStyles style;
        private CultureInfo culture;

        public CurrencyConvertor(NumberStyles style, CultureInfo culture)
        {
            this.style = style;
            this.culture = culture;
        }

        public decimal ConvertCurrencyStringToDecimal(string value)
        {
            decimal number;
            var isParsed = Decimal.TryParse(value, style, culture, out number);
            Assert.IsTrue(isParsed, "Parsing failed");

            return number;
        }
    }
}
