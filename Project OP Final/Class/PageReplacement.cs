using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Project_OP_Final.Class
{
    internal class PageReplacement
    {
        public List<int> referenceString { get; set; }
        public int frameCount { get; set; }
        public List<List<int>> frameStates { get; set; }
        public int faults { get; set; }
        public List<bool> pageFaults { get; set; }
        public List<List<bool>> bitsStates { get; set; }

        public void OPTAlgorithmRun()
        {
            frameStates = new List<List<int>>();
            int faults = 0;
            List<int> frame = new List<int>();
            pageFaults = Enumerable.Repeat(false, referenceString.Count).ToList();

            for (int i=0; i < referenceString.Count; i++)
            {
                if (!frame.Contains(referenceString[i]))
                {
                    if (frame.Count < frameCount)
                    {
                        frame.Add(referenceString[i]);
                    }
                    else
                    {
                        int idxFurthestReference = 0;
                        int idxReplacedPage = 0;
                        bool foundFurthestReference = false;
                        for (int j = 0; j < frame.Count; j++)
                        {
                            bool foundReference = false;
                            for (int k = i + 1; k < referenceString.Count; k++)
                            {
                                if (frame[j] == referenceString[k])
                                {
                                    if (idxFurthestReference < k - i)
                                    {
                                        idxFurthestReference = k - i;
                                        idxReplacedPage = j;
                                    }
                                    foundReference = true;
                                    break;
                                }
                            }
                            if (foundReference == false)
                            {
                                frame[j] = referenceString[i];
                                faults++;
                                foundFurthestReference = true;
                                break;
                            }
                        }
                        if (foundFurthestReference == false)
                        {
                            frame[idxReplacedPage] = referenceString[i];
                            faults++;
                        }
                        pageFaults[i] = true;
                    }
                }
                List<int> copyFrames = new List<int>();
                foreach (int j in frame)
                {
                    copyFrames.Add(j);
                }
                frameStates.Add(copyFrames);
            }
            this.faults = faults;
        }

        public void LRUAlgorithmRun()
        {
            frameStates = new List<List<int>>();
            int faults = 0;
            List<int> frame = new List<int>();
            pageFaults = Enumerable.Repeat(false, referenceString.Count).ToList();

            for (int i = 0; i < referenceString.Count; i++)
            {
                if (!frame.Contains(referenceString[i]))
                {
                    if (frame.Count < frameCount)
                    {
                        frame.Add(referenceString[i]);
                    }
                    else
                    {
                        int idxLongestUnreferenced = 0;
                        int idxReplacedPage = 0;
                        bool foundLongestUnreferenced = false;
                        for (int j = 0; j < frame.Count; j++)
                        {
                            bool foundReference = false;
                            for (int k = i - 1; k >= 0; k--)
                            {
                                if (frame[j] == referenceString[k])
                                {
                                    if (idxLongestUnreferenced < i - k)
                                    {
                                        idxLongestUnreferenced = i - k;
                                        idxReplacedPage = j;
                                    }
                                    foundReference = true;
                                    break;
                                }
                            }
                            if (foundReference == false)
                            {
                                frame[j] = referenceString[i];
                                faults++;
                                foundLongestUnreferenced = true;
                                break;
                            }
                        }
                        if (foundLongestUnreferenced == false)
                        {
                            frame[idxReplacedPage] = referenceString[i];
                            faults++;
                        }
                        pageFaults[i] = true;
                    }
                }
                List<int> copyFrames = new List<int>();
                foreach (int j in frame)
                {
                    copyFrames.Add(j);
                }
                frameStates.Add(copyFrames);
            }
            this.faults = faults;
        }

        public void FIFOAlgorithmRun()
        {
            frameStates = new List<List<int>>();
            int faults = 0;
            List<int> frame = new List<int>();
            pageFaults = Enumerable.Repeat(false, referenceString.Count).ToList();
            int turnoverIndex = 0;

            for (int i = 0; i < referenceString.Count; i++)
            {
                if (!frame.Contains(referenceString[i]))
                {
                    if (frame.Count < frameCount)
                    {
                        frame.Add(referenceString[i]);
                    }
                    else
                    {
                        frame[turnoverIndex] = referenceString[i];
                        turnoverIndex++;
                        if (turnoverIndex == frameCount)
                        {
                            turnoverIndex = 0;
                        }
                        pageFaults[i] = true;
                        faults++;
                    }
                }
                List<int> copyFrames = new List<int>();
                foreach (int j in frame)
                {
                    copyFrames.Add(j);
                }
                frameStates.Add(copyFrames);
            }
            this.faults = faults;
        }

        public void ClockAlgorithmRun()
        {
            frameStates = new List<List<int>>();
            int faults = 0;
            List<int> frame = new List<int>();
            pageFaults = Enumerable.Repeat(false, referenceString.Count).ToList();
            List<bool> bits = Enumerable.Repeat(false, frameCount).ToList();
            int turnoverIndex = 0;
            bitsStates = new List<List<bool>>();

            for (int i = 0; i < referenceString.Count; i++)
            {
                if (!frame.Contains(referenceString[i]))
                {
                    if (frame.Count < frameCount)
                    {
                        frame.Add(referenceString[i]);
                        bits[turnoverIndex] = true;
                        turnoverIndex++;
                        if (turnoverIndex == frameCount) turnoverIndex = 0;
                    }
                    else
                    {
                        while (bits[turnoverIndex])
                        {
                            bits[turnoverIndex] = false;
                            turnoverIndex++;
                            if (turnoverIndex == frameCount) turnoverIndex = 0;
                        }
                        frame[turnoverIndex] = referenceString[i];
                        bits[turnoverIndex] = true;
                        turnoverIndex++;
                        if (turnoverIndex == frameCount) turnoverIndex = 0;
                        pageFaults[i] = true;
                        faults++;
                    }
                }
                else
                {
                    bool found = false;
                    for (int j = 0; j < frame.Count; j++)
                    {
                        if (frame[j] == referenceString[i])
                        {
                            bits[j] = true;
                            found = true;
                            break;
                        }
                    }
                }
                List<int> copyFrames = new List<int>();
                foreach (int j in frame)
                {
                    copyFrames.Add(j);
                }
                frameStates.Add(copyFrames);
                bitsStates.Add(new List<bool>(bits));
            }
            this.faults = faults;
        }
    }
}
