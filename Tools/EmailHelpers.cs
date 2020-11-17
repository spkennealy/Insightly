using System.Linq;

namespace Tools
{
    public static class EmailHelpers
    {
        public static string ParseEmailDomain(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return null;
            return email?.Split('@')?.Last();
        }
    }
}
