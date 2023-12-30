using FlixOne.InventoryManagemement.interfaces;

namespace FlixOne.InventoryManagemementClient.ui;

public class ConsoleUserInterface : IUserInterface {
    //read value from console
     public string ReadValue(string message){
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(message);
        return Console.ReadLine();
     }
    //message to the console
    public void WriteMessage(string message){
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(message);
    }

    //writer warning message to the console
    public void WriteWarning(string message){
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine(message);
    }
}