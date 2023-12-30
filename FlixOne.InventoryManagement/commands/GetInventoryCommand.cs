using FlixOne.InventoryManagemement.interfaces;
using FlixOne.InventoryManagemementClient.commands;

namespace FlixOne.InventoryManagemement.commands;

 public class GetInventoryCommand : NonTerminatingCommand
    {
        public GetInventoryCommand(IUserInterface userInterface) : base(userInterface)
        {            
        }

        internal override bool InternalCommand()
        {
            return false;
        }
    }