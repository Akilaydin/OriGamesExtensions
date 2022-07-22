using System.Linq;

namespace LogBreaker.Utils.Extensions
{
    public static class CommonExtensions
    {
        public static bool IsOneOf<T>(this T item, params T[] options)
        {
            return options.Contains(item);
        }
    }
}