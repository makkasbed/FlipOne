using FlixOne.InventoryManagemementClient.interfaces;

namespace FlixOne.InventoryManagemementClient.commands;

internal class QuitCommand : InventoryCommand
{
    public QuitCommand(IUserInterface userInterface) : base(true, _userInterface:userInterface)
    {
    }

    internal override bool InternalCommand()
    {
        userInterface.WriteMessage("Thank you for using FlixOne Inventory management system");

        return true;
    }
}