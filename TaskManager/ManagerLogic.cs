using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    public  class ManagerLogic
    {
 
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Task Manager");
            Console.WriteLine("------------------------");
        }
        public static List<string> CreateTasksList()
        {
            List<string> tasks = new List<string>();
            string addTask;
            do
            {
               
                Console.Write("Enter a task to add: ");
                addTask = Console.ReadLine();
                tasks.Add(addTask);

            } while (addTask.ToLower().Trim() != "");
           
            return tasks;
        }

        public static void DisplayTasks(List<string> tasks)
        {
            Console.WriteLine("\nAll Tasks");
            foreach (var task in tasks)
            {
                Console.WriteLine($"{task}");
            }
        }
        //Implement methods to add, remove, update, and list tasks.
        public static void AddTask(List<string> tasks)
        {
            Console.Write("Enter a task you would like to add: ");
            string newTask = Console.ReadLine();
            tasks.Add (newTask);

        }
        public static void RemoveTask(List<string> tasks)
        {
            Console.Write("Enter a task you would like to remove: ");
            string removeTask = Console.ReadLine();
            tasks.Remove(removeTask);
        }

        public static void UpdateTask(List<string> tasks)
        {
            Console.Write("Enter a task you would like to update: ");
            string updateTask = Console.ReadLine();
            tasks.Add(updateTask);
        }

        //Allow users to mark tasks as complete.








        //Use a dictionary to categorize tasks (e.g., Work, Personal, Urgent).
    }
}
