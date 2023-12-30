// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
using FlixOne.InventoryManagemementClient.ui;
namespace FlixOne.InventoryManagemementClient;

public class Program
{
    private static void main(String[] args)
    {
            var service = new CatalogService(new ConsoleUserInterface());            
            service.Run();

            Console.WriteLine("CatalogService has completed.");
            Console.ReadLine();
    }
}

