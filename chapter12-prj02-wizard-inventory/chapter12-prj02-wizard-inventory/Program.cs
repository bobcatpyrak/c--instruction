using System;
using System.Collections.Generic;

namespace chapter12_prj02_wizard_inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Wizard Inventory Game\n" +
                                "\nCOMMAND MENU" + 
                                "\nshow - Show all items" +
                                "\ngrab - Grab an item" +
                                "\nedit - Edit an item" +
                                "\ndrop - Drop an item" +
                                "\nexit - Exit program");
            bool loop = true;
            List<String> inv = new List<String>();
            inv.Add("boots");
            inv.Add("Twiggy");
            inv.Add("skirt");

            while (loop)
            {
                Console.Write("\nCommand: ");
                String command = Console.ReadLine();

                switch(command)
                {
                    case "show":
                        foreach (String s in inv)
                            Console.WriteLine(s);
                        break;
                    case "grab":
                        if(inv.Count > 3)
                        {
                            Console.WriteLine("Inventory is full!");
                            break;
                        }
                        Console.Write("Add an item: ");
                        inv.Add(Console.ReadLine());
                        break;
                    case "exit":
                        Console.WriteLine("The wizard has died");
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("Invalid command");
                        break;
                }
                    
            }
        }
    }
}
