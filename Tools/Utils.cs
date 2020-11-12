using Amazon.Lambda.Core;
using Models.Insightly;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace Common.Tools
{
    public static class Utils
    {
        public static void LogMessage(string message)
        {
            LambdaLogger.Log($"{message}");
            Debug.WriteLine(message);
        }

        public static void LogError(string errorMessage)
        {
            LambdaLogger.Log($"ERROR {errorMessage}");
            Debug.WriteLine($"ERROR {errorMessage}");
        }

        public static bool EndFunctionSuccessfully(string successMessage)
        {
            LogMessage(successMessage);
            LogMessage($"------------- END OF FUNCTION --------------");
            return true;
        }

        public static bool EndFunctionError(string errorMessage)
        {
            LogError($"<<<<<< ERROR >>>>>>");
            LogError(errorMessage);
            LogError($"------------- END OF FUNCTION --------------");
            return false;
        }

        public static GatewayResponse EndFunctionSuccessfullyGateway(string message, Dictionary<string, string> headers)
        {
            LogMessage(message);
            return new GatewayResponse(message, headers, 200);
        }

        public static GatewayResponse EndFunctionErrorGateway(string message, Dictionary<string, string> headers, int statusCode)
        {
            LogError(message);
            return new GatewayResponse(message, headers, statusCode);
        }

        public static string EncodeBase64(string plainText)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }
        
        public static string ExtractIdFromUrl(string url)
        {
            var splitUrl = url.Split('/');
            return splitUrl[splitUrl.Length - 1];
        }

        public static CustomField CreateCustomField(InsightlyCustomFieldObject obj, string fieldName, object fieldValue)
        {
            var customField = new CustomField() { FIELD_NAME = fieldName, FIELD_VALUE = fieldValue };
            obj.CUSTOMFIELDS.Add(customField);
            return customField;
        }

        public static CustomField ExtractCustomField(InsightlyCustomFieldObject obj, string fieldName, object fieldValue = null)
        {
            return obj?.CUSTOMFIELDS?.Where(cf => cf.FIELD_NAME == fieldName)?.FirstOrDefault() ?? CreateCustomField(obj, fieldName, fieldValue);
        }

        public static object ExtractCustomFieldValue(InsightlyCustomFieldObject obj, string fieldName)
        {
            return obj?.CUSTOMFIELDS?.Where(cf => cf.FIELD_NAME == fieldName)?.FirstOrDefault()?.FIELD_VALUE;
        }

        public static Project SetProjectCustomFieldValue(Project project, string fieldName, object value)
        {
            if (project == null || fieldName == null) return project;
            var field = ExtractCustomField(project, fieldName, value);
            field.FIELD_VALUE = value;
            return project;
        }

        public static double? SumNumericCustomFieldOnMultipleRecords(IEnumerable<InsightlyCustomFieldObject> insightlyObjects, string fieldName)
        {
            if (insightlyObjects == null || insightlyObjects.Count() == 0 || string.IsNullOrWhiteSpace(fieldName)) return null;
            double? sum = 0;

            foreach(var record in insightlyObjects)
            {
                double fieldAmount = double.TryParse(ExtractCustomFieldValue(record, fieldName)?.ToString(), out double amt) ? amt : 0;
                sum += fieldAmount;
            }

            return sum;
        }

        public static string GetStandardFieldLabel(string fieldName)
        {
            switch(fieldName)
            {
                case "ACTUAL_CLOSE_DATE":
                    return "Actual Close Date";
                case "BID_AMOUNT":
                    return "Bid";
                case "BID_CURRENCY":
                    return "Bid Currency";
                case "BID_DURATION":
                    return "Bid Duration";
                case "BID_TYPE":
                    return "Bid Type";
                case "CATEGORY_ID":
                    return "Category ID";
                case "OPPORTUNITY_STATE":
                    return "Current State";
                case "LAST_ACTIVITY_DATE_UTC":
                    return "Date of Last Activity UTC";
                case "NEXT_ACTIVITY_DATE_UTC":
                    return "Date of Next Activity UTC";
                case "OPPORTUNITY_DETAILS":
                    return "Description";
                case "FORECAST_CLOSE_DATE":
                    return "Forecast Close Date UTC";
                case "DATE_CREATED_UTC":
                    return "Opportunity Created";
                case "OPPORTUNITY_NAME":
                    return "Opportunity Name";
                case "ORGANISATION_ID":
                    return "Organization ID";
                case "PIPELINE_ID":
                    return "Pipeline ID";
                case "PROBABILITY":
                    return "Probability Of Winning";
                case "OPPORTUNITY_ID":
                    return "Record ID";
                case "STAGE_ID":
                    return "Stage ID";
                case "RESPONSIBLE_USER_ID":
                    return "User Responsible ID";
                default:
                    return fieldName;    
            }
        }

        public static long? ParseToLong(object value)
        {
            if (value == null) return null;
            var parsed = long.TryParse(value?.ToString(), out long parsedValue);
            return parsed ? (long?)parsedValue : null;
        }

        public static int? ParseToInt(object value)
        {
            if (value == null) return null;
            var parsed = int.TryParse(value?.ToString(), out int parsedValue);
            return parsed ? (int?)parsedValue : null;
        }

        public static double? ParseToDouble(object value)
        {
            if (value == null) return null;
            var parsed = double.TryParse(value?.ToString(), out double parsedValue);
            return parsed ? (double?)parsedValue : null;
        }

        public static NameValueCollection ParseUrlEncodedString(string value)
        {
            return HttpUtility.ParseQueryString(value);
        }

        public static string UrlEncodedString(string value)
        {
            return HttpUtility.UrlEncode(value);
        }

        public static string ConvertStateAbrvToFullName(string state)
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

        public static string ConvertThreeLetterNameToCountryName(string countryCode)
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

        public static string ConvertTwoLetterIsoToCountryName(string countryCode)
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

        public static bool IsNumber(object value)
        {
            if (value == null) return false;

            return value is sbyte
                    || value is byte
                    || value is short
                    || value is ushort
                    || value is int
                    || value is uint
                    || value is long
                    || value is ulong
                    || value is float
                    || value is double
                    || value is decimal;
        }

        // Credit to pimbrouwers on github: https://gist.github.com/pimbrouwers/8f78e318ccfefff18f518a483997be29
        public static string ParseNextLinkHeader(IEnumerable<string> links)
        {
            foreach (string linkString in links)
            {
                var relMatch = Regex.Match(linkString, "(?<=rel=\").+?(?=\")", RegexOptions.IgnoreCase);
                var linkMatch = Regex.Match(linkString, "(?<=<).+?(?=>)", RegexOptions.IgnoreCase);

                if (relMatch.Success && linkMatch.Success)
                {
                    string rel = relMatch.Value.ToUpper();
                    string link = linkMatch.Value;

                    if (rel == "NEXT") return link;
                }
            }

            return null;
        }
    }
}