using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTS
{
    abstract class Task
    {

        public int Progress { get; set; }
        public int Number { get; set; }
        public int Complexity { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }
        public const double Priority = 0;

        public Task(int number, int complexity, string description)
        {
            Number = number;
            Complexity = complexity;
            Description = description;
            Status = Status.ToDo;
            Progress = 0;
        }

        public bool IsCompleted() { return Progress > Complexity * Priority;  }

    }
}
