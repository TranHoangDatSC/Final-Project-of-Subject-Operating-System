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

                if (nextProcess.RemainingTime == nextProcess.BurstTime) 
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

                if (nextProcess.RemainingTime == nextProcess.BurstTime) 
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

                if (nextProcess.RemainingTime == nextProcess.BurstTime)
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

                if (nextProcess.RemainingTime == nextProcess.BurstTime)
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

                // If process finishes now, calculate its properties
                if (nextProcess.RemainingTime == 0)
                {
                    nextProcess.CompletionTime = currentTime;
                    nextProcess.TurnaroundTime = nextProcess.CompletionTime - nextProcess.ArrivalTime;
                    nextProcess.WaitingTime = nextProcess.TurnaroundTime - nextProcess.BurstTime;
                    completed.Add(nextProcess);
                }
            }
            return progress;
        }

        public static List<ProcessSnapshot> P_SRTFRun(List<Process> processes)
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
                    .OrderBy(p => p.Priority)
                    .ThenBy(p => p.RemainingTime)
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

                // If process finishes now, calculate its properties
                if (nextProcess.RemainingTime == 0)
                {
                    nextProcess.CompletionTime = currentTime;
                    nextProcess.TurnaroundTime = nextProcess.CompletionTime - nextProcess.ArrivalTime;
                    nextProcess.WaitingTime = nextProcess.TurnaroundTime - nextProcess.BurstTime;
                    completed.Add(nextProcess);
                }
            }
            return progress;
        }

        public static List<ProcessSnapshot> RRRun(List<Process> processes, int quantumTime)
        {
            List<ProcessSnapshot> progress = new List<ProcessSnapshot>();
            Queue<Process> readyQueue = new Queue<Process>();
            int currentTime = 0;
            int completedCount = 0;

            // Track arrival separately
            var arrivalList = processes.OrderBy(p => p.ArrivalTime).ToList();
            int arrivalIndex = 0;

            while (completedCount < processes.Count)
            {
                // Enqueue new arrivals
                while (arrivalIndex < arrivalList.Count && arrivalList[arrivalIndex].ArrivalTime <= currentTime)
                {
                    readyQueue.Enqueue(arrivalList[arrivalIndex]);
                    arrivalIndex++;
                }

                if (readyQueue.Count == 0)
                {
                    progress.Add(new ProcessSnapshot { Id = "Idle", StartTime = currentTime, EndTime = currentTime + 1 });
                    currentTime++;
                    continue;
                }

                var process = readyQueue.Dequeue();

                // Record first start time
                if (process.RemainingTime == process.BurstTime)
                    process.StartTime = currentTime;

                /*
                 Cases: 
                      1. nextProcess.RemainingTime > quantumTime => EndTime = currentTime + quantumTime
                      2. nextProcess.RemainingTime = quantumTime => EndTime = currentTime + quantumTime ->END
                      3. nextProcess.RemainingTime < quantumTime => EndTime = currentTime + nextProcess.RemainingTime ->END
                */
                int executionTime = Math.Min(quantumTime, process.RemainingTime);

                progress.Add(new ProcessSnapshot
                {
                    Id = process.ID,
                    StartTime = currentTime,
                    EndTime = currentTime + executionTime
                });

                currentTime += executionTime;
                process.RemainingTime -= executionTime;

                // Add any new arrivals that happened during this process's execution
                while (arrivalIndex < arrivalList.Count && arrivalList[arrivalIndex].ArrivalTime <= currentTime)
                {
                    readyQueue.Enqueue(arrivalList[arrivalIndex]);
                    arrivalIndex++;
                }

                if (process.RemainingTime == 0)
                {
                    process.CompletionTime = currentTime;
                    process.TurnaroundTime = process.CompletionTime - process.ArrivalTime;
                    process.WaitingTime = process.TurnaroundTime - process.BurstTime;
                    completedCount++;
                }
                else
                {
                    // Not done, requeue
                    readyQueue.Enqueue(process);
                }
            }

            return progress;
        }


        public static List<ProcessSnapshot> P_RRRun(List<Process> processes, int quantumTime)
        {
            List<ProcessSnapshot> progress = new List<ProcessSnapshot>();
            List<Process> readyQueue = new List<Process>();
            int currentTime = 0;
            int completedCount = 0;
            int arrivalIndex = 0;

            var arrivalList = processes.OrderBy(p => p.ArrivalTime).ToList();

            Process current = null;
            int currentQuantumUsed = 0;

            while (completedCount < processes.Count)
            {
                // Add newly arrived processes to the ready queue
                while (arrivalIndex < arrivalList.Count && arrivalList[arrivalIndex].ArrivalTime <= currentTime)
                {
                    readyQueue.Add(arrivalList[arrivalIndex]);
                    arrivalIndex++;
                }

                // Preemption: check if current should stop due to higher-priority arrival
                if (current != null)
                {
                    var higherPriority = readyQueue.Where(p => p.Priority < current.Priority).ToList();
                    if (higherPriority.Count > 0)
                    {
                        readyQueue.Add(current); // Preempt and requeue
                        current = null;
                        currentQuantumUsed = 0;
                    }
                }

                if (current == null)
                {
                    if (readyQueue.Count == 0)
                    {
                        progress.Add(new ProcessSnapshot { Id = "Idle", StartTime = currentTime, EndTime = currentTime + 1 });
                        currentTime++;
                        continue;
                    }

                    // Select highest priority from queue
                    current = readyQueue.OrderBy(p => p.Priority).ThenBy(p => p.ArrivalTime).First();
                    readyQueue.Remove(current);

                    if (current.RemainingTime == current.BurstTime)
                        current.StartTime = currentTime;

                    currentQuantumUsed = 0;
                }

                int execStart = currentTime;
                current.RemainingTime--;
                currentTime++;
                currentQuantumUsed++;

                // Record step
                progress.Add(new ProcessSnapshot { Id = current.ID, StartTime = execStart, EndTime = currentTime });

                if (current.RemainingTime == 0)
                {
                    current.CompletionTime = currentTime;
                    current.TurnaroundTime = current.CompletionTime - current.ArrivalTime;
                    current.WaitingTime = current.TurnaroundTime - current.BurstTime;
                    current = null;
                    completedCount++;
                    currentQuantumUsed = 0;
                }
                else if (currentQuantumUsed == quantumTime)
                {
                    readyQueue.Add(current);
                    current = null;
                    currentQuantumUsed = 0;
                }
            }

            return progress;
        }



    }
}
