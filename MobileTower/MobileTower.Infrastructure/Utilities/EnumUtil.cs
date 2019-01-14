using System;

namespace MobileTower.Infrastructure.Utilities
{
    public class EnumUtil
    {
        private EnumUtil()
        {

        }

        public static T ParseEnum<T>(string value)
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }
    }
}
