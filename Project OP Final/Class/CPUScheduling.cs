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
        public int Priority { get; set; } // Only used for priority scheduling

        public int StartTime { get; set; }
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

                if (nextProcess.StartTime == -1) nextProcess.StartTime = currentTime; //Only set ONCE
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

                //Add to readyQueue
                foreach (var p in processes.Except(completed).ToList())
                {
                    if (p.ArrivalTime <= currentTime && !readyQueue.Contains(p))
                    {
                        readyQueue.Add(p);
                    }
                }
                //Select next process from readyQueue
                if (readyQueue.Count == 0)
                {
                    // If no process is in ready queue, increment currentTime
                    currentTime++;
                    continue;
                }

                nextProcess = readyQueue.OrderBy(p => p.ArrivalTime).First();
                if (nextProcess.StartTime == -1) 
                    nextProcess.StartTime = Math.Max(currentTime, nextProcess.ArrivalTime); // Set start time only ONCE

                readyQueue.Remove(nextProcess);

                //Calculate TAT, WT, CompletionTime, StartTime
                nextProcess.CompletionTime = nextProcess.StartTime + nextProcess.BurstTime;
                nextProcess.TurnaroundTime = nextProcess.CompletionTime - nextProcess.ArrivalTime;
                nextProcess.WaitingTime = nextProcess.TurnaroundTime - nextProcess.BurstTime;

                //Update current time to the completion time of THIS nextProcess
                currentTime = nextProcess.CompletionTime;

                completed.Add(nextProcess); //While loop handler
            }
            //Update the passed in processes list
            processes.Clear();
            processes.AddRange(completed);
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
    }
}
