using System.Text;

namespace LINQ.Common;

public static class IEnumerableExtentions
{
    public static void Print<T>(this IEnumerable<T> data)
    {
        foreach (var element in data)
        {
            Console.WriteLine($"Element value : {element}");
        }
    }
    
    public static void Print<TKey,TValue>(this IDictionary<TKey,TValue> data)
    {
        foreach (var element in data)
        {
            Console.WriteLine($"Element key {element.Key} value : {element.Value}");
        }
    }
    
    public static string ToDisplayString<T>(this IEnumerable<T> data)
    {
        StringBuilder sb = new StringBuilder();
        
        foreach (var element in data)
        {
            sb.AppendLine($"{element}");
        }

        return sb.ToString();
    }
}