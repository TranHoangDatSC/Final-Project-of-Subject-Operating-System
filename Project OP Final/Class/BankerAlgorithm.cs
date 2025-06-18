using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_OP_Final.Class
{
    public class BankerAlgorithm
    {
        public int ProcessCount { get; set; }
        public int ResourceCount { get; set; }

        public int[,] MaxDemand { get; set; }
        public int[,] Allocation { get; set; }
        public int[] Available { get; set; }

        public int[,] Need
        {
            get
            {
                int[,] need = new int[ProcessCount, ResourceCount];
                for(int i = 0; i < ProcessCount; i++)
                {
                    for(int j = 0; j < ResourceCount; j++)
                    {
                        need[i, j] = MaxDemand[i, j] - Allocation[i, j];
                    }
                }
                return need;
            }
        }
        public BankerAlgorithm(int processCount, int resourceCount)
        {
            ProcessCount = processCount;
            ResourceCount = resourceCount;
            MaxDemand = new int[processCount, resourceCount];
            Allocation = new int[processCount, resourceCount];
            Available = new int[resourceCount];
        }

        public bool IsSafe(out List<int> safeSequence, out bool isDeadLock)
        {
            safeSequence = new List<int>();
            isDeadLock = false;
            int[] work = (int[])Available.Clone();
            bool[] finish = new bool[ProcessCount];

            bool changed;
            do
            {
                changed = false;
                for (int i = 0; i < ProcessCount; i++)
                {
                    if (!finish[i])
                    {
                        bool canAllocate = true;
                        for (int j = 0; j < ResourceCount; j++)
                        {
                            if (Need[i, j] > work[j])
                            {
                                canAllocate = false;
                                break;
                            }
                        }

                        if (canAllocate)
                        {
                            for (int j = 0; j < ResourceCount; j++)
                                work[j] += Allocation[i, j];

                            finish[i] = true;
                            safeSequence.Add(i);
                            changed = true;
                        }
                    }
                }
            } while (changed);

            isDeadLock = finish.Any(f => !f) && safeSequence.Count == 0;
            return finish.All(f => f);
        }

        public bool RequestResource(int processIndex, int[] request)
        {
            for (int i = 0; i < ResourceCount; i++)
            {
                if (request[i] > Need[processIndex, i])
                    return false;
                if (request[i] > Available[i])
                    return false;
            }

            // Cấp phát tạm thời
            for (int i = 0; i < ResourceCount; i++)
            {
                Available[i] -= request[i];
                Allocation[processIndex, i] += request[i];
            }

            // Kiểm tra hệ thống có còn an toàn không
            if (IsSafe(out _, out _))
                return true;

            // Hủy cấp phát nếu không an toàn
            for (int i = 0; i < ResourceCount; i++)
            {
                Available[i] += request[i];
                Allocation[processIndex, i] -= request[i];
            }

            return false;
        }

        public void ResetTableBanker()
        {
            MaxDemand = new int[ProcessCount, ResourceCount];
            Allocation = new int[ProcessCount, ResourceCount];
            Available = new int[ResourceCount];
        }
        public string SuggestDeadlockSolution()
        {
            List<int> unfinished = new List<int>();

            bool[] finish = new bool[ProcessCount];
            int[] work = (int[])Available.Clone();

            bool changed;

            do
            {
                changed = false;

                for (int i = 0; i < ProcessCount; i++)
                {
                    if (!finish[i])
                    {
                        bool canAllocate = true;

                        for (int j = 0; j < ResourceCount; j++)
                        {
                            if (Need[i, j] > work[j])
                            {
                                canAllocate = false;
                                break;
                            }
                        }

                        if (canAllocate)
                        {
                            for (int j = 0; j < ResourceCount; j++)
                                work[j] += Allocation[i, j];
                            finish[i] = true;
                            changed = true;
                        }
                    }
                }
            } while (changed);

            for (int i = 0; i < ProcessCount; i++)
                if (!finish[i]) unfinished.Add(i);

            if (unfinished.Count == 0)
                return "No deadlock to solve.";

            var solution = new StringBuilder();

            solution.AppendLine($"Deadlock involves process(es): {string.Join(", ", unfinished.Select(id => $"P{id}"))}.");

            foreach (int p in unfinished)
            {
                solution.AppendLine($"- P{p} is waiting. Currently allocated: {string.Join(", ", Enumerable.Range(0, ResourceCount).Select(r => Allocation[p, r]))}. Needed: {string.Join(", ", Enumerable.Range(0, ResourceCount).Select(r => Need[p, r]))}.Consider terminating P{p} or freeing its resources.");
            }

            return solution.ToString();
        }
    }
}
