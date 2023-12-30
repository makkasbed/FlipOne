using FlixOne.InventoryManagemementClient.interfaces;

namespace FlixOne.InventoryManagemementClient.commands;

internal class HelpCommand : NonTerminatingCommand {
    public HelpCommand(IUserInterface userInterface) : base(userInterface)
    {
    }

    internal override bool InternalCommand()
    {
        Console.WriteLine("USAGE:");
        Console.WriteLine("\taddinventory (a)");
        Console.WriteLine("Examples:");

       
        return true;
    }
}