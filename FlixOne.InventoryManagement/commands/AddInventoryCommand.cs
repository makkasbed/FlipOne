using FlixOne.InventoryManagemement.interfaces;

namespace FlixOne.InventoryManagemementClient.commands;

public class AddInventoryCommand : InventoryCommand, IParameterizedCommand
{
    public string InventoryName {get; private set;}

    public AddInventoryCommand(IUserInterface userInterface) : base(commandIsTerminating:true)
    {
    }

    /// <summary>
    /// AddInventoryCommand requires name
    /// </summary>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public bool GetParameters()
    {
        if(string.IsNullOrWhiteSpace(InventoryName))
            InventoryName = GetParameter("name");

        return !string.IsNullOrWhiteSpace(InventoryName);    
    }
    internal string GetParameter(string parameterName){
        return userInterface.ReadValue($"Enter {parameterName}:");
    }

    internal override bool InternalCommand()
    {
        throw new NotImplementedException();
    }
}