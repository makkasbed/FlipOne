using FlixOne.InventoryManagemement.interfaces;
using FlixOne.InventoryManagemementClient.commands;

namespace FlixOne.InventoryManagemement.commands;

public class UpdateQuantityCommand : NonTerminatingCommand, IParameterizedCommand
{

    public UpdateQuantityCommand(IUserInterface userInterface) : base(userInterface)
    {
    }

    internal string InventoryName { get; private set; }

    private int _quantity;
    internal int Quantity { get => _quantity; private set => _quantity = value; }

    /// <summary>
    ///     UpdateQuantity requires name and an integer value
    /// </summary>
    /// <returns></returns>
    public bool GetParameters()
    {
        if (string.IsNullOrWhiteSpace(InventoryName))
            InventoryName = GetParameter("name");

        if (Quantity == 0)
            int.TryParse(GetParameter("quantity"), out _quantity);

        return !string.IsNullOrWhiteSpace(InventoryName) && Quantity != 0;
    }

    internal override bool InternalCommand()
    {
        throw new NotImplementedException("Implemented in next chapter!");
    }
    internal string GetParameter(string parameterName)
    {
        return userInterface.ReadValue($"Enter {parameterName}:");
    }
}