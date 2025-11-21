// This program need Person.Library2

using Person.Library2;

namespace PersonConsole1;

internal class Program
{
    static void Main(string[] args)
    {
        PersonList list = new();

        while (true)
        {
            Console.WriteLine("1. Add Person");
            Console.WriteLine("2. Show All Person");
            Console.WriteLine("3. Search For Person By Id");
            Console.WriteLine("4. Remove Person By Id");
            Console.WriteLine("5. Exit Program");
            Console.Write("Enter Your Choice: "); string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter Number of Person: "); byte n;
                    if(byte.TryParse(Console.ReadLine(), out n))
                    {
                        for (byte i = 0; i < n; i++)
                        {
                            Console.WriteLine($"Input Information for Person {i + 1}: ");
                            list.AddPerson();
                        }
                    } else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    break;

                case "2":
                    list.outputAll();
                    break;

                case "3":
                    Console.Write("Enter Id Search: "); byte id;
                    if(byte.TryParse(Console.ReadLine(), out id))
                    {
                        list.SearchById(id);
                        Console.WriteLine("Search Person Successfully!");
                    } else
                    {
                        Console.WriteLine("Invalid Input!");
                        Console.Write("Enter Id to Search Again: ");
                    }
                    break;

                case "4":
                    Console.Write("Enter ID to Remove: "); byte idRemove;
                    if(byte.TryParse(Console.ReadLine(), out idRemove))
                    {
                        bool removed = list.RemoveById(idRemove);
                        Console.WriteLine("People Remvoed Successfully!");
                        list.outputAll();
                    } else
                    {
                        Console.WriteLine("Invalid Input!");
                        Console.Write("Input Id to Remvoe Again: ");
                    }
                    break;

                case "5":
                    Console.WriteLine("Exitting Program!");
                    return;
            }
        }
    }
}

