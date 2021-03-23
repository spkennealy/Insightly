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
            LambdaLogger.Log(message);
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

        public static string EndFunctionSuccessfullyWithClock(DateTime startTime)
        {
            var endTime = DateTime.UtcNow;
            var totalTime = endTime - startTime;
            LogMessage($"Function End Time (UTC): {endTime}");
            LogMessage($"Total Function Runtime (hour:min:sec): {totalTime.BuildFunctionClock()}");
            EndFunctionSuccessfully("Done!");
            return "Success!";
        }

        public static string EndFunctionErrorWithClock(DateTime startTime, string errorMessage)
        {
            EndFunctionError(errorMessage);
            var endTime = DateTime.UtcNow;
            var totalTime = endTime - startTime;
            LogMessage($"Function End Time (UTC): {endTime}");
            LogMessage($"Total Function Runtime (hour:min:sec): {totalTime.BuildFunctionClock()}");
            return errorMessage;
        }

        public static string EncodeBase64(string plainText)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
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

        public static bool ContainsValues(this IEnumerable<dynamic> records)
        {
            return records != null && records.Count() > 0;
        }
    }
}