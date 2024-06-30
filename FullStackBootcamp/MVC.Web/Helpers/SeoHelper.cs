using System.Text.RegularExpressions;

namespace MVC.Web.Helpers
{
    public static class SeoHelper
    {
        public static string MakeSeoFriendly(this string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return string.Empty;
            }

            string seoFriendlyName = name.ToLower();

            seoFriendlyName = seoFriendlyName
                .Replace('ö', 'o')
                .Replace('ü', 'u')
                .Replace('ç', 'c')
                .Replace('ş', 's');
            seoFriendlyName = Regex.Replace(seoFriendlyName, @"[^a-z0-9\s-]", "");

            seoFriendlyName = Regex.Replace(seoFriendlyName, @"\s+", "-");

            return seoFriendlyName;
        }
    }
}
