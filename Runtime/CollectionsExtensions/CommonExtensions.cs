using System.Linq;

namespace OriGames.Extensions.CollectionExtensions
{
    public static class CommonExtensions
    {
        public static bool IsOneOf<T>(this T item, params T[] options)
        {
            return options.Contains(item);
        }
    }
}