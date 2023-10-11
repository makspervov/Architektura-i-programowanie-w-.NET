namespace Lab2.Solution
{
    public class MyFormatter
    {
        public static string FormatUsdPrice(double price)
        {
            var usc = new System.Globalization.CultureInfo("en-us");
            return price.ToString("C2", usc);
        }
        public static string FormatZlPrice(double price)
        {
            var zl = new System.Globalization.CultureInfo("pl-pl");
            return price.ToString("C2", zl);
        }
    }
}
