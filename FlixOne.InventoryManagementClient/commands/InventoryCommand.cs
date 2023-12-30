using FlixOne.InventoryManagemementClient.interfaces;

namespace FlixOne.InventoryManagemementClient.commands;

public abstract class InventoryCommand {
    private readonly bool _isTerminatingCommand;
    private bool commandIsTerminating;

    protected IUserInterface userInterface {get;}

    internal InventoryCommand(bool commandIsTerminating,IUserInterface _userInterface){
        _isTerminatingCommand = commandIsTerminating;
        userInterface = _userInterface;

    }

    protected InventoryCommand(bool commandIsTerminating)
    {
        this.commandIsTerminating = commandIsTerminating;
    }

    public (bool wasSuccessful, bool shouldQuit) RunCommand(){
        if(this is IParameterizedCommand parameterizedCommand){
            var allParametersCompleted = false;

            while(allParametersCompleted == false){
                allParametersCompleted = parameterizedCommand.GetParameters();
            }
        }
        return (InternalCommand(), _isTerminatingCommand);
    }
    internal abstract bool InternalCommand();

}