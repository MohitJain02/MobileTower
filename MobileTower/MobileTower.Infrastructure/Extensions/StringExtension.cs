using System.Linq;

namespace MobileTower.Infrastructure.Extensions
{
    public static class StringExtension
    {
        public static string GetEntityUniqueId(this string url)
        {
            var string_parts = url.Split('/').ToList();

            return string_parts.LastOrDefault();
        }
    }

}
