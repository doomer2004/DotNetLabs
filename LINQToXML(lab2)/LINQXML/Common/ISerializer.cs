using System.Xml.Linq;

namespace LINQ.Common;

public interface ISerializer
{
    string Serialize<T>(T obj);

    T Deserialize<T>(XElement element);

    IEnumerable<T> Deserialize<T>(IEnumerable<XElement> elements);
}