using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_project.DB
{
    public class EnumStringValueAttribute : Attribute
    {
        public string Value { get; protected set; }

        public EnumStringValueAttribute(string value)
        {
            Value = value;
        }
    }

    public enum EnumSkip
    {
        [EnumStringValue("Отсутствие")]
        Absent,

        [EnumStringValue("Опоздание")]
        Late,

        [EnumStringValue("Уважительная причина")]
        Excused,

        [EnumStringValue("Уважительная причина")]
        Present
    }

    public static class EnumExtension
    {
        public static string GetStringValue(this Enum value)
        {
            var type = value.GetType();
            var fieldInfo = type.GetField(value.ToString());
            var attributes = fieldInfo.GetCustomAttributes(typeof(EnumStringValueAttribute), false) as EnumStringValueAttribute[];

            return attributes != null && attributes.Length > 0 ? attributes[0].Value : null;
        }
    }
}
