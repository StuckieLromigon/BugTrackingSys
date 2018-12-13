using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTS
{
    class Program
    {

        static void Main(string[] args)
        {
            CreateTaskList();
            StartEmulation();
        }

        public static void StartEmulation()
        {
            for(int i = 0; i < 30; i++)
            {
                EmulationStep();
                if(i / 2 == 1)
                {
                    AddBugForFeature();
                }
                if (Info.TaskList.Count == 0) return;
            }
        }

        public static void AddBugForFeature()
        {
            for(int i = 0; i < Info.ProcessWidth; i++)
            {
                if(Info.TasksInProcess[i].GetType() == typeof(Feature))
                {
                    Bug bug = CreateTask(1) as Bug;
                    bug.linkedFeature = Info.TasksInProcess[i] as Feature;
                    Info.TaskList.Add(Info.TasksInProcess[i]);
                    Info.TasksInProcess.Remove(Info.TasksInProcess[i]);
                    Info.TasksInProcess.Add(bug);
                    break;
                }
            }
            

        }

        public static void EmulationStep()
        {
            UpdateProcessingTasks();

            foreach(Task task in Info.TasksInProcess)
            {
                task.Progress++;
            }
        }

        private static void UpdateProcessingTasks()
        {
            int processCount = Info.TasksInProcess.Count;
            for (int i = 0; i < processCount; i++)
            {
                if(Info.TasksInProcess[i].IsCompleted())
                {
                    Info.TasksInProcess[i].Status = Status.Done;
                    Info.SolvedTasks.Add(Info.TasksInProcess[i]);
                    Info.TasksInProcess.Remove(Info.TasksInProcess[i]);
                    i--;
                }
            }
            while (Info.TasksInProcess.Count < Info.ProcessWidth)
            {
                Info.TaskList[0].Status = Status.InProgress;
                Info.TasksInProcess.Add(Info.TaskList[0]);
                Info.TaskList.RemoveAt(0);
            }
        }

        public static void CreateTaskList()
        {
            Console.WriteLine("Start of Task Creation");
            Info.TasksInProcess = new List<Task>();
            Info.UsedNumbers = new List<int>();
            Info.SolvedTasks = new List<Task>();
            Info.TaskList = new List<Task>();

            while (true)
            {
                int taskType = ChooseTaskTypeToCreate();
                Info.TaskList.Add(CreateTask(taskType));

                Console.WriteLine("Wanna stop? Press Y");
                ConsoleKeyInfo keyPressed = Console.ReadKey();
                if (keyPressed.Key == ConsoleKey.Y)
                    break;
            }

        }

        private static Task CreateTask(int taskType)
        {
            Random random = new Random();
            int taskNumber = 1;
            while (Info.UsedNumbers.Contains(taskNumber))
            {
                taskNumber = random.Next(-1000, 1000);
            }
            Info.UsedNumbers.Add(taskNumber);
            int taskComplexity = random.Next(1, 5);
            string taskDescription = "this is description";
            switch(taskType)
            {
                case 1:
                    return new Bug(taskNumber, taskComplexity, taskDescription);
                case 2:
                    return new Feature(taskNumber, taskComplexity, taskDescription);
                case 3:
                    return new TechnicalDebt(taskNumber, taskComplexity, taskDescription);
                default:
                    throw new NotImplementedException();
            }
        }

        private static int ChooseTaskTypeToCreate()
        {
            int task = 0;
            bool parsed = false;

            while (!parsed)
            {
                parsed = int.TryParse(Console.ReadLine(), out task);
                parsed = task < 4 && task > 0;
                if (!parsed)
                    Console.WriteLine("Create Again");
            }

            return task;
        }
    }
}
