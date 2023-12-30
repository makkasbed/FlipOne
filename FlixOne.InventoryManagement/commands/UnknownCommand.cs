using FlixOne.InventoryManagemement.interfaces;
using FlixOne.InventoryManagemementClient.commands;

namespace FlixOne.InventoryManagemement.commands;
 public class UnknownCommand : NonTerminatingCommand
    {
        public UnknownCommand(IUserInterface userInterface) : base(userInterface)
        {
        }

        internal override bool InternalCommand()
        {            
            userInterface.WriteWarning("Unable to determine the desired command.");         

            return false;
        }
    }