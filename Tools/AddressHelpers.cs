using System;
using System.Globalization;
using System.Linq;

namespace Tools
{
    public static class AddressHelpers
    {
        public static string ConvertStateAbrvToFullName(this string state)
        {
            switch (state)
            {
                case "AL":
                    return "Alabama";
                case "AK":
                    return "Alaska";
                case "AR":
                    return "Arkansas";
                case "AZ":
                    return "Arizona";
                case "CA":
                    return "California";
                case "CO":
                    return "Colorado";
                case "CT":
                    return "Connecticut";
                case "DE":
                    return "Delaware";
                case "FL":
                    return "Florida";
                case "GA":
                    return "Georgia";
                case "HI":
                    return "Hawaii";
                case "ID":
                    return "Idaho";
                case "IL":
                    return "Illinois";
                case "IN":
                    return "Indiana";
                case "IA":
                    return "Iowa";
                case "KS":
                    return "Kansas";
                case "KY":
                    return "Kentucky";
                case "LA":
                    return "Louisiana";
                case "ME":
                    return "Maine";
                case "MD":
                    return "Maryland";
                case "MA":
                    return "Massachusetts";
                case "MI":
                    return "Michigan";
                case "MN":
                    return "Minnesota";
                case "MS":
                    return "Mississippi";
                case "MO":
                    return "Missouri";
                case "MT":
                    return "Montana";
                case "NE":
                    return "Nebraska";
                case "NV":
                    return "Nevada";
                case "NH":
                    return "New Hampshire";
                case "NJ":
                    return "New Jersey";
                case "NM":
                    return "New Mexico";
                case "NY":
                    return "New York";
                case "NC":
                    return "North Carolina";
                case "ND":
                    return "North Dakota";
                case "OH":
                    return "Ohio";
                case "OK":
                    return "Oklahoma";
                case "OR":
                    return "Oregon";
                case "PA":
                    return "Pennsylvania";
                case "RI":
                    return "Rhode Island";
                case "SC":
                    return "South Carolina";
                case "SD":
                    return "South Dakota";
                case "TN":
                    return "Tennessee";
                case "TX":
                    return "Texas";
                case "UT":
                    return "Utah";
                case "VT":
                    return "Vermont";
                case "VA":
                    return "Virginia";
                case "WA":
                    return "Washington";
                case "WV":
                    return "West Virginia";
                case "WI":
                    return "Wisconsin";
                case "WY":
                    return "Wyoming";
                default:
                    return state;
            }
        }

        public static string ConvertThreeLetterNameToCountryName(this string countryCode)
        {
            if (countryCode.Length != 3)
            {
                return countryCode;
            }

            countryCode = countryCode.ToUpper();

            CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
            foreach (var region in cultures.Select(culture => new RegionInfo(culture.Name)).Where(region => string.Equals(region.ThreeLetterISORegionName, countryCode, StringComparison.CurrentCultureIgnoreCase)))
            {
                return region.EnglishName;
            }

            return null;
        }

        public static string ConvertTwoLetterIsoToCountryName(this string countryCode)
        {
            if (countryCode.Length != 2)
            {
                return countryCode;
            }

            countryCode = countryCode.ToUpper();

            CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
            foreach (var region in cultures.Select(culture => new RegionInfo(culture.Name)).Where(region => string.Equals(region.TwoLetterISORegionName, countryCode, StringComparison.CurrentCultureIgnoreCase)))
            {
                return region.EnglishName;
            }

            return countryCode;
        }
    }
}
