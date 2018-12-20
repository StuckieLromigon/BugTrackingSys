using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTS
{
    static class Info
    {
        public const int ProcessWidth = 5;

        public static List<Task> TaskList { get; set; }
        public static List<int> UsedNumbers { get; set; }
        public static List<Task> TasksInProcess { get; set; }
        public static List<Task> SolvedTasks { get; set; }

        public static void ShowInformation()
        {
            Console.WriteLine("Tasks, that remained Unsolved");
            ShowList(TaskList);
            Console.WriteLine("Tasks that was half-solved");
            ShowList(TasksInProcess);
            Console.WriteLine("Final list of Solved Tasks");
            ShowList(SolvedTasks);
        }
        private static void ShowList(List<Task> list)
        {
            if(list.Count == 0)
                Console.WriteLine("No Tasks");
            foreach(object el in list)
            {
                Console.WriteLine(el.ToString());
            }
            Console.WriteLine();
        }
    }
}
