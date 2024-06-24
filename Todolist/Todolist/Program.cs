using System;
 
class Program

{

    static void Main(string[] args)

    {

        var toDoList = new ToDoList();

        while (true)

        {

            Console.WriteLine("\nTo-Do List Application");

            Console.WriteLine("1. Add a new to-do item");

            Console.WriteLine("2. View all to-do items");

            Console.WriteLine("3. Remove a to-do item");

            Console.WriteLine("4. Mark a to-do item as completed");

            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");

            var choice = Console.ReadLine();

            switch (choice)

            {

                case "1":

                    Console.Write("Enter the description of the to-do item: ");

                    var description = Console.ReadLine();

                    toDoList.AddItem(description);

                    break;

                case "2":

                    toDoList.ViewItems();

                    break;

                case "3":

                    Console.Write("Enter the ID of the to-do item to remove: ");

                    if (int.TryParse(Console.ReadLine(), out int removeId))

                    {

                        toDoList.RemoveItem(removeId);

                    }

                    else

                    {

                        Console.WriteLine("Invalid ID.");

                    }

                    break;

                case "4":

                    Console.Write("Enter the ID of the to-do item to mark as completed: ");

                    if (int.TryParse(Console.ReadLine(), out int completeId))

                    {

                        toDoList.MarkAsCompleted(completeId);

                    }

                    else

                    {

                        Console.WriteLine("Invalid ID.");

                    }

                    break;

                case "5":

                    return;

                default:

                    Console.WriteLine("Invalid choice. Please try again.");

                    break;

            }

        }

    }

}
