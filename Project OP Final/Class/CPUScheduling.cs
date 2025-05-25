using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_OP_Final.Class
{
    internal class CPUScheduling
    {
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
    }
}
