// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
namespace FlixOne.InventoryManagemementClient;

public class Program
{
    private static void main(String[] args)
    {
        Greeting();

        GetCommand("?").RunCommand(out bool shouldQuit);

        while(!shouldQuit){
            Console.WriteLine(" > ");
            var input = Console.ReadLine();
            var command = GetCommand(input);

            var wasSuccessful = command.RunCommand(out shouldQuit);

            if(!wasSuccessful){
                Console.WriteLine("Enter ? to view options.");
            }
        }

        Console.WriteLine("Catalog Service has completed!");
    }
}

