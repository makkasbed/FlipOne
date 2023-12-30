using FlixOne.InventoryManagemementClient.interfaces;

namespace FlixOne.InventoryManagemementClient.commands;

internal abstract class NonTerminatingCommand: InventoryCommand {
    protected NonTerminatingCommand(IUserInterface userInterface): base(commandIsTerminating: false,_userInterface:userInterface){}
}