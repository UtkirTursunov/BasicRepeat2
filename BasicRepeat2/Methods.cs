using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicRepeat2;

public class Methods
{
   public static void MainScreen()
    {
        Console.WriteLine("1. Add a task.");
        Console.WriteLine("2. Remove a task.");
        Console.WriteLine("3. Mark the task as completed.");
        Console.WriteLine("4. Display tasks.");
        Console.WriteLine("5. Exit");
    }

    public static void AddTask(List<(string Task, bool IsCompleted)> tasks)
    {
        Console.WriteLine("Enter the task!");
        string Task = Console.ReadLine();
        tasks.Add((Task, false));
        Console.WriteLine("Task added successfully.");
    }

    public static void RemoveTask(List<(string Task, bool IsCompleted)> tasks)
    {
        DisplayTasks(tasks);
        Console.WriteLine("Choose the number of task for removing...");
        int.TryParse(Console.ReadLine(), out int index);

        if (index > 0 && index <= tasks.Count)
        {
            tasks.RemoveAt(index - 1);
            Console.WriteLine("Task removed successfully!");
        }
        else
        {
            Console.WriteLine("Invalid task number...Please check the number of task");
        }
    }

    public static void MarkAsCompleted(List<(string Task, bool IsCompleted)> tasks)
    {
        DisplayTasks(tasks);
        Console.WriteLine("Choose the number of task for marking as completed...");
        int.TryParse(Console.ReadLine(), out int index);

        if(index > 0 && index <= tasks.Count)
        {
            tasks[index - 1] = (tasks[index - 1].Task, true);
            Console.WriteLine("Task has been marked as completed");
        }
        else
        {
            Console.WriteLine("Invalid task number...Please check the number of task");
        }
    }

    public static void DisplayTasks(List<(string Task, bool IsCompleted)> tasks)
    {
        if(tasks.Count == 0)
        {
            Console.WriteLine("No found");
        }
        else
        {
            Console.WriteLine("\nTasks:");
            for(int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i].Task} - {(tasks[i].IsCompleted ? "Completed" : "Not Completed")}");
            }
        }
    }
}
