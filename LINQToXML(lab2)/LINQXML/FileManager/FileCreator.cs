using System.Xml;
using System.Xml.Linq;
using LINQ.DataAccess;
using LINQ.Models;
using System.Xml.Serialization;
using LINQ.Common;

namespace LINQXML.FileManager;

public class FileCreator : IFileCreator
{
    private readonly DataContext _dataContext;

    public FileCreator(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    public void Create(string fileName)
    {
        SerializeDataContext(fileName);
    }
    
    public void SerializeDataContext(string filePath)
    {
        var xml = Serializer.Serialize(_dataContext);
        using (var sw = new StreamWriter(filePath))
        {
            sw.Write(xml);
        }
    }
}