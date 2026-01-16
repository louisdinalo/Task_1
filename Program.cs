using System;

namespace TaskMaster
{
    struct TaskPriority
    {
        public int Level;
    }

    class Usertask
    {
        public string Title;
        public TaskPriority Priority;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Usertask task = new Usertask();
            task.Title = "Complete project documentation";
            task.Priority = new TaskPriority { Level = 1 };

            Console.WriteLine($"Task: {task.Title}, Priority Level: {task.Priority.Level}");
        }
    }
}



Console.ReadKey();
