using System.Collections.Specialized;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace Tools
{
    public static class HttpHelpers
    {
        public static NameValueCollection ParseUrlEncodedString(this string value)
        {
            return HttpUtility.ParseQueryString(value);
        }

        public static string UrlEncodedString(this string value)
        {
            return HttpUtility.UrlEncode(value);
        }

        public static string ExtractLinkHeaderNext(string linkHeader)
        {
            if (string.IsNullOrWhiteSpace(linkHeader)) return null;

            var nextUrl = string.Empty;
            var linkStrings = linkHeader.Split(',');

            if (linkStrings != null && linkStrings.Any())
            {
                foreach (string linkString in linkStrings)
                {
                    var relMatch = Regex.Match(linkString, "(?<=rel=\").+?(?=\")", RegexOptions.IgnoreCase);
                    var linkMatch = Regex.Match(linkString, "(?<=<).+?(?=>)", RegexOptions.IgnoreCase);

                    if (relMatch.Success && linkMatch.Success && relMatch.Value.ToUpper() == "NEXT")
                    {
                        nextUrl = linkMatch.Value;
                    }
                }
            }

            return nextUrl;
        }

        public static string ExtractLinkHeaderNextPage(string linkHeader)
        {
            var nextUrl = ExtractLinkHeaderNext(linkHeader);
            if (string.IsNullOrWhiteSpace(nextUrl)) return null;
            return $"?{nextUrl.Split("?").LastOrDefault()}";
        }
    }
}
