using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project006.MVC
{
    class BusSystem
    {
        private List<string> devices;
        private List<Line> lines;
        private List<Dictionary<string, string>> dataPackets;

        public object Lines { get; internal set; }
        public object DataPackets { get; internal set; }
        public string[] Devices { get; internal set; }

        public BusSystem(int numDevices, int numLines)
        {
            devices = new List<string>();
            lines = new List<Line>();
            dataPackets = new List<Dictionary<string, string>>();

            for (int i = 1; i <= numDevices; i++)
            {
                devices.Add($"Device{i}");
            }

            for (int i = 0; i < numLines; i++)
            {
                lines.Add(new Line());
            }
        }

        public void AddDevice(string device)
        {
            devices.Add(device);
        }

        public void AddLine()
        {
            lines.Add(new Line());
        }

        public void RemoveDevice(string device)
        {
            devices.Remove(device);
        }

        public void RemoveLine(Line line)
        {
            lines.Remove(line);
        }

        public void GenerateDataPacket(string sender, string receiver)
        {
            Random random = new Random();
            int length = random.Next(1, 11);

            Dictionary<string, string> packet = new Dictionary<string, string>
            {
                { "sender", sender },
                { "receiver", receiver },
                { "length", length.ToString() }
            };

            dataPackets.Add(packet);
            TransmitDataPacket(packet);
        }

        private void TransmitDataPacket(Dictionary<string, string> packet)
        {
            foreach (Line line in lines)
            {
                if (line.IsFree())
                {
                    line.Transmit(packet);
                    break;
                }
            }
        }

        public double GetAverageWaitingTime()
        {
            if (dataPackets.Count == 0)
            {
                return 0;
            }

            double totalWaitingTime = 0;

            foreach (var packet in dataPackets)
            {
                totalWaitingTime += double.Parse(packet["length"]);
            }

            return totalWaitingTime / dataPackets.Count;
        }
    }

}

