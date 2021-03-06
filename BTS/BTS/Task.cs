﻿using System;
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
        public virtual double Priority { get { return 0; } }

        public Task(int number, int complexity, string description)
        {
            Number = number;
            Complexity = complexity;
            Description = description;
            Status = Status.ToDo;
            Progress = 0;
        }

        public bool IsCompleted() { return Progress > Complexity * Priority;  }

        public virtual string ToString(string type)
        {
            string status = "Is ";
            switch (Status)
            {
                case Status.Done:
                    status += "done";
                    break;
                case Status.InProgress:
                    status += "in progress";
                    break;
                case Status.ToDo:
                    status += "not solvet yet";
                    break;
            }
            return String.Format("This is {0}, it's number - {1}, it's Complexity - {2}, Description - {3}, Status - {4}",
                type, Number, Complexity, Description, status);
        }
    }
}
