
using LINQ.DataAccess;
using LINQ.Models;

namespace LINQXML.FileManager;

public class FileUpdater : IFileUpdater
{
    public void UpdateClient(string filePath, string clientFullName, string clientAddress, 
        string clientPhoneNumber, int clientId)
    {
        var xml = string.Empty;
        using (var sr = new StreamReader(filePath))
        {
            xml = sr.ReadToEnd();
        }
        var serializer = new System.Xml.Serialization.XmlSerializer(typeof(DataContext));
        var dataContext = (DataContext)serializer.Deserialize(new StringReader(xml));
        Client client = new Client(clientId, clientFullName, clientAddress, clientPhoneNumber);
        dataContext.Clients.Add(client);
        using (var sw = new StreamWriter(filePath))
        {
            serializer.Serialize(sw, dataContext);
        }
    }

    public void UpdateOrder(string filePath, int clientId, int orderId, int carFromVehicleFleetId, int days)
    {
        var xml = string.Empty;
        using (var sr = new StreamReader(filePath))
        {
            xml = sr.ReadToEnd();
        }
        var serializer = new System.Xml.Serialization.XmlSerializer(typeof(DataContext));
        var dataContext = (DataContext)serializer.Deserialize(new StringReader(xml));
        Order order = new Order(orderId + 1, clientId, carFromVehicleFleetId, 
            DateTime.Now, DateTime.Now.AddDays(days), false);
        dataContext.Orders.Add(order);
        using (var sw = new StreamWriter(filePath))
        {
            serializer.Serialize(sw, dataContext);
        }
    }
}