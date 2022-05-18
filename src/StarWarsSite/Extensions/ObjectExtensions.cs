using System.Text.RegularExpressions;

namespace StarWarsSite.Extensions;

public static class ObjectExtension
{
    public static List<KeyValuePair<string, string>> ToDictionary(this object obj)
    {
        var dictionary = new List<KeyValuePair<string, string>>();
        foreach (var property in obj.GetType().GetProperties())
        {
            var value = property.GetValue(obj);
            var propertyName =
                Regex.Replace(property.Name, "(?!^)([A-Z])",
                    " $1"); // Splits property name into words. Uses negative lookahead to match only uppercase letters, and insert a space in front of each match.
            var propertyValue = ParseValue(value);
            dictionary.Add(new KeyValuePair<string, string>(propertyName, propertyValue));
        }

        var nameKeyVal = dictionary.Find(x => x.Key == "Name");
        dictionary.Remove(nameKeyVal);
        return dictionary.Prepend(nameKeyVal).ToList();
    }

    private static string ParseValue(object? value)
    {
        return value switch
        {
            string[] => string.Join(", ", (string[])value),
            _ => value?.ToString() ?? "Unknown"
        };
    }
}