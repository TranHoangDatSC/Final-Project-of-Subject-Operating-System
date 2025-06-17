using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_OP_Final
{
    public class Process
    {
        public string ID { get; set; }
        public int ArrivalTime { get; set; }
        public int BurstTime { get; set; }
        public int Priority { get; set; } 

        public int StartTime { get; set; }
        public int RemainingTime { get; set; } // For SRTF and RR scheduling
        public int CompletionTime { get; set; }

        public int TurnaroundTime { get; set; }
        public int WaitingTime { get; set; }

        public Process() { }

        public Process(string id, int arrivalTime, int burstTime, int priority = 0)
        {
            ID = id;
            ArrivalTime = arrivalTime;
            BurstTime = burstTime;
            Priority = priority;
            StartTime = -1; // Initialized to -1, will be set during scheduling
            RemainingTime = BurstTime;
            CompletionTime = 0; // Initialized to 0, will be set during scheduling
            TurnaroundTime = 0;
            WaitingTime = 0;
        }

        public static void PriorityRun(List<Process> processes) //Non-preemptive
        {
            /*
            - Each process is assigned a priority (lower number = higher priority).

            - The CPU is allocated to the process with the HIGHEST priority.

            - If two processes have the same priority, use arrival time as a tiebreaker. 

            workflow: 
            1. initialize list of completed processes, a list of processes that are in the ready queue
                and currentTime to track the time pointer
            2. implement logic to select the process with the highest priority from the ready queue
                    if in that time, no process is in the ready queue, increment currentTime
                    if exists process(s) in the ready queue, perform picking the suitable process
            3. Loop through the processes until completed.Count = processes.Count

            3. Handle button Run
            */
            List<Process> completed = new List<Process>();
            List<Process> readyQueue = new List<Process>();

            int currentTime = 0;

            while (completed.Count < processes.Count)
            {
                Process nextProcess = null;

                // Check for processes that have arrived by currentTime
                foreach (var p in processes.Except(completed).ToList())
                {
                    if (p.ArrivalTime <= currentTime && !readyQueue.Contains(p))
                    {
                        readyQueue.Add(p);
                    }
                }

                if (readyQueue.Count == 0)
                {
                    // If no process is in ready queue, increment currentTime
                    currentTime++;
                    continue;
                }

                //Determine the next process to run based on priority
                nextProcess = readyQueue.OrderBy(process => process.Priority)
                                         .ThenBy(process => process.ArrivalTime)
                                         .First();

                if (nextProcess.StartTime == -1) 
                    nextProcess.StartTime = Math.Max(nextProcess.ArrivalTime, currentTime); //Only set ONCE
                //Thuc thi roi thi cut khoi readyQueue
                readyQueue.Remove(nextProcess);

                //Calculate waiting time and turnaround time
                //Non-preemptive -> currentTime and CompletionTime jumps to the end of the current process
                nextProcess.CompletionTime = currentTime + nextProcess.BurstTime;
                nextProcess.TurnaroundTime = nextProcess.CompletionTime - nextProcess.ArrivalTime;
                nextProcess.WaitingTime = nextProcess.TurnaroundTime - nextProcess.BurstTime;

                currentTime = nextProcess.CompletionTime; // Move current time to the end of the process

                completed.Add(nextProcess); 
            }

            //Update the original processes list with the completed processes
            processes.Clear();
            processes.AddRange(completed);
        }

        public static void FCFSRun(List<Process> processes)
        {
            List<Process> completed = new List<Process>();
            List<Process> readyQueue = new List<Process>();

            int currentTime = 0;

            while (completed.Count < processes.Count)
            {
                Process nextProcess = null;

                
                foreach (var p in processes.Except(completed).ToList())
                {
                    if (p.ArrivalTime <= currentTime && !readyQueue.Contains(p))
                    {
                        readyQueue.Add(p);
                    }
                }
                
                if (readyQueue.Count == 0)
                {
                    currentTime++;
                    continue;
                }
                
                nextProcess = readyQueue.OrderBy(p => p.ArrivalTime).First();

                if (nextProcess.StartTime == -1) 
                    nextProcess.StartTime = Math.Max(currentTime, nextProcess.ArrivalTime); 

                readyQueue.Remove(nextProcess);

                nextProcess.CompletionTime = nextProcess.StartTime + nextProcess.BurstTime;
                nextProcess.TurnaroundTime = nextProcess.CompletionTime - nextProcess.ArrivalTime;
                nextProcess.WaitingTime = nextProcess.TurnaroundTime - nextProcess.BurstTime;

                currentTime = nextProcess.CompletionTime;

                completed.Add(nextProcess); 
            }
            processes.Clear();
            processes.AddRange(completed);
        }

        public static void SJFRun(List<Process> processes)
        {
            List<Process> completed = new List<Process>();

            List<Process> readyQueue = new List<Process>();

            int currentTime = 0;

            while (completed.Count < processes.Count)
            {
                Process nextProcess = null;
                
                foreach (var p in processes.Except(completed).ToList())
                {
                    if (p.ArrivalTime <= currentTime && !readyQueue.Contains(p)) 
                        readyQueue.Add(p); 
                }

                if (readyQueue.Count == 0)
                {
                    currentTime++;
                    continue;
                }

                nextProcess = readyQueue.OrderBy(p => p.BurstTime)
                                        .First();
                readyQueue.Remove(nextProcess);

                if (nextProcess.StartTime == -1)
                    nextProcess.StartTime = Math.Max(currentTime, nextProcess.ArrivalTime);

                nextProcess.CompletionTime = nextProcess.StartTime + nextProcess.BurstTime;
                currentTime = nextProcess.CompletionTime;

                nextProcess.TurnaroundTime = nextProcess.CompletionTime - nextProcess.ArrivalTime;
                nextProcess.WaitingTime = nextProcess.TurnaroundTime - nextProcess.BurstTime;

                completed.Add(nextProcess);
            }

            processes.Clear();
            processes.AddRange(completed);
        }

        public static void P_SJFRun(List<Process> processes)
        {
            List<Process> completed = new List<Process>();

            List<Process> readyQueue = new List<Process>();

            int currentTime = 0;

            while (completed.Count < processes.Count)
            {
                Process nextProcess = null;

                foreach (var p in processes.Except(completed).ToList())
                {
                    if (p.ArrivalTime <= currentTime && !readyQueue.Contains(p))
                        readyQueue.Add(p);
                }

                if (readyQueue.Count == 0)
                {
                    currentTime++;
                    continue;
                }

                nextProcess = readyQueue.OrderBy(p => p.Priority)
                                        .ThenBy(p => p.BurstTime)
                                        .First();
                readyQueue.Remove(nextProcess);

                if (nextProcess.StartTime == -1)
                    nextProcess.StartTime = Math.Max(currentTime, nextProcess.ArrivalTime);

                nextProcess.CompletionTime = nextProcess.StartTime + nextProcess.BurstTime;
                currentTime = nextProcess.CompletionTime;

                nextProcess.TurnaroundTime = nextProcess.CompletionTime - nextProcess.ArrivalTime;
                nextProcess.WaitingTime = nextProcess.TurnaroundTime - nextProcess.BurstTime;

                completed.Add(nextProcess);
            }

            processes.Clear();
            processes.AddRange(completed);
        }


 
    


    public class ProcessSnapshot
        {
            public string Id { get; set; }
            public int StartTime { get; set; }
            public int EndTime { get; set; } // For Gantt chart visualization
        }

        /*
        public static void SRTFRun(List<Process> processes)
        {

             //To sum up: To select the process with the shortest remaining time at each second currentTime passes. 

            List<Process> completed = new List<Process>(); //Track completed processes
            List<Process> progress = new List<Process>(); //Track processes for Gantt Chart
            List<Process> readyQueue = new List<Process>();
            int currentTime = 0;

            while (processes.Count > completed.Count)
            {
                Process nextProcess = null;
                readyQueue.Clear();
                foreach (var p in processes.Except(completed).ToList())
                {
                    //Allow the same process to be added into readyQueue again
                    //as long as Remaining Burst Time is still > 0
                    if (p.ArrivalTime <= currentTime && p.RemainingTime > 0)
                        readyQueue.Add(p);
                }

                if (readyQueue.Count == 0)
                {
                    currentTime++;
                    continue;
                }

                nextProcess = readyQueue.OrderBy(p => p.RemainingTime).ThenBy(p => p.ArrivalTime).First();

                //After selecting nextProcess for CPU, start updating its properties
                //Update StartTime many times whenever it was selected as nextProcess until finished excecution
                nextProcess.StartTime = currentTime; 

                nextProcess.RemainingTime--;
                readyQueue.Remove(nextProcess); //It can be added back to readyQueue if it still has RemainingTime > 0

                //Amount of time that nextProcess has been executed
                nextProcess.CompletionTime = nextProcess.StartTime + 1;

                //CompletionTime = BurstTime + StartTime - RemainingTime

                currentTime++;

                if (nextProcess.RemainingTime == 0)
                {
                    //Final excecution => calculate TAT, WT only ONCE when process is finished
                    nextProcess.TurnaroundTime = nextProcess.CompletionTime - nextProcess.ArrivalTime;
                    nextProcess.WaitingTime = nextProcess.TurnaroundTime - nextProcess.BurstTime;
                    completed.Add(nextProcess);

                }
                progress.Add(nextProcess); //To track the working process for Gantt Chart
            }
            processes.Clear();
            processes.AddRange(progress);
        }
        */

        public static List<ProcessSnapshot> SRTFRun(List<Process> processes)
        {
            List<Process> completed = new List<Process>();              // Finished processes
            List<ProcessSnapshot> progress = new List<ProcessSnapshot>(); // Gantt Chart log
            int currentTime = 0;

            while (processes.Count > completed.Count)
            {
                // Build ready queue for this time unit
                List<Process> readyQueue = processes
                    .Where(p => p.ArrivalTime <= currentTime && p.RemainingTime > 0)
                    .ToList();

                if (readyQueue.Count == 0)
                {
                    // CPU is idle
                    progress.Add(new ProcessSnapshot { Id = "Idle", StartTime = currentTime, EndTime = currentTime + 1 });
                    currentTime++;
                    continue;
                }

                // Select the process with the shortest remaining time
                Process nextProcess = readyQueue
                    .OrderBy(p => p.RemainingTime)
                    .ThenBy(p => p.ArrivalTime)
                    .First();

                // If this is the first time the process is executed, record its start time
                if (nextProcess.BurstTime == nextProcess.RemainingTime)
                {
                    nextProcess.StartTime = currentTime;
                }

                // Log the execution for this time unit
                progress.Add(new ProcessSnapshot
                {
                    Id = nextProcess.ID,
                    StartTime = currentTime,
                    EndTime = currentTime + 1
                });

                // Execute process for 1 time unit
                nextProcess.RemainingTime--;
                currentTime++;

                // If process finishes now, calculate its metrics
                if (nextProcess.RemainingTime == 0)
                {
                    nextProcess.CompletionTime = currentTime;
                    nextProcess.TurnaroundTime = nextProcess.CompletionTime - nextProcess.ArrivalTime;
                    nextProcess.WaitingTime = nextProcess.TurnaroundTime - nextProcess.BurstTime;
                    completed.Add(nextProcess);
                }
            }

            //foreach (var log in progress)
            //{
            //    Console.WriteLine($"[{log.StartTime}-{log.EndTime}] -> {log.Id}");
            //}

            // Replace original list with completed for further reporting
            //processes.Clear();
            //processes.AddRange(progress);
            return progress;
        }



        public static void P_SRTFRun(List<Process> processes)
        {

        }

        public static void RRRun(List<Process> processes, int quantumTime)
        {
            // Round Robin scheduling logic
        }
    }

    internal class CPUScheduling
    {
    }
}
