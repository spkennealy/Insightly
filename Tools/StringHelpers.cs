using System.IO;
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
    }
}
