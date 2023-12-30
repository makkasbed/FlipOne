namespace FlixOne.InventoryManagemementClient.interfaces;

public interface IUserInterface {
    public string ReadValue(string message);
    public void WriteMessage(string message);
    public void WriteWarning(string message);
}