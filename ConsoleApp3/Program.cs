class Program
{
    static List <string> tasks = new List<string> ();
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Basic TO-DO List");
            Console.WriteLine("1.Add\n2.View\n3.Exit\n4.Delete");
            int.TryParse(Console.ReadLine(), out int n);
            if (n == 1)
            {
                AddTask();
            }
            if (n == 2)
            {
                ViewTask();
            }
            if (n == 3)
                return;
            if (n == 4)
            {
                DeleteTask(n);
            }
        }        
        static void AddTask()
        {
            Console.WriteLine("Enter your task");
            string task = Console.ReadLine()??string.Empty;
            tasks.Add(task);
        }
        static void ViewTask()
        {
            for(int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1} : {tasks[i]}");

            }
        }
        static void DeleteTask(int n)
        {
            for(int i = 0; i < tasks.Count; i++)
            {
                tasks.Remove(tasks[i]);
            }
            Console.WriteLine("Task deleted successfully");
        }
    }
}

