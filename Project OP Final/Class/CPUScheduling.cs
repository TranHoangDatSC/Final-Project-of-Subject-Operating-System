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
        public void FCFSRun() { }
        public void SJFRun() { }
        public void SRTFRun() { }
        public void RRRun() { }

    }
}
