using FlixOne.InventoryManagemement.interfaces;

namespace FlixOne.InventoryManagemementClient.commands;

public abstract class NonTerminatingCommand: InventoryCommand {
    protected NonTerminatingCommand(IUserInterface userInterface): base(commandIsTerminating: false,_userInterface:userInterface){}
}