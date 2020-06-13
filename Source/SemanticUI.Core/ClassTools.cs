using System.Collections.Generic;
using System.Linq;

namespace Sidea.SemanticUI.Core
{
    public static class ClassTools
    {
        public static string ToClass(this IEnumerable<string> classes)
            => string.Join(" ", classes.Where(c => !string.IsNullOrWhiteSpace(c)).ToArray());

        public static string ToClassIf(this string @class, bool condition)
            => condition ? @class : string.Empty;

        public static string ToClassIfNot(this string @class, bool condition)
            => condition ? string.Empty : @class;

        public static string ToClassIf(this bool value, string trueClass)
            => value.ToClass(trueClass, string.Empty);

        public static string ToClassIfNot(this bool value, string falseClass)
            => value.ToClass(string.Empty, falseClass);

        public static string ToClass(this bool value, string trueClass, string falseClass)
            => (value ? trueClass : falseClass) ?? string.Empty; 

        public static void SetAsAttribute(this string value, string attributeName, IDictionary<string, object> attributes, bool ignoreIfNull = true)
            => SetAttribute(attributeName, value, attributes, ignoreIfNull);

        public static void SetAttribute(string attributeName, object value, IDictionary<string, object> attributes, bool ignoreIfNull = true)
        {
            if(ignoreIfNull && value == null)
            {
                return;
            }

            if (attributes.ContainsKey(attributeName))
            {
                attributes[attributeName] = value;
            }
            else
            {
                attributes.Add(attributeName, value);
            }
        }
    }
}
