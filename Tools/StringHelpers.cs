﻿using System.IO;
using System.Text.RegularExpressions;

namespace Tools
{
    public static class StringHelpers
    {
        public static string RemoveHtmlTags(this string htmlString)
        {
            return Regex.Replace(htmlString, @"<(.|\n)*?>", string.Empty);
        }

        public static string ReSizeTextField(this string text, int maxLenth)
        {
            if (text.Length > maxLenth)
            {
                text = text.Substring(0, maxLenth);
            }
            return text;
        }

        public static string ReSizeTextFieldWithEllipsis(this string text, int maxLenth)
        {
            if (text.Length > maxLenth)
            {
                text = $"{text.Substring(0, maxLenth - 3)}...";
            }
            return text;
        }

        public static string ReSizeForMultiLineText(this string text)
        {
            if (text.Length > 4000)
            {
                text = text.Substring(0, 4000);
            }
            return text;
        }

        public static string ReplaceSpacesWithUnderscores(this string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return text;
            return text.Replace(' ', '_');
        }

        public static string ReplaceSpacesWithUnderscoresAndRemoveSpecialCharacters(this string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return text;
            return Regex.Replace(text.Replace(' ', '_'), "[^\\w\\._]", string.Empty);
        }

        public static string CapitalizeWord(this string word)
        {
            if (string.IsNullOrWhiteSpace(word)) return word;
            if (word.Length == 1)
            {
                return word.ToUpper();
            }
            else
            {
                return word[0].ToString().ToUpper() + word.Substring(1, word.Length - 1);
            }
        }

        public static string CapitalizeAllWords(this string sentence)
        {
            if (string.IsNullOrWhiteSpace(sentence)) return sentence;

            string result = string.Empty;
            string[] words = sentence.Split(' ');
            foreach (var word in words)
            {
                result += CapitalizeWord(word);
            }

            return result;
        }

        public static string ConvertToSafeFileName(this string fileName)
        {
            foreach (char c in Path.GetInvalidFileNameChars())
            {
                fileName = fileName.Replace(c, '_');
            }

            return fileName.ReplaceSpacesWithUnderscores();
        }

        public static void SplitFullNameToFirstAndLast(string fullName, out string firstName, out string lastName)
        {
            firstName = null;
            lastName = null;
            if (string.IsNullOrWhiteSpace(fullName))
            {
                return;
            }

            fullName = fullName.Trim();
            fullName = Regex.Replace(fullName, @"\s+", " "); // Converting all spaces to one space only if any	        
            string[] nameTokens = fullName.Split(nameDelimiterArray);

            firstName = nameTokens[0];
            for (int i = 1; i < nameTokens.Length; i++)
            {
                if (nameTokens.Length > 2 && i == 1)
                {
                    firstName = firstName + " " + nameTokens[i];
                    continue;
                }

                lastName = lastName + " " + nameTokens[i];
            }
            firstName = firstName?.Trim();
            lastName = lastName?.Trim();
        }

        public static string BuildFunctionClock(this TimeSpan timeSpan)
        {
            string totalHours = timeSpan.Hours > 9 ? timeSpan.Hours.ToString() : $"0{timeSpan.Hours}";
            string totalMin = timeSpan.Minutes > 9 ? timeSpan.Minutes.ToString() : $"0{timeSpan.Minutes}";
            string totalSec = timeSpan.Seconds > 9 ? timeSpan.Seconds.ToString() : $"0{timeSpan.Seconds}";
            return $"{totalHours}:{totalMin}:{totalSec}";
        }

        public static string ExtractObjectName(this string objectUrl)
        {
            return string.Join(" ", objectUrl?.Substring(0, objectUrl.Length - 3)?.Split('_'));
        }

        public static bool IsDifferentString(this string value1, string value2)
        {
            return value1?.ToLower() != value2?.ToLower();
        }
    }
}
