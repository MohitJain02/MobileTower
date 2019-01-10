using System;

namespace MobileTower.Infrastructure.Utilities
{
    public static class EnumUtil
    {
        public static T ParseEnum<T>(string value)
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }
    }
}
