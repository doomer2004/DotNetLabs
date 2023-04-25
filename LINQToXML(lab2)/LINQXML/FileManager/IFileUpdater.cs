namespace LINQXML.FileManager;

public interface IFileUpdater
{
    void UpdateClient(string filePath,  string clientFullName, string clientAddress,
        string clientPhoneNumber, int clientId);
    
    void UpdateOrder(string filePath, int clientId, int orderId, int carFromVehicleFleetId,int days);
}