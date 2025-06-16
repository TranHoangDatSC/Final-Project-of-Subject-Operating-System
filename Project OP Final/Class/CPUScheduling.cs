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
        public int CompletionTime { get; set; }
        public int TurnaroundTime { get; set; }
        public int WaitingTime { get; set; }
        public int Priority { get; set; } // Only used for priority scheduling
        public Process() { }

        public Process(string id, int arrivalTime, int burstTime, int priority = 0)
        {
            ID = id;
            ArrivalTime = arrivalTime;
            BurstTime = burstTime;
            Priority = priority;
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
                readyQueue.Remove(nextProcess);

                //Calculate waiting time and turnaround time
                //Non-preemptive -> currentTime and CompletionTime jumps to the end of the current process
                nextProcess.CompletionTime = currentTime + nextProcess.BurstTime;
                nextProcess.TurnaroundTime = nextProcess.CompletionTime - nextProcess.ArrivalTime;
                nextProcess.WaitingTime = nextProcess.TurnaroundTime - nextProcess.BurstTime;

                currentTime = nextProcess.CompletionTime; // Move current time to the end of the process

                completed.Add(nextProcess); 
            }
        }

        public void FCFSRun(List<Process> processes)
        {
            // First Come First Serve scheduling logic

        }

        public void SJFRun(List<Process> processes)
        {
            // Shortest Job First scheduling logic
        }

        public void SRTFRun(List<Process> processes)
        {
            // Shortest Remaining Time First scheduling logic
        }

        public void RRRun(List<Process> processes, int quantumTime)
        {
            // Round Robin scheduling logic
        }
    }

    internal class CPUScheduling
    {


        /*-------------------------------------------------------------------------------
        public List<string> processIDs { get; set; }
        public List<int> burstTimes { get; set; }
        public List<int> arrivingTimes { get; set; }
        public List<int> waitingTimes { get; set; }
        public List<int> turnaroundTimes { get; set; }
        public List<int> priorityLevels { get; set; }

        //Functions to run different CPU scheduling algorithms
        public void FCFSRun()
        {
            // First Come First Serve scheduling logic
            waitingTimes = new List<int>();
            turnaroundTimes = new List<int>();
            int totalWaitingTime = 0;
            for (int i = 0; i < burstTimes.Count; i++)
            {
                if (i == 0)
                {
                    waitingTimes.Add(0);
                }
                else
                {
                    waitingTimes.Add(totalWaitingTime);
                }
                totalWaitingTime += burstTimes[i];
                turnaroundTimes.Add(waitingTimes[i] + burstTimes[i]);
            }
        }

        public void SJFRun()
        {
            // Shortest Job First scheduling logic
            waitingTimes = new List<int>();
            turnaroundTimes = new List<int>();
            int totalWaitingTime = 0;
            var sortedIndices = burstTimes.Select((value, index) => new { value, index })
                                          .OrderBy(x => x.value)
                                          .Select(x => x.index)
                                          .ToList();
            for (int i = 0; i < sortedIndices.Count; i++)
            {
                int index = sortedIndices[i];
                if (i == 0)
                {
                    waitingTimes.Add(0);
                }
                else
                {
                    waitingTimes.Add(totalWaitingTime);
                }
                totalWaitingTime += burstTimes[index];
                turnaroundTimes.Add(waitingTimes[i] + burstTimes[index]);
            }
        }

        public void SRTFRun()
        {
            // Shortest Remaining Time First scheduling logic
            waitingTimes = new List<int>(new int[burstTimes.Count]);
            turnaroundTimes = new List<int>(new int[burstTimes.Count]);
            int time = 0;
            var remainingBurstTime = burstTimes.ToList();
            while (remainingBurstTime.Any(x => x > 0))
            {
                int index = remainingBurstTime.IndexOf(remainingBurstTime.Where(x => x > 0).Min());
                if (index != -1)
                {
                    remainingBurstTime[index]--;
                    time++;
                    for (int i = 0; i < burstTimes.Count; i++)
                    {
                        if (i != index && remainingBurstTime[i] > 0)
                        {
                            waitingTimes[i]++;
                        }
                    }
                }
            }
            for (int i = 0; i < burstTimes.Count; i++)
            {
                turnaroundTimes[i] = waitingTimes[i] + burstTimes[i];
            }
        }


        public void RoundRobinRun(int timeQuantum)
        {
            // Round Robin scheduling logic
            waitingTimes = new List<int>(new int[burstTimes.Count]);
            turnaroundTimes = new List<int>(new int[burstTimes.Count]);
            Queue<int> queue = new Queue<int>();
            List <int> remainingBurstTime = burstTimes.ToList();
            int time = 0;
            for (int i = 0; i < burstTimes.Count; i++)
            {
                queue.Enqueue(i);
            }
            while (queue.Count > 0)
            {
                int index = queue.Dequeue();
                if (remainingBurstTime[index] > timeQuantum)
                {
                    time += timeQuantum;
                    remainingBurstTime[index] -= timeQuantum;
                    queue.Enqueue(index);
                }
                else
                {
                    time += remainingBurstTime[index];
                    waitingTimes[index] = time - burstTimes[index];
                    turnaroundTimes[index] = waitingTimes[index] + burstTimes[index];
                    remainingBurstTime[index] = 0;
                }
            }
        }
        */
    }
}
