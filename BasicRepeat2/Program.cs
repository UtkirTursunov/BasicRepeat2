namespace BasicRepeat2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<(string Task, bool IsCompleted)> tasks = new List<(string, bool)>();
            bool isRun = true;

            Methods.MainScreen();

            while (isRun)
            {
                int.TryParse(Console.ReadLine(), out int choice);
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Methods.AddTask(tasks);
                        break;
                    case 2:
                        Console.Clear();
                        Methods.RemoveTask(tasks);
                        break;
                    case 3:
                        Console.Clear();
                        Methods.MarkAsCompleted(tasks);
                        break;
                    case 4:
                        Console.Clear();
                        Methods.DisplayTasks(tasks);
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Program exited. Goodbye!");
                        isRun = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again");
                        break;
                }

                if (choice >= 1 && choice <= 4)
                {
                    Console.WriteLine("\nDo you want any operation? (yes/no)");
                    string continueChoice = Console.ReadLine()?.ToLower();

                    if (continueChoice == "yes" || continueChoice == "y")
                    {
                        Console.Clear();
                        Methods.MainScreen();
                    }
                    else if (continueChoice == "no" || continueChoice == "n")
                    {
                        isRun = false;
                        Console.Clear();
                        Console.WriteLine("Program excited. Goodbye!!!");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Return to the main menu.");
                        Thread.Sleep(1500);
                        Console.Clear();
                        Methods.MainScreen();
                    }
                }
            }
        }
    }
}
