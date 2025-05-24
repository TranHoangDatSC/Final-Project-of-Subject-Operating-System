using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_OP_Final.Class
{
    public enum Direction { Left, Right }
    public class DiskScheduling
    {
        public static int FCFS(int[] requests, int head, out List<(int from, int to, int move)> steps)
        {
            steps = new List<(int, int, int)>();
            int total = 0;
            foreach (int r in requests)
            {
                int move = Math.Abs(head - r);
                steps.Add((head, r, move));
                total += move;
                head = r;
            }
            return total;
        }
        public static int SSTF(int[] requests, int head, out List<(int from, int to, int move)> steps)
        {
            steps = new List<(int, int, int)>();
            List<int> req = requests.ToList();
            int total = 0;

            while (req.Count > 0)
            {
                int closest = req.OrderBy(r => Math.Abs(r - head)).First();
                int move = Math.Abs(head - closest);
                steps.Add((head, closest, move));
                total += move;
                head = closest;
                req.Remove(closest);
            }
            return total;
        }
        public static int SCAN(int[] requests, int head, int diskSize, Direction direction, out List<(int from, int to, int move)> steps)
        {
            steps = new List<(int, int, int)>();
            List<int> req = requests.ToList();
            req.Add(head);
            req.Sort();
            int total = 0;
            int index = req.IndexOf(head);

            if (direction == Direction.Right)
            {
                for (int i = index + 1; i < req.Count; i++)
                {
                    int move = Math.Abs(head - req[i]);
                    steps.Add((head, req[i], move));
                    total += move;
                    head = req[i];
                }

                if (head != diskSize - 1)
                {
                    steps.Add((head, diskSize - 1, diskSize - 1 - head));
                    total += diskSize - 1 - head;
                    head = diskSize - 1;
                }

                for (int i = index - 1; i >= 0; i--)
                {
                    int move = Math.Abs(head - req[i]);
                    steps.Add((head, req[i], move));
                    total += move;
                    head = req[i];
                }
            }
            else // Left
            {
                for (int i = index - 1; i >= 0; i--)
                {
                    int move = Math.Abs(head - req[i]);
                    steps.Add((head, req[i], move));
                    total += move;
                    head = req[i];
                }

                if (head != 0)
                {
                    steps.Add((head, 0, head));
                    total += head;
                    head = 0;
                }

                for (int i = index + 1; i < req.Count; i++)
                {
                    int move = Math.Abs(head - req[i]);
                    steps.Add((head, req[i], move));
                    total += move;
                    head = req[i];
                }
            }

            return total;
        }
        public static int CSCAN(int[] requests, int head, int diskSize, out List<(int from, int to, int move)> steps)
        {
            steps = new List<(int, int, int)>();
            List<int> req = requests.ToList();
            req.Add(head);
            req.Sort();
            int total = 0;
            int index = req.IndexOf(head);

            for (int i = index + 1; i < req.Count; i++)
            {
                int move = Math.Abs(head - req[i]);
                steps.Add((head, req[i], move));
                total += move;
                head = req[i];
            }

            if (head != diskSize - 1)
            {
                steps.Add((head, diskSize - 1, diskSize - 1 - head));
                total += diskSize - 1 - head;
                steps.Add((diskSize - 1, 0, diskSize - 1));
                total += diskSize - 1;
                head = 0;
            }

            for (int i = 0; i < index; i++)
            {
                int move = Math.Abs(head - req[i]);
                steps.Add((head, req[i], move));
                total += move;
                head = req[i];
            }

            return total;
        }
        public static int LOOK(int[] requests, int head, Direction direction, out List<(int from, int to, int move)> steps)
        {
            steps = new List<(int, int, int)>();
            List<int> req = requests.ToList();
            req.Add(head);
            req.Sort();
            int total = 0;
            int index = req.IndexOf(head);

            if (direction == Direction.Right)
            {
                for (int i = index + 1; i < req.Count; i++)
                {
                    int move = Math.Abs(head - req[i]);
                    steps.Add((head, req[i], move));
                    total += move;
                    head = req[i];
                }

                for (int i = index - 1; i >= 0; i--)
                {
                    int move = Math.Abs(head - req[i]);
                    steps.Add((head, req[i], move));
                    total += move;
                    head = req[i];
                }
            }
            else // Left
            {
                for (int i = index - 1; i >= 0; i--)
                {
                    int move = Math.Abs(head - req[i]);
                    steps.Add((head, req[i], move));
                    total += move;
                    head = req[i];
                }

                for (int i = index + 1; i < req.Count; i++)
                {
                    int move = Math.Abs(head - req[i]);
                    steps.Add((head, req[i], move));
                    total += move;
                    head = req[i];
                }
            }

            return total;
        }
        public static int CLOOK(int[] requests, int head, out List<(int from, int to, int move)> steps)
        {
            steps = new List<(int, int, int)>();
            List<int> req = requests.ToList();
            req.Add(head);
            req.Sort();
            int total = 0;
            int index = req.IndexOf(head);

            for (int i = index + 1; i < req.Count; i++)
            {
                int move = Math.Abs(head - req[i]);
                steps.Add((head, req[i], move));
                total += move;
                head = req[i];
            }

            for (int i = 0; i < index; i++)
            {
                int move = Math.Abs(head - req[i]);
                steps.Add((head, req[i], move));
                total += move;
                head = req[i];
            }

            return total;
        }
    }
}
