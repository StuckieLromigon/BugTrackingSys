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
    }
}
