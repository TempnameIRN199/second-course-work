using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_project.DB
{
    public class EnumStringValueAttributes : Attribute
    {
        public string StringValue { get; protected set; }

        public EnumStringValueAttributes(string value)
        {
            this.StringValue = value;
        }
    }

    public enum EnumType
    {
        [EnumStringValue("Лекція")]
        Lecture,
        [EnumStringValue("Практичне заняття")]
        Practice,
        [EnumStringValue("Лабораторна робота")]
        Laboratory
    }

    public static class EnumExtensions
    {
        public static string GetStringValues(this Enum value)
        {
            var type = value.GetType();
            var fieldInfo = type.GetField(value.ToString());
            var attributes = fieldInfo.GetCustomAttributes(typeof(EnumStringValueAttributes), false) as EnumStringValueAttributes[];

            return attributes != null && attributes.Length > 0 ? attributes[0].StringValue : null;
        }
    }
}
