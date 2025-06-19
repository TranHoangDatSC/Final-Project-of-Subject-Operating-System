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
        public static int SCAN_RIGHT(int[] requests, int head, int diskSize, Direction direction, out List<(int from, int to, int move)> steps)
        {
            steps = new List<(int from, int to, int move)>();
            List<int> req = requests.Distinct().ToList();

            req.Sort();

            List<int> left = req.Where(r => r < head).OrderByDescending(r => r).ToList();
            List<int> right = req.Where(r => r >= head).OrderBy(r => r).ToList();

            int total = 0;
            int current = head;

            foreach (int r in right)
            {
                int move = Math.Abs(current - r);
                steps.Add((current, r, move));
                total += move;
                current = r;
            }

            // Đi đến rìa phải (diskSize - 1)
            if (current < diskSize - 1)
            {
                int move = diskSize - 1 - current;
                steps.Add((current, diskSize - 1, move));
                total += move;
                current = diskSize - 1;
            }

            // Quay lại, xử lý bên trái
            foreach (int r in left)
            {
                int move = Math.Abs(current - r);
                steps.Add((current, r, move));
                total += move;
                current = r;
            }

            return total;
        }
        public static int CSCAN_RIGHT(int[] requests, int head, int diskSize, out List<(int from, int to, int move)> steps)
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
        public static int SCAN_LEFT(int[] requests, int head, int diskSize, Direction direction, out List<(int from, int to, int move)> steps)
        {
            steps = new List<(int from, int to, int move)>();
            List<int> req = requests.Distinct().ToList();

            req.Sort();

            List<int> left = req.Where(r => r <= head).OrderByDescending(r => r).ToList(); // bên trái & tại head
            List<int> right = req.Where(r => r > head).OrderBy(r => r).ToList();           // bên phải

            int total = 0;
            int current = head;

            // Đi trái
            foreach (int r in left)
            {
                int move = Math.Abs(current - r);
                steps.Add((current, r, move));
                total += move;
                current = r;
            }

            // Đi đến rìa trái (0)
            if (current > 0)
            {
                int move = current;
                steps.Add((current, 0, move));
                total += move;
                current = 0;
            }

            // Quay ngược lại, xử lý bên phải
            foreach (int r in right)
            {
                int move = Math.Abs(current - r);
                steps.Add((current, r, move));
                total += move;
                current = r;
            }

            return total;
        }
        public static int CSCAN_LEFT(int[] requests, int head, int diskSize, out List<(int from, int to, int move)> steps)
        {
            steps = new List<(int from, int to, int move)>();
            List<int> req = requests.ToList();
            req.Add(head);
            req.Sort();

            int total = 0;
            int index = req.IndexOf(head);

            // Đi ngược về trái (giảm dần)
            for (int i = index - 1; i >= 0; i--)
            {
                int move = Math.Abs(head - req[i]);
                steps.Add((head, req[i], move));
                total += move;
                head = req[i];
            }

            if (head != 0)
            {
                steps.Add((head, 0, head));        // về rìa trái
                total += head;

                steps.Add((0, diskSize - 1, diskSize - 1)); // quay vòng về phải
                total += diskSize - 1;

                head = diskSize - 1;
            }

            // Xử lý các request bên phải
            for (int i = req.Count - 1; i > index; i--)
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
            req.Sort();

            var left = req.Where(r => r < head).OrderByDescending(r => r).ToList();
            var right = req.Where(r => r >= head).OrderBy(r => r).ToList(); // Lưu ý: r >= head để bao gồm nếu head là request

            int total = 0;

            // Luôn đi hết bên phải, rồi mới qua trái
            foreach (int r in right)
            {
                int move = Math.Abs(head - r);
                steps.Add((head, r, move));
                total += move;
                head = r;
            }

            foreach (int r in left)
            {
                int move = Math.Abs(head - r);
                steps.Add((head, r, move));
                total += move;
                head = r;
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
