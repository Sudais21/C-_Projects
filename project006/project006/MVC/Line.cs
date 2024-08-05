using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace project006.MVC
{
    class Line
    {
        private Semaphore status;
        private List<Dictionary<string, string>> dataPackets;

        public Line()
        {
            status = new Semaphore(1, 1);
            dataPackets = new List<Dictionary<string, string>>();
        }

        public void Transmit(Dictionary<string, string> packet)
        {
            status.WaitOne();
            dataPackets.Add(packet);
            status.Release();
        }

        public bool IsFree()
        {
            return dataPackets.Count == 0;
        }
    }
}

